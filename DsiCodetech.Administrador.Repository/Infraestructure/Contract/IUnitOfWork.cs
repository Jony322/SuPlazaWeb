﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodetech.Administrador.Repository.Infraestructure.Contract
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Return the database reference for this UOW
        /// </summary>
        DbContext Db { get; }
    }
}
