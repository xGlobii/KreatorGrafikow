namespace Kreator_Grafików
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            workersGrid.CellClick += workersGrid_CellClick;
            workersGrid.CellValueChanged += workersGrid_HoursUpdate;
        }

        private void workersNumber_ValueChanged(object sender, EventArgs e)
        {
            workersGrid.Rows.Clear();
            workersGrid.ColumnCount = 33;

            for (int i = 0; i < workersNumber.Value; i++)
            {
                workersGrid.Rows.Add(2);
            }

            for (int i = 0; i < workersGrid.Columns.Count; i++)
            {
                DataGridViewColumn column = workersGrid.Columns[i];

                if (i == 0 || i == 32)
                    column.Width = 100;
                else
                    column.Width = 40;
            }

            for (int i = 0; i < workersGrid.Rows.Count; i++)
            {
                DataGridViewRow row = workersGrid.Rows[i];
                if (i % 2 == 0)
                    row.Height = 30;
                else
                    row.Height = 60;
            }

            foreach (DataGridViewColumn column in workersGrid.Columns)
            {
                foreach (DataGridViewRow row in workersGrid.Rows)
                {
                    if (row.Index % 2 == 0)
                    {
                        if (column.Index == 0 || column.Index == 32)
                        {
                            workersGrid.Rows[row.Index].Cells[column.Index].Style.BackColor = Color.Black;
                        }

                        if (column.Index > 0 && column.Index < 32)
                        {
                            workersGrid.Rows[row.Index].Cells[column.Index].Value = column.Index;
                        }
                    }
                }
            }
        }

        private string getCheckedRadioHours(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    if (radioButton.Text == "W" || radioButton.Text == "UR")
                        return radioButton.Text;
                    else if (radioButton.Text == "Inne:")
                        return customStart.Value + "-" + customEnd.Value;
                    else
                        return radioButton.Text;
                }
            }
            return null;
        }

        private Tuple<string, Color> getChceckedRadioColor(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    switch (radioButton.Text)
                    {
                        case "Biały":
                            return new Tuple<string, Color>("Biały", Color.White);
                            break;
                        case "Weekend":
                            return new Tuple<string, Color>("Weekend", Color.FromArgb(244, 176, 132));
                            break;
                        case "Kasa":
                            return new Tuple<string, Color>("Kasa", Color.FromArgb(166, 166, 166));
                            break;
                    }
                }
            }

            return new Tuple<string, Color>("Biały", Color.White);
        }

        private string getActionRadio(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return null;
        }

        private void workersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = workersGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            switch (getActionRadio(actionGroupbox))
            {
                case "Godzina":
                    if (e.RowIndex % 2 == 1 && (e.ColumnIndex > 0 && e.ColumnIndex < 32))
                    {
                        cell.Value = getCheckedRadioHours(hoursGropbox);
                    }
                    break;
                case "Kolor":
                    Tuple<string, Color> colorResult = getChceckedRadioColor(colorGroupbox);
                    if (colorResult.Item1 == "Biały" && (e.ColumnIndex > 0 && e.ColumnIndex < 32))
                    {
                        cell.Style.BackColor = colorResult.Item2;
                    }
                    else if (colorResult.Item1 == "Weekend" && e.RowIndex % 2 == 0 && e.ColumnIndex > 0 && e.ColumnIndex < 32)
                    {
                        cell.Style.BackColor = colorResult.Item2;
                    }
                    else if (colorResult.Item1 == "Kasa" && e.RowIndex % 2 == 1 && e.ColumnIndex > 0 && e.ColumnIndex < 32)
                    {
                        cell.Style.BackColor = colorResult.Item2;
                    }
                    break;
                case "Osoba":
                    if (e.RowIndex % 2 == 1 && e.ColumnIndex == 0)
                    {
                        cell.Value = personTextbox.Text;
                    }
                    break;
            }
        }

        private void workersGrid_HoursUpdate(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in workersGrid.Rows)
            {
                if (row.Index % 2 == 1)
                {
                    DataGridViewCell cell = workersGrid.Rows[row.Index].Cells[32];
                    int hours = 0;

                    foreach (DataGridViewColumn col in workersGrid.Columns)
                    {
                        if(col.Index > 0 && col.Index < 32)
                        {
                            var c = workersGrid.Rows[row.Index].Cells[col.Index].Value;
                            switch(c)
                            {
                                case null:
                                case "W":
                                case "UR":
                                    hours += 0;
                                    break;
                                default:

                                    string[] parts = c.ToString().Split("-");

                                    int start = int.Parse(parts[0]);
                                    int end = int.Parse(parts[1]);

                                    hours += end - start;

                                    break;
                            }
                        }
                    }

                    cell.Value = hours;
                }
            }
        }
    }
}
