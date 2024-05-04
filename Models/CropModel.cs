using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CropWIKImvc.Models
{
    // Define the Crop entity class
    public class Crop
    {
        public int Id { get; set; } // Primary key
        public string User { get; set; }
        public string CropName { get; set; }
        public string CropType { get; set; }
        public string CropVariety { get; set; }
        public string PlantingPeriod { get; set; }
        public string HarvestingPeriod { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string SoilType { get; set; }
        public string Climate { get; set; }
        public int ItShouldNotBeRepeatedForHowmanyYearsOnSameField { get; set; }
        public List<string> Fertilizers { get; set; }
        public List<string> Pests { get; set; }
        public List<string> Diseases { get; set; }
        public int NitrogenSupply { get; set; }
        public int NitrogenDemand { get; set; }
        public int SoilResidualNitrogen { get; set; }
    }


   

    // Define the database context class
    public class CropDbContext : DbContext
    {
        public CropDbContext(DbContextOptions<CropDbContext> options) : base(options)
        {
        }

        public DbSet<Crop> Crops { get; set; } // Represents the Crop table in the database
    }
}
