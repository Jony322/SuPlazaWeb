﻿using DsiCodetech.Administrador.Repository.Infraestructure;
using DsiCodetech.Administrador.Repository.Infraestructure.Contract;
using DsiCodetech.Administrador.Repository.PosAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodetech.Administrador.Repository
{
    public class FormaPagoRepository: BaseRepository<forma_pago>
    {
        public FormaPagoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
