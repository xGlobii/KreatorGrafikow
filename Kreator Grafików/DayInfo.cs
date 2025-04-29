using System.Text.Json.Serialization;

namespace Kreator_Grafików
{
	public class DayInfo(string hour, string dayType, string register)
	{
		[JsonPropertyName("godz")]
		public string Hour { get; set; } = hour;

		[JsonPropertyName("dzien")]
		public string DayType { get; set; } = dayType;

		[JsonPropertyName("kasa")]
		public string Register { get; set; } = register;
	}
}
