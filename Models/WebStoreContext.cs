using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebStoreCursoMVC.Models
{
    public class WebStoreContext : DbContext
    {
        public DbSet<Categoria> Categorias
        { get; set; }
        public DbSet<Producto> Productos
        { get; set; }
        public DbSet<Usuario> Usuarios
        { get; set; }
        public DbSet<Carrito> Carritos
        { get; set; }
        public DbSet<CarroDetalle> CarrosDetalle
        { get; set; }
        public DbSet<Comentario> Comentarios
        { get; set; }
        public DbSet<Favorito> Favoritos
        { get; set; }
        public DbSet<Promocion> Promociones
        { get; set; }
        public DbSet<PromoDetalle> PromoDetalles
        { get; set; }

    }
}