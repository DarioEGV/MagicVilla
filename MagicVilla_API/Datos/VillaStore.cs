using MagicVilla_API.Modelos.DTO;

namespace MagicVilla_API.Datos
{
    public static class  VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>()
        {
                new VillaDTO { Id = 1,Nombre="Buenos Aires",Ocupantes=3,MetrosCuadrados=250 },
                new VillaDTO { Id = 2,Nombre="Rio Negro",Ocupantes=5,MetrosCuadrados=500 }
        };
    }
}
