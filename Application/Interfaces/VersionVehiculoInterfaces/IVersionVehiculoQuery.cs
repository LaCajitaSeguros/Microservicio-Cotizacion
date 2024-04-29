using Domain.Entities;

namespace Application.Interfaces.VersionVehiculoInterfaces
{
    public interface IVersionVehiculoQuery
    {
        VersionVehiculo ObtenerVersion(int versionId, int modeloId);
        VersionVehiculo ObtenerVersionPorId(int versionId);
        List<VersionVehiculo> ObtenerVersiones(int modeloId);
    }
}
