using Application.Response;
using Domain.Entities;

namespace Application.Interfaces.VersionVehiculoInterfaces
{
    public interface IVersionVehiculoService
    {
        VersionVehiculo ObtenerVersion(int versionId, int modeloId);

        VersionVehiculo ObtenerVersionPorId(int versionId);

        List<VersionResponse> ObtenerListaVersiones(int modeloId);
    }
}
