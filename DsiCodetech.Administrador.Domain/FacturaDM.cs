﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DSICodeTech.FacturacionElectronica40.Model;

namespace DsiCodetech.Administrador.Domain
{
    public class FacturaDM
    {
        public string Id { get; set; }

        public string MetodoPago { get; set; }

        public string FormaPago { get; set; }

        public string UsoCfdi { get; set; }

        public string TipoComprobante { get; set; }

        public string Exportacion { get; set; }

        public EmpresaDM Emisor { get; set; }

        public ClienteDM Receptor { get; set; }

        public ComprobanteInformacionGlobal ComprobanteInformacionGlobal { get; set; }

        public List<ComprobanteCfdiRelacionados> ComprobanteCfdiRelacionados { get; set; }

        public List<ConceptoDM> Conceptos { get; set; }
    }

    public class ConceptoDM
    {
        public int Ticket { get; set; }

        public int IdPos { get; set; }

        public ComprobanteConceptoImpuestos Impuestos { get; set; }
    }

}
