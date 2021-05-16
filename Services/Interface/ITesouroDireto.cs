﻿using ApiClienteEasy.Models.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiClienteEasy.Services
{
    public interface ITesouroDireto
    {

        Task<List<TesouroDireto>> GetTesouro(int ClientId);

        //Get FUNDOS
    }
}
