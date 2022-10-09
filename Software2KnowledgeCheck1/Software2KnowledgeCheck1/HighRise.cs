using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class HighRise : Building
    {
        public int NumberOfStories { get; set; }
        public string OwnerName { get; set; }
        public List<string> Directory  { get; set; }

        public List<Building> Buildings { get; } = new List<Building>();

        public void CreateApartment(HighRise highrise)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<HighRise>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                Buildings.Add(highrise);
            }
        }

    }
}
