using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class LCLConsultas
    {
        private ConexionMySql conexionMySql;
        private List<LCLtarifarios> mConsulta;

        public LCLConsultas()
        {
            conexionMySql = new ConexionMySql();
            mConsulta = new List<LCLtarifarios>();
        }

        public List<LCLtarifarios> getLCL(string filtro, string filtro2)
        {
            string QUERY = "SELECT t.id AS id,t.ruta AS ruta,ao.proveedor AS proveedorAO,ao.manejos AS manejosAO,ao.hbl AS hblAO,fi.proveedor AS proveedorFI,fi.thc_d_cbm AS thc_cbmFI,fi.thc_d_minimo AS thc_minimoFI,fi.vgm_minimo AS vgm_minimoFI,fi.bunker_cbm AS bunker_cbmFI,fi.bunker_minimo AS bunker_minimoFI,fi.sed_minimo AS des_minimoFI,fi.tica_minimo AS tica_minimoFI,fi.forwarding_minimo AS forwarding_minimoFI,fi.manejos_minimo AS manejos_minimoFI,fi.carga_peligrosa_minimo AS carga_peligrosa_minimoFI,gp.proveedor AS proveedorGP,gp.cargos AS cargosGP,mpb.proveedor AS proveedorMPB,mpb.transporte_bodega AS transporte_bodegaMPB,oc1.proveedor AS proveedorOC1,oc1.producto AS productoOC1,oc1.costo AS costoOC1,oc2.proveedor AS proveedorOC2,oc2.producto AS productoOC2,oc2.costo AS costoOC2,oc3.proveedor AS proveedorOC3,oc3.producto AS productoOC3,oc3.costo AS costoOC3,cd1.proveedor AS proveedorCD1,cd1.flete AS costoCD1,cd2.proveedor AS proveedorCD2,cd2.flete AS costoCD2,cd3.proveedor AS proveedorCD3,cd3.flete AS costoCD3,m.modalidad AS modalidad,e.equipo AS equipo,t.desde AS desde,t.hasta AS hasta,t.total_flete_cbm AS totalCBM,t.total_otros_costos_cbm AS totalOtrosCBM,t.total_flete_minimo AS totalMinimo,t.total_otros_costos_minimos AS totalOtrosMinimos,t.total_otros_costos_flat AS totalOtrosFlat FROM tb_lcl AS t INNER JOIN tb_agente_origen_lcl AS ao ON t.id_agente_origen=ao.id INNER JOIN tb_flete_internacional_lcl AS fi ON t.id_naviero=fi.id INNER JOIN tb_cargos_en_destino_lcl AS gp ON t.id_cargos_en_destino=gp.id INNER JOIN tb_movimiento_bodega_lcl AS mpb ON t.id_movimiento_bodega=mpb.id INNER JOIN tb_otras_categorias_lcl AS oc1 ON t.id_otras_categorias1=oc1.id INNER JOIN tb_otras_categorias_lcl AS oc2 ON t.id_otras_categorias2=oc2.id INNER JOIN tb_otras_categorias_lcl AS oc3 ON t.id_otras_categorias3=oc3.id INNER JOIN tb_cargos_destino_lcl AS cd1 ON t.id_cargos_destino1=cd1.id INNER JOIN tb_cargos_destino_lcl AS cd2 ON t.id_cargos_destino2=cd2.id INNER JOIN tb_cargos_destino_lcl AS cd3 ON t.id_cargos_destino3=cd3.id INNER JOIN tb_modalidad AS m ON t.id_modalidad=m.id INNER JOIN tb_equipo AS e ON t.id_equipo=e.id "; 
            MySqlDataReader mReader = null; 
            try
            {
                if (filtro != "" && filtro2 != "")
                {
                    QUERY += " WHERE desde >= '" + filtro + "' AND hasta <= '" + filtro2 + "';";
                }
                else if (filtro != "")
                {
                    QUERY += " WHERE t.id LIKE '%" + filtro + "%' OR t.ruta LIKE '%" + filtro + "%' OR ao.proveedor LIKE '%" + filtro + "%' OR ao.manejos LIKE '%" + filtro + "%' OR ao.hbl LIKE '%" + filtro + "%' OR fi.proveedor LIKE '%" + filtro + "%' OR fi.thc LIKE '%" + filtro + "%' OR fi.doc_fee LIKE '%" + filtro + "%' OR fi.security_ LIKE '%" + filtro + "%' OR fi.impresion_bl LIKE '%" + filtro + "%' OR fi.port_facility LIKE '%" + filtro + "%' OR fi.canal_fee LIKE '%" + filtro + "%' OR fi.vac LIKE '%" + filtro + "%' OR fi.impdo LIKE '%" + filtro + "%' OR fi.merchant LIKE '%" + filtro + "%' OR gp.proveedor LIKE '%" + filtro + "%' OR gp.cargos LIKE '%" + filtro + "%' OR t.gastos_portuarios_total LIKE '%" + filtro + "%' OR mpb.proveedor LIKE '%" + filtro + "%' OR mpb.transporte_bodega LIKE '%" + filtro + "%' OR oc1.proveedor LIKE '%" + filtro + "%' OR oc1.producto LIKE '%" + filtro + "%' OR oc1.costo LIKE '%" + filtro + "%' OR oc2.proveedor LIKE '%" + filtro + "%' OR oc2.producto LIKE '%" + filtro + "%' OR oc2.costo LIKE '%" + filtro + "%' OR oc3.proveedor LIKE '%" + filtro + "%' OR oc3.producto LIKE '%" + filtro + "%' OR oc3.costo LIKE '%" + filtro + "%' OR cd1.proveedor LIKE '%" + filtro + "%' OR cd1.flete LIKE '%" + filtro + "%' OR cd2.proveedor LIKE '%" + filtro + "%' OR cd2.flete LIKE '%" + filtro + "%' OR cd3.proveedor LIKE '%" + filtro + "%' OR cd1.flete LIKE '%" + filtro + "%' OR m.modalidad LIKE '%" + filtro + "%' OR e.equipo LIKE '%" + filtro + "%' OR t.desde LIKE '%" + filtro + "%' OR t.hasta LIKE '%" + filtro + "%' OR t.total_flete_cbm LIKE '%" + filtro + "%' OR t.total_otros_costos_cbm LIKE '%" + filtro + "%' OR t.total_flete_minimo LIKE '%" + filtro + "%' OR t.total_otros_costos_minimos LIKE '%" + filtro + "%' OR t.total_otros_costos_flat LIKE '%" + filtro + "%';";
                }
                

                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                LCLtarifarios mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new LCLtarifarios();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Ruta = mReader.GetString("ruta");

                    mDatos.Proveedor_Agente_Origen = mReader.GetString("proveedorAO");
                    mDatos.Manejos_Agente_Origen = mReader.GetFloat("manejosAO");
                    mDatos.Hbl_Agente_Origen = mReader.GetFloat("hblAO");

                    mDatos.Proveedor_Flete_Internacional = mReader.GetString("proveedorFI");
                    mDatos.Thc_Cbm_Flete_Internacional = mReader.GetFloat("thc_cbmFI");
                    mDatos.Thc_Minimo_Flete_Internacional = mReader.GetFloat("thc_minimoFI");
                    mDatos.Vgm_Minimo_Flete_Internacional = mReader.GetFloat("vgm_minimoFI");
                    mDatos.Bunker_Cbm_Flete_Internacional = mReader.GetFloat("bunker_cbmFI");
                    mDatos.Bunker_Minimo_Flete_Internacional = mReader.GetFloat("bunker_minimoFI");
                    mDatos.Sed_Minimo_Flete_Internacional = mReader.GetFloat("sed_minimoFI");
                    mDatos.Tica_Minimo_Flete_Internacional = mReader.GetFloat("tica_minimoFI");
                    mDatos.Forwarding_Minimo_Flete_Internacional = mReader.GetFloat("forwarding_minimoFI");
                    mDatos.Manejos_Minimo_Flete_Internacional = mReader.GetFloat("manejos_minimoFI");
                    mDatos.Carga_Peligrosa_Flete_Internacional = mReader.GetFloat("carga_peligrosa_minimoFI");

                    mDatos.Proveedor_Cargos_En_Destino = mReader.GetString("proveedorGP");
                    mDatos.Costos_Cargos_En_Destino = mReader.GetFloat("cargosGP");

                    mDatos.Proveedor_Movimiento_Bodega = mReader.GetString("proveedorMPB");
                    mDatos.Transporte_Bodega_Movimiento_Bodega = mReader.GetFloat("transporte_bodegaMPB");

                    mDatos.Proveedor_Otras_Categorias1 = mReader.GetString("proveedorOC1");
                    mDatos.Producto_Otras_Categorias1 = mReader.GetString("productoOC1");
                    mDatos.Costos_Otras_Categorias1 = mReader.GetFloat("costoOC1");
                    mDatos.Proveedor_Otras_Categorias2 = mReader.GetString("proveedorOC2");
                    mDatos.Producto_Otras_Categorias2 = mReader.GetString("productoOC2");
                    mDatos.Costos_Otras_Categorias2 = mReader.GetFloat("costoOC2");
                    mDatos.Proveedor_Otras_Categorias3 = mReader.GetString("proveedorOC3");
                    mDatos.Producto_Otras_Categorias3 = mReader.GetString("productoOC3");
                    mDatos.Costos_Otras_Categorias3 = mReader.GetFloat("costoOC3");

                    mDatos.Proveedor_Cargos_Destino1 = mReader.GetString("proveedorCD1");
                    mDatos.Costo_Cargos_Destino1 = mReader.GetFloat("costoCD1");
                    mDatos.Proveedor_Cargos_Destino2 = mReader.GetString("proveedorCD2");
                    mDatos.Costo_Cargos_Destino2 = mReader.GetFloat("costoCD2");
                    mDatos.Proveedor_Cargos_Destino3 = mReader.GetString("proveedorCD3");
                    mDatos.Costo_Cargos_Destino3 = mReader.GetFloat("costoCD3");

                    mDatos.Modalidad = mReader.GetString("modalidad");
                    mDatos.Equipo = mReader.GetString("equipo");
                    mDatos.Desde = mReader.GetString("desde");
                    mDatos.Hasta = mReader.GetString("hasta");
                    mDatos.Total_Flete_Cbm = mReader.GetFloat("totalCBM");
                    mDatos.Total_Otros_Costos_Cbm = mReader.GetFloat("totalOtrosCBM");
                    mDatos.Total_Flete_Minimo = mReader.GetFloat("totalMinimo");
                    mDatos.Total_Otros_Costos_Minimos = mReader.GetFloat("totalOtrosMinimos");
                    mDatos.Total_Otros_Costos_Flat = mReader.GetFloat("totalOtrosFlat");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        internal bool agregarLCL(LCLtarifarios mTarifarios)
        {
            string QUERY = "CALL agregarLCL(@id_agente_origen,@id_naviero,@id_gastos_portuarios,@id_movimiento_puerto_bodega,@id_otras_categorias1,@id_otras_categorias2,@id_otras_categorias3,@id_cargos_destino1,@id_cargos_destino2,@id_cargos_destino3,@id_equipo,@id_modalidad,@desde,@hasta,@ruta,@total_flete_cbm,@total_flete_minimo,@total_costos_cbm,@total_costos_minimo,@total_costos_flat);"; 
            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id_agente_origen", mTarifarios.Id_Agente_Origen));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_naviero", mTarifarios.Id_Naviero));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_gastos_portuarios", mTarifarios.Id_Gastos_Portuarios));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_movimiento_puerto_bodega", mTarifarios.Id_Movimiento_Puerto_Bodega));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_otras_categorias1", mTarifarios.Id_Otras_Categorias1));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_otras_categorias2", mTarifarios.Id_Otras_Categorias2));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_otras_categorias3", mTarifarios.Id_Otras_Categorias3));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_cargos_destino1", mTarifarios.Id_Cargos_Destino1));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_cargos_destino2", mTarifarios.Id_Cargos_Destino2));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_cargos_destino3", mTarifarios.Id_Cargos_Destino3));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_modalidad", mTarifarios.Id_Modalidad));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_equipo", mTarifarios.Id_Equipo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@desde", mTarifarios.Desde));
            mySqlCommand.Parameters.Add(new MySqlParameter("@hasta", mTarifarios.Hasta));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ruta", mTarifarios.Ruta));
            mySqlCommand.Parameters.Add(new MySqlParameter("@total_flete_cbm", mTarifarios.Total_Flete_Cbm));
            mySqlCommand.Parameters.Add(new MySqlParameter("@total_flete_minimo", mTarifarios.Total_Flete_Minimo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@total_costos_cbm", mTarifarios.Total_Otros_Costos_Cbm));
            mySqlCommand.Parameters.Add(new MySqlParameter("@total_costos_minimo", mTarifarios.Total_Otros_Costos_Minimos));
            mySqlCommand.Parameters.Add(new MySqlParameter("@total_costos_flat", mTarifarios.Total_Otros_Costos_Flat));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarLCL(LCLtarifarios mTarifarios)
        {
            string QUERY = "CALL eliminarLCL(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mTarifarios.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarTodoLCL()
        {
            string QUERY = "CALL eliminarTodoLCL();";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
