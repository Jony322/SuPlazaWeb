﻿using DsiCodetech.Administrador.Domain;
using DsiCodetech.Administrador.Repository;
using DsiCodetech.Administrador.Repository.Infraestructure.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodetech.Administrador.Business
{
    public class MesBusiness
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly Mes_Repository repository;
        public MesBusiness(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            repository = new Mes_Repository(unitOfWork);
        }

        public List<MesDM> GetMes()
        {
            List<MesDM> meses = null;
            return meses = repository.GetAll().Select(p => new MesDM
            {
                Id = p.id,
                Descripcion = p.descripcion,
                Fecha_Inicio = p.fecha_inicio.Value.ToShortDateString(),
                Fecha_Fin = p.fecha_fin.Value.ToShortDateString(),


            }).OrderBy(p=> p.Id).ToList();
        }
    }
}
