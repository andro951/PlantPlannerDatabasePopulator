using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantPlannerDatabasePopulator {
	public struct Plant {
		public string Name { get; set; }
		public string Type { get; set; }
		public string Family { get; set; }
		public double WateringFrequency { get; set; }
		public double MinTemperatureCelsius { get; set; }
		public double MaxTemperatureCelsius { get; set; }
		public string LightType { get; set; }
		public double HoursOfLightPerDay { get; set; }
		public double MinHumidity { get; set; }
		public double MaxHumidity { get; set; }
		public double MinPH { get; set; }
		public double MaxPH { get; set; }
		public double ExpectedHeightMeters { get; set; }
		public double ExpectedWidthMeters { get; set; }
		public double FertilizerFrequencyInDays { get; set; }
		public string FertilizerType { get; set; }
		public string SoilType { get; set; }
		public string ImageUrl { get; set; }
		public Plant(string name, string type, string family, double wateringFrequency, double minTemperatureCelsius, double maxTemperatureCelsius, string lightType, double hoursOfLightPerDay, double minHumidity, double maxHumidity, double minPH, double maxPH, double expectedHeightMeters, double expectedWidthMeters, double fertilizerFrequencyInDays, string fertilizerType, string soilType, string imageUrl) {
			Name = name;
			Type = type;
			Family = family;
			WateringFrequency = wateringFrequency;
			MinTemperatureCelsius = minTemperatureCelsius;
			MaxTemperatureCelsius = maxTemperatureCelsius;
			LightType = lightType;
			HoursOfLightPerDay = hoursOfLightPerDay;
			MinHumidity = minHumidity;
			MaxHumidity = maxHumidity;
			MinPH = minPH;
			MaxPH = maxPH;
			ExpectedHeightMeters = expectedHeightMeters;
			ExpectedWidthMeters = expectedWidthMeters;
			FertilizerFrequencyInDays = fertilizerFrequencyInDays;
			FertilizerType = fertilizerType;
			SoilType = soilType;
			ImageUrl = imageUrl;
		}
	}
}
