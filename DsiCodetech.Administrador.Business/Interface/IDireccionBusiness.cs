﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodetech.Administrador.Domain;

namespace DsiCodetech.Administrador.Business.Interface
{
    public interface IDireccionBusiness
    {
        List<EntidadDM> GetAllEntidades();

        List<MunicipioDM> GetAllMunicipios(short id);
    }
}
