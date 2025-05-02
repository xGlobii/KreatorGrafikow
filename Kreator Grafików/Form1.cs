using System.Data;
using System.Drawing.Printing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace Kreator_Grafików
{
	public partial class Form1 : Form
	{
		const int cellWidth = 40;
		const int bigCellWidth = 100;
		const int cellHeight = 30;
		const int bigCellHeight = 60;
		private int currentRowIndex = 0;

		public Form1()
		{
			InitializeComponent();
			workersGrid.CellClick += workersGrid_CellClick;
			workersGrid.CellValueChanged += workersGrid_HoursUpdate;
			printDocument1.PrintPage += printDocument1_PrintPage;
		}

		private void workersNumber_ValueChanged(object sender, EventArgs e)
		{
			workersGrid.Rows.Clear();
			workersGrid.ColumnCount = 33;

			for (int i = 0; i < WorkersNumber.Value; i++)
			{
				workersGrid.Rows.Add(2);
			}

			for (int i = 0; i < workersGrid.Columns.Count; i++)
			{
				DataGridViewColumn column = workersGrid.Columns[i];

				if (i == 0 || i == 32)
					column.Width = bigCellWidth;
				else
					column.Width = cellWidth;
			}

			for (int i = 0; i < workersGrid.Rows.Count; i++)
			{
				DataGridViewRow row = workersGrid.Rows[i];
				if (i % 2 == 0)
					row.Height = cellHeight;
				else
					row.Height = bigCellHeight;
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

		private string? GetCheckedRadioHours(GroupBox groupBox)
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

		private Tuple<string, Color> GetChceckedRadioColor(GroupBox groupBox)
		{
			foreach (Control control in groupBox.Controls)
			{
				if (control is RadioButton radioButton && radioButton.Checked)
				{
					switch (radioButton.Text)
					{
						case "Biały":
							return new Tuple<string, Color>("Biały", Color.White);
						case "Weekend":
							return new Tuple<string, Color>("Weekend", Color.FromArgb(244, 176, 132));
						case "Kasa":
							return new Tuple<string, Color>("Kasa", Color.FromArgb(166, 166, 166));
					}
				}
			}

			return new Tuple<string, Color>("Biały", Color.White);
		}

		private string? GetActionRadio(GroupBox groupBox)
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

			switch (GetActionRadio(actionGroupbox))
			{
				case "Godzina":
					if (e.RowIndex % 2 == 1 && (e.ColumnIndex > 0 && e.ColumnIndex < 32))
					{
						cell.Value = GetCheckedRadioHours(hoursGropbox);
					}
					break;
				case "Kolor":
					Tuple<string, Color> colorResult = GetChceckedRadioColor(colorGroupbox);
					if (colorResult.Item1 == "Biały" && (e.ColumnIndex > 0 && e.ColumnIndex < 32))
					{
						int column = e.ColumnIndex;
						if (e.RowIndex % 2 == 0)
						{
							for (int i = 0; i < workersGrid.Rows.Count; i += 2)
							{
								DataGridViewCell cell2 = workersGrid.Rows[i].Cells[column];
								cell2.Style.BackColor = colorResult.Item2;
							}
						}
						else
						{
							cell.Style.BackColor = colorResult.Item2;
						}
					}
					else if (colorResult.Item1 == "Weekend" && e.RowIndex % 2 == 0 && e.ColumnIndex > 0 && e.ColumnIndex < 32)
					{
						int column = e.ColumnIndex;
						for (int i = 0; i < workersGrid.Rows.Count; i += 2)
						{
							DataGridViewCell cell2 = workersGrid.Rows[i].Cells[column];
							cell2.Style.BackColor = colorResult.Item2;
						}
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
						if (col.Index > 0 && col.Index < 32)
						{
							var c = workersGrid.Rows[row.Index].Cells[col.Index].Value;
							switch (c)
							{
								case null:
								case "W":
								case "UR":
								case "":
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

		private void BtnReset_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in workersGrid.Rows)
			{

				foreach (DataGridViewColumn column in workersGrid.Columns)
				{
					DataGridViewCell cell = workersGrid.Rows[row.Index].Cells[column.Index];

					if (row.Index % 2 == 1)
					{
						cell.Value = "";
					}

					if (column.Index > 0 && column.Index < 32)
					{
						cell.Style.BackColor = Color.White;
					}
				}
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			PrintPreviewDialog printPreviewDialog = new()
			{
				Document = printDocument1
			};
			printDocument1.DefaultPageSettings.Landscape = true;
			printPreviewDialog.ShowDialog();
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			int topMargin = 50;
			int leftMargin = 50;

			int x;
			int y = topMargin;

			for (int row = currentRowIndex; row < workersGrid.Rows.Count; row++)
			{
				int dynamicHeight = (row % 2 == 0) ? cellHeight : bigCellHeight - 10;
				x = leftMargin;
				foreach (DataGridViewColumn column in workersGrid.Columns)
				{
					DataGridViewCell cell = workersGrid.Rows[row].Cells[column.Index];
					string cellValue = cell.Value?.ToString() ?? "";

					int dynamicWidth = (column.Index > 0) ? cellWidth - 10 : bigCellWidth;

					SolidBrush brush = new(cell.Style.BackColor);

					StringFormat sf = new StringFormat()
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					};

					e.Graphics.FillRectangle(brush, new Rectangle(x, y, dynamicWidth, dynamicHeight));
					e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, dynamicWidth, dynamicHeight));
					e.Graphics.DrawString(cellValue, new Font("Arial", 10), Brushes.Black, new Rectangle(x, y, dynamicWidth, dynamicHeight), sf);
					x += dynamicWidth;
				}
				y += dynamicHeight;

				if (y >= e.MarginBounds.Height + topMargin)
				{
					e.HasMorePages = true;
					currentRowIndex = row + 1;
					return;
				}
			}
			currentRowIndex = 0;
			e.HasMorePages = false;

		}

		private void BtnSaveJSON_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new()
			{
				Filter = "Pliki JSON (*.json)|*.json",
				Title = "Zapisz jako JSON",
				FileName = "data.json"
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ConvertToJson(saveFileDialog.FileName);
			}
		}

		private void ConvertToJson(string filePath)
		{
			var employees = new Dictionary<string, Dictionary<string, object>>();

			foreach (DataGridViewRow row in workersGrid.Rows)
			{
				if (row.Index % 2 == 1)
				{
					var employeeData = new Dictionary<string, object>();
					for (int col = 1; col < workersGrid.Columns.Count - 1; col++)
					{
						DataGridViewCell cell = workersGrid.Rows[row.Index].Cells[col];
						employeeData.Add(col.ToString(), new DayInfo(
							cell.Value?.ToString() ?? "",
							workersGrid.Rows[row.Index - 1].Cells[col].Style.BackColor == Color.FromArgb(244, 176, 132) ? "weekend" : "roboczy",
							cell.Style.BackColor == Color.FromArgb(166, 166, 166) ? "tak" : "nie"));
					}
					employeeData.Add("suma", workersGrid.Rows[row.Index].Cells[32].Value?.ToString() ?? "");
					employees.Add(workersGrid.Rows[row.Index].Cells[0].Value?.ToString() ?? $"Pracownik{(row.Index + 1) / 2}", employeeData);
				}
			}

			var jsonOptions = new JsonSerializerOptions();
			jsonOptions.WriteIndented = true;

			string jsonString = JsonSerializer.Serialize(employees, jsonOptions);
			File.WriteAllText(filePath, jsonString);
			MessageBox.Show("Zapisano do pliku JSON: " + filePath, "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new()
			{
				Filter = "Pliki JSON (*.json)|*.json",
				Title = "Wczytaj plik JSON"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				ConvertToDictionary(openFileDialog.FileName);
			}
		}

		private void ConvertToDictionary(string filePath)
		{
			workersGrid.Rows.Clear();

			var jsonOptions = new JsonSerializerOptions();
			var employees = new Dictionary<string, Dictionary<string, object>>();

			var data = File.ReadAllText(filePath);
			employees = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, object>>>(data, jsonOptions);

			int count = employees?.Count ?? 0;
			WorkersNumber.Value = count;

			var loadedEmployees = new Dictionary<string, Dictionary<string, object>>();

			foreach (var employee in employees)
			{
				var employeeInfo = new Dictionary<string, object>();

				foreach (var day in employee.Value)
				{
					if (day.Key == "suma")
					{
						employeeInfo.Add(day.Key, day.Value);
						continue;
					}

					DayInfo dayInfo = JsonSerializer.Deserialize<DayInfo>(day.Value.ToString());
					employeeInfo.Add(day.Key, dayInfo);
				}

				loadedEmployees.Add(employee.Key, employeeInfo);
			}

			foreach (DataGridViewRow row in workersGrid.Rows)
			{
				foreach (DataGridViewColumn col in workersGrid.Columns)
				{
					DataGridViewCell cell = workersGrid.Rows[row.Index].Cells[col.Index];

					if (row.Index % 2 == 1)
					{
						if (col.Index == 0)
						{
							cell.Value = loadedEmployees?.ElementAt(row.Index / 2).Key ?? "";
						}
						else if (col.Index > 0 && col.Index < 32)
						{
							var dayInfo = loadedEmployees?.ElementAt(row.Index / 2).Value[col.Index.ToString()] as DayInfo;
							cell.Value = dayInfo.Hour;

							if (dayInfo.Register == "tak")
								cell.Style.BackColor = Color.FromArgb(166, 166, 166);

							if (dayInfo.DayType == "weekend")
								workersGrid.Rows[row.Index - 1].Cells[col.Index].Style.BackColor = Color.FromArgb(244, 176, 132);
						}
					}
				}
			}
		}
	}
}
