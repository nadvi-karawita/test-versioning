using CsvHelper;
using CsvHelper.Configuration;
using Patient_BulkImport_Formatter.Models;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Patient_BulkImport_Formatter
{
    public partial class ImportFormatter : Form
    {
        private bool validData;
        private CsvConfiguration readerConfig => new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HeaderValidated = null
        };

        public ImportFormatter()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using var ofd = new OpenFileDialog() { Filter = "(*.csv)|*.csv", ValidateNames = true };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    validData = true;

                    var reader = new CsvReader(sr, readerConfig);
                    var jmPatientList = reader?.GetRecords<JMPatient>()?.ToList()
                        .Where(patient =>
                        !string.IsNullOrWhiteSpace(patient.PatientUR) ||
                        !string.IsNullOrWhiteSpace(patient.GivenName) ||
                        !string.IsNullOrWhiteSpace(patient.Surname) ||
                        !string.IsNullOrWhiteSpace(patient.DueDate) ||
                        !string.IsNullOrWhiteSpace(patient.EmailAddress) ||
                        !string.IsNullOrWhiteSpace(patient.Address) ||
                        !string.IsNullOrWhiteSpace(patient.PhoneNo)
                        ).ToList();

                    var etpPatientList = new List<ETPPatient>();

                    if (jmPatientList!.Any())
                        foreach (var jmPatient in jmPatientList)
                        {
                            var eTPPatient = new ETPPatient
                            {
                                URNumber = jmPatient.PatientUR.Trim() ?? string.Empty,
                                FamilyName = jmPatient.Surname.Trim() ?? string.Empty,
                                FirstName = jmPatient.GivenName.Trim() ?? string.Empty,
                                DateOfBirth = string.Empty,
                                ExpectedDateOfDelivery = DateTime.ParseExact(jmPatient.DueDate, "d/MM/yyyy", null)
                                    .ToString("yyyyMMdd") ?? string.Empty,
                                EmailAddress = jmPatient.EmailAddress.Trim() ?? string.Empty,
                                SiteID = "3",
                                ActivationCode = string.Empty,
                                MobilePhone = jmPatient.PhoneNo ?? string.Empty
                            };

                            etpPatientList.Add(eTPPatient);
                        }

                    eTPPatientBindingSource.DataSource = etpPatientList;
                    DataGridValidation();

                    if (validData)
                        MessageBox.Show("All data is in valid format", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Errors found in data. Please correct data format", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                validData = false;
                MessageBox.Show($"{ex.Message}\nPlease make sure the csv file is in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (eTPPatientBindingSource.DataSource is IList<ETPPatient> dataSource && dataSource.Any())
                {
                    if (validData)
                    {
                        using var sfd = new SaveFileDialog() { Filter = "(*.csv)|*.csv", ValidateNames = true };

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using var sw = new StreamWriter(sfd.FileName);
                            var etpPatientList = (List<ETPPatient>)eTPPatientBindingSource.DataSource;
                            var writer = new CsvWriter(sw, readerConfig);
                            writer.WriteHeader(typeof(ETPPatient));
                            writer.NextRecord();

                            foreach (ETPPatient eTPPatient in etpPatientList)
                            {
                                writer.WriteRecord(eTPPatient);
                                writer.NextRecord();
                            }
                            MessageBox.Show("Export Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid data found.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No data found\nPlease load a csv file first", "No CSV file found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear the data?", "Clear Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                validData = false;
                eTPPatientBindingSource.DataSource = null;
            }
        }

        private void recheckBtn_Click(object sender, EventArgs e)
        {
            if (eTPPatientBindingSource.DataSource is IList<ETPPatient> dataSource && dataSource.Any())
            {
                validData = true;
                DataGridValidation();

                if (validData)
                    MessageBox.Show("All data is in valid format", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Errors found in data. Please correct data format", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No data found\nPlease load a csv file first", "No CSV file found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Validation Methods
        private void DataGridValidation()
        {
            foreach (var cell in from DataGridViewRow row in dataGridView1.Rows
                                 from DataGridViewCell cell in row.Cells
                                 select cell)
                cell.Style.BackColor = dataGridView1.DefaultCellStyle.BackColor;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.Cells.Cast<DataGridViewCell>().All(cell => cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString())))
                {
                    var mobilePhoneCellValue = row.Cells[8]?.Value;
                    var mobileNumber = mobilePhoneCellValue != null ? mobilePhoneCellValue.ToString() : string.Empty;

                    var emailAdressCellValue = row.Cells[5]?.Value;
                    var emailAdress = emailAdressCellValue != null ? emailAdressCellValue.ToString() : string.Empty;

                    if (!ValidateMobileNumber(mobileNumber ?? string.Empty))
                    {
                        row.Cells[8].Style.BackColor = Color.Red;
                    }

                    if (!ValidateEmailAddress(emailAdress ?? string.Empty))
                    {
                        row.Cells[5].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private bool ValidateMobileNumber(string mobileNumber)
        {
            var pattern = @"^0\d{9}$";
            var regexResult = Regex.IsMatch(mobileNumber, pattern);

            validData = regexResult ? validData : regexResult;
            return regexResult;
        }

        private bool ValidateEmailAddress(string emailAddress)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            var regexResult = Regex.IsMatch(emailAddress, emailPattern);

            validData = regexResult ? validData : regexResult;
            return regexResult;
        }
        #endregion
    }
}