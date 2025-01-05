using EnvioDBLib.Models;
using System.Collections.Generic;

namespace EnvioDBLib.DAO
{
    public interface IEnvioDAO
    {
        void Add(Envio nuevo);

        void Update(Envio obj);

        void Delete(int id);

        List<Envio> GetAll();
    }
}
