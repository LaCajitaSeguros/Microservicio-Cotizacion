using Application.Interfaces.VersionVehiculoInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Queries
{
    public class VersionVehiculoQuery : IVersionVehiculoQuery
    {
        private readonly AppDbContext _context;

        public VersionVehiculoQuery(AppDbContext context)
        {
            _context = context;
        }

        public VersionVehiculo ObtenerVersion(int versionId, int modeloId)
        {
            return _context.Version.FirstOrDefault(vv => vv.VersionId == versionId && vv.ModeloId == modeloId);
        }

        public List<VersionVehiculo> ObtenerVersiones(int modeloId)
        {
            return _context.Version.Where(vv => vv.ModeloId == modeloId).ToList();
        }

        public VersionVehiculo ObtenerVersionPorId(int versionId)
        {
            return _context.Version.FirstOrDefault(vv => vv.VersionId == versionId);
        }
    }
}
