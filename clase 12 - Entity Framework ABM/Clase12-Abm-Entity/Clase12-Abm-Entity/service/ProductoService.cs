using Clase12_Abm_Entity.database;
using Clase12_Abm_Entity.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12_Abm_Entity.service
{
    public static class ProductoService
    {

        public static bool EliminarProductoPorId(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Producto productoAEliminar = context.Productos.Include(p => p.ProductoVendidos).Where(p => p.Id == id).FirstOrDefault();

                if(productoAEliminar is not null)
                {
                    context.Productos.Remove(productoAEliminar);
                    context.SaveChanges();
                    return true;
                }
            }

            return false;
        }
    }
}
