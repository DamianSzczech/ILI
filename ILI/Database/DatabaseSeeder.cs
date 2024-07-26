using ILI.Models;
using System.Security.Cryptography;
using System.Text;

namespace ILI.Database
{
    internal static class DatabaseSeeder
    {
        public static void Seed()
        {
            using DatabaseContext context = new();
            context.Database.EnsureCreated();

            if (!context.Countries.Any())
            {
                context.Countries.AddRange(
                    new Country { CountryId = StringToGuid("USA"), CountryName = "USA" },
                    new Country { CountryId = StringToGuid("Canada"), CountryName = "Canada" },
                    new Country { CountryId = StringToGuid("Mexico"), CountryName = "Mexico" },
                    new Country { CountryId = StringToGuid("Germany"), CountryName = "Germany" },
                    new Country { CountryId = StringToGuid("Pakistan"), CountryName = "Pakistan" },
                    new Country { CountryId = StringToGuid("Portugal"), CountryName = "Portugal" }
                );
            }

            if (!context.Ranks.Any())
            {
                context.Ranks.AddRange(
                    new Rank { RankId = StringToGuid("Sergeant"), RankName = "Sergeant" },
                    new Rank { RankId = StringToGuid("Private"), RankName = "Private" },
                    new Rank { RankId = StringToGuid("Lieutenant"), RankName = "Lieutenant" },
                    new Rank { RankId = StringToGuid("Captain"), RankName = "Captain" }
                );
            }

            if (!context.SensorTypes.Any())
            {
                context.SensorTypes.AddRange(
                    new SensorType { SensorTypeId = StringToGuid("Bio"), SensorTypeName = "Bio" },
                    new SensorType { SensorTypeId = StringToGuid("Optical"), SensorTypeName = "Optical" },
                    new SensorType { SensorTypeId = StringToGuid("Navigation"), SensorTypeName = "Navigation" },
                    new SensorType { SensorTypeId = StringToGuid("Aerial"), SensorTypeName = "Aerial" }
                );
            }

            if (!context.Sensors.Any())
            {
                context.Sensors.AddRange(
                    new Sensor { SensorId = StringToGuid("HeartRateMonitor"), SensorName = "HeartRateMonitor", SensorTypeId = StringToGuid("Bio") },
                    new Sensor { SensorId = StringToGuid("BioSensor"), SensorName = "BioSensor", SensorTypeId = StringToGuid("Bio") },
                    new Sensor { SensorId = StringToGuid("ThermalCamera"), SensorName = "ThermalCamera", SensorTypeId = StringToGuid("Optical") },
                    new Sensor { SensorId = StringToGuid("NightVisionGoggles"), SensorName = "NightVisionGoggles", SensorTypeId = StringToGuid("Optical") },
                    new Sensor { SensorId = StringToGuid("GPS"), SensorName = "GPS", SensorTypeId = StringToGuid("Navigation") },
                    new Sensor { SensorId = StringToGuid("DroneCamera"), SensorName = "DroneCamera", SensorTypeId = StringToGuid("Aerial") }
                );
            }

            if (!context.Soldiers.Any())
            {
                context.Soldiers.AddRange(
                    new Soldier
                    {
                        SoldierId = StringToGuid("John Doe"),
                        Name = "John Doe",
                        RankId = StringToGuid("Sergeant"),
                        CountryId = StringToGuid("USA"),
                        TrainingInfo = "{\"basic\": \"completed\", \"advanced\": \"in progress\"}",
                        Latitude = 34.052235M,
                        Longitude = -118.243683M,
                        SensorId = StringToGuid("HeartRateMonitor")
                    },
                    new Soldier
                    {
                        SoldierId = StringToGuid("Jane Smith"),
                        Name = "Jane Smith",
                        RankId = StringToGuid("Private"),
                        CountryId = StringToGuid("Canada"),
                        TrainingInfo = "{\"basic\": \"completed\", \"advanced\": \"completed\"}",
                        Latitude = 45.421530M,
                        Longitude = -75.697193M,
                        SensorId = StringToGuid("ThermalCamera")
                    },
                    new Soldier
                    {
                        SoldierId = StringToGuid("Anna Muller"),
                        Name = "Anna Muller",
                        RankId = StringToGuid("Captain"),
                        CountryId = StringToGuid("Germany"),
                        TrainingInfo = "{\"basic\": \"completed\", \"advanced\": \"in progress\"}",
                        Latitude = 52.520008M,
                        Longitude = 13.404954M,
                        SensorId = StringToGuid("BioSensor")
                    },
                    new Soldier
                    {
                        SoldierId = StringToGuid("Ali Khan"),
                        Name = "Ali Khan",
                        RankId = StringToGuid("Sergeant"),
                        CountryId = StringToGuid("Pakistan"),
                        TrainingInfo = "{\"basic\": \"completed\", \"advanced\": \"completed\"}",
                        Latitude = 33.684422M,
                        Longitude = 73.047882M,
                        SensorId = StringToGuid("ThermalCamera")
                    }
                );
            }

            context.SaveChanges();
        }

        private static Guid StringToGuid(string value)
        {
            byte[] data = MD5.HashData(Encoding.Default.GetBytes(value));
            return new Guid(data);
        }
    }
}
