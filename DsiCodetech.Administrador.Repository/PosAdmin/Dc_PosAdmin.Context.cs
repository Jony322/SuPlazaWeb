﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DsiCodetech.Administrador.Repository.PosAdmin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Dc_PosAdminEntities : DbContext
    {
        public Dc_PosAdminEntities()
            : base("name=Dc_PosAdminEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<articulo> articulo { get; set; }
        public virtual DbSet<clasificacion> clasificacion { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<compra> compra { get; set; }
        public virtual DbSet<compra_articulo> compra_articulo { get; set; }
        public virtual DbSet<control_errores> control_errores { get; set; }
        public virtual DbSet<ctrl_errores> ctrl_errores { get; set; }
        public virtual DbSet<direccion_proveedor> direccion_proveedor { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<empresa> empresa { get; set; }
        public virtual DbSet<entidad> entidad { get; set; }
        public virtual DbSet<entrada> entrada { get; set; }
        public virtual DbSet<entrada_articulo> entrada_articulo { get; set; }
        public virtual DbSet<estadistica> estadistica { get; set; }
        public virtual DbSet<estatus> estatus { get; set; }
        public virtual DbSet<factura> factura { get; set; }
        public virtual DbSet<factura_articulo> factura_articulo { get; set; }
        public virtual DbSet<factura_venta> factura_venta { get; set; }
        public virtual DbSet<generacion_codigos> generacion_codigos { get; set; }
        public virtual DbSet<inventario_articulo> inventario_articulo { get; set; }
        public virtual DbSet<inventario_captura> inventario_captura { get; set; }
        public virtual DbSet<inventario_fisico> inventario_fisico { get; set; }
        public virtual DbSet<inventario_fisico_articulo> inventario_fisico_articulo { get; set; }
        public virtual DbSet<kit_articulos> kit_articulos { get; set; }
        public virtual DbSet<movimiento_almacen> movimiento_almacen { get; set; }
        public virtual DbSet<municipio> municipio { get; set; }
        public virtual DbSet<oferta> oferta { get; set; }
        public virtual DbSet<oferta_articulo> oferta_articulo { get; set; }
        public virtual DbSet<orden> orden { get; set; }
        public virtual DbSet<orden_articulo> orden_articulo { get; set; }
        public virtual DbSet<pedido> pedido { get; set; }
        public virtual DbSet<pedido_articulo> pedido_articulo { get; set; }
        public virtual DbSet<permiso> permiso { get; set; }
        public virtual DbSet<pos> pos { get; set; }
        public virtual DbSet<pos_admin_settings> pos_admin_settings { get; set; }
        public virtual DbSet<pos_control> pos_control { get; set; }
        public virtual DbSet<precio_temporal> precio_temporal { get; set; }
        public virtual DbSet<promocion> promocion { get; set; }
        public virtual DbSet<promocion_articulo> promocion_articulo { get; set; }
        public virtual DbSet<proveedor> proveedor { get; set; }
        public virtual DbSet<salida> salida { get; set; }
        public virtual DbSet<salida_articulo> salida_articulo { get; set; }
        public virtual DbSet<unidad_medida> unidad_medida { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<usuario_permiso> usuario_permiso { get; set; }
        public virtual DbSet<venta_articulo> venta_articulo { get; set; }
        public virtual DbSet<venta_cancelada> venta_cancelada { get; set; }
        public virtual DbSet<venta_cancelada_articulo> venta_cancelada_articulo { get; set; }
        public virtual DbSet<venta_devolucion> venta_devolucion { get; set; }
        public virtual DbSet<venta_devolucion_articulo> venta_devolucion_articulo { get; set; }
        public virtual DbSet<productos_sin_iva> productos_sin_iva { get; set; }
        public virtual DbSet<colector_articulo> colector_articulo { get; set; }
        public virtual DbSet<colector_compra> colector_compra { get; set; }
        public virtual DbSet<colector_inventario_fisico> colector_inventario_fisico { get; set; }
        public virtual DbSet<colector_orden> colector_orden { get; set; }
        public virtual DbSet<colector_orden_articulo> colector_orden_articulo { get; set; }
        public virtual DbSet<colector_proveedor> colector_proveedor { get; set; }
        public virtual DbSet<colector_unidad_medida> colector_unidad_medida { get; set; }
        public virtual DbSet<colector_usuario> colector_usuario { get; set; }
        public virtual DbSet<colector_usuario_permiso> colector_usuario_permiso { get; set; }
        public virtual DbSet<vw_articulo> vw_articulo { get; set; }
        public virtual DbSet<vw_articulos_principales> vw_articulos_principales { get; set; }
        public virtual DbSet<vw_cajas> vw_cajas { get; set; }
        public virtual DbSet<vw_clasificacion> vw_clasificacion { get; set; }
        public virtual DbSet<vw_items> vw_items { get; set; }
        public virtual DbSet<vw_oferta_articulo> vw_oferta_articulo { get; set; }
        public virtual DbSet<vw_offers> vw_offers { get; set; }
        public virtual DbSet<clave_producto_serv> clave_producto_serv { get; set; }
        public virtual DbSet<exportacion> exportacion { get; set; }
        public virtual DbSet<forma_pago> forma_pago { get; set; }
        public virtual DbSet<mes> mes { get; set; }
        public virtual DbSet<metodo_pago> metodo_pago { get; set; }
        public virtual DbSet<moneda> moneda { get; set; }
        public virtual DbSet<pais> pais { get; set; }
        public virtual DbSet<periodicidad> periodicidad { get; set; }
        public virtual DbSet<regimen_fiscal> regimen_fiscal { get; set; }
        public virtual DbSet<tipo_comprobante> tipo_comprobante { get; set; }
        public virtual DbSet<tipo_relacion> tipo_relacion { get; set; }
        public virtual DbSet<uso_cfdi> uso_cfdi { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<direccion> direccion { get; set; }
        public virtual DbSet<venta> venta { get; set; }
    
        public virtual int reset_estadistica(Nullable<short> anio)
        {
            var anioParameter = anio.HasValue ?
                new ObjectParameter("anio", anio) :
                new ObjectParameter("anio", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("reset_estadistica", anioParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_cierre_inventario(Nullable<System.Guid> inventoryID)
        {
            var inventoryIDParameter = inventoryID.HasValue ?
                new ObjectParameter("InventoryID", inventoryID) :
                new ObjectParameter("InventoryID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_cierre_inventario", inventoryIDParameter);
        }
    
        public virtual ObjectResult<sp_corte_caja_Result> sp_corte_caja(Nullable<System.DateTime> fechaIni, Nullable<System.DateTime> fechaFin, string vendedor, Nullable<int> idPos)
        {
            var fechaIniParameter = fechaIni.HasValue ?
                new ObjectParameter("fechaIni", fechaIni) :
                new ObjectParameter("fechaIni", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("fechaFin", fechaFin) :
                new ObjectParameter("fechaFin", typeof(System.DateTime));
    
            var vendedorParameter = vendedor != null ?
                new ObjectParameter("vendedor", vendedor) :
                new ObjectParameter("vendedor", typeof(string));
    
            var idPosParameter = idPos.HasValue ?
                new ObjectParameter("idPos", idPos) :
                new ObjectParameter("idPos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_corte_caja_Result>("sp_corte_caja", fechaIniParameter, fechaFinParameter, vendedorParameter, idPosParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_estadistica_oferta(Nullable<System.Guid> offer_id)
        {
            var offer_idParameter = offer_id.HasValue ?
                new ObjectParameter("offer_id", offer_id) :
                new ObjectParameter("offer_id", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_estadistica_oferta", offer_idParameter);
        }
    
        public virtual ObjectResult<sp_exportToDAT_Result> sp_exportToDAT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_exportToDAT_Result>("sp_exportToDAT");
        }
    
        public virtual ObjectResult<sp_exportToXLS_Result> sp_exportToXLS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_exportToXLS_Result>("sp_exportToXLS");
        }
    
        public virtual int sp_fromAsociadoToPrincipal(string cod_barras)
        {
            var cod_barrasParameter = cod_barras != null ?
                new ObjectParameter("cod_barras", cod_barras) :
                new ObjectParameter("cod_barras", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_fromAsociadoToPrincipal", cod_barrasParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_pedido_anio_Result> sp_pedido_anio(Nullable<System.Guid> proveedor, Nullable<short> anio, Nullable<short> mes, Nullable<short> dias_mes, Nullable<short> dias_ped)
        {
            var proveedorParameter = proveedor.HasValue ?
                new ObjectParameter("proveedor", proveedor) :
                new ObjectParameter("proveedor", typeof(System.Guid));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("anio", anio) :
                new ObjectParameter("anio", typeof(short));
    
            var mesParameter = mes.HasValue ?
                new ObjectParameter("mes", mes) :
                new ObjectParameter("mes", typeof(short));
    
            var dias_mesParameter = dias_mes.HasValue ?
                new ObjectParameter("dias_mes", dias_mes) :
                new ObjectParameter("dias_mes", typeof(short));
    
            var dias_pedParameter = dias_ped.HasValue ?
                new ObjectParameter("dias_ped", dias_ped) :
                new ObjectParameter("dias_ped", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_pedido_anio_Result>("sp_pedido_anio", proveedorParameter, anioParameter, mesParameter, dias_mesParameter, dias_pedParameter);
        }
    
        public virtual ObjectResult<sp_pedido_captura_pendiente_Result> sp_pedido_captura_pendiente(Nullable<System.Guid> idpedido)
        {
            var idpedidoParameter = idpedido.HasValue ?
                new ObjectParameter("Idpedido", idpedido) :
                new ObjectParameter("Idpedido", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_pedido_captura_pendiente_Result>("sp_pedido_captura_pendiente", idpedidoParameter);
        }
    
        public virtual ObjectResult<sp_pedido_promedio_Result> sp_pedido_promedio(Nullable<System.Guid> proveedor, Nullable<short> anio, Nullable<short> mes, Nullable<short> dias_mes, Nullable<short> dias_ped)
        {
            var proveedorParameter = proveedor.HasValue ?
                new ObjectParameter("proveedor", proveedor) :
                new ObjectParameter("proveedor", typeof(System.Guid));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("anio", anio) :
                new ObjectParameter("anio", typeof(short));
    
            var mesParameter = mes.HasValue ?
                new ObjectParameter("mes", mes) :
                new ObjectParameter("mes", typeof(short));
    
            var dias_mesParameter = dias_mes.HasValue ?
                new ObjectParameter("dias_mes", dias_mes) :
                new ObjectParameter("dias_mes", typeof(short));
    
            var dias_pedParameter = dias_ped.HasValue ?
                new ObjectParameter("dias_ped", dias_ped) :
                new ObjectParameter("dias_ped", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_pedido_promedio_Result>("sp_pedido_promedio", proveedorParameter, anioParameter, mesParameter, dias_mesParameter, dias_pedParameter);
        }
    
        public virtual ObjectResult<sp_pedido_suspendido_Result> sp_pedido_suspendido(Nullable<System.Guid> pedido_id, Nullable<short> dias_mes)
        {
            var pedido_idParameter = pedido_id.HasValue ?
                new ObjectParameter("pedido_id", pedido_id) :
                new ObjectParameter("pedido_id", typeof(System.Guid));
    
            var dias_mesParameter = dias_mes.HasValue ?
                new ObjectParameter("dias_mes", dias_mes) :
                new ObjectParameter("dias_mes", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_pedido_suspendido_Result>("sp_pedido_suspendido", pedido_idParameter, dias_mesParameter);
        }
    
        public virtual ObjectResult<sp_pedido_suspendido_promedio_Result> sp_pedido_suspendido_promedio(Nullable<System.Guid> pedido_id, Nullable<short> dias_mes)
        {
            var pedido_idParameter = pedido_id.HasValue ?
                new ObjectParameter("pedido_id", pedido_id) :
                new ObjectParameter("pedido_id", typeof(System.Guid));
    
            var dias_mesParameter = dias_mes.HasValue ?
                new ObjectParameter("dias_mes", dias_mes) :
                new ObjectParameter("dias_mes", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_pedido_suspendido_promedio_Result>("sp_pedido_suspendido_promedio", pedido_idParameter, dias_mesParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual ObjectResult<sp_reporte_entrada_almacen_Result> sp_reporte_entrada_almacen(Nullable<System.Guid> idEntrada)
        {
            var idEntradaParameter = idEntrada.HasValue ?
                new ObjectParameter("IdEntrada", idEntrada) :
                new ObjectParameter("IdEntrada", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_reporte_entrada_almacen_Result>("sp_reporte_entrada_almacen", idEntradaParameter);
        }
    
        public virtual ObjectResult<sp_reporte_formato_Result> sp_reporte_formato(Nullable<System.Guid> idInventario)
        {
            var idInventarioParameter = idInventario.HasValue ?
                new ObjectParameter("IdInventario", idInventario) :
                new ObjectParameter("IdInventario", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_reporte_formato_Result>("sp_reporte_formato", idInventarioParameter);
        }
    
        public virtual ObjectResult<sp_reporte_inventario_actual_Result> sp_reporte_inventario_actual(Nullable<System.Guid> idProveedor)
        {
            var idProveedorParameter = idProveedor.HasValue ?
                new ObjectParameter("IdProveedor", idProveedor) :
                new ObjectParameter("IdProveedor", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_reporte_inventario_actual_Result>("sp_reporte_inventario_actual", idProveedorParameter);
        }
    
        public virtual ObjectResult<sp_reporte_inventario_fisico_Result> sp_reporte_inventario_fisico(Nullable<System.Guid> inventoryID)
        {
            var inventoryIDParameter = inventoryID.HasValue ?
                new ObjectParameter("InventoryID", inventoryID) :
                new ObjectParameter("InventoryID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_reporte_inventario_fisico_Result>("sp_reporte_inventario_fisico", inventoryIDParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
