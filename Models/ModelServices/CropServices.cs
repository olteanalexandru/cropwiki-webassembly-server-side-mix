using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using CropWIKImvc.Models;

namespace CropWIKImvc.Models.ModelServices
{
    public class CropServices
    {
        private readonly CropDbContext _context;

        public CropServices(CropDbContext context)
        {
            _context = context;
        }

        public List<Crop> GetAllCrops()
        {
            try
            {
                // Fetch crops from the database
                var crops = _context.Crops.ToList();

                // Return the fetched crops
                return crops;
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                System.Diagnostics.Debug.WriteLine($"An error occurred while fetching crops: {ex.Message}");

                // Return some hardcoded values
                return new List<Crop>
        {
            new Crop
            {
                Id = 1,
                User = "JohnDoe",
                CropName = "Tomato",
                CropType = "Vegetable",
                CropVariety = "Roma",
                PlantingPeriod = "Spring",
                HarvestingPeriod = "Fall",
                Description = "Roma tomatoes are a plum tomato popularly used both for canning and producing tomato paste because of their slender and firm nature.",
                Image = "tomato_image.jpg",
                SoilType = "Loamy soil",
                Climate = "Temperate",
                ItShouldNotBeRepeatedForHowmanyYearsOnSameField = 3,
                Fertilizers = new List<string> { "Organic fertilizers" },
                Pests = new List<string> { "Aphids", "Whiteflies" },
                Diseases = new List<string> { "Bacterial spot", "Early blight" },
                NitrogenSupply = 50,
                NitrogenDemand = 40,
                SoilResidualNitrogen = 20
            },
            // Add more hardcoded crops 
            new Crop
            {
                Id = 2,
                User = "JaneDoe",
                CropName = "Potato",
                CropType = "Vegetable",
                CropVariety = "Russet",
                PlantingPeriod = "Spring",
                HarvestingPeriod = "Fall",
                Description = "Russet potatoes are large, starchy potatoes with a brown skin and white flesh. They are commonly used for baking, mashing, and frying.",
                Image = "potato_image.jpg",
                SoilType = "Sandy soil",
                Climate = "Cool",
                ItShouldNotBeRepeatedForHowmanyYearsOnSameField = 2,
                Fertilizers = new List<string> { "Potassium fertilizers" },
                Pests = new List<string> { "Colorado potato beetle", "Aphids" },
                Diseases = new List<string> { "Late blight", "Early blight" },
                NitrogenSupply = 40,
                NitrogenDemand = 30,
                SoilResidualNitrogen = 15
            }
            };
            }
        }
    }
}
