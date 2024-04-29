using Application.Models;
using Application.Response;

namespace Application.Interfaces.ObjetoInformacionParametrizadaInterfaces
{
    public interface IObtenerInformacionParametrizada
    {
        ObjetoParametrizado ObtenerInformacion(CrearVehiculoRequest request, ObjetoParametrizado objetoParametrizado);
        VehiculoResponse ObtenerInformacionVehiculo(int versionId);
    }
}
