﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vagas.Api.Entities;

namespace Vagas.Consumer.Services
{
    public interface ILinkedinService
    {
        [Post("/vagas")]
        public Task<VagaLinkedin> CadastrarVaga([Body] VagaLinkedin vaga);
    }
}
