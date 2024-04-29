using Application.Response;
using Domain.Entities;

namespace Application.Interfaces.ModeloInterfaces
{
    public interface IModeloService
    {
        Modelo ObtenerValoresModelos(int modeloId, int marcaId);
        Modelo ObtenerModelo(int modeloId);
        List<ModeloResponse> ObtenerListaModelos(int marcaId);
    }
}
