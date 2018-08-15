﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebStoreCursoMVC.Models
{
    public class Carrito
    {
        public Carrito()
        {
            detalle = new HashSet<CarroDetalle>();
        }

        public int carritoID { get; set; }

        [Required]
        public int usuarioID { get; set; }

        [Required]
        public bool abierto { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Fecha de Venta")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
        public DateTime fechaVenta { get; set; }

        [Required]
        public decimal total { get; set; }

        //Relacionado a un usuario.
        public virtual Usuario usuario { get; set; }

        //Relacionado a varios carros detalles.
        public virtual ICollection<CarroDetalle> detalle { get; set; }
    }
}