﻿using LojaApi.Models;
using System.Threading.Tasks;

namespace LojaApi.Interfaces
{
    public interface ICompraService
    {
        Task Efetivar(CompraRequest compraRequest);
    }
}
