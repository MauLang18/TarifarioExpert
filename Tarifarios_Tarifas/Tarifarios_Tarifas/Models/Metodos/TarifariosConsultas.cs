using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class CompetidoresConsultas
    {
        private ConexionMySql conexionMySql;
        private List<COMPETIDORES> mConsulta;

        public CompetidoresConsultas()
        {
            conexionMySql = new ConexionMySql();
            mConsulta = new List<COMPETIDORES>();
        }

        public List<COMPETIDORES> getTarifarios(string filtro, string filtro2)
        {
            string QUERY = "SELECT t.id AS id,t.ruta AS ruta,ao.proveedor AS proveedorAO,ao.manejos AS manejosAO,ao.hbl AS hblAO,t.agente_origen_total AS totalAO,fi.proveedor AS proveedorFI,fi.thc AS thcFI,fi.doc_fee AS doc_feeFI,fi.security_ AS securityFI,fi.impresion_bl AS impresion_blFI,fi.port_facility AS port_facilityFI,fi.canal_fee AS canal_feeFI,fi.vac AS vacFI,fi.impdo AS impdoFI,fi.merchant AS merchantFI,t.naviero_flete_total AS fleteFI,t.naviero_destino_total AS totalFI,gp.proveedor AS proveedorGP,gp.manejos_puerto AS manejos_puertoGP,t.gastos_portuarios_total AS totalGP,mpb.proveedor AS proveedorMPB,mpb.transporte_puerto AS transporte_puertoMPB,t.movimiento_puerto_bodega_total AS totalMPB,oc1.proveedor AS proveedorOC1,oc1.producto AS productoOC1,oc1.costo AS costoOC1,oc2.proveedor AS proveedorOC2,oc2.producto AS productoOC2,oc2.costo AS costoOC2,oc3.proveedor AS proveedorOC3,oc3.producto AS productoOC3,oc3.costo AS costoOC3,t.otras_categorias_total AS totalOC,os1.proveedor AS proveedorOS1,os1.producto AS productoOS1,os1.costo AS costoOS1,os2.proveedor AS proveedorOS2,os2.producto AS productoOS2,os2.costo AS costoOS2,os3.proveedor AS proveedorOS3,os3.producto AS productoOS3,os3.costo AS costoOS3,t.otros_servicios_total AS totalOS,cd1.proveedor AS proveedorCD1,cd1.flete AS costoCD1,cd2.proveedor AS proveedorCD2,cd2.flete AS costoCD2,cd3.proveedor AS proveedorCD3,cd3.flete AS costoCD3,t.cargos_destino_total AS totalCD,m.modalidad AS modalidad,e.equipo AS equipo,t.desde AS desde,t.hasta AS hasta,t.total AS total FROM tb_tarifarios AS t INNER JOIN tb_agente_origen AS ao ON t.id_agente_origen=ao.id INNER JOIN tb_flete_internacional AS fi ON t.id_naviero=fi.id INNER JOIN tb_gastos_portuarios AS gp ON t.id_gastos_portuarios=gp.id INNER JOIN tb_movimiento_puerto_bodega AS mpb ON t.id_movimiento_puerto_bodega=mpb.id INNER JOIN tb_otras_categorias AS oc1 ON t.id_otras_categorias1=oc1.id INNER JOIN tb_otras_categorias AS oc2 ON t.id_otras_categorias2=oc2.id INNER JOIN tb_otras_categorias AS oc3 ON t.id_otras_categorias3=oc3.id INNER JOIN tb_otros_servicios AS os1 ON t.id_otros_servicios1=os1.id INNER JOIN tb_otros_servicios AS os2 ON t.id_otros_servicios2=os2.id INNER JOIN tb_otros_servicios AS os3 ON t.id_otros_servicios3=os3.id INNER JOIN tb_cargos_destino AS cd1 ON t.id_cargos_destino1=cd1.id INNER JOIN tb_cargos_destino AS cd2 ON t.id_cargos_destino2=cd2.id INNER JOIN tb_cargos_destino AS cd3 ON t.id_cargos_destino3=cd3.id INNER JOIN tb_modalidad AS m ON t.id_modalidad=m.id INNER JOIN tb_equipo AS e ON t.id_equipo=e.id ";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "" && filtro2 != "")
                {
                    QUERY += " WHERE desde >= '" + filtro + "' AND hasta <= '" + filtro2 + "';";
                }
                else if (filtro != "")
                {
                    QUERY += " WHERE t.id LIKE '%"+filtro+"%' OR t.ruta LIKE '%"+filtro+"%' OR ao.proveedor LIKE '%"+filtro+"%' OR ao.manejos LIKE '%"+filtro+"%' OR ao.hbl LIKE '%"+filtro+"%' OR t.agente_origen_total LIKE '%"+filtro+"%' OR fi.proveedor LIKE '%"+filtro+"%' OR fi.thc LIKE '%"+filtro+"%' OR fi.doc_fee LIKE '%"+filtro+"%' OR fi.security_ LIKE '%"+filtro+"%' OR fi.impresion_bl LIKE '%"+filtro+"%' OR fi.port_facility LIKE '%"+filtro+"%' OR fi.canal_fee LIKE '%"+filtro+"%' OR fi.vac LIKE '%"+filtro+"%' OR fi.impdo LIKE '%"+filtro+ "%' OR fi.merchant LIKE '%" + filtro+"%' OR t.naviero_flete_total LIKE '%"+filtro+"%' OR t.naviero_destino_total LIKE '%"+filtro+"%' OR gp.proveedor LIKE '%"+filtro+"%' OR gp.manejos_puerto LIKE '%"+filtro+"%' OR t.gastos_portuarios_total LIKE '%"+filtro+"%' OR mpb.proveedor LIKE '%"+filtro+"%' OR mpb.transporte_puerto LIKE '%"+filtro+"%' OR t.movimiento_puerto_bodega_total LIKE '%"+filtro+"%' OR oc1.proveedor LIKE '%"+filtro+"%' OR oc1.producto LIKE '%"+filtro+"%' OR oc1.costo LIKE '%"+filtro+"%' OR oc2.proveedor LIKE '%"+filtro+"%' OR oc2.producto LIKE '%"+filtro+"%' OR oc2.costo LIKE '%"+filtro+"%' OR oc3.proveedor LIKE '%"+filtro+"%' OR oc3.producto LIKE '%"+filtro+"%' OR oc3.costo LIKE '%"+filtro+"%' OR t.otras_categorias_total LIKE '%"+filtro+"%' OR os1.proveedor LIKE '%"+filtro+"%' OR os1.producto LIKE '%"+filtro+"%' OR os1.costo LIKE '%"+filtro+"%' OR os2.proveedor LIKE '%"+filtro+"%' OR os2.producto LIKE '%"+filtro+"%' OR os2.costo LIKE '%"+filtro+"%' OR os3.proveedor LIKE '%"+filtro+"%' OR os3.producto LIKE '%"+filtro+"%' OR os3.costo LIKE '%"+filtro+"%' OR t.otros_servicios_total LIKE '%"+filtro+"%' OR cd1.proveedor LIKE '%"+filtro+"%' OR cd1.flete LIKE '%"+filtro+"%' OR cd2.proveedor LIKE '%"+filtro+ "%' OR cd2.flete LIKE '%"+filtro+"%' OR cd3.proveedor LIKE '%" + filtro+ "%' OR cd1.flete LIKE '%"+filtro+"%' OR t.cargos_destino_total LIKE '%" + filtro+"%' OR m.modalidad LIKE '%"+filtro+"%' OR e.equipo LIKE '%"+filtro+"%' OR t.desde LIKE '%"+filtro+"%' OR t.hasta LIKE '%"+filtro+"%' OR t.total LIKE '%"+filtro+"%';";
                }
                

                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                COMPETIDORES mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new COMPETIDORES();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Ruta = mReader.GetString("ruta");

                    mDatos.Proveedor_Agente_Origen = mReader.GetString("proveedorAO");
                    mDatos.Manejos_Agente_Origen = mReader.GetFloat("manejosAO");
                    mDatos.Hbl_Agente_Origen = mReader.GetFloat("hblAO");
                    mDatos.Agente_Origen_Total = mReader.GetFloat("totalAO");

                    mDatos.Proveedor_Flete_Internacional = mReader.GetString("proveedorFI");
                    mDatos.Thc_Flete_Internacional = mReader.GetFloat("thcFI");
                    mDatos.Doc_Fee_Flete_Internacional = mReader.GetFloat("doc_feeFI");
                    mDatos.Security_Flete_Internacional = mReader.GetFloat("securityFI");
                    mDatos.Impresion_Bl_Flete_Internacional = mReader.GetFloat("impresion_blFI");
                    mDatos.Port_Facility_Flete_Internacional = mReader.GetFloat("port_facilityFI");
                    mDatos.Canal_Fee_Flete_Internacional = mReader.GetFloat("canal_feeFI");
                    mDatos.Vac_Flete_Internacional = mReader.GetFloat("vacFI");
                    mDatos.Impdo_Flete_Internacional = mReader.GetFloat("impdoFI");
                    mDatos.Merchant_Flete_Internacional = mReader.GetFloat("merchantFI");
                    mDatos.Flete_Internacional_Total = mReader.GetFloat("fleteFI");
                    mDatos.Flete_Internacional_Destino = mReader.GetFloat("totalFI");

                    mDatos.Proveedor_Gastos_Portuarios = mReader.GetString("proveedorGP");
                    mDatos.Manejos_Puerto_Gastos_Portuarios = mReader.GetFloat("manejos_puertoGP");
                    mDatos.Gastos_Portuarios_Total = mReader.GetFloat("totalGP");

                    mDatos.Proveedor_Movimiento_Puerto_Bodega = mReader.GetString("proveedorMPB");
                    mDatos.Transporte_Puerto_Movimiento_Puerto_Bodega = mReader.GetFloat("transporte_puertoMPB");
                    mDatos.Movimiento_Puerto_Bodega_Total = mReader.GetFloat("totalMPB");

                    mDatos.Proveedor_Otras_Categorias1 = mReader.GetString("proveedorOC1");
                    mDatos.Producto_Otras_Categorias1 = mReader.GetString("productoOC1");
                    mDatos.Costos_Otras_Categorias1 = mReader.GetFloat("costoOC1");
                    mDatos.Proveedor_Otras_Categorias2 = mReader.GetString("proveedorOC2");
                    mDatos.Producto_Otras_Categorias2 = mReader.GetString("productoOC2");
                    mDatos.Costos_Otras_Categorias2 = mReader.GetFloat("costoOC2");
                    mDatos.Proveedor_Otras_Categorias3 = mReader.GetString("proveedorOC3");
                    mDatos.Producto_Otras_Categorias3 = mReader.GetString("productoOC3");
                    mDatos.Costos_Otras_Categorias3 = mReader.GetFloat("costoOC3");
                    mDatos.Otras_Categorias_Total = mReader.GetFloat("totalOC");

                    mDatos.Proveedor_Otros_Servicios1 = mReader.GetString("proveedorOS1"); 
                    mDatos.Producto_Otros_Servicios1 = mReader.GetString("productoOS1");
                    mDatos.Costos_Otros_Servicios1 = mReader.GetFloat("costoOS1");
                    mDatos.Proveedor_Otros_Servicios2 = mReader.GetString("proveedorOS2");
                    mDatos.Producto_Otros_Servicios2 = mReader.GetString("productoOS2");
                    mDatos.Costos_Otros_Servicios2 = mReader.GetFloat("costoOS2");
                    mDatos.Proveedor_Otros_Servicios3 = mReader.GetString("proveedorOS3");
                    mDatos.Producto_Otros_Servicios3 = mReader.GetString("productoOS3");
                    mDatos.Costos_Otros_Servicios3 = mReader.GetFloat("costoOS3");
                    mDatos.Otros_Servicios_Total = mReader.GetFloat("totalOS");

                    mDatos.Proveedor_Cargos_Destino1 = mReader.GetString("proveedorCD1");
                    mDatos.Costo_Cargos_Destino1 = mReader.GetFloat("costoCD1");
                    mDatos.Proveedor_Cargos_Destino2 = mReader.GetString("proveedorCD2");
                    mDatos.Costo_Cargos_Destino2 = mReader.GetFloat("costoCD2");
                    mDatos.Proveedor_Cargos_Destino3 = mReader.GetString("proveedorCD3");
                    mDatos.Costo_Cargos_Destino3 = mReader.GetFloat("costoCD3");
                    mDatos.Cargos_Detino_Total = mReader.GetFloat("totalCD");

                    mDatos.Modalidad = mReader.GetString("modalidad");
                    mDatos.Equipo = mReader.GetString("equipo");
                    mDatos.Desde = mReader.GetString("desde");
                    mDatos.Hasta = mReader.GetString("hasta");
                    mDatos.Total = mReader.GetFloat("total");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        internal bool agregarTarifario(COMPETIDORES mTarifarios)
        {
            string QUERY = "CALL agregarT(@agente_origen,@naviero,@naviero_destino,@gastos_portuarios,@movimiento_puerto_bodega,@otras_categorias,@otros_servicios,@cargos_destino,@desde,@hasta,@total,@id_agente_origen,@id_naviero,@id_gastos_portuarios,@id_movimiento_puerto_bodega,@id_otras_categorias1,@id_otras_categorias2,@id_otras_categorias3,@id_otros_servicios1,@id_otros_servicios2,@id_otros_servicios3,@id_cargos_destino1,@id_cargos_destino2,@id_cargos_destino3,@id_modalidad,@id_equipo,@ruta);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@agente_origen", mTarifarios.Agente_Origen_Total));
            mySqlCommand.Parameters.Add(new MySqlParameter("@naviero", mTarifarios.Flete_Internacional_Total));
            mySqlCommand.Parameters.Add(new MySqlParameter("@naviero_destino", mTarifarios.Flete_Internacional_Destino));
            mySqlCommand.Parameters.Add(new MySqlParameter("@gastos_portuarios", mTarifarios.Gastos_Portuarios_Total));
            mySqlCommand.Parameters.Add(new MySqlParameter("@movimiento_puerto_bodega", mTarifarios.Movimiento_Puerto_Bodega_Total));
            mySqlCommand.Parameters.Add(new MySqlParameter("@otras_categorias", mTarifarios.Otras_Categorias_Total));
            mySqlCommand.Parameters.Add(new MySqlParameter("@otros_servicios", mTarifarios.Otros_Servicios_Total));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cargos_destino", mTarifarios.Cargos_Detino_Total));
            mySqlCommand.Parameters.Add(new MySqlParameter("@desde", mTarifarios.Desde));
            mySqlCommand.Parameters.Add(new MySqlParameter("@hasta", mTarifarios.Hasta));
            mySqlCommand.Parameters.Add(new MySqlParameter("@total", mTarifarios.Total));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_agente_origen", mTarifarios.Id_Agente_Origen));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_naviero", mTarifarios.Id_Naviero));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_gastos_portuarios", mTarifarios.Id_Gastos_Portuarios));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_movimiento_puerto_bodega", mTarifarios.Id_Movimiento_Puerto_Bodega));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_otras_categorias1", mTarifarios.Id_Otras_Categorias1));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_otros_servicios1", mTarifarios.Id_Otros_Servicios1));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_otras_categorias2", mTarifarios.Id_Otras_Categorias2));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_otros_servicios2", mTarifarios.Id_Otros_Servicios2));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_otras_categorias3", mTarifarios.Id_Otras_Categorias3));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_otros_servicios3", mTarifarios.Id_Otros_Servicios3));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_cargos_destino1", mTarifarios.Id_Cargos_Destino1));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_cargos_destino2", mTarifarios.Id_Cargos_Destino2));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_cargos_destino3", mTarifarios.Id_Cargos_Destino3));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_modalidad", mTarifarios.Id_Modalidad));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_equipo", mTarifarios.Id_Equipo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ruta", mTarifarios.Ruta));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarTarifario(COMPETIDORES mTarifarios)
        {
            string QUERY = "CALL eliminarT(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mTarifarios.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarTodoTarifario()
        {
            string QUERY = "CALL eliminarTodoT();";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
