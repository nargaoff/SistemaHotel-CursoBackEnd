using System.Collections.Generic;
using System.Linq;
using SistemaHotel.Model.Classes.Contextos;

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Cargo
    {
        public int Id { get; set; }
        public string Cargos { get; set; }

        public Cargo()
        {
        }

        public Cargo(string cargos)
        {
            Cargos = cargos;
        }

        public List<Cargo> CarregarCargo()
        {
            using (var contexto = new ContextoCargo())
            {
                return contexto.Set<Cargo>().ToList();
            }
        }

        public void SalvarCargo()
        {
            using (var contexto = new ContextoCargo())
            {
                contexto.Set<Cargo>().Add(this);
                contexto.SaveChanges();
            }
        }

        public void AtualizarCargo()
        {
            using (var contexto = new ContextoCargo())
            {
                contexto.Set<Cargo>().Update(this);
                contexto.SaveChanges();
            }
        }

        public void DeletarCargo()
        {
            using (var contexto = new ContextoCargo())
            {
                contexto.Set<Cargo>().Remove(this);
                contexto.SaveChanges();
            }
        }
    }
}
