﻿using DsiCodetech.Administrador.Business.Interface;
using DsiCodetech.Administrador.Domain;
using DsiCodetech.Administrador.Repository;
using DsiCodetech.Administrador.Repository.Infraestructure;
using DsiCodetech.Administrador.Repository.Infraestructure.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodetech.Administrador.Business
{
    public class TipoComprobanteBusiness : ITipoComprobanteBusiness
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly TipoComprobanteRepository repository;

        public TipoComprobanteBusiness(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            repository = new TipoComprobanteRepository(unitOfWork);
        }
        /// <summary>
        /// Este metodo se encarga de consultar todos los tipos de comprobantes
        /// </summary>
        /// <returns>una coleccion de tipos de comprobantes</returns>
        public List<TipoComprobanteDM> GetAllTipoComprobante()
        {
            List<TipoComprobanteDM> comprobantes = null;

            comprobantes = repository.GetAll().Select(p => new TipoComprobanteDM
            {
                Id = p.id.TrimStart().TrimEnd(),
                Descripcion = p.descripcion,
                Fecha_Inicio = p.fecha_inicio == null ? DateTime.Now.ToShortDateString() : p.fecha_inicio.Value.ToShortDateString(),
                Fecha_Fin = p.fecha_fin == null ? DateTime.Now.ToShortDateString() : p.fecha_fin.Value.ToShortDateString(),
                
                
            }).OrderBy(p=>p.Id).ToList();
            return comprobantes;
        }

        /// <summary>
        /// Este metodo se encarga de consultar por identificador un tipo de comprobante
        /// </summary>
        /// <param name="id">el identificador del comprobante</param>
        /// <returns>la entidad  tipocomprobante</returns>
        public TipoComprobanteDM GetTipoComprobanteById(string id)
        {

            var comprobante = repository.SingleOrDefault(p => p.id == id);
            TipoComprobanteDM comprobanteModel = new TipoComprobanteDM
            {
                Id = comprobante.id,
                Descripcion = comprobante.descripcion,
                Fecha_Inicio = comprobante.fecha_inicio.Value.ToShortDateString(),
                Fecha_Fin = comprobante.fecha_fin.Value.ToShortDateString(),
                
            };
            return comprobanteModel;
        }


    }
}
