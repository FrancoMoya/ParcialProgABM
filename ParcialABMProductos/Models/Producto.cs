﻿using System;
using System.Collections.Generic;

namespace ParcialABMProductos.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Código { get; set; } = null!;
        public string? Descripción { get; set; }
        public decimal Precio { get; set; }
        public string Tamaño { get; set; } = null!;
    }
}
