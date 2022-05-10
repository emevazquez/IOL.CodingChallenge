using IOL.CodingChallenge.Model;
using System.Collections.Generic;

namespace IOL.CodingChallenge.Repository.Repositorios
{
    public interface IFormaGeometricaRepository
    {
        IEnumerable<FormaGeometrica> ObtenerFormas();

        void AgregarForma(FormaGeometrica forma);
        void Calcular(FormaGeometrica forma);
    }
}