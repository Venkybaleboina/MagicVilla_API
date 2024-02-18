using MagicVilla.API.Models.DTO;

namespace MagicVilla.API.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
            {
                new VillaDto { Id = 1, Name = "Pool View",Sqrt=100,Occupancy=4 },
                new VillaDto { Id = 2, Name = "Beach View",Sqrt=300,Occupancy=3 }
            };

    }
}
