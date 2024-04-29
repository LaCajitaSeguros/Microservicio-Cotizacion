using Application.Response;
using Domain.Entities;

namespace Application.Interfaces.ModeloInterfaces
{
    public interface IModeloQuery
    {
        Modelo ObtenerModelo(int modeloId, int marcaId);
        Modelo ObtenerModeloPorId(int modeloId);
        List<Modelo> ObtenerModelos(int marcaId);
    }
}
