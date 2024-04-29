using Application.Models;
using Application.Response;

namespace Application.Interfaces.VehiculoInterfaces
{
    public interface IVehiculoService
    {
        public Task<List<PlanesResponse>> CotizarVehiculo(CrearVehiculoRequest request);
        public Task<VehiculoResponse> ObtenerVehiculo(int versionId);
    }
}
