using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarifarios_Tarifas.Globales;
using Tarifarios_Tarifas.Models.Atributos;
using Tarifarios_Tarifas.Models.Metodos;

namespace Tarifarios_Tarifas.Forms
{
    public partial class FrmAgregarDatos : Form
    {
        private List<ORIGEN> mOrigen;
        private ORIGEN mOrigen1;
        private OrigenConsultas mOrigenConsultas;
        private List<POL> mPol;
        private POL mPol1;
        private PolConsultas mPolConsultas;
        private List<POD> mPod;
        private POD mPod1;
        private PodConsultas mPodConsultas;
        private List<VIA> mVia;
        private VIA mVia1;
        private ViaConsultas mViaConsultas;
        private List<PAIS> mDestino;
        private PAIS mDestino1;
        private PaisConsultas mDestinoConsultas;
        private List<Equipo> mEquipo;
        private Equipo mEquipo1;
        private EquipoConsultas mEquipoConsultas;
        private List<Modalidad> mModalidad;
        private Modalidad mModalidad1;
        private ModalidadConsultas mModalidadConsultas;
        private List<AgenteOrigen> mAgenteOrigen;
        private AgenteOrigen mAgenteOrigen1;
        private AgenteOrigenConsultas mAgenteOrigenConsultas;
        private List<Naviero> mFleteInternacional;
        private Naviero mFleteInternacional1;
        private NavieroConsultas mFleteInternacionalConsultas;
        private List<CargosDestino> mCargosDestino;
        private CargosDestino mCargosDestino1;
        private CargosDestinoConsultas mCargosDestinoConsultas;
        private List<GastosPortuarios> mGastosPortuarios;
        private GastosPortuarios mGastosPortuarios1;
        private GastosPortariosConsultas mGastosPortuariosConsultas;
        private List<MovimientoPuertoBodega> mMovimientoPuertoBodega;
        private MovimientoPuertoBodega mMovimientoPuertoBodega1;
        private MovimientoPuertoBodegaConsultas mMovimientoPuertoBodegaConsultas;
        private List<OtrasCategorias> mOtrasCategorias;
        private OtrasCategorias mOtrasCategorias1;
        private OtrasCategoriasConsultas mOtrasCategoriasConsultas;
        private List<OtroServicios> mOtrosServicios;
        private OtroServicios mOtrosServicios1;
        private OtrosServiciosConsultas mOtrosServiciosConsultas;
        private List<AgenteOrigenLCL> mAgenteOrigenLCL;
        private AgenteOrigenLCL mAgenteOrigenLCL1;
        private AgenteOrigenLCLConsultas mAgenteOrigenLCLConsultas;
        private List<NavieroLCL> mFleteInternacionalLCL;
        private NavieroLCL mFleteInternacionalLCL1;
        private NavieroLCLConsultas mFleteInternacionalLCLConsultas;
        private List<GastosPortuariosLCL> mGastosPortuariosLCL;
        private GastosPortuariosLCL mGastosPortuariosLCL1;
        private GastosPortariosLCLConsultas mGastosPortuariosLCLConsultas;
        private List<MovimientoPuertoBodegaLCL> mMovimientoPuertoBodegaLCL;
        private MovimientoPuertoBodegaLCL mMovimientoPuertoBodegaLCL1;
        private MovimientoPuertoBodegaLCLConsultas mMovimientoPuertoBodegaLCLConsultas;
        private List<OtrasCategoriasLCL> mOtrasCategoriasLCL;
        private OtrasCategoriasLCL mOtrasCategoriasLCL1;
        private OtrasCategoriasLCLConsultas mOtrasCategoriasLCLConsultas;
        private List<CargosDestinoLCL> mCargosDestinoLCL;
        private CargosDestinoLCL mCargosDestinoLCL1;
        private CargosDestinoLCLConsultas mCargosDestinoLCLConsultas;

        string[] lista = { "ALEMANIA", "ARABIA SAUDITA", "ARGELIA", "ARGENTINA", "AUSTRALIA", "AUSTRIA", "BAHAMAS", "BANGLADESH", "BARBADOS", "BELGICA", "BELICE", "BOLIVIA", "BRASIL", "CANADA", "CHILE", "CHINA", "COLOMBIA", "COSTA RICA", "CROACIA", "CUBA", "DINAMARCA", "DOMINICA", "DUABI", "ECUADOR", "EGIPTO", "ESLOVAQUIA", "ESLOVENIA", "ESPAÑA", "FINLANDIA", "FILIPINAS", "FRANCIA", "GRECIA", "GUATEMALA", "HAITI", "HOLANDA", "HONDURAS", "HUNGRIA", "INDIA", "INDONESIA", "IRLANDIA", "ISLANDIA", "ISRAEL", "ITALIA", "JAMAICA", "JAPON", "KOREA", "LUXEMBURGO", "MALASIA", "MALDIVAS", "MARRUECOS", "MEXICO", "MONACO", "MONGOLIA", "NEPAL", "NICARAGUA", "NORUEGA", "NUEVA ZELANDA", "PANAMA", "PARAGUAY", "PERU", "POLONIA", "PORTUGAL", "QATAR", "REINO UNIDO", "REPUBLICA DOMINICANA", "RUSIA", "EL SALVADOR", "SINGAPUR", "SUDAFRICA", "SUECIA", "SUIZA", "THAILANDIA", "TAIWAN", "TUNEZ", "TURQUIA", "UCRANIA", "URUGUAY", "USA", "VENEZUELA", "VIETNAM" };
        string[] lista1 = { "RODMAN", "CRISTOBAL", "MANZANILLO", "BALBOA", "MOIN", "CALDERA", "NO APLICA" };
        string[] lista2 = { "RODMAN", "CRISTOBAL", "MANZANILLO", "BALBOA" };

        public FrmAgregarDatos()
        {
            InitializeComponent();

            mOrigen = new List<ORIGEN>();
            mOrigen1 = new ORIGEN();
            mOrigenConsultas = new OrigenConsultas();
            mPol = new List<POL>();
            mPol1 = new POL();
            mPolConsultas = new PolConsultas();
            mPod = new List<POD>();
            mPod1 = new POD();
            mPodConsultas = new PodConsultas();
            mVia = new List<VIA>();
            mVia1 = new VIA();
            mViaConsultas = new ViaConsultas();
            mDestino = new List<PAIS>();
            mDestino1 = new PAIS();
            mDestinoConsultas = new PaisConsultas();
            mEquipo = new List<Equipo>();
            mEquipo1 = new Equipo();
            mEquipoConsultas = new EquipoConsultas();
            mModalidad = new List<Modalidad>();
            mModalidad1 = new Modalidad();
            mModalidadConsultas = new ModalidadConsultas();
            mAgenteOrigen = new List<AgenteOrigen>();
            mAgenteOrigen1 = new AgenteOrigen();
            mAgenteOrigenConsultas = new AgenteOrigenConsultas();
            mFleteInternacional = new List<Naviero>();
            mFleteInternacional1 = new Naviero();
            mFleteInternacionalConsultas = new NavieroConsultas();
            mCargosDestino = new List<CargosDestino>();
            mCargosDestino1 = new CargosDestino();
            mCargosDestinoConsultas = new CargosDestinoConsultas();
            mGastosPortuarios = new List<GastosPortuarios>();
            mGastosPortuarios1 = new GastosPortuarios();
            mGastosPortuariosConsultas = new GastosPortariosConsultas();
            mMovimientoPuertoBodega = new List<MovimientoPuertoBodega>();
            mMovimientoPuertoBodega1 = new MovimientoPuertoBodega();
            mMovimientoPuertoBodegaConsultas = new MovimientoPuertoBodegaConsultas();
            mOtrasCategorias = new List<OtrasCategorias>();
            mOtrasCategorias1 = new OtrasCategorias();
            mOtrasCategoriasConsultas = new OtrasCategoriasConsultas();
            mOtrosServicios = new List<OtroServicios>();
            mOtrosServicios1 = new OtroServicios();
            mOtrosServiciosConsultas = new OtrosServiciosConsultas();
            mAgenteOrigenLCL = new List<AgenteOrigenLCL>();
            mAgenteOrigenLCL1 = new AgenteOrigenLCL();
            mAgenteOrigenLCLConsultas = new AgenteOrigenLCLConsultas();
            mFleteInternacionalLCL = new List<NavieroLCL>();
            mFleteInternacionalLCL1 = new NavieroLCL();
            mFleteInternacionalLCLConsultas = new NavieroLCLConsultas();
            mGastosPortuariosLCL = new List<GastosPortuariosLCL>();
            mGastosPortuariosLCL1 = new GastosPortuariosLCL();
            mGastosPortuariosLCLConsultas = new GastosPortariosLCLConsultas();
            mMovimientoPuertoBodegaLCL = new List<MovimientoPuertoBodegaLCL>();
            mMovimientoPuertoBodegaLCL1 = new MovimientoPuertoBodegaLCL();
            mMovimientoPuertoBodegaLCLConsultas = new MovimientoPuertoBodegaLCLConsultas();
            mOtrasCategoriasLCL = new List<OtrasCategoriasLCL>();
            mOtrasCategoriasLCL1 = new OtrasCategoriasLCL();
            mOtrasCategoriasLCLConsultas = new OtrasCategoriasLCLConsultas();
            mCargosDestinoLCL = new List<CargosDestinoLCL>();
            mCargosDestinoLCL1 = new CargosDestinoLCL();
            mCargosDestinoLCLConsultas = new CargosDestinoLCLConsultas();

            var heightField = typeof(CheckedListBox).GetField("scaledListItemBordersHeight", BindingFlags.NonPublic | BindingFlags.Instance);

            var addedHeight = 30;

            heightField.SetValue(clbAgenteOrigen, addedHeight);
            heightField.SetValue(clbAgenteOrigenLCL, addedHeight);
            heightField.SetValue(clbPaisesFleteInternacional, addedHeight);
            heightField.SetValue(clbViasFleteInternacional, addedHeight);
            heightField.SetValue(clbPaisesFleteInternacionalLCL, addedHeight);
            heightField.SetValue(clbViasFleteInternacionalLCL, addedHeight);
            heightField.SetValue(clbCargosDestino, addedHeight);
            heightField.SetValue(clbCargosDestinoLCL, addedHeight);
            heightField.SetValue(clbGastosPortuarios, addedHeight);
            heightField.SetValue(clbGastosPortuariosLCL, addedHeight);
            heightField.SetValue(clbMovimientoPuertoBodega, addedHeight);
            heightField.SetValue(clbMovimientoPuertoBodegaLCL, addedHeight);
            heightField.SetValue(clbOtrasCategorias, addedHeight);
            heightField.SetValue(clbOtrasCategoriasLCL, addedHeight);
            heightField.SetValue(clbOtrosServicios, addedHeight);
            heightField.SetValue(clbViasDestino, addedHeight);
            heightField.SetValue(clbViasDestinoLCL, addedHeight);

            cargarORIGEN();
            cargarPOL();
            cargarPOD();
            cargarVIA();
            cargarDESTINO();
            cargarEQUIPO();
            cargarMODALIDAD();
            cargarAGENTEORIGEN();
            cargarAGENTEORIGENLCL();
            cargarFLETEINTERNACIONAL();
            cargarFLETEINTERNACIONALLCL();
            cargarCARGOSDESTINO();
            cargarCARGOSDESTINOLCL();
            cargarGASTOSPORTUARIOS();
            cargarGASTOSPORTUARIOSLCL();
            cargarMOVIMIENTOPUERTOBODEGA();
            cargarMOVIMIENTOPUERTOBODEGALCL();
            cargarOTRASCATEGORIAS();
            cargarOTRASCATEGORIASLCL();
            cargarOTROSSERVICIOS();
        }
        private void cargarORIGEN()
        {
            dgvOrigen.Rows.Clear();
            dgvOrigen.Refresh();
            mOrigen.Clear();
            mOrigen = mOrigenConsultas.getOrigen();
            for (int i = 0; i < mOrigen.Count; i++)
            {
                dgvOrigen.RowTemplate.Height = 50;
                dgvOrigen.Rows.Add(
                    mOrigen[i].Id,
                    mOrigen[i].Origen);
            }
        }
        private void cargarPOL()
        {
            dgvPol.Rows.Clear();
            dgvPol.Refresh();
            mPol.Clear();
            mPol = mPolConsultas.getPol();
            for (int i = 0; i < mPol.Count; i++)
            {
                dgvPol.RowTemplate.Height = 50;
                dgvPol.Rows.Add(
                    mPol[i].Id,
                    mPol[i].Pol);
            }
        }
        private void cargarPOD()
        {
            dgvPod.Rows.Clear();
            dgvPod.Refresh();
            mPod.Clear();
            mPod = mPodConsultas.getPod();
            for (int i = 0; i < mPod.Count; i++)
            {
                dgvPod.RowTemplate.Height = 50;
                dgvPod.Rows.Add(
                    mPod[i].Id,
                    mPod[i].Pod);
            }
        }
        private void cargarVIA()
        {
            dgvVia.Rows.Clear();
            dgvVia.Refresh();
            mVia.Clear();
            mVia = mViaConsultas.getVia();
            for (int i = 0; i < mVia.Count; i++)
            {
                dgvVia.RowTemplate.Height = 50;
                dgvVia.Rows.Add(
                    mVia[i].Id,
                    mVia[i].Via);
            }
        }
        private void cargarDESTINO()
        {
            dgvDestino.Rows.Clear();
            dgvDestino.Refresh();
            mDestino.Clear();
            mDestino = mDestinoConsultas.getPais();
            for (int i = 0; i < mDestino.Count; i++)
            {
                dgvDestino.RowTemplate.Height = 50;
                dgvDestino.Rows.Add(
                    mDestino[i].Id,
                    mDestino[i].Pais);
            }
        }
        private void cargarEQUIPO()
        {
            dgvEquipo.Rows.Clear();
            dgvEquipo.Refresh();
            mEquipo.Clear();
            mEquipo = mEquipoConsultas.getEquipo();
            for (int i = 0; i < mEquipo.Count; i++)
            {
                dgvEquipo.RowTemplate.Height = 50;
                dgvEquipo.Rows.Add(
                    mEquipo[i].Id,
                    mEquipo[i].Equipos);
            }
        }
        private void cargarMODALIDAD()
        {
            dgvModalidad.Rows.Clear();
            dgvModalidad.Refresh();
            mModalidad.Clear();
            mModalidad = mModalidadConsultas.getModalidad();
            for (int i = 0; i < mModalidad.Count; i++)
            {
                dgvModalidad.RowTemplate.Height = 50;
                dgvModalidad.Rows.Add(
                    mModalidad[i].Id,
                    mModalidad[i].Modalidades);
            }
        }
        private void cargarAGENTEORIGEN()
        {
            dgvAgenteOrigen.Rows.Clear();
            dgvAgenteOrigen.Refresh();
            mAgenteOrigen.Clear();
            mAgenteOrigen = mAgenteOrigenConsultas.getAgenteOrigen1();
            for (int i = 0; i < mAgenteOrigen.Count; i++)
            {
                dgvAgenteOrigen.RowTemplate.Height = 50;
                dgvAgenteOrigen.Rows.Add(
                    mAgenteOrigen[i].Id,
                    mAgenteOrigen[i].Proveedor,
                    mAgenteOrigen[i].Hbl,
                    mAgenteOrigen[i].Manejos);
            }
            clbAgenteOrigen.Items.Clear();
            clbAgenteOrigen.Refresh();
            clbAgenteOrigen.Items.AddRange(lista);
        }
        private void cargarAGENTEORIGENLCL()
        {
            dgvAgenteOrigenLCL.Rows.Clear();
            dgvAgenteOrigenLCL.Refresh();
            mAgenteOrigenLCL.Clear();
            mAgenteOrigenLCL = mAgenteOrigenLCLConsultas.getAgenteOrigen1();
            for (int i = 0; i < mAgenteOrigenLCL.Count; i++)
            {
                dgvAgenteOrigenLCL.RowTemplate.Height = 50;
                dgvAgenteOrigenLCL.Rows.Add(
                    mAgenteOrigenLCL[i].Id,
                    mAgenteOrigenLCL[i].Proveedor,
                    mAgenteOrigenLCL[i].Hbl,
                    mAgenteOrigenLCL[i].Manejos);
            }
            clbAgenteOrigenLCL.Items.Clear();
            clbAgenteOrigenLCL.Refresh();
            clbAgenteOrigenLCL.Items.AddRange(lista);
        }
        private void cargarFLETEINTERNACIONAL()
        {
            dgvFleteInternacional.Rows.Clear();
            dgvFleteInternacional.Refresh();
            mFleteInternacional.Clear();
            mFleteInternacional = mFleteInternacionalConsultas.getNaviero1();
            for (int i = 0; i < mFleteInternacional.Count; i++)
            {
                dgvFleteInternacional.RowTemplate.Height = 50;
                dgvFleteInternacional.Rows.Add(
                    mFleteInternacional[i].Id,
                    mFleteInternacional[i].Proveedor,
                    mFleteInternacional[i].Thc,
                    mFleteInternacional[i].Doc_fee,
                    mFleteInternacional[i].Security,
                    mFleteInternacional[i].Impresion_bl,
                    mFleteInternacional[i].Port_facility,
                    mFleteInternacional[i].Canal_fee,
                    mFleteInternacional[i].Vac,
                    mFleteInternacional[i].Impdo,
                    mFleteInternacional[i].Merchant);
            }
            clbPaisesFleteInternacional.Items.Clear();
            clbPaisesFleteInternacional.Refresh();
            clbPaisesFleteInternacional.Items.AddRange(lista);
            clbViasFleteInternacional.Items.Clear();
            clbViasFleteInternacional.Refresh();
            clbViasFleteInternacional.Items.AddRange(lista1);
        }
        private void cargarFLETEINTERNACIONALLCL()
        {
            dgvFleteInternacionalLCL.Rows.Clear();
            dgvFleteInternacionalLCL.Refresh();
            mFleteInternacionalLCL.Clear();
            mFleteInternacionalLCL = mFleteInternacionalLCLConsultas.getNaviero1();
            for (int i = 0; i < mFleteInternacionalLCL.Count; i++)
            {
                dgvFleteInternacionalLCL.RowTemplate.Height = 50;
                dgvFleteInternacionalLCL.Rows.Add(
                    mFleteInternacionalLCL[i].Id,
                    mFleteInternacionalLCL[i].Proveedor,
                    mFleteInternacionalLCL[i].Thc_d_cbm,
                    mFleteInternacionalLCL[i].Thc_d_minimo,
                    mFleteInternacionalLCL[i].Vgm_minimo,
                    mFleteInternacionalLCL[i].Bunker_cbm,
                    mFleteInternacionalLCL[i].Bunker_minimo,
                    mFleteInternacionalLCL[i].Sed_minimo,
                    mFleteInternacionalLCL[i].Tica_minimo,
                    mFleteInternacionalLCL[i].Forwarding_minimo,
                    mFleteInternacionalLCL[i].Manejos_minimo,
                    mFleteInternacionalLCL[i].Carga_peligrosa_minimo);
            }
            clbPaisesFleteInternacionalLCL.Items.Clear();
            clbPaisesFleteInternacionalLCL.Refresh();
            clbPaisesFleteInternacionalLCL.Items.AddRange(lista);
            clbViasFleteInternacionalLCL.Items.Clear();
            clbViasFleteInternacionalLCL.Refresh();
            clbViasFleteInternacionalLCL.Items.AddRange(lista1);
        }
        private void cargarCARGOSDESTINO()
        {
            dgvCargpsDestino.Rows.Clear();
            dgvCargpsDestino.Refresh();
            mCargosDestino.Clear();
            mCargosDestino = mCargosDestinoConsultas.getCargosDestino1();
            for (int i = 0; i < mCargosDestino.Count; i++)
            {
                dgvCargpsDestino.RowTemplate.Height = 50;
                dgvCargpsDestino.Rows.Add(
                    mCargosDestino[i].Id,
                    mCargosDestino[i].Proveedor,
                    mCargosDestino[i].Flete);
            }
            clbCargosDestino.Items.Clear();
            clbCargosDestino.Refresh();
            clbCargosDestino.Items.AddRange(lista);
            clbViasDestino.Items.Clear();
            clbViasDestino.Refresh();
            clbViasDestino.Items.AddRange(lista1);
        }
        private void cargarCARGOSDESTINOLCL()
        {
            dgvCargpsDestinoLCL.Rows.Clear();
            dgvCargpsDestinoLCL.Refresh();
            mCargosDestinoLCL.Clear();
            mCargosDestinoLCL = mCargosDestinoLCLConsultas.getCargosDestino1();
            for (int i = 0; i < mCargosDestinoLCL.Count; i++)
            {
                dgvCargpsDestinoLCL.RowTemplate.Height = 50;
                dgvCargpsDestinoLCL.Rows.Add(
                    mCargosDestinoLCL[i].Id,
                    mCargosDestinoLCL[i].Proveedor,
                    mCargosDestinoLCL[i].Flete);
            }
            clbCargosDestinoLCL.Items.Clear();
            clbCargosDestinoLCL.Refresh();
            clbCargosDestinoLCL.Items.AddRange(lista);
            clbViasDestinoLCL.Items.Clear();
            clbViasDestinoLCL.Refresh();
            clbViasDestinoLCL.Items.AddRange(lista1);
        }

        private void cargarGASTOSPORTUARIOS()
        {
            dgvGastosPortuarios.Rows.Clear();
            dgvGastosPortuarios.Refresh();
            mGastosPortuarios.Clear();
            mGastosPortuarios = mGastosPortuariosConsultas.getGastosPortuarios1();
            for (int i = 0; i < mGastosPortuarios.Count; i++)
            {
                dgvGastosPortuarios.RowTemplate.Height = 50;
                dgvGastosPortuarios.Rows.Add(
                    mGastosPortuarios[i].Id,
                    mGastosPortuarios[i].Proveedor,
                    mGastosPortuarios[i].Manejos_pueto);
            }
            clbOtrosServicios.Items.Clear();
            clbOtrosServicios.Refresh();
            clbOtrosServicios.Items.AddRange(lista2);
        }
        private void cargarGASTOSPORTUARIOSLCL()
        {
            dgvGastosPortuariosLCL.Rows.Clear();
            dgvGastosPortuariosLCL.Refresh();
            mGastosPortuariosLCL.Clear();
            mGastosPortuariosLCL = mGastosPortuariosLCLConsultas.getGastosPortuarios1();
            for (int i = 0; i < mGastosPortuariosLCL.Count; i++)
            {
                dgvGastosPortuariosLCL.RowTemplate.Height = 50;
                dgvGastosPortuariosLCL.Rows.Add(
                    mGastosPortuariosLCL[i].Id,
                    mGastosPortuariosLCL[i].Proveedor,
                    mGastosPortuariosLCL[i].Cargos);
            }
            clbGastosPortuariosLCL.Items.Clear();
            clbGastosPortuariosLCL.Refresh();
            clbGastosPortuariosLCL.Items.AddRange(lista2);
        }
        private void cargarMOVIMIENTOPUERTOBODEGA()
        {
            dgvMovimientoPuertoBodega.Rows.Clear();
            dgvMovimientoPuertoBodega.Refresh();
            mMovimientoPuertoBodega.Clear();
            mMovimientoPuertoBodega = mMovimientoPuertoBodegaConsultas.getMovimientoPuertoBodega1();
            for (int i = 0; i < mMovimientoPuertoBodega.Count; i++)
            {
                dgvMovimientoPuertoBodega.RowTemplate.Height = 50;
                dgvMovimientoPuertoBodega.Rows.Add(
                    mMovimientoPuertoBodega[i].Id,
                    mMovimientoPuertoBodega[i].Proveedor,
                    mMovimientoPuertoBodega[i].Transporte_puerto);
            }
            clbMovimientoPuertoBodega.Items.Clear();
            clbMovimientoPuertoBodega.Refresh();
            clbMovimientoPuertoBodega.Items.AddRange(lista2);
        }
        private void cargarMOVIMIENTOPUERTOBODEGALCL()
        {
            dgvMovimientoPuertoBodegaLCL.Rows.Clear();
            dgvMovimientoPuertoBodegaLCL.Refresh();
            mMovimientoPuertoBodegaLCL.Clear();
            mMovimientoPuertoBodegaLCL = mMovimientoPuertoBodegaLCLConsultas.getMovimientoPuertoBodega1();
            for (int i = 0; i < mMovimientoPuertoBodegaLCL.Count; i++)
            {
                dgvMovimientoPuertoBodegaLCL.RowTemplate.Height = 50;
                dgvMovimientoPuertoBodegaLCL.Rows.Add(
                    mMovimientoPuertoBodegaLCL[i].Id,
                    mMovimientoPuertoBodegaLCL[i].Proveedor,
                    mMovimientoPuertoBodegaLCL[i].Transporte_bodega);
            }
            clbMovimientoPuertoBodegaLCL.Items.Clear();
            clbMovimientoPuertoBodegaLCL.Refresh();
            clbMovimientoPuertoBodegaLCL.Items.AddRange(lista2);
        }
        private void cargarOTRASCATEGORIAS()
        {
            dgvOtrasCategorias.Rows.Clear();
            dgvOtrasCategorias.Refresh();
            mOtrasCategorias.Clear();
            mOtrasCategorias = mOtrasCategoriasConsultas.getOtrasCategorias1();
            for (int i = 0; i < mOtrasCategorias.Count; i++)
            {
                dgvOtrasCategorias.RowTemplate.Height = 50;
                dgvOtrasCategorias.Rows.Add(
                    mOtrasCategorias[i].Id,
                    mOtrasCategorias[i].Proveedor,
                    mOtrasCategorias[i].Producto,
                    mOtrasCategorias[i].Costo);
            }
            clbOtrasCategorias.Items.Clear();
            clbOtrasCategorias.Refresh();
            clbOtrasCategorias.Items.AddRange(lista2);
        }
        private void cargarOTRASCATEGORIASLCL()
        {
            dgvOtrasCategoriasLCL.Rows.Clear();
            dgvOtrasCategoriasLCL.Refresh();
            mOtrasCategoriasLCL.Clear();
            mOtrasCategoriasLCL = mOtrasCategoriasLCLConsultas.getOtrasCategorias1();
            for (int i = 0; i < mOtrasCategoriasLCL.Count; i++)
            {
                dgvOtrasCategoriasLCL.RowTemplate.Height = 50;
                dgvOtrasCategoriasLCL.Rows.Add(
                    mOtrasCategoriasLCL[i].Id,
                    mOtrasCategoriasLCL[i].Proveedor,
                    mOtrasCategoriasLCL[i].Producto,
                    mOtrasCategoriasLCL[i].Costo);
            }
            clbOtrasCategoriasLCL.Items.Clear();
            clbOtrasCategoriasLCL.Refresh();
            clbOtrasCategoriasLCL.Items.AddRange(lista2);
        }
        private void cargarOTROSSERVICIOS()
        {
            dgvOtrosServicios.Rows.Clear();
            dgvOtrosServicios.Refresh();
            mOtrosServicios.Clear();
            mOtrosServicios = mOtrosServiciosConsultas.getOtrosServicios1();
            for (int i = 0; i < mOtrosServicios.Count; i++)
            {
                dgvOtrosServicios.RowTemplate.Height = 50;
                dgvOtrosServicios.Rows.Add(
                    mOtrosServicios[i].Id,
                    mOtrosServicios[i].Proveedor,
                    mOtrosServicios[i].Producto,
                    mOtrosServicios[i].Costo);
            }
            clbOtrosServicios.Items.Clear();
            clbOtrosServicios.Refresh();
            clbOtrosServicios.Items.AddRange(lista2);
        }

        private void cargarDatosGuardadosOrigen()
        {
            mOrigen1.Id = getIdOrigenIfExist();
            mOrigen1.Origen = (txtPaisOrigen.Text).ToUpper();
        }
        private void cargarDatosGuardadosPol()
        {
            mPol1.Id = getIdPolIfExist();
            mPol1.Pol = (txtPol.Text).ToUpper();
        }
        private void cargarDatosGuardadosPod()
        {
            mPod1.Id = getIdPodIfExist();
            mPod1.Pod = (txtPod.Text).ToUpper();
        }
        private void cargarDatosGuardadosVia()
        {
            mVia1.Id = getIdViaIfExist();
            mVia1.Via = (txtVia.Text).ToUpper();
        }
        private void cargarDatosGuardadosDestino()
        {
            mDestino1.Id = getIdDestinoIfExist();
            mDestino1.Pais = (txtPaisDestino.Text).ToUpper();
        }
        private void cargarDatosGuardadosEquipo()
        {
            mEquipo1.Id = getIdEquipoIfExist();
            mEquipo1.Equipos = (txtEquipo.Text).ToUpper();
        }
        private void cargarDatosGuardadosModalidad()
        {
            mModalidad1.Id = getIdModalidadIfExist();
            mModalidad1.Modalidades = (txtModalidad.Text).ToUpper();
        }
        private void cargarDatosGuardadosAgenteOrigen()
        {
            mAgenteOrigen1.Id = getIdAgenteOrigenIfExist();
            mAgenteOrigen1.Proveedor = (txtAgenteOrigen.Text).ToUpper();
            mAgenteOrigen1.Manejos = float.Parse(txtManejosAgenteOrigen.Text);
            mAgenteOrigen1.Hbl = float.Parse(txtHblAgenteOrigen.Text);
            for (int i = 0; i < clbAgenteOrigen.Items.Count; i++)
            {
                if (clbAgenteOrigen.GetItemChecked(i))
                {
                    if (clbAgenteOrigen.GetItemText(i) == "0")
                    {
                        mAgenteOrigen1.alemania = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "1")
                    {
                        mAgenteOrigen1.arabia_saudi = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "2")
                    {
                        mAgenteOrigen1.argelia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "3")
                    {
                        mAgenteOrigen1.argentina = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "4")
                    {
                        mAgenteOrigen1.australia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "5")
                    {
                        mAgenteOrigen1.austria = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "6")
                    {
                        mAgenteOrigen1.bahamas = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "7")
                    {
                        mAgenteOrigen1.bangladesh = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "8")
                    {
                        mAgenteOrigen1.barbados = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "9")
                    {
                        mAgenteOrigen1.belgica = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "10")
                    {
                        mAgenteOrigen1.belice = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "11")
                    {
                        mAgenteOrigen1.bolivia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "12")
                    {
                        mAgenteOrigen1.brasil = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "13")
                    {
                        mAgenteOrigen1.canada = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "14")
                    {
                        mAgenteOrigen1.chile = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "15")
                    {
                        mAgenteOrigen1.china = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "16")
                    {
                        mAgenteOrigen1.colombia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "17")
                    {
                        mAgenteOrigen1.crc = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "18")
                    {
                        mAgenteOrigen1.croacia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "19")
                    {
                        mAgenteOrigen1.cuba = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "20")
                    {
                        mAgenteOrigen1.dinamarca = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "21")
                    {
                        mAgenteOrigen1.dominica = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "22")
                    {
                        mAgenteOrigen1.dubai = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "23")
                    {
                        mAgenteOrigen1.ecuador = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "24")
                    {
                        mAgenteOrigen1.egipto = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "25")
                    {
                        mAgenteOrigen1.eslovaquia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "26")
                    {
                        mAgenteOrigen1.eslovenia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "27")
                    {
                        mAgenteOrigen1.espana = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "28")
                    {
                        mAgenteOrigen1.finlandia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "29")
                    {
                        mAgenteOrigen1.flipinas = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "30")
                    {
                        mAgenteOrigen1.francia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "31")
                    {
                        mAgenteOrigen1.grecia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "32")
                    {
                        mAgenteOrigen1.guatemala = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "33")
                    {
                        mAgenteOrigen1.haiti = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "34")
                    {
                        mAgenteOrigen1.holanda = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "35")
                    {
                        mAgenteOrigen1.honduras = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "36")
                    {
                        mAgenteOrigen1.hungria = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "37")
                    {
                        mAgenteOrigen1.india = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "38")
                    {
                        mAgenteOrigen1.indonesia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "39")
                    {
                        mAgenteOrigen1.irlandia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "40")
                    {
                        mAgenteOrigen1.islandia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "41")
                    {
                        mAgenteOrigen1.israel = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "42")
                    {
                        mAgenteOrigen1.italia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "43")
                    {
                        mAgenteOrigen1.jamaica = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "44")
                    {
                        mAgenteOrigen1.japon = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "45")
                    {
                        mAgenteOrigen1.korea = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "46")
                    {
                        mAgenteOrigen1.luxemburgo = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "47")
                    {
                        mAgenteOrigen1.malasia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "48")
                    {
                        mAgenteOrigen1.maldivas = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "49")
                    {
                        mAgenteOrigen1.marruecos = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "50")
                    {
                        mAgenteOrigen1.maxico = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "51")
                    {
                        mAgenteOrigen1.monaco = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "52")
                    {
                        mAgenteOrigen1.mongolia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "53")
                    {
                        mAgenteOrigen1.nepal = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "54")
                    {
                        mAgenteOrigen1.nicaragua = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "55")
                    {
                        mAgenteOrigen1.noruega = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "56")
                    {
                        mAgenteOrigen1.nueva_zelanda = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "57")
                    {
                        mAgenteOrigen1.panama = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "58")
                    {
                        mAgenteOrigen1.paraguay = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "59")
                    {
                        mAgenteOrigen1.peru = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "60")
                    {
                        mAgenteOrigen1.polonia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "61")
                    {
                        mAgenteOrigen1.portugal = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "62")
                    {
                        mAgenteOrigen1.qatar = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "63")
                    {
                        mAgenteOrigen1.reino_unido = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "64")
                    {
                        mAgenteOrigen1.republica_dominicana = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "65")
                    {
                        mAgenteOrigen1.rusia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "66")
                    {
                        mAgenteOrigen1.salvador = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "67")
                    {
                        mAgenteOrigen1.singapur = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "68")
                    {
                        mAgenteOrigen1.sudafrica = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "69")
                    {
                        mAgenteOrigen1.suecia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "70")
                    {
                        mAgenteOrigen1.suiza = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "71")
                    {
                        mAgenteOrigen1.thailandia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "72")
                    {
                        mAgenteOrigen1.taiwan = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "73")
                    {
                        mAgenteOrigen1.tunez = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "74")
                    {
                        mAgenteOrigen1.turquia = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "75")
                    {
                        mAgenteOrigen1.ucrania = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "76")
                    {
                        mAgenteOrigen1.uruguay = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "77")
                    {
                        mAgenteOrigen1.usa = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "78")
                    {
                        mAgenteOrigen1.venezuela = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "79")
                    {
                        mAgenteOrigen1.vietnam = 1;
                    }
                }
                else
                {
                    if (clbAgenteOrigen.GetItemText(i) == "0")
                    {
                        mAgenteOrigen1.alemania = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "1")
                    {
                        mAgenteOrigen1.arabia_saudi = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "2")
                    {
                        mAgenteOrigen1.argelia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "3")
                    {
                        mAgenteOrigen1.argentina = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "4")
                    {
                        mAgenteOrigen1.australia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "5")
                    {
                        mAgenteOrigen1.austria = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "6")
                    {
                        mAgenteOrigen1.bahamas = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "7")
                    {
                        mAgenteOrigen1.bangladesh = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "8")
                    {
                        mAgenteOrigen1.barbados = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "9")
                    {
                        mAgenteOrigen1.belgica = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "10")
                    {
                        mAgenteOrigen1.belice = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "11")
                    {
                        mAgenteOrigen1.bolivia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "12")
                    {
                        mAgenteOrigen1.brasil = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "13")
                    {
                        mAgenteOrigen1.canada = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "14")
                    {
                        mAgenteOrigen1.chile = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "15")
                    {
                        mAgenteOrigen1.china = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "16")
                    {
                        mAgenteOrigen1.colombia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "17")
                    {
                        mAgenteOrigen1.crc = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "18")
                    {
                        mAgenteOrigen1.croacia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "19")
                    {
                        mAgenteOrigen1.cuba = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "20")
                    {
                        mAgenteOrigen1.dinamarca = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "21")
                    {
                        mAgenteOrigen1.dominica = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "22")
                    {
                        mAgenteOrigen1.dubai = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "23")
                    {
                        mAgenteOrigen1.ecuador = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "24")
                    {
                        mAgenteOrigen1.egipto = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "25")
                    {
                        mAgenteOrigen1.eslovaquia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "26")
                    {
                        mAgenteOrigen1.eslovenia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "27")
                    {
                        mAgenteOrigen1.espana = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "28")
                    {
                        mAgenteOrigen1.finlandia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "29")
                    {
                        mAgenteOrigen1.flipinas = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "30")
                    {
                        mAgenteOrigen1.francia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "31")
                    {
                        mAgenteOrigen1.grecia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "32")
                    {
                        mAgenteOrigen1.guatemala = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "33")
                    {
                        mAgenteOrigen1.haiti = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "34")
                    {
                        mAgenteOrigen1.holanda = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "35")
                    {
                        mAgenteOrigen1.honduras = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "36")
                    {
                        mAgenteOrigen1.hungria = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "37")
                    {
                        mAgenteOrigen1.india = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "38")
                    {
                        mAgenteOrigen1.indonesia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "39")
                    {
                        mAgenteOrigen1.irlandia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "40")
                    {
                        mAgenteOrigen1.islandia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "41")
                    {
                        mAgenteOrigen1.israel = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "42")
                    {
                        mAgenteOrigen1.italia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "43")
                    {
                        mAgenteOrigen1.jamaica = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "44")
                    {
                        mAgenteOrigen1.japon = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "45")
                    {
                        mAgenteOrigen1.korea = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "46")
                    {
                        mAgenteOrigen1.luxemburgo = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "47")
                    {
                        mAgenteOrigen1.malasia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "48")
                    {
                        mAgenteOrigen1.maldivas = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "49")
                    {
                        mAgenteOrigen1.marruecos = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "50")
                    {
                        mAgenteOrigen1.maxico = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "51")
                    {
                        mAgenteOrigen1.monaco = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "52")
                    {
                        mAgenteOrigen1.mongolia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "53")
                    {
                        mAgenteOrigen1.nepal = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "54")
                    {
                        mAgenteOrigen1.nicaragua = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "55")
                    {
                        mAgenteOrigen1.noruega = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "56")
                    {
                        mAgenteOrigen1.nueva_zelanda = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "57")
                    {
                        mAgenteOrigen1.panama = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "58")
                    {
                        mAgenteOrigen1.paraguay = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "59")
                    {
                        mAgenteOrigen1.peru = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "60")
                    {
                        mAgenteOrigen1.polonia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "61")
                    {
                        mAgenteOrigen1.portugal = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "62")
                    {
                        mAgenteOrigen1.qatar = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "63")
                    {
                        mAgenteOrigen1.reino_unido = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "64")
                    {
                        mAgenteOrigen1.republica_dominicana = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "65")
                    {
                        mAgenteOrigen1.rusia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "66")
                    {
                        mAgenteOrigen1.salvador = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "67")
                    {
                        mAgenteOrigen1.singapur = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "68")
                    {
                        mAgenteOrigen1.sudafrica = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "69")
                    {
                        mAgenteOrigen1.suecia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "70")
                    {
                        mAgenteOrigen1.suiza = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "71")
                    {
                        mAgenteOrigen1.thailandia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "72")
                    {
                        mAgenteOrigen1.taiwan = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "73")
                    {
                        mAgenteOrigen1.tunez = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "74")
                    {
                        mAgenteOrigen1.turquia = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "75")
                    {
                        mAgenteOrigen1.ucrania = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "76")
                    {
                        mAgenteOrigen1.uruguay = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "77")
                    {
                        mAgenteOrigen1.usa = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "78")
                    {
                        mAgenteOrigen1.venezuela = 0;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "78")
                    {
                        mAgenteOrigen1.vietnam = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosAgenteOrigenLCL()
        {
            mAgenteOrigenLCL1.Id = getIdAgenteOrigenLCLIfExist();
            mAgenteOrigenLCL1.Proveedor = (txtAgenteOrigenLCL.Text).ToUpper();
            mAgenteOrigenLCL1.Manejos = float.Parse(txtManejosAgenteOrigenLCL.Text);
            mAgenteOrigenLCL1.Hbl = float.Parse(txtHblAgenteOrigenLCL.Text);
            for (int i = 0; i < clbAgenteOrigenLCL.Items.Count; i++)
            {
                if (clbAgenteOrigenLCL.GetItemChecked(i))
                {
                    if (clbAgenteOrigenLCL.GetItemText(i) == "0")
                    {
                        mAgenteOrigenLCL1.alemania = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "1")
                    {
                        mAgenteOrigenLCL1.arabia_saudi = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "2")
                    {
                        mAgenteOrigenLCL1.argelia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "3")
                    {
                        mAgenteOrigenLCL1.argentina = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "4")
                    {
                        mAgenteOrigenLCL1.australia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "5")
                    {
                        mAgenteOrigenLCL1.austria = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "6")
                    {
                        mAgenteOrigenLCL1.bahamas = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "7")
                    {
                        mAgenteOrigenLCL1.bangladesh = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "8")
                    {
                        mAgenteOrigenLCL1.barbados = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "9")
                    {
                        mAgenteOrigenLCL1.belgica = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "10")
                    {
                        mAgenteOrigenLCL1.belice = 1;
                    }
                    else if (clbAgenteOrigen.GetItemText(i) == "11")
                    {
                        mAgenteOrigenLCL1.bolivia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "12")
                    {
                        mAgenteOrigenLCL1.brasil = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "13")
                    {
                        mAgenteOrigenLCL1.canada = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "14")
                    {
                        mAgenteOrigenLCL1.chile = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "15")
                    {
                        mAgenteOrigenLCL1.china = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "16")
                    {
                        mAgenteOrigenLCL1.colombia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "17")
                    {
                        mAgenteOrigenLCL1.crc = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "18")
                    {
                        mAgenteOrigenLCL1.croacia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "19")
                    {
                        mAgenteOrigenLCL1.cuba = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "20")
                    {
                        mAgenteOrigenLCL1.dinamarca = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "21")
                    {
                        mAgenteOrigenLCL1.dominica = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "22")
                    {
                        mAgenteOrigenLCL1.dubai = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "23")
                    {
                        mAgenteOrigen1.ecuador = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "24")
                    {
                        mAgenteOrigenLCL1.egipto = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "25")
                    {
                        mAgenteOrigenLCL1.eslovaquia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "26")
                    {
                        mAgenteOrigenLCL1.eslovenia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "27")
                    {
                        mAgenteOrigenLCL1.espana = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "28")
                    {
                        mAgenteOrigenLCL1.finlandia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "29")
                    {
                        mAgenteOrigenLCL1.flipinas = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "30")
                    {
                        mAgenteOrigenLCL1.francia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "31")
                    {
                        mAgenteOrigenLCL1.grecia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "32")
                    {
                        mAgenteOrigenLCL1.guatemala = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "33")
                    {
                        mAgenteOrigenLCL1.haiti = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "34")
                    {
                        mAgenteOrigenLCL1.holanda = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "35")
                    {
                        mAgenteOrigenLCL1.honduras = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "36")
                    {
                        mAgenteOrigenLCL1.hungria = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "37")
                    {
                        mAgenteOrigenLCL1.india = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "38")
                    {
                        mAgenteOrigenLCL1.indonesia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "39")
                    {
                        mAgenteOrigenLCL1.irlandia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "40")
                    {
                        mAgenteOrigenLCL1.islandia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "41")
                    {
                        mAgenteOrigenLCL1.israel = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "42")
                    {
                        mAgenteOrigenLCL1.italia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "43")
                    {
                        mAgenteOrigenLCL1.jamaica = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "44")
                    {
                        mAgenteOrigenLCL1.japon = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "45")
                    {
                        mAgenteOrigenLCL1.korea = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "46")
                    {
                        mAgenteOrigenLCL1.luxemburgo = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "47")
                    {
                        mAgenteOrigenLCL1.malasia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "48")
                    {
                        mAgenteOrigenLCL1.maldivas = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "49")
                    {
                        mAgenteOrigenLCL1.marruecos = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "50")
                    {
                        mAgenteOrigenLCL1.maxico = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "51")
                    {
                        mAgenteOrigenLCL1.monaco = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "52")
                    {
                        mAgenteOrigenLCL1.mongolia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "53")
                    {
                        mAgenteOrigenLCL1.nepal = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "54")
                    {
                        mAgenteOrigenLCL1.nicaragua = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "55")
                    {
                        mAgenteOrigenLCL1.noruega = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "56")
                    {
                        mAgenteOrigenLCL1.nueva_zelanda = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "57")
                    {
                        mAgenteOrigenLCL1.panama = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "58")
                    {
                        mAgenteOrigenLCL1.paraguay = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "59")
                    {
                        mAgenteOrigenLCL1.peru = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "60")
                    {
                        mAgenteOrigenLCL1.polonia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "61")
                    {
                        mAgenteOrigenLCL1.portugal = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "62")
                    {
                        mAgenteOrigenLCL1.qatar = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "63")
                    {
                        mAgenteOrigenLCL1.reino_unido = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "64")
                    {
                        mAgenteOrigenLCL1.republica_dominicana = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "65")
                    {
                        mAgenteOrigenLCL1.rusia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "66")
                    {
                        mAgenteOrigenLCL1.salvador = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "67")
                    {
                        mAgenteOrigenLCL1.singapur = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "68")
                    {
                        mAgenteOrigenLCL1.sudafrica = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "69")
                    {
                        mAgenteOrigenLCL1.suecia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "70")
                    {
                        mAgenteOrigenLCL1.suiza = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "71")
                    {
                        mAgenteOrigenLCL1.thailandia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "72")
                    {
                        mAgenteOrigenLCL1.taiwan = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "73")
                    {
                        mAgenteOrigenLCL1.tunez = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "74")
                    {
                        mAgenteOrigenLCL1.turquia = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "75")
                    {
                        mAgenteOrigenLCL1.ucrania = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "76")
                    {
                        mAgenteOrigenLCL1.uruguay = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "77")
                    {
                        mAgenteOrigenLCL1.usa = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "78")
                    {
                        mAgenteOrigenLCL1.venezuela = 1;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "79")
                    {
                        mAgenteOrigenLCL1.vietnam = 1;
                    }
                }
                else
                {
                    if (clbAgenteOrigenLCL.GetItemText(i) == "0")
                    {
                        mAgenteOrigenLCL1.alemania = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "1")
                    {
                        mAgenteOrigenLCL1.arabia_saudi = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "2")
                    {
                        mAgenteOrigenLCL1.argelia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "3")
                    {
                        mAgenteOrigenLCL1.argentina = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "4")
                    {
                        mAgenteOrigenLCL1.australia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "5")
                    {
                        mAgenteOrigenLCL1.austria = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "6")
                    {
                        mAgenteOrigenLCL1.bahamas = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "7")
                    {
                        mAgenteOrigenLCL1.bangladesh = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "8")
                    {
                        mAgenteOrigenLCL1.barbados = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "9")
                    {
                        mAgenteOrigenLCL1.belgica = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "10")
                    {
                        mAgenteOrigenLCL1.belice = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "11")
                    {
                        mAgenteOrigenLCL1.bolivia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "12")
                    {
                        mAgenteOrigenLCL1.brasil = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "13")
                    {
                        mAgenteOrigenLCL1.canada = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "14")
                    {
                        mAgenteOrigenLCL1.chile = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "15")
                    {
                        mAgenteOrigenLCL1.china = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "16")
                    {
                        mAgenteOrigenLCL1.colombia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "17")
                    {
                        mAgenteOrigenLCL1.crc = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "18")
                    {
                        mAgenteOrigenLCL1.croacia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "19")
                    {
                        mAgenteOrigenLCL1.cuba = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "20")
                    {
                        mAgenteOrigenLCL1.dinamarca = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "21")
                    {
                        mAgenteOrigenLCL1.dominica = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "22")
                    {
                        mAgenteOrigenLCL1.dubai = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "23")
                    {
                        mAgenteOrigenLCL1.ecuador = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "24")
                    {
                        mAgenteOrigenLCL1.egipto = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "25")
                    {
                        mAgenteOrigenLCL1.eslovaquia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "26")
                    {
                        mAgenteOrigenLCL1.eslovenia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "27")
                    {
                        mAgenteOrigenLCL1.espana = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "28")
                    {
                        mAgenteOrigenLCL1.finlandia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "29")
                    {
                        mAgenteOrigenLCL1.flipinas = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "30")
                    {
                        mAgenteOrigenLCL1.francia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "31")
                    {
                        mAgenteOrigenLCL1.grecia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "32")
                    {
                        mAgenteOrigenLCL1.guatemala = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "33")
                    {
                        mAgenteOrigenLCL1.haiti = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "34")
                    {
                        mAgenteOrigenLCL1.holanda = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "35")
                    {
                        mAgenteOrigenLCL1.honduras = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "36")
                    {
                        mAgenteOrigenLCL1.hungria = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "37")
                    {
                        mAgenteOrigenLCL1.india = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "38")
                    {
                        mAgenteOrigenLCL1.indonesia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "39")
                    {
                        mAgenteOrigenLCL1.irlandia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "40")
                    {
                        mAgenteOrigenLCL1.islandia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "41")
                    {
                        mAgenteOrigenLCL1.israel = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "42")
                    {
                        mAgenteOrigenLCL1.italia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "43")
                    {
                        mAgenteOrigenLCL1.jamaica = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "44")
                    {
                        mAgenteOrigenLCL1.japon = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "45")
                    {
                        mAgenteOrigenLCL1.korea = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "46")
                    {
                        mAgenteOrigenLCL1.luxemburgo = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "47")
                    {
                        mAgenteOrigenLCL1.malasia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "48")
                    {
                        mAgenteOrigenLCL1.maldivas = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "49")
                    {
                        mAgenteOrigenLCL1.marruecos = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "50")
                    {
                        mAgenteOrigenLCL1.maxico = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "51")
                    {
                        mAgenteOrigenLCL1.monaco = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "52")
                    {
                        mAgenteOrigenLCL1.mongolia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "53")
                    {
                        mAgenteOrigenLCL1.nepal = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "54")
                    {
                        mAgenteOrigenLCL1.nicaragua = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "55")
                    {
                        mAgenteOrigenLCL1.noruega = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "56")
                    {
                        mAgenteOrigenLCL1.nueva_zelanda = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "57")
                    {
                        mAgenteOrigenLCL1.panama = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "58")
                    {
                        mAgenteOrigenLCL1.paraguay = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "59")
                    {
                        mAgenteOrigenLCL1.peru = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "60")
                    {
                        mAgenteOrigenLCL1.polonia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "61")
                    {
                        mAgenteOrigenLCL1.portugal = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "62")
                    {
                        mAgenteOrigenLCL1.qatar = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "63")
                    {
                        mAgenteOrigenLCL1.reino_unido = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "64")
                    {
                        mAgenteOrigenLCL1.republica_dominicana = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "65")
                    {
                        mAgenteOrigenLCL1.rusia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "66")
                    {
                        mAgenteOrigenLCL1.salvador = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "67")
                    {
                        mAgenteOrigenLCL1.singapur = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "68")
                    {
                        mAgenteOrigenLCL1.sudafrica = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "69")
                    {
                        mAgenteOrigenLCL1.suecia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "70")
                    {
                        mAgenteOrigenLCL1.suiza = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "71")
                    {
                        mAgenteOrigenLCL1.thailandia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "72")
                    {
                        mAgenteOrigenLCL1.taiwan = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "73")
                    {
                        mAgenteOrigenLCL1.tunez = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "74")
                    {
                        mAgenteOrigenLCL1.turquia = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "75")
                    {
                        mAgenteOrigenLCL1.ucrania = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "76")
                    {
                        mAgenteOrigenLCL1.uruguay = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "77")
                    {
                        mAgenteOrigenLCL1.usa = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "78")
                    {
                        mAgenteOrigenLCL1.venezuela = 0;
                    }
                    else if (clbAgenteOrigenLCL.GetItemText(i) == "78")
                    {
                        mAgenteOrigenLCL1.vietnam = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosFleteInternacional()
        {
            mFleteInternacional1.Id = getIdFleteInternacionalIfExist();
            mFleteInternacional1.Proveedor = (txtFleteInternacional.Text).ToUpper();
            mFleteInternacional1.Thc = float.Parse(txtThcFleteInternacional.Text);
            mFleteInternacional1.Doc_fee = float.Parse(txtDocFeeFleteInternacional.Text);
            mFleteInternacional1.Security = float.Parse(txtSecurityFleteInternacional.Text);
            mFleteInternacional1.Impresion_bl = float.Parse(txtImpresionBLFleteInternacional.Text);
            mFleteInternacional1.Port_facility = float.Parse(txtPortFacilityFleteInternacional.Text);
            mFleteInternacional1.Canal_fee = float.Parse(txtCanalFeeFleteInternacional.Text);
            mFleteInternacional1.Vac = float.Parse(txtVacFleteInternacional.Text);
            mFleteInternacional1.Impdo = float.Parse(txtImpdoFleteInternacional.Text);
            mFleteInternacional1.Merchant = float.Parse(txtMerchantFleteInternacional.Text);
            for (int i = 0; i < clbPaisesFleteInternacional.Items.Count; i++)
            {
                if (clbPaisesFleteInternacional.GetItemChecked(i))
                {
                    if (clbPaisesFleteInternacional.GetItemText(i) == "0")
                    {
                        mFleteInternacional1.alemania = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "1")
                    {
                        mFleteInternacional1.arabia_saudi = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "2")
                    {
                        mFleteInternacional1.argelia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "3")
                    {
                        mFleteInternacional1.argentina = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "4")
                    {
                        mFleteInternacional1.australia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "5")
                    {
                        mFleteInternacional1.austria = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "6")
                    {
                        mFleteInternacional1.bahamas = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "7")
                    {
                        mFleteInternacional1.bangladesh = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "8")
                    {
                        mFleteInternacional1.barbados = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "9")
                    {
                        mFleteInternacional1.belgica = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "10")
                    {
                        mFleteInternacional1.belice = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "11")
                    {
                        mFleteInternacional1.bolivia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "12")
                    {
                        mFleteInternacional1.brasil = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "13")
                    {
                        mFleteInternacional1.canada = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "14")
                    {
                        mFleteInternacional1.chile = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "15")
                    {
                        mFleteInternacional1.china = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "16")
                    {
                        mFleteInternacional1.colombia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "17")
                    {
                        mFleteInternacional1.crc = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "18")
                    {
                        mFleteInternacional1.croacia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "19")
                    {
                        mFleteInternacional1.cuba = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "20")
                    {
                        mFleteInternacional1.dinamarca = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "21")
                    {
                        mFleteInternacional1.dominica = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "22")
                    {
                        mFleteInternacional1.dubai = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "23")
                    {
                        mFleteInternacional1.ecuador = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "24")
                    {
                        mFleteInternacional1.egipto = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "25")
                    {
                        mFleteInternacional1.eslovaquia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "26")
                    {
                        mFleteInternacional1.eslovenia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "27")
                    {
                        mFleteInternacional1.espana = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "28")
                    {
                        mFleteInternacional1.finlandia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "29")
                    {
                        mFleteInternacional1.flipinas = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "30")
                    {
                        mFleteInternacional1.francia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "31")
                    {
                        mFleteInternacional1.grecia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "32")
                    {
                        mFleteInternacional1.guatemala = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "33")
                    {
                        mFleteInternacional1.haiti = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "34")
                    {
                        mFleteInternacional1.holanda = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "35")
                    {
                        mFleteInternacional1.honduras = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "36")
                    {
                        mFleteInternacional1.hungria = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "37")
                    {
                        mFleteInternacional1.india = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "38")
                    {
                        mFleteInternacional1.indonesia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "39")
                    {
                        mFleteInternacional1.irlandia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "40")
                    {
                        mFleteInternacional1.islandia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "41")
                    {
                        mFleteInternacional1.israel = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "42")
                    {
                        mFleteInternacional1.italia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "43")
                    {
                        mFleteInternacional1.jamaica = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "44")
                    {
                        mFleteInternacional1.japon = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "45")
                    {
                        mFleteInternacional1.korea = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "46")
                    {
                        mFleteInternacional1.luxemburgo = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "47")
                    {
                        mFleteInternacional1.malasia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "48")
                    {
                        mFleteInternacional1.maldivas = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "49")
                    {
                        mFleteInternacional1.marruecos = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "50")
                    {
                        mFleteInternacional1.maxico = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "51")
                    {
                        mFleteInternacional1.monaco = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "52")
                    {
                        mFleteInternacional1.mongolia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "53")
                    {
                        mFleteInternacional1.nepal = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "54")
                    {
                        mFleteInternacional1.nicaragua = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "55")
                    {
                        mFleteInternacional1.noruega = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "56")
                    {
                        mFleteInternacional1.nueva_zelanda = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "57")
                    {
                        mFleteInternacional1.panama = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "58")
                    {
                        mFleteInternacional1.paraguay = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "59")
                    {
                        mFleteInternacional1.peru = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "60")
                    {
                        mFleteInternacional1.polonia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "61")
                    {
                        mFleteInternacional1.portugal = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "62")
                    {
                        mFleteInternacional1.qatar = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "63")
                    {
                        mFleteInternacional1.reino_unido = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "64")
                    {
                        mFleteInternacional1.republica_dominicana = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "65")
                    {
                        mFleteInternacional1.rusia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "66")
                    {
                        mFleteInternacional1.salvador = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "67")
                    {
                        mFleteInternacional1.singapur = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "68")
                    {
                        mFleteInternacional1.sudafrica = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "69")
                    {
                        mFleteInternacional1.suecia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "70")
                    {
                        mFleteInternacional1.suiza = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "71")
                    {
                        mFleteInternacional1.thailandia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "72")
                    {
                        mFleteInternacional1.taiwan = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "73")
                    {
                        mFleteInternacional1.tunez = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "74")
                    {
                        mFleteInternacional1.turquia = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "75")
                    {
                        mFleteInternacional1.ucrania = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "76")
                    {
                        mFleteInternacional1.uruguay = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "77")
                    {
                        mFleteInternacional1.usa = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "78")
                    {
                        mFleteInternacional1.venezuela = 1;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "79")
                    {
                        mFleteInternacional1.vietnam = 1;
                    }
                }
                else
                {
                    if (clbPaisesFleteInternacional.GetItemText(i) == "0")
                    {
                        mFleteInternacional1.alemania = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "1")
                    {
                        mFleteInternacional1.arabia_saudi = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "2")
                    {
                        mFleteInternacional1.argelia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "3")
                    {
                        mFleteInternacional1.argentina = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "4")
                    {
                        mFleteInternacional1.australia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "5")
                    {
                        mFleteInternacional1.austria = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "6")
                    {
                        mFleteInternacional1.bahamas = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "7")
                    {
                        mFleteInternacional1.bangladesh = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "8")
                    {
                        mFleteInternacional1.barbados = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "9")
                    {
                        mFleteInternacional1.belgica = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "10")
                    {
                        mFleteInternacional1.belice = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "11")
                    {
                        mFleteInternacional1.bolivia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "12")
                    {
                        mFleteInternacional1.brasil = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "13")
                    {
                        mFleteInternacional1.canada = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "14")
                    {
                        mFleteInternacional1.chile = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "15")
                    {
                        mFleteInternacional1.china = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "16")
                    {
                        mFleteInternacional1.colombia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "17")
                    {
                        mFleteInternacional1.crc = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "18")
                    {
                        mFleteInternacional1.croacia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "19")
                    {
                        mFleteInternacional1.cuba = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "20")
                    {
                        mFleteInternacional1.dinamarca = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "21")
                    {
                        mFleteInternacional1.dominica = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "22")
                    {
                        mFleteInternacional1.dubai = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "23")
                    {
                        mFleteInternacional1.ecuador = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "24")
                    {
                        mFleteInternacional1.egipto = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "25")
                    {
                        mFleteInternacional1.eslovaquia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "26")
                    {
                        mFleteInternacional1.eslovenia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "27")
                    {
                        mFleteInternacional1.espana = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "28")
                    {
                        mFleteInternacional1.finlandia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "29")
                    {
                        mFleteInternacional1.flipinas = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "30")
                    {
                        mFleteInternacional1.francia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "31")
                    {
                        mFleteInternacional1.grecia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "32")
                    {
                        mFleteInternacional1.guatemala = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "33")
                    {
                        mFleteInternacional1.haiti = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "34")
                    {
                        mFleteInternacional1.holanda = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "35")
                    {
                        mFleteInternacional1.honduras = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "36")
                    {
                        mFleteInternacional1.hungria = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "37")
                    {
                        mFleteInternacional1.india = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "38")
                    {
                        mFleteInternacional1.indonesia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "39")
                    {
                        mFleteInternacional1.irlandia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "40")
                    {
                        mFleteInternacional1.islandia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "41")
                    {
                        mFleteInternacional1.israel = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "42")
                    {
                        mFleteInternacional1.italia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "43")
                    {
                        mFleteInternacional1.jamaica = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "44")
                    {
                        mFleteInternacional1.japon = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "45")
                    {
                        mFleteInternacional1.korea = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "46")
                    {
                        mFleteInternacional1.luxemburgo = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "47")
                    {
                        mFleteInternacional1.malasia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "48")
                    {
                        mFleteInternacional1.maldivas = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "49")
                    {
                        mFleteInternacional1.marruecos = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "50")
                    {
                        mFleteInternacional1.maxico = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "51")
                    {
                        mFleteInternacional1.monaco = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "52")
                    {
                        mFleteInternacional1.mongolia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "53")
                    {
                        mFleteInternacional1.nepal = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "54")
                    {
                        mFleteInternacional1.nicaragua = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "55")
                    {
                        mFleteInternacional1.noruega = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "56")
                    {
                        mFleteInternacional1.nueva_zelanda = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "57")
                    {
                        mFleteInternacional1.panama = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "58")
                    {
                        mFleteInternacional1.paraguay = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "59")
                    {
                        mFleteInternacional1.peru = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "60")
                    {
                        mFleteInternacional1.polonia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "61")
                    {
                        mFleteInternacional1.portugal = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "62")
                    {
                        mFleteInternacional1.qatar = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "63")
                    {
                        mFleteInternacional1.reino_unido = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "64")
                    {
                        mFleteInternacional1.republica_dominicana = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "65")
                    {
                        mFleteInternacional1.rusia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "66")
                    {
                        mFleteInternacional1.salvador = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "67")
                    {
                        mFleteInternacional1.singapur = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "68")
                    {
                        mFleteInternacional1.sudafrica = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "69")
                    {
                        mFleteInternacional1.suecia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "70")
                    {
                        mFleteInternacional1.suiza = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "71")
                    {
                        mFleteInternacional1.thailandia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "72")
                    {
                        mFleteInternacional1.taiwan = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "73")
                    {
                        mFleteInternacional1.tunez = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "74")
                    {
                        mFleteInternacional1.turquia = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "75")
                    {
                        mFleteInternacional1.ucrania = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "76")
                    {
                        mFleteInternacional1.uruguay = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "77")
                    {
                        mFleteInternacional1.usa = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "78")
                    {
                        mFleteInternacional1.venezuela = 0;
                    }
                    else if (clbPaisesFleteInternacional.GetItemText(i) == "78")
                    {
                        mFleteInternacional1.vietnam = 0;
                    }
                }
            }
            for (int i = 0; i < clbViasFleteInternacional.Items.Count; i++)
            {
                if (clbViasFleteInternacional.GetItemChecked(i))
                {
                    if (clbViasFleteInternacional.GetItemText(i) == "0")
                    {
                        mFleteInternacional1.rodman = 1;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "1")
                    {
                        mFleteInternacional1.cristobal = 1;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "2")
                    {
                        mFleteInternacional1.manzanillo = 1;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "3")
                    {
                        mFleteInternacional1.balboa = 1;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "4")
                    {
                        mFleteInternacional1.moin = 1;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "5")
                    {
                        mFleteInternacional1.caldera = 1;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "6")
                    {
                        mFleteInternacional1.no_aplica = 1;
                    }
                }
                else
                {
                    if (clbViasFleteInternacional.GetItemText(i) == "0")
                    {
                        mFleteInternacional1.rodman = 0;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "1")
                    {
                        mFleteInternacional1.cristobal = 0;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "2")
                    {
                        mFleteInternacional1.manzanillo = 0;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "3")
                    {
                        mFleteInternacional1.balboa = 0;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "4")
                    {
                        mFleteInternacional1.moin = 0;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "5")
                    {
                        mFleteInternacional1.caldera = 0;
                    }
                    else if (clbViasFleteInternacional.GetItemText(i) == "6")
                    {
                        mFleteInternacional1.no_aplica = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosFleteInternacionalLCL()
        {
            mFleteInternacionalLCL1.Id = getIdFleteInternacionalLCLIfExist();
            mFleteInternacionalLCL1.Proveedor = (txtFleteInternacionalLCL.Text).ToUpper();
            mFleteInternacionalLCL1.Thc_d_cbm = float.Parse(txtThcDCBMFleteInternacionalLCL.Text);
            mFleteInternacionalLCL1.Thc_d_minimo = float.Parse(txtThcDMinimoFleteInternacionalLCL.Text);
            mFleteInternacionalLCL1.Vgm_minimo = float.Parse(txtVgmMinimoFleteInternacionalLCL.Text);
            mFleteInternacionalLCL1.Bunker_cbm = float.Parse(txtBunkerCBMFleteInternacionalLCL.Text);
            mFleteInternacionalLCL1.Bunker_minimo = float.Parse(txtBunkerMinimoFleteInternacionalLCL.Text);
            mFleteInternacionalLCL1.Sed_minimo = float.Parse(txtSedMinimoFleteInternacionalLCL.Text);
            mFleteInternacionalLCL1.Tica_minimo = float.Parse(txtTicaMinimoFleteInternacionalLCL.Text);
            mFleteInternacionalLCL1.Forwarding_minimo = float.Parse(txtForwardingMinimoFleteInternacionalLCL.Text);
            mFleteInternacionalLCL1.Manejos_minimo = float.Parse(txtManejosMinimoFleteInternacionalLCL.Text);
            mFleteInternacionalLCL1.Carga_peligrosa_minimo = float.Parse(txtCargaPeligrosaMinimoFleteInternacional.Text);
            for (int i = 0; i < clbPaisesFleteInternacionalLCL.Items.Count; i++)
            {
                if (clbPaisesFleteInternacionalLCL.GetItemChecked(i))
                {
                    if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "0")
                    {
                        mFleteInternacionalLCL1.alemania = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "1")
                    {
                        mFleteInternacionalLCL1.arabia_saudi = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "2")
                    {
                        mFleteInternacionalLCL1.argelia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "3")
                    {
                        mFleteInternacionalLCL1.argentina = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "4")
                    {
                        mFleteInternacionalLCL1.australia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "5")
                    {
                        mFleteInternacionalLCL1.austria = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "6")
                    {
                        mFleteInternacionalLCL1.bahamas = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "7")
                    {
                        mFleteInternacionalLCL1.bangladesh = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "8")
                    {
                        mFleteInternacionalLCL1.barbados = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "9")
                    {
                        mFleteInternacionalLCL1.belgica = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "10")
                    {
                        mFleteInternacionalLCL1.belice = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "11")
                    {
                        mFleteInternacionalLCL1.bolivia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "12")
                    {
                        mFleteInternacionalLCL1.brasil = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "13")
                    {
                        mFleteInternacionalLCL1.canada = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "14")
                    {
                        mFleteInternacionalLCL1.chile = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "15")
                    {
                        mFleteInternacionalLCL1.china = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "16")
                    {
                        mFleteInternacionalLCL1.colombia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "17")
                    {
                        mFleteInternacionalLCL1.crc = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "18")
                    {
                        mFleteInternacionalLCL1.croacia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "19")
                    {
                        mFleteInternacionalLCL1.cuba = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "20")
                    {
                        mFleteInternacionalLCL1.dinamarca = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "21")
                    {
                        mFleteInternacionalLCL1.dominica = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "22")
                    {
                        mFleteInternacionalLCL1.dubai = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "23")
                    {
                        mFleteInternacionalLCL1.ecuador = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "24")
                    {
                        mFleteInternacionalLCL1.egipto = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "25")
                    {
                        mFleteInternacionalLCL1.eslovaquia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "26")
                    {
                        mFleteInternacionalLCL1.eslovenia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "27")
                    {
                        mFleteInternacionalLCL1.espana = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "28")
                    {
                        mFleteInternacionalLCL1.finlandia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "29")
                    {
                        mFleteInternacionalLCL1.flipinas = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "30")
                    {
                        mFleteInternacionalLCL1.francia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "31")
                    {
                        mFleteInternacionalLCL1.grecia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "32")
                    {
                        mFleteInternacionalLCL1.guatemala = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "33")
                    {
                        mFleteInternacionalLCL1.haiti = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "34")
                    {
                        mFleteInternacionalLCL1.holanda = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "35")
                    {
                        mFleteInternacionalLCL1.honduras = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "36")
                    {
                        mFleteInternacionalLCL1.hungria = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "37")
                    {
                        mFleteInternacionalLCL1.india = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "38")
                    {
                        mFleteInternacionalLCL1.indonesia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "39")
                    {
                        mFleteInternacionalLCL1.irlandia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "40")
                    {
                        mFleteInternacionalLCL1.islandia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "41")
                    {
                        mFleteInternacionalLCL1.israel = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "42")
                    {
                        mFleteInternacionalLCL1.italia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "43")
                    {
                        mFleteInternacionalLCL1.jamaica = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "44")
                    {
                        mFleteInternacionalLCL1.japon = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "45")
                    {
                        mFleteInternacionalLCL1.korea = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "46")
                    {
                        mFleteInternacionalLCL1.luxemburgo = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "47")
                    {
                        mFleteInternacionalLCL1.malasia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "48")
                    {
                        mFleteInternacionalLCL1.maldivas = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "49")
                    {
                        mFleteInternacionalLCL1.marruecos = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "50")
                    {
                        mFleteInternacionalLCL1.maxico = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "51")
                    {
                        mFleteInternacionalLCL1.monaco = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "52")
                    {
                        mFleteInternacionalLCL1.mongolia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "53")
                    {
                        mFleteInternacionalLCL1.nepal = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "54")
                    {
                        mFleteInternacionalLCL1.nicaragua = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "55")
                    {
                        mFleteInternacionalLCL1.noruega = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "56")
                    {
                        mFleteInternacionalLCL1.nueva_zelanda = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "57")
                    {
                        mFleteInternacionalLCL1.panama = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "58")
                    {
                        mFleteInternacionalLCL1.paraguay = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "59")
                    {
                        mFleteInternacionalLCL1.peru = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "60")
                    {
                        mFleteInternacionalLCL1.polonia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "61")
                    {
                        mFleteInternacionalLCL1.portugal = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "62")
                    {
                        mFleteInternacionalLCL1.qatar = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "63")
                    {
                        mFleteInternacionalLCL1.reino_unido = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "64")
                    {
                        mFleteInternacionalLCL1.republica_dominicana = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "65")
                    {
                        mFleteInternacionalLCL1.rusia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "66")
                    {
                        mFleteInternacionalLCL1.salvador = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "67")
                    {
                        mFleteInternacionalLCL1.singapur = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "68")
                    {
                        mFleteInternacionalLCL1.sudafrica = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "69")
                    {
                        mFleteInternacionalLCL1.suecia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "70")
                    {
                        mFleteInternacionalLCL1.suiza = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "71")
                    {
                        mFleteInternacionalLCL1.thailandia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "72")
                    {
                        mFleteInternacionalLCL1.taiwan = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "73")
                    {
                        mFleteInternacionalLCL1.tunez = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "74")
                    {
                        mFleteInternacionalLCL1.turquia = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "75")
                    {
                        mFleteInternacionalLCL1.ucrania = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "76")
                    {
                        mFleteInternacionalLCL1.uruguay = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "77")
                    {
                        mFleteInternacionalLCL1.usa = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "78")
                    {
                        mFleteInternacionalLCL1.venezuela = 1;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "79")
                    {
                        mFleteInternacionalLCL1.vietnam = 1;
                    }
                }
                else
                {
                    if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "0")
                    {
                        mFleteInternacionalLCL1.alemania = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "1")
                    {
                        mFleteInternacionalLCL1.arabia_saudi = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "2")
                    {
                        mFleteInternacionalLCL1.argelia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "3")
                    {
                        mFleteInternacionalLCL1.argentina = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "4")
                    {
                        mFleteInternacionalLCL1.australia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "5")
                    {
                        mFleteInternacionalLCL1.austria = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "6")
                    {
                        mFleteInternacionalLCL1.bahamas = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "7")
                    {
                        mFleteInternacionalLCL1.bangladesh = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "8")
                    {
                        mFleteInternacionalLCL1.barbados = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "9")
                    {
                        mFleteInternacionalLCL1.belgica = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "10")
                    {
                        mFleteInternacionalLCL1.belice = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "11")
                    {
                        mFleteInternacionalLCL1.bolivia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "12")
                    {
                        mFleteInternacionalLCL1.brasil = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "13")
                    {
                        mFleteInternacionalLCL1.canada = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "14")
                    {
                        mFleteInternacionalLCL1.chile = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "15")
                    {
                        mFleteInternacionalLCL1.china = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "16")
                    {
                        mFleteInternacionalLCL1.colombia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "17")
                    {
                        mFleteInternacionalLCL1.crc = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "18")
                    {
                        mFleteInternacionalLCL1.croacia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "19")
                    {
                        mFleteInternacionalLCL1.cuba = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "20")
                    {
                        mFleteInternacionalLCL1.dinamarca = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "21")
                    {
                        mFleteInternacionalLCL1.dominica = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "22")
                    {
                        mFleteInternacionalLCL1.dubai = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "23")
                    {
                        mFleteInternacionalLCL1.ecuador = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "24")
                    {
                        mFleteInternacionalLCL1.egipto = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "25")
                    {
                        mFleteInternacionalLCL1.eslovaquia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "26")
                    {
                        mFleteInternacionalLCL1.eslovenia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "27")
                    {
                        mFleteInternacionalLCL1.espana = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "28")
                    {
                        mFleteInternacionalLCL1.finlandia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "29")
                    {
                        mFleteInternacionalLCL1.flipinas = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "30")
                    {
                        mFleteInternacionalLCL1.francia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "31")
                    {
                        mFleteInternacionalLCL1.grecia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "32")
                    {
                        mFleteInternacionalLCL1.guatemala = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "33")
                    {
                        mFleteInternacionalLCL1.haiti = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "34")
                    {
                        mFleteInternacionalLCL1.holanda = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "35")
                    {
                        mFleteInternacionalLCL1.honduras = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "36")
                    {
                        mFleteInternacionalLCL1.hungria = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "37")
                    {
                        mFleteInternacionalLCL1.india = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "38")
                    {
                        mFleteInternacionalLCL1.indonesia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "39")
                    {
                        mFleteInternacionalLCL1.irlandia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "40")
                    {
                        mFleteInternacionalLCL1.islandia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "41")
                    {
                        mFleteInternacionalLCL1.israel = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "42")
                    {
                        mFleteInternacionalLCL1.italia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "43")
                    {
                        mFleteInternacionalLCL1.jamaica = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "44")
                    {
                        mFleteInternacionalLCL1.japon = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "45")
                    {
                        mFleteInternacionalLCL1.korea = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "46")
                    {
                        mFleteInternacionalLCL1.luxemburgo = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "47")
                    {
                        mFleteInternacionalLCL1.malasia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "48")
                    {
                        mFleteInternacionalLCL1.maldivas = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "49")
                    {
                        mFleteInternacionalLCL1.marruecos = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "50")
                    {
                        mFleteInternacionalLCL1.maxico = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "51")
                    {
                        mFleteInternacionalLCL1.monaco = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "52")
                    {
                        mFleteInternacionalLCL1.mongolia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "53")
                    {
                        mFleteInternacionalLCL1.nepal = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "54")
                    {
                        mFleteInternacionalLCL1.nicaragua = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "55")
                    {
                        mFleteInternacionalLCL1.noruega = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "56")
                    {
                        mFleteInternacionalLCL1.nueva_zelanda = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "57")
                    {
                        mFleteInternacionalLCL1.panama = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "58")
                    {
                        mFleteInternacionalLCL1.paraguay = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "59")
                    {
                        mFleteInternacionalLCL1.peru = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "60")
                    {
                        mFleteInternacionalLCL1.polonia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "61")
                    {
                        mFleteInternacionalLCL1.portugal = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "62")
                    {
                        mFleteInternacionalLCL1.qatar = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "63")
                    {
                        mFleteInternacionalLCL1.reino_unido = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "64")
                    {
                        mFleteInternacionalLCL1.republica_dominicana = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "65")
                    {
                        mFleteInternacionalLCL1.rusia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "66")
                    {
                        mFleteInternacionalLCL1.salvador = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "67")
                    {
                        mFleteInternacionalLCL1.singapur = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "68")
                    {
                        mFleteInternacionalLCL1.sudafrica = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "69")
                    {
                        mFleteInternacionalLCL1.suecia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "70")
                    {
                        mFleteInternacionalLCL1.suiza = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "71")
                    {
                        mFleteInternacionalLCL1.thailandia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "72")
                    {
                        mFleteInternacionalLCL1.taiwan = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "73")
                    {
                        mFleteInternacionalLCL1.tunez = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "74")
                    {
                        mFleteInternacionalLCL1.turquia = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "75")
                    {
                        mFleteInternacionalLCL1.ucrania = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "76")
                    {
                        mFleteInternacionalLCL1.uruguay = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "77")
                    {
                        mFleteInternacionalLCL1.usa = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "78")
                    {
                        mFleteInternacionalLCL1.venezuela = 0;
                    }
                    else if (clbPaisesFleteInternacionalLCL.GetItemText(i) == "78")
                    {
                        mFleteInternacionalLCL1.vietnam = 0;
                    }
                }
            }
            for (int i = 0; i < clbViasFleteInternacionalLCL.Items.Count; i++)
            {
                if (clbViasFleteInternacionalLCL.GetItemChecked(i))
                {
                    if (clbViasFleteInternacionalLCL.GetItemText(i) == "0")
                    {
                        mFleteInternacionalLCL1.rodman = 1;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "1")
                    {
                        mFleteInternacionalLCL1.cristobal = 1;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "2")
                    {
                        mFleteInternacionalLCL1.manzanillo = 1;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "3")
                    {
                        mFleteInternacionalLCL1.balboa = 1;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "4")
                    {
                        mFleteInternacionalLCL1.moin = 1;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "5")
                    {
                        mFleteInternacionalLCL1.caldera = 1;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "6")
                    {
                        mFleteInternacionalLCL1.no_aplica = 1;
                    }
                }
                else
                {
                    if (clbViasFleteInternacionalLCL.GetItemText(i) == "0")
                    {
                        mFleteInternacionalLCL1.rodman = 0;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "1")
                    {
                        mFleteInternacionalLCL1.cristobal = 0;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "2")
                    {
                        mFleteInternacionalLCL1.manzanillo = 0;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "3")
                    {
                        mFleteInternacionalLCL1.balboa = 0;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "4")
                    {
                        mFleteInternacionalLCL1.moin = 0;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "5")
                    {
                        mFleteInternacionalLCL1.caldera = 0;
                    }
                    else if (clbViasFleteInternacionalLCL.GetItemText(i) == "6")
                    {
                        mFleteInternacionalLCL1.no_aplica = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosCargosDestino()
        {
            mCargosDestino1.Id = getIdCargosDestinoIfExist();
            mCargosDestino1.Proveedor = (txtCargosDestino.Text).ToUpper();
            mCargosDestino1.Flete = float.Parse(txtFleteCargosDestino.Text);
            for (int i = 0; i < clbCargosDestino.Items.Count; i++)
            {
                if (clbCargosDestino.GetItemChecked(i))
                {
                    if (clbCargosDestino.GetItemText(i) == "0")
                    {
                        mCargosDestino1.alemania = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "1")
                    {
                        mCargosDestino1.arabia_saudi = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "2")
                    {
                        mCargosDestino1.argelia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "3")
                    {
                        mCargosDestino1.argentina = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "4")
                    {
                        mCargosDestino1.australia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "5")
                    {
                        mCargosDestino1.austria = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "6")
                    {
                        mCargosDestino1.bahamas = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "7")
                    {
                        mCargosDestino1.bangladesh = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "8")
                    {
                        mCargosDestino1.barbados = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "9")
                    {
                        mCargosDestino1.belgica = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "10")
                    {
                        mCargosDestino1.belice = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "11")
                    {
                        mCargosDestino1.bolivia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "12")
                    {
                        mCargosDestino1.brasil = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "13")
                    {
                        mCargosDestino1.canada = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "14")
                    {
                        mCargosDestino1.chile = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "15")
                    {
                        mCargosDestino1.china = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "16")
                    {
                        mCargosDestino1.colombia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "17")
                    {
                        mCargosDestino1.crc = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "18")
                    {
                        mCargosDestino1.croacia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "19")
                    {
                        mCargosDestino1.cuba = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "20")
                    {
                        mCargosDestino1.dinamarca = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "21")
                    {
                        mCargosDestino1.dominica = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "22")
                    {
                        mCargosDestino1.dubai = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "23")
                    {
                        mCargosDestino1.ecuador = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "24")
                    {
                        mCargosDestino1.egipto = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "25")
                    {
                        mCargosDestino1.eslovaquia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "26")
                    {
                        mCargosDestino1.eslovenia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "27")
                    {
                        mCargosDestino1.espana = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "28")
                    {
                        mCargosDestino1.finlandia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "29")
                    {
                        mCargosDestino1.flipinas = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "30")
                    {
                        mCargosDestino1.francia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "31")
                    {
                        mCargosDestino1.grecia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "32")
                    {
                        mCargosDestino1.guatemala = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "33")
                    {
                        mCargosDestino1.haiti = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "34")
                    {
                        mCargosDestino1.holanda = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "35")
                    {
                        mCargosDestino1.honduras = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "36")
                    {
                        mCargosDestino1.hungria = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "37")
                    {
                        mCargosDestino1.india = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "38")
                    {
                        mCargosDestino1.indonesia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "39")
                    {
                        mCargosDestino1.irlandia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "40")
                    {
                        mCargosDestino1.islandia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "41")
                    {
                        mCargosDestino1.israel = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "42")
                    {
                        mCargosDestino1.italia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "43")
                    {
                        mCargosDestino1.jamaica = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "44")
                    {
                        mCargosDestino1.japon = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "45")
                    {
                        mCargosDestino1.korea = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "46")
                    {
                        mCargosDestino1.luxemburgo = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "47")
                    {
                        mCargosDestino1.malasia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "48")
                    {
                        mCargosDestino1.maldivas = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "49")
                    {
                        mCargosDestino1.marruecos = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "50")
                    {
                        mCargosDestino1.maxico = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "51")
                    {
                        mCargosDestino1.monaco = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "52")
                    {
                        mCargosDestino1.mongolia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "53")
                    {
                        mCargosDestino1.nepal = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "54")
                    {
                        mCargosDestino1.nicaragua = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "55")
                    {
                        mCargosDestino1.noruega = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "56")
                    {
                        mCargosDestino1.nueva_zelanda = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "57")
                    {
                        mCargosDestino1.panama = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "58")
                    {
                        mCargosDestino1.paraguay = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "59")
                    {
                        mCargosDestino1.peru = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "60")
                    {
                        mCargosDestino1.polonia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "61")
                    {
                        mCargosDestino1.portugal = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "62")
                    {
                        mCargosDestino1.qatar = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "63")
                    {
                        mCargosDestino1.reino_unido = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "64")
                    {
                        mCargosDestino1.republica_dominicana = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "65")
                    {
                        mCargosDestino1.rusia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "66")
                    {
                        mCargosDestino1.salvador = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "67")
                    {
                        mCargosDestino1.singapur = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "68")
                    {
                        mCargosDestino1.sudafrica = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "69")
                    {
                        mCargosDestino1.suecia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "70")
                    {
                        mCargosDestino1.suiza = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "71")
                    {
                        mCargosDestino1.thailandia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "72")
                    {
                        mCargosDestino1.taiwan = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "73")
                    {
                        mCargosDestino1.tunez = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "74")
                    {
                        mCargosDestino1.turquia = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "75")
                    {
                        mCargosDestino1.ucrania = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "76")
                    {
                        mCargosDestino1.uruguay = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "77")
                    {
                        mCargosDestino1.usa = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "78")
                    {
                        mCargosDestino1.venezuela = 1;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "79")
                    {
                        mCargosDestino1.vietnam = 1;
                    }
                }
                else
                {
                    if (clbCargosDestino.GetItemText(i) == "0")
                    {
                        mCargosDestino1.alemania = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "1")
                    {
                        mCargosDestino1.arabia_saudi = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "2")
                    {
                        mCargosDestino1.argelia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "3")
                    {
                        mCargosDestino1.argentina = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "4")
                    {
                        mCargosDestino1.australia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "5")
                    {
                        mCargosDestino1.austria = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "6")
                    {
                        mCargosDestino1.bahamas = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "7")
                    {
                        mCargosDestino1.bangladesh = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "8")
                    {
                        mCargosDestino1.barbados = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "9")
                    {
                        mCargosDestino1.belgica = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "10")
                    {
                        mCargosDestino1.belice = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "11")
                    {
                        mCargosDestino1.bolivia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "12")
                    {
                        mCargosDestino1.brasil = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "13")
                    {
                        mCargosDestino1.canada = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "14")
                    {
                        mCargosDestino1.chile = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "15")
                    {
                        mCargosDestino1.china = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "16")
                    {
                        mCargosDestino1.colombia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "17")
                    {
                        mCargosDestino1.crc = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "18")
                    {
                        mCargosDestino1.croacia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "19")
                    {
                        mCargosDestino1.cuba = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "20")
                    {
                        mCargosDestino1.dinamarca = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "21")
                    {
                        mCargosDestino1.dominica = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "22")
                    {
                        mCargosDestino1.dubai = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "23")
                    {
                        mCargosDestino1.ecuador = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "24")
                    {
                        mCargosDestino1.egipto = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "25")
                    {
                        mCargosDestino1.eslovaquia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "26")
                    {
                        mCargosDestino1.eslovenia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "27")
                    {
                        mCargosDestino1.espana = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "28")
                    {
                        mCargosDestino1.finlandia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "29")
                    {
                        mCargosDestino1.flipinas = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "30")
                    {
                        mCargosDestino1.francia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "31")
                    {
                        mCargosDestino1.grecia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "32")
                    {
                        mCargosDestino1.guatemala = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "33")
                    {
                        mCargosDestino1.haiti = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "34")
                    {
                        mCargosDestino1.holanda = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "35")
                    {
                        mCargosDestino1.honduras = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "36")
                    {
                        mCargosDestino1.hungria = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "37")
                    {
                        mCargosDestino1.india = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "38")
                    {
                        mCargosDestino1.indonesia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "39")
                    {
                        mCargosDestino1.irlandia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "40")
                    {
                        mCargosDestino1.islandia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "41")
                    {
                        mCargosDestino1.israel = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "42")
                    {
                        mCargosDestino1.italia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "43")
                    {
                        mCargosDestino1.jamaica = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "44")
                    {
                        mCargosDestino1.japon = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "45")
                    {
                        mCargosDestino1.korea = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "46")
                    {
                        mCargosDestino1.luxemburgo = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "47")
                    {
                        mCargosDestino1.malasia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "48")
                    {
                        mCargosDestino1.maldivas = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "49")
                    {
                        mCargosDestino1.marruecos = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "50")
                    {
                        mCargosDestino1.maxico = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "51")
                    {
                        mCargosDestino1.monaco = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "52")
                    {
                        mCargosDestino1.mongolia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "53")
                    {
                        mCargosDestino1.nepal = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "54")
                    {
                        mCargosDestino1.nicaragua = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "55")
                    {
                        mCargosDestino1.noruega = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "56")
                    {
                        mCargosDestino1.nueva_zelanda = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "57")
                    {
                        mCargosDestino1.panama = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "58")
                    {
                        mCargosDestino1.paraguay = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "59")
                    {
                        mCargosDestino1.peru = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "60")
                    {
                        mCargosDestino1.polonia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "61")
                    {
                        mCargosDestino1.portugal = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "62")
                    {
                        mCargosDestino1.qatar = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "63")
                    {
                        mCargosDestino1.reino_unido = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "64")
                    {
                        mCargosDestino1.republica_dominicana = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "65")
                    {
                        mCargosDestino1.rusia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "66")
                    {
                        mCargosDestino1.salvador = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "67")
                    {
                        mCargosDestino1.singapur = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "68")
                    {
                        mCargosDestino1.sudafrica = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "69")
                    {
                        mCargosDestino1.suecia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "70")
                    {
                        mCargosDestino1.suiza = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "71")
                    {
                        mCargosDestino1.thailandia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "72")
                    {
                        mCargosDestino1.taiwan = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "73")
                    {
                        mCargosDestino1.tunez = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "74")
                    {
                        mCargosDestino1.turquia = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "75")
                    {
                        mCargosDestino1.ucrania = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "76")
                    {
                        mCargosDestino1.uruguay = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "77")
                    {
                        mCargosDestino1.usa = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "78")
                    {
                        mCargosDestino1.venezuela = 0;
                    }
                    else if (clbCargosDestino.GetItemText(i) == "78")
                    {
                        mCargosDestino1.vietnam = 0;
                    }
                }
            }
            for (int i = 0; i < clbViasDestino.Items.Count; i++)
            {
                if (clbViasDestino.GetItemChecked(i))
                {
                    if (clbViasDestino.GetItemText(i) == "0")
                    {
                        mCargosDestino1.rodman = 1;
                    }
                    else if (clbViasDestino.GetItemText(i) == "1")
                    {
                        mCargosDestino1.cristobal = 1;
                    }
                    else if (clbViasDestino.GetItemText(i) == "2")
                    {
                        mCargosDestino1.manzanillo = 1;
                    }
                    else if (clbViasDestino.GetItemText(i) == "3")
                    {
                        mCargosDestino1.balboa = 1;
                    }
                    else if (clbViasDestino.GetItemText(i) == "4")
                    {
                        mCargosDestino1.moin = 1;
                    }
                    else if (clbViasDestino.GetItemText(i) == "5")
                    {
                        mCargosDestino1.caldera = 1;
                    }
                    else if (clbViasDestino.GetItemText(i) == "6")
                    {
                        mCargosDestino1.no_aplica = 1;
                    }
                }
                else
                {
                    if (clbViasDestino.GetItemText(i) == "0")
                    {
                        mCargosDestino1.rodman = 0;
                    }
                    else if (clbViasDestino.GetItemText(i) == "1")
                    {
                        mCargosDestino1.cristobal = 0;
                    }
                    else if (clbViasDestino.GetItemText(i) == "2")
                    {
                        mCargosDestino1.manzanillo = 0;
                    }
                    else if (clbViasDestino.GetItemText(i) == "3")
                    {
                        mCargosDestino1.balboa = 0;
                    }
                    else if (clbViasDestino.GetItemText(i) == "4")
                    {
                        mCargosDestino1.moin = 0;
                    }
                    else if (clbViasDestino.GetItemText(i) == "5")
                    {
                        mCargosDestino1.caldera = 0;
                    }
                    else if (clbViasDestino.GetItemText(i) == "6")
                    {
                        mCargosDestino1.no_aplica = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosCargosDestinoLCL()
        {
            mCargosDestinoLCL1.Id = getIdCargosDestinoLCLIfExist();
            mCargosDestinoLCL1.Proveedor = (txtCargosDestinoLCL.Text).ToUpper();
            mCargosDestinoLCL1.Flete = float.Parse(txtFleteCargosDestinoLCL.Text);
            for (int i = 0; i < clbCargosDestinoLCL.Items.Count; i++)
            {
                if (clbCargosDestinoLCL.GetItemChecked(i))
                {
                    if (clbCargosDestinoLCL.GetItemText(i) == "0")
                    {
                        mCargosDestinoLCL1.alemania = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "1")
                    {
                        mCargosDestinoLCL1.arabia_saudi = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "2")
                    {
                        mCargosDestinoLCL1.argelia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "3")
                    {
                        mCargosDestinoLCL1.argentina = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "4")
                    {
                        mCargosDestinoLCL1.australia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "5")
                    {
                        mCargosDestinoLCL1.austria = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "6")
                    {
                        mCargosDestinoLCL1.bahamas = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "7")
                    {
                        mCargosDestinoLCL1.bangladesh = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "8")
                    {
                        mCargosDestinoLCL1.barbados = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "9")
                    {
                        mCargosDestinoLCL1.belgica = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "10")
                    {
                        mCargosDestinoLCL1.belice = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "11")
                    {
                        mCargosDestinoLCL1.bolivia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "12")
                    {
                        mCargosDestinoLCL1.brasil = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "13")
                    {
                        mCargosDestinoLCL1.canada = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "14")
                    {
                        mCargosDestinoLCL1.chile = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "15")
                    {
                        mCargosDestinoLCL1.china = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "16")
                    {
                        mCargosDestinoLCL1.colombia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "17")
                    {
                        mCargosDestinoLCL1.crc = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "18")
                    {
                        mCargosDestinoLCL1.croacia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "19")
                    {
                        mCargosDestinoLCL1.cuba = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "20")
                    {
                        mCargosDestinoLCL1.dinamarca = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "21")
                    {
                        mCargosDestinoLCL1.dominica = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "22")
                    {
                        mCargosDestinoLCL1.dubai = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "23")
                    {
                        mCargosDestinoLCL1.ecuador = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "24")
                    {
                        mCargosDestinoLCL1.egipto = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "25")
                    {
                        mCargosDestinoLCL1.eslovaquia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "26")
                    {
                        mCargosDestinoLCL1.eslovenia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "27")
                    {
                        mCargosDestinoLCL1.espana = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "28")
                    {
                        mCargosDestinoLCL1.finlandia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "29")
                    {
                        mCargosDestinoLCL1.flipinas = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "30")
                    {
                        mCargosDestinoLCL1.francia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "31")
                    {
                        mCargosDestinoLCL1.grecia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "32")
                    {
                        mCargosDestinoLCL1.guatemala = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "33")
                    {
                        mCargosDestinoLCL1.haiti = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "34")
                    {
                        mCargosDestinoLCL1.holanda = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "35")
                    {
                        mCargosDestinoLCL1.honduras = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "36")
                    {
                        mCargosDestinoLCL1.hungria = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "37")
                    {
                        mCargosDestinoLCL1.india = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "38")
                    {
                        mCargosDestinoLCL1.indonesia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "39")
                    {
                        mCargosDestinoLCL1.irlandia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "40")
                    {
                        mCargosDestinoLCL1.islandia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "41")
                    {
                        mCargosDestinoLCL1.israel = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "42")
                    {
                        mCargosDestinoLCL1.italia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "43")
                    {
                        mCargosDestinoLCL1.jamaica = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "44")
                    {
                        mCargosDestinoLCL1.japon = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "45")
                    {
                        mCargosDestinoLCL1.korea = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "46")
                    {
                        mCargosDestinoLCL1.luxemburgo = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "47")
                    {
                        mCargosDestinoLCL1.malasia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "48")
                    {
                        mCargosDestinoLCL1.maldivas = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "49")
                    {
                        mCargosDestinoLCL1.marruecos = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "50")
                    {
                        mCargosDestinoLCL1.maxico = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "51")
                    {
                        mCargosDestinoLCL1.monaco = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "52")
                    {
                        mCargosDestinoLCL1.mongolia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "53")
                    {
                        mCargosDestinoLCL1.nepal = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "54")
                    {
                        mCargosDestinoLCL1.nicaragua = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "55")
                    {
                        mCargosDestinoLCL1.noruega = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "56")
                    {
                        mCargosDestinoLCL1.nueva_zelanda = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "57")
                    {
                        mCargosDestinoLCL1.panama = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "58")
                    {
                        mCargosDestinoLCL1.paraguay = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "59")
                    {
                        mCargosDestinoLCL1.peru = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "60")
                    {
                        mCargosDestinoLCL1.polonia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "61")
                    {
                        mCargosDestinoLCL1.portugal = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "62")
                    {
                        mCargosDestinoLCL1.qatar = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "63")
                    {
                        mCargosDestinoLCL1.reino_unido = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "64")
                    {
                        mCargosDestinoLCL1.republica_dominicana = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "65")
                    {
                        mCargosDestinoLCL1.rusia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "66")
                    {
                        mCargosDestinoLCL1.salvador = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "67")
                    {
                        mCargosDestinoLCL1.singapur = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "68")
                    {
                        mCargosDestinoLCL1.sudafrica = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "69")
                    {
                        mCargosDestinoLCL1.suecia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "70")
                    {
                        mCargosDestinoLCL1.suiza = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "71")
                    {
                        mCargosDestinoLCL1.thailandia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "72")
                    {
                        mCargosDestinoLCL1.taiwan = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "73")
                    {
                        mCargosDestinoLCL1.tunez = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "74")
                    {
                        mCargosDestinoLCL1.turquia = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "75")
                    {
                        mCargosDestinoLCL1.ucrania = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "76")
                    {
                        mCargosDestinoLCL1.uruguay = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "77")
                    {
                        mCargosDestinoLCL1.usa = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "78")
                    {
                        mCargosDestinoLCL1.venezuela = 1;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "79")
                    {
                        mCargosDestinoLCL1.vietnam = 1;
                    }
                }
                else
                {
                    if (clbCargosDestinoLCL.GetItemText(i) == "0")
                    {
                        mCargosDestinoLCL1.alemania = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "1")
                    {
                        mCargosDestinoLCL1.arabia_saudi = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "2")
                    {
                        mCargosDestinoLCL1.argelia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "3")
                    {
                        mCargosDestinoLCL1.argentina = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "4")
                    {
                        mCargosDestinoLCL1.australia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "5")
                    {
                        mCargosDestinoLCL1.austria = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "6")
                    {
                        mCargosDestinoLCL1.bahamas = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "7")
                    {
                        mCargosDestinoLCL1.bangladesh = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "8")
                    {
                        mCargosDestinoLCL1.barbados = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "9")
                    {
                        mCargosDestinoLCL1.belgica = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "10")
                    {
                        mCargosDestinoLCL1.belice = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "11")
                    {
                        mCargosDestinoLCL1.bolivia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "12")
                    {
                        mCargosDestinoLCL1.brasil = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "13")
                    {
                        mCargosDestinoLCL1.canada = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "14")
                    {
                        mCargosDestinoLCL1.chile = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "15")
                    {
                        mCargosDestinoLCL1.china = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "16")
                    {
                        mCargosDestinoLCL1.colombia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "17")
                    {
                        mCargosDestinoLCL1.crc = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "18")
                    {
                        mCargosDestinoLCL1.croacia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "19")
                    {
                        mCargosDestinoLCL1.cuba = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "20")
                    {
                        mCargosDestinoLCL1.dinamarca = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "21")
                    {
                        mCargosDestinoLCL1.dominica = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "22")
                    {
                        mCargosDestinoLCL1.dubai = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "23")
                    {
                        mCargosDestinoLCL1.ecuador = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "24")
                    {
                        mCargosDestinoLCL1.egipto = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "25")
                    {
                        mCargosDestinoLCL1.eslovaquia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "26")
                    {
                        mCargosDestinoLCL1.eslovenia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "27")
                    {
                        mCargosDestinoLCL1.espana = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "28")
                    {
                        mCargosDestinoLCL1.finlandia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "29")
                    {
                        mCargosDestinoLCL1.flipinas = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "30")
                    {
                        mCargosDestinoLCL1.francia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "31")
                    {
                        mCargosDestinoLCL1.grecia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "32")
                    {
                        mCargosDestinoLCL1.guatemala = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "33")
                    {
                        mCargosDestinoLCL1.haiti = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "34")
                    {
                        mCargosDestinoLCL1.holanda = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "35")
                    {
                        mCargosDestinoLCL1.honduras = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "36")
                    {
                        mCargosDestinoLCL1.hungria = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "37")
                    {
                        mCargosDestinoLCL1.india = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "38")
                    {
                        mCargosDestinoLCL1.indonesia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "39")
                    {
                        mCargosDestinoLCL1.irlandia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "40")
                    {
                        mCargosDestinoLCL1.islandia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "41")
                    {
                        mCargosDestinoLCL1.israel = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "42")
                    {
                        mCargosDestinoLCL1.italia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "43")
                    {
                        mCargosDestinoLCL1.jamaica = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "44")
                    {
                        mCargosDestinoLCL1.japon = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "45")
                    {
                        mCargosDestinoLCL1.korea = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "46")
                    {
                        mCargosDestinoLCL1.luxemburgo = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "47")
                    {
                        mCargosDestinoLCL1.malasia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "48")
                    {
                        mCargosDestinoLCL1.maldivas = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "49")
                    {
                        mCargosDestinoLCL1.marruecos = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "50")
                    {
                        mCargosDestinoLCL1.maxico = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "51")
                    {
                        mCargosDestinoLCL1.monaco = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "52")
                    {
                        mCargosDestinoLCL1.mongolia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "53")
                    {
                        mCargosDestinoLCL1.nepal = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "54")
                    {
                        mCargosDestinoLCL1.nicaragua = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "55")
                    {
                        mCargosDestinoLCL1.noruega = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "56")
                    {
                        mCargosDestinoLCL1.nueva_zelanda = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "57")
                    {
                        mCargosDestinoLCL1.panama = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "58")
                    {
                        mCargosDestinoLCL1.paraguay = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "59")
                    {
                        mCargosDestinoLCL1.peru = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "60")
                    {
                        mCargosDestinoLCL1.polonia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "61")
                    {
                        mCargosDestinoLCL1.portugal = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "62")
                    {
                        mCargosDestinoLCL1.qatar = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "63")
                    {
                        mCargosDestinoLCL1.reino_unido = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "64")
                    {
                        mCargosDestinoLCL1.republica_dominicana = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "65")
                    {
                        mCargosDestinoLCL1.rusia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "66")
                    {
                        mCargosDestinoLCL1.salvador = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "67")
                    {
                        mCargosDestinoLCL1.singapur = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "68")
                    {
                        mCargosDestinoLCL1.sudafrica = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "69")
                    {
                        mCargosDestinoLCL1.suecia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "70")
                    {
                        mCargosDestinoLCL1.suiza = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "71")
                    {
                        mCargosDestinoLCL1.thailandia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "72")
                    {
                        mCargosDestinoLCL1.taiwan = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "73")
                    {
                        mCargosDestinoLCL1.tunez = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "74")
                    {
                        mCargosDestinoLCL1.turquia = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "75")
                    {
                        mCargosDestinoLCL1.ucrania = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "76")
                    {
                        mCargosDestinoLCL1.uruguay = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "77")
                    {
                        mCargosDestinoLCL1.usa = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "78")
                    {
                        mCargosDestinoLCL1.venezuela = 0;
                    }
                    else if (clbCargosDestinoLCL.GetItemText(i) == "78")
                    {
                        mCargosDestinoLCL1.vietnam = 0;
                    }
                }
            }
            for (int i = 0; i < clbViasDestinoLCL.Items.Count; i++)
            {
                if (clbViasDestinoLCL.GetItemChecked(i))
                {
                    if (clbViasDestinoLCL.GetItemText(i) == "0")
                    {
                        mCargosDestinoLCL1.rodman = 1;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "1")
                    {
                        mCargosDestinoLCL1.cristobal = 1;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "2")
                    {
                        mCargosDestinoLCL1.manzanillo = 1;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "3")
                    {
                        mCargosDestinoLCL1.balboa = 1;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "4")
                    {
                        mCargosDestinoLCL1.moin = 1;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "5")
                    {
                        mCargosDestinoLCL1.caldera = 1;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "6")
                    {
                        mCargosDestinoLCL1.no_aplica = 1;
                    }
                }
                else
                {
                    if (clbViasDestinoLCL.GetItemText(i) == "0")
                    {
                        mCargosDestinoLCL1.rodman = 0;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "1")
                    {
                        mCargosDestinoLCL1.cristobal = 0;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "2")
                    {
                        mCargosDestinoLCL1.manzanillo = 0;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "3")
                    {
                        mCargosDestinoLCL1.balboa = 0;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "4")
                    {
                        mCargosDestinoLCL1.moin = 0;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "5")
                    {
                        mCargosDestinoLCL1.caldera = 0;
                    }
                    else if (clbViasDestinoLCL.GetItemText(i) == "6")
                    {
                        mCargosDestinoLCL1.no_aplica = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosGastosPortuarios()
        {
            mGastosPortuarios1.Id = getIdGastosPortuariosIfExist();
            mGastosPortuarios1.Proveedor = (txtProveedorGastosPortuarios.Text).ToUpper();
            mGastosPortuarios1.Manejos_pueto = float.Parse(txtGastosPortuarios.Text);
            for (int i = 0; i < clbGastosPortuarios.Items.Count; i++)
            {
                if (clbGastosPortuarios.GetItemChecked(i))
                {
                    if (clbGastosPortuarios.GetItemText(i) == "0")
                    {
                        mGastosPortuarios1.rodman = 1;
                    }
                    else if (clbGastosPortuarios.GetItemText(i) == "1")
                    {
                        mGastosPortuarios1.cristobal = 1;
                    }
                    else if (clbGastosPortuarios.GetItemText(i) == "2")
                    {
                        mGastosPortuarios1.manzanillo = 1;
                    }
                    else if (clbGastosPortuarios.GetItemText(i) == "3")
                    {
                        mGastosPortuarios1.balboa = 1;
                    }
                }
                else
                {
                    if (clbGastosPortuarios.GetItemText(i) == "0")
                    {
                        mGastosPortuarios1.rodman = 0;
                    }
                    else if (clbGastosPortuarios.GetItemText(i) == "1")
                    {
                        mGastosPortuarios1.cristobal = 0;
                    }
                    else if (clbGastosPortuarios.GetItemText(i) == "2")
                    {
                        mGastosPortuarios1.manzanillo = 0;
                    }
                    else if (clbGastosPortuarios.GetItemText(i) == "3")
                    {
                        mGastosPortuarios1.balboa = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosGastosPortuariosLCL()
        {
            mGastosPortuariosLCL1.Id = getIdGastosPortuariosLCLIfExist();
            mGastosPortuariosLCL1.Proveedor = (txtProveedorGastosPortuariosLCL.Text).ToUpper();
            mGastosPortuariosLCL1.Cargos = float.Parse(txtGastosPortuariosLCL.Text);
            for (int i = 0; i < clbGastosPortuariosLCL.Items.Count; i++)
            {
                if (clbGastosPortuariosLCL.GetItemChecked(i))
                {
                    if (clbGastosPortuariosLCL.GetItemText(i) == "0")
                    {
                        mGastosPortuariosLCL1.rodman = 1;
                    }
                    else if (clbGastosPortuariosLCL.GetItemText(i) == "1")
                    {
                        mGastosPortuariosLCL1.cristobal = 1;
                    }
                    else if (clbGastosPortuariosLCL.GetItemText(i) == "2")
                    {
                        mGastosPortuariosLCL1.manzanillo = 1;
                    }
                    else if (clbGastosPortuariosLCL.GetItemText(i) == "3")
                    {
                        mGastosPortuariosLCL1.balboa = 1;
                    }
                }
                else
                {
                    if (clbGastosPortuariosLCL.GetItemText(i) == "0")
                    {
                        mGastosPortuariosLCL1.rodman = 0;
                    }
                    else if (clbGastosPortuariosLCL.GetItemText(i) == "1")
                    {
                        mGastosPortuariosLCL1.cristobal = 0;
                    }
                    else if (clbGastosPortuariosLCL.GetItemText(i) == "2")
                    {
                        mGastosPortuariosLCL1.manzanillo = 0;
                    }
                    else if (clbGastosPortuariosLCL.GetItemText(i) == "3")
                    {
                        mGastosPortuariosLCL1.balboa = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosMovimientoPuertoBodega()
        {
            mMovimientoPuertoBodega1.Id = getIdMovimientoPuertoBodegaIfExist();
            mMovimientoPuertoBodega1.Proveedor = (txtProveedorMovimientoPuertoBodega.Text).ToUpper();
            mMovimientoPuertoBodega1.Transporte_puerto = float.Parse(txtMovimientoPuertoBodega.Text);
            for (int i = 0; i < clbMovimientoPuertoBodega.Items.Count; i++)
            {
                if (clbMovimientoPuertoBodega.GetItemChecked(i))
                {
                    if (clbMovimientoPuertoBodega.GetItemText(i) == "0")
                    {
                        mMovimientoPuertoBodega1.rodman = 1;
                    }
                    else if (clbMovimientoPuertoBodega.GetItemText(i) == "1")
                    {
                        mMovimientoPuertoBodega1.cristobal = 1;
                    }
                    else if (clbMovimientoPuertoBodega.GetItemText(i) == "2")
                    {
                        mMovimientoPuertoBodega1.manzanillo = 1;
                    }
                    else if (clbMovimientoPuertoBodega.GetItemText(i) == "3")
                    {
                        mMovimientoPuertoBodega1.balboa = 1;
                    }
                }
                else
                {
                    if (clbMovimientoPuertoBodega.GetItemText(i) == "0")
                    {
                        mMovimientoPuertoBodega1.rodman = 0;
                    }
                    else if (clbMovimientoPuertoBodega.GetItemText(i) == "1")
                    {
                        mMovimientoPuertoBodega1.cristobal = 0;
                    }
                    else if (clbMovimientoPuertoBodega.GetItemText(i) == "2")
                    {
                        mMovimientoPuertoBodega1.manzanillo = 0;
                    }
                    else if (clbMovimientoPuertoBodega.GetItemText(i) == "3")
                    {
                        mMovimientoPuertoBodega1.balboa = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosMovimientoPuertoBodegaLCL()
        {
            mMovimientoPuertoBodegaLCL1.Id = getIdMovimientoPuertoBodegaLCLIfExist();
            mMovimientoPuertoBodegaLCL1.Proveedor = (txtProveedorMovimientoPuertoBodegaLCL.Text).ToUpper();
            mMovimientoPuertoBodegaLCL1.Transporte_bodega = float.Parse(txtMovimientoPuertoBodegaLCL.Text);
            for (int i = 0; i < clbMovimientoPuertoBodegaLCL.Items.Count; i++)
            {
                if (clbMovimientoPuertoBodegaLCL.GetItemChecked(i))
                {
                    if (clbMovimientoPuertoBodegaLCL.GetItemText(i) == "0")
                    {
                        mMovimientoPuertoBodegaLCL1.rodman = 1;
                    }
                    else if (clbMovimientoPuertoBodegaLCL.GetItemText(i) == "1")
                    {
                        mMovimientoPuertoBodegaLCL1.cristobal = 1;
                    }
                    else if (clbMovimientoPuertoBodegaLCL.GetItemText(i) == "2")
                    {
                        mMovimientoPuertoBodegaLCL1.manzanillo = 1;
                    }
                    else if (clbMovimientoPuertoBodegaLCL.GetItemText(i) == "3")
                    {
                        mMovimientoPuertoBodegaLCL1.balboa = 1;
                    }
                }
                else
                {
                    if (clbMovimientoPuertoBodegaLCL.GetItemText(i) == "0")
                    {
                        mMovimientoPuertoBodegaLCL1.rodman = 0;
                    }
                    else if (clbMovimientoPuertoBodegaLCL.GetItemText(i) == "1")
                    {
                        mMovimientoPuertoBodegaLCL1.cristobal = 0;
                    }
                    else if (clbMovimientoPuertoBodegaLCL.GetItemText(i) == "2")
                    {
                        mMovimientoPuertoBodegaLCL1.manzanillo = 0;
                    }
                    else if (clbMovimientoPuertoBodegaLCL.GetItemText(i) == "3")
                    {
                        mMovimientoPuertoBodegaLCL1.balboa = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosOtrasCategorias()
        {
            mOtrasCategorias1.Id = getIdOtrasCategoriasIfExist();
            mOtrasCategorias1.Proveedor = (txtProveedorOtrasCategorias.Text).ToUpper();
            mOtrasCategorias1.Producto = (txtServicioOtrasCategorias.Text).ToUpper();
            mOtrasCategorias1.Costo = float.Parse(txtCostoOtrasCategorias.Text);
            for (int i = 0; i < clbOtrasCategorias.Items.Count; i++)
            {
                if (clbOtrasCategorias.GetItemChecked(i))
                {
                    if (clbOtrasCategorias.GetItemText(i) == "0")
                    {
                        mOtrasCategorias1.rodman = 1;
                    }
                    else if (clbOtrasCategorias.GetItemText(i) == "1")
                    {
                        mOtrasCategorias1.cristobal = 1;
                    }
                    else if (clbOtrasCategorias.GetItemText(i) == "2")
                    {
                        mOtrasCategorias1.manzanillo = 1;
                    }
                    else if (clbOtrasCategorias.GetItemText(i) == "3")
                    {
                        mOtrasCategorias1.balboa = 1;
                    }
                }
                else
                {
                    if (clbOtrasCategorias.GetItemText(i) == "0")
                    {
                        mOtrasCategorias1.rodman = 0;
                    }
                    else if (clbOtrasCategorias.GetItemText(i) == "1")
                    {
                        mOtrasCategorias1.cristobal = 0;
                    }
                    else if (clbOtrasCategorias.GetItemText(i) == "2")
                    {
                        mOtrasCategorias1.manzanillo = 0;
                    }
                    else if (clbOtrasCategorias.GetItemText(i) == "3")
                    {
                        mOtrasCategorias1.balboa = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosOtrasCategoriasLCL()
        {
            mOtrasCategoriasLCL1.Id = getIdOtrasCategoriasLCLIfExist();
            mOtrasCategoriasLCL1.Proveedor = (txtProveedorOtrasCategoriasLCL.Text).ToUpper();
            mOtrasCategoriasLCL1.Producto = (txtServicioOtrasCategoriasLCL.Text).ToUpper();
            mOtrasCategoriasLCL1.Costo = float.Parse(txtCostoOtrasCategoriasLCL.Text);
            for (int i = 0; i < clbOtrasCategoriasLCL.Items.Count; i++)
            {
                if (clbOtrasCategoriasLCL.GetItemChecked(i))
                {
                    if (clbOtrasCategoriasLCL.GetItemText(i) == "0")
                    {
                        mOtrasCategoriasLCL1.rodman = 1;
                    }
                    else if (clbOtrasCategoriasLCL.GetItemText(i) == "1")
                    {
                        mOtrasCategoriasLCL1.cristobal = 1;
                    }
                    else if (clbOtrasCategoriasLCL.GetItemText(i) == "2")
                    {
                        mOtrasCategoriasLCL1.manzanillo = 1;
                    }
                    else if (clbOtrasCategoriasLCL.GetItemText(i) == "3")
                    {
                        mOtrasCategoriasLCL1.balboa = 1;
                    }
                }
                else
                {
                    if (clbOtrasCategoriasLCL.GetItemText(i) == "0")
                    {
                        mOtrasCategoriasLCL1.rodman = 0;
                    }
                    else if (clbOtrasCategoriasLCL.GetItemText(i) == "1")
                    {
                        mOtrasCategoriasLCL1.cristobal = 0;
                    }
                    else if (clbOtrasCategoriasLCL.GetItemText(i) == "2")
                    {
                        mOtrasCategoriasLCL1.manzanillo = 0;
                    }
                    else if (clbOtrasCategoriasLCL.GetItemText(i) == "3")
                    {
                        mOtrasCategoriasLCL1.balboa = 0;
                    }
                }
            }
        }
        private void cargarDatosGuardadosOtrosServicios()
        {
            mOtrosServicios1.Id = getIdOtrosServiciosIfExist();
            mOtrosServicios1.Proveedor = (txtProveedorOtrosServicios.Text).ToUpper();
            mOtrosServicios1.Producto = (txtServiciosOtrosServicios.Text).ToUpper();
            mOtrosServicios1.Costo = float.Parse(txtCostoOtrosServicios.Text);
            for (int i = 0; i < clbOtrosServicios.Items.Count; i++)
            {
                if (clbOtrosServicios.GetItemChecked(i))
                {
                    if (clbOtrosServicios.GetItemText(i) == "0")
                    {
                        mOtrosServicios1.rodman = 1;
                    }
                    else if (clbOtrosServicios.GetItemText(i) == "1")
                    {
                        mOtrosServicios1.cristobal = 1;
                    }
                    else if (clbOtrosServicios.GetItemText(i) == "2")
                    {
                        mOtrosServicios1.manzanillo = 1;
                    }
                    else if (clbOtrosServicios.GetItemText(i) == "3")
                    {
                        mOtrosServicios1.balboa = 1;
                    }
                }
                else
                {
                    if (clbOtrosServicios.GetItemText(i) == "0")
                    {
                        mOtrosServicios1.rodman = 0;
                    }
                    else if (clbOtrosServicios.GetItemText(i) == "1")
                    {
                        mOtrosServicios1.cristobal = 0;
                    }
                    else if (clbOtrosServicios.GetItemText(i) == "2")
                    {
                        mOtrosServicios1.manzanillo = 0;
                    }
                    else if (clbOtrosServicios.GetItemText(i) == "3")
                    {
                        mOtrosServicios1.balboa = 0;
                    }
                }
            }
        }

        private int getIdOrigenIfExist()
        {
            if (!txtIdOrigen.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdOrigen.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdPolIfExist()
        {
            if (!txtIdPol.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdPol.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdPodIfExist()
        {
            if (!txtIdPod.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdPod.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdViaIfExist()
        {
            if (!txtIdVia.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdVia.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdDestinoIfExist()
        {
            if (!txtIdDestino.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdDestino.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdEquipoIfExist()
        {
            if (!txtIdEquipo.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdEquipo.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdModalidadIfExist()
        {
            if (!txtIdModalidad.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdModalidad.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdAgenteOrigenIfExist()
        {
            if (!txtIdAgenteOrigen.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdAgenteOrigen.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdAgenteOrigenLCLIfExist()
        {
            if (!txtIdAgenteOrigenLCL.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdAgenteOrigenLCL.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdFleteInternacionalIfExist()
        {
            if (!txtIdFleteInternacional.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdFleteInternacional.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdFleteInternacionalLCLIfExist()
        {
            if (!txtIdFleteInternacionalLCL.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdFleteInternacionalLCL.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdCargosDestinoIfExist()
        {
            if (!txtIdCargosDestino.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdCargosDestino.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdCargosDestinoLCLIfExist()
        {
            if (!txtIdCargosDestinoLCL.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdCargosDestinoLCL.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdGastosPortuariosIfExist()
        {
            if (!txtIdGastosPortuarios.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdGastosPortuarios.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdGastosPortuariosLCLIfExist()
        {
            if (!txtIdGastosPortuariosLCL.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdGastosPortuariosLCL.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdMovimientoPuertoBodegaIfExist()
        {
            if (!txtIdMovimientoPuertoBodega.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdMovimientoPuertoBodega.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdMovimientoPuertoBodegaLCLIfExist()
        {
            if (!txtIdMovimientoPuertoBodegaLCL.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdMovimientoPuertoBodegaLCL.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdOtrasCategoriasIfExist()
        {
            if (!txtIdOtrasCategorias.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdOtrasCategorias.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdOtrasCategoriasLCLIfExist()
        {
            if (!txtIdOtrasCategoriasLCL.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdOtrasCategoriasLCL.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }
        private int getIdOtrosServiciosIfExist()
        {
            if (!txtIdOtrosServicios.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtIdOtrosServicios.Text.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }

        private void limpiarCampos()
        {
            txtIdOrigen.Text = "";
            txtPaisOrigen.Text = "";
            txtIdPol.Text = "";
            txtPol.Text = "";
            txtIdPod.Text = "";
            txtPod.Text = "";
            txtIdVia.Text = "";
            txtVia.Text = "";
            txtIdDestino.Text = "";
            txtPaisDestino.Text = "";
            txtIdEquipo.Text = "";
            txtEquipo.Text = "";
            txtIdModalidad.Text = "";
            txtModalidad.Text = "";
            txtIdAgenteOrigen.Text = "";
            txtAgenteOrigen.Text = "";
            txtHblAgenteOrigen.Text = "";
            txtManejosAgenteOrigen.Text = "";
            txtIdFleteInternacional.Text = "";
            txtFleteInternacional.Text = "";
            txtThcFleteInternacional.Text = "";
            txtDocFeeFleteInternacional.Text = "";
            txtSecurityFleteInternacional.Text = "";
            txtImpresionBLFleteInternacional.Text = "";
            txtPortFacilityFleteInternacional.Text = "";
            txtCanalFeeFleteInternacional.Text = "";
            txtVacFleteInternacional.Text = "";
            txtImpdoFleteInternacional.Text = "";
            txtMerchantFleteInternacional.Text = "";
            txtIdCargosDestino.Text = "";
            txtCargosDestino.Text = "";
            txtFleteCargosDestino.Text = "";
            txtIdGastosPortuarios.Text = "";
            txtProveedorGastosPortuarios.Text = "";
            txtGastosPortuarios.Text = "";
            txtIdMovimientoPuertoBodega.Text = "";
            txtProveedorMovimientoPuertoBodega.Text = "";
            txtMovimientoPuertoBodega.Text = "";
            txtIdOtrasCategorias.Text = "";
            txtProveedorOtrasCategorias.Text = "";
            txtServicioOtrasCategorias.Text = "";
            txtCostoOtrasCategorias.Text = "";
            txtIdOtrosServicios.Text = "";
            txtProveedorOtrosServicios.Text = "";
            txtServiciosOtrosServicios.Text = "";
            txtCostoOtrosServicios.Text = "";
            txtIdAgenteOrigenLCL.Text = "";
            txtAgenteOrigenLCL.Text = "";
            txtHblAgenteOrigenLCL.Text = "";
            txtManejosAgenteOrigenLCL.Text = "";
            txtIdFleteInternacionalLCL.Text = "";
            txtFleteInternacionalLCL.Text = "";
            txtThcDCBMFleteInternacionalLCL.Text = "";
            txtThcDMinimoFleteInternacionalLCL.Text = "";
            txtVgmMinimoFleteInternacionalLCL.Text = "";
            txtBunkerCBMFleteInternacionalLCL.Text = "";
            txtBunkerMinimoFleteInternacionalLCL.Text = "";
            txtSedMinimoFleteInternacionalLCL.Text = "";
            txtTicaMinimoFleteInternacionalLCL.Text = "";
            txtForwardingMinimoFleteInternacionalLCL.Text = "";
            txtManejosMinimoFleteInternacionalLCL.Text = "";
            txtCargaPeligrosaMinimoFleteInternacional.Text = "";
            txtIdGastosPortuariosLCL.Text = "";
            txtProveedorGastosPortuariosLCL.Text = "";
            txtGastosPortuariosLCL.Text = "";
            txtIdMovimientoPuertoBodegaLCL.Text = "";
            txtProveedorMovimientoPuertoBodegaLCL.Text = "";
            txtMovimientoPuertoBodegaLCL.Text = "";
            txtIdOtrasCategoriasLCL.Text = "";
            txtProveedorOtrasCategoriasLCL.Text = "";
            txtServicioOtrasCategoriasLCL.Text = "";
            txtCostoOtrasCategoriasLCL.Text = "";
            txtIdCargosDestinoLCL.Text = "";
            txtCargosDestinoLCL.Text = "";
            txtFleteCargosDestinoLCL.Text = "";
        }

        private void dgvOrigen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvOrigen.Rows[e.RowIndex];
            txtIdOrigen.Text = Convert.ToString(fila.Cells["idOrigen"].Value);
            txtPaisOrigen.Text = Convert.ToString(fila.Cells["origen"].Value);

            if (dgvOrigen.Columns[e.ColumnIndex].Name == "editarOrigen")
            {
                btnOrigen.Text = "EDITAR";
            }

            if (dgvOrigen.Columns[e.ColumnIndex].Name == "eliminarOrigen")
            {
                btnOrigen.Text = "ELIMINAR";
            }
        }

        private void btnAgregarOrigen_Click(object sender, EventArgs e)
        {
            if (btnOrigen.Text == "AGREGAR")
            {
                cargarDatosGuardadosOrigen();
                if (mOrigenConsultas.agregarOrigen(mOrigen1))
                {
                    MessageBox.Show("PAIS AGREGADO");
                    cargarORIGEN();
                    limpiarCampos();
                }

            }
            else if (btnOrigen.Text == "EDITAR")
            {
                cargarDatosGuardadosOrigen();
                if (mOrigenConsultas.modificarOrigen(mOrigen1))
                {
                    MessageBox.Show("PAIS MODIFICADO");
                    cargarORIGEN();
                    limpiarCampos();
                    btnOrigen.Text = "AGREGAR";
                }
            }
            else if (btnOrigen.Text == "ELIMINAR")
            {

                if (getIdOrigenIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL PAIS?", "ELIMINAR PAIS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosOrigen();

                    if (mOrigenConsultas.eliminarOrigen(mOrigen1))
                    {
                        MessageBox.Show("PAIS ELIMINADO");
                        cargarORIGEN();
                        limpiarCampos();
                        btnOrigen.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvPol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvPol.Rows[e.RowIndex];
            txtIdPol.Text = Convert.ToString(fila.Cells["idPol"].Value);
            txtPol.Text = Convert.ToString(fila.Cells["pol"].Value);

            if (dgvPol.Columns[e.ColumnIndex].Name == "editarPol")
            {
                btnPol.Text = "EDITAR";
            }

            if (dgvPol.Columns[e.ColumnIndex].Name == "eliminarPol")
            {
                btnPol.Text = "ELIMINAR";
            }
        }

        private void btnPol_Click(object sender, EventArgs e)
        {
            if (btnPol.Text == "AGREGAR")
            {
                cargarDatosGuardadosPol();
                if (mPolConsultas.agregarPol(mPol1))
                {
                    MessageBox.Show("POL AGREGADO");
                    cargarPOL();
                    limpiarCampos();
                }

            }
            else if (btnPol.Text == "EDITAR")
            {
                cargarDatosGuardadosPol();
                if (mPolConsultas.modificarPol(mPol1))
                {
                    MessageBox.Show("POL MODIFICADO");
                    cargarPOL();
                    limpiarCampos();
                    btnPol.Text = "AGREGAR";
                }
            }
            else if (btnPol.Text == "ELIMINAR")
            {

                if (getIdPolIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL POL?", "ELIMINAR POL", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosPol();

                    if (mPolConsultas.eliminarPol(mPol1))
                    {
                        MessageBox.Show("POL ELIMINADO");
                        cargarPOL();
                        limpiarCampos();
                        btnPol.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvPod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvPod.Rows[e.RowIndex];
            txtIdPod.Text = Convert.ToString(fila.Cells["idPod"].Value);
            txtPod.Text = Convert.ToString(fila.Cells["pod"].Value);

            if (dgvPod.Columns[e.ColumnIndex].Name == "editarPod")
            {
                btnPod.Text = "EDITAR";
            }

            if (dgvPod.Columns[e.ColumnIndex].Name == "eliminarPod")
            {
                btnPod.Text = "ELIMINAR";
            }
        }

        private void btnPod_Click(object sender, EventArgs e)
        {
            if (btnPod.Text == "AGREGAR")
            {
                cargarDatosGuardadosPod();
                if (mPodConsultas.agregarPod(mPod1))
                {
                    MessageBox.Show("POD AGREGADO");
                    cargarPOD();
                    limpiarCampos();
                }

            }
            else if (btnPod.Text == "EDITAR")
            {
                cargarDatosGuardadosPod();
                if (mPodConsultas.modificarPod(mPod1))
                {
                    MessageBox.Show("POD MODIFICADO");
                    cargarPOD();
                    limpiarCampos();
                    btnPod.Text = "AGREGAR";
                }
            }
            else if (btnPod.Text == "ELIMINAR")
            {

                if (getIdPodIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL POD?", "ELIMINAR POD", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosPod();

                    if (mPodConsultas.eliminarPod(mPod1))
                    {
                        MessageBox.Show("POD ELIMINADO");
                        cargarPOD();
                        limpiarCampos();
                        btnPod.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvVia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvVia.Rows[e.RowIndex];
            txtIdVia.Text = Convert.ToString(fila.Cells["idVia"].Value);
            txtVia.Text = Convert.ToString(fila.Cells["via"].Value);

            if (dgvVia.Columns[e.ColumnIndex].Name == "editarVia")
            {
                btnVia.Text = "EDITAR";
            }

            if (dgvVia.Columns[e.ColumnIndex].Name == "eliminarVia")
            {
                btnVia.Text = "ELIMINAR";
            }
        }

        private void btnVia_Click(object sender, EventArgs e)
        {
            if (btnVia.Text == "AGREGAR")
            {
                cargarDatosGuardadosVia();
                if (mViaConsultas.agregarVia(mVia1))
                {
                    MessageBox.Show("VIA AGREGADO");
                    cargarVIA();
                    limpiarCampos();
                }

            }
            else if (btnVia.Text == "EDITAR")
            {
                cargarDatosGuardadosVia();
                if (mViaConsultas.modificarVia(mVia1))
                {
                    MessageBox.Show("VIA MODIFICADO");
                    cargarVIA();
                    limpiarCampos();
                    btnVia.Text = "AGREGAR";
                }
            }
            else if (btnVia.Text == "ELIMINAR")
            {

                if (getIdViaIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR LA VIA?", "ELIMINAR VIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosVia();

                    if (mViaConsultas.eliminarVia(mVia1))
                    {
                        MessageBox.Show("VIA ELIMINADO");
                        cargarVIA();
                        limpiarCampos();
                        btnVia.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvDestino_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDestino.Rows[e.RowIndex];
            txtIdDestino.Text = Convert.ToString(fila.Cells["idDestino"].Value);
            txtPaisDestino.Text = Convert.ToString(fila.Cells["destino"].Value);

            if (dgvDestino.Columns[e.ColumnIndex].Name == "editarDestino")
            {
                btnDestino.Text = "EDITAR";
            }

            if (dgvDestino.Columns[e.ColumnIndex].Name == "eliminarDestino")
            {
                btnDestino.Text = "ELIMINAR";
            }
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            if (btnDestino.Text == "AGREGAR")
            {
                cargarDatosGuardadosDestino();
                if (mDestinoConsultas.agregarDestino(mDestino1))
                {
                    MessageBox.Show("PAIS AGREGADO");
                    cargarDESTINO();
                    limpiarCampos();
                }

            }
            else if (btnDestino.Text == "EDITAR")
            {
                cargarDatosGuardadosDestino();
                if (mDestinoConsultas.modificarDestino(mDestino1))
                {
                    MessageBox.Show("PAIS MODIFICADO");
                    cargarDESTINO();
                    limpiarCampos();
                    btnDestino.Text = "AGREGAR";
                }
            }
            else if (btnDestino.Text == "ELIMINAR")
            {

                if (getIdDestinoIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL PAIS?", "ELIMINAR PAIS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosDestino();

                    if (mDestinoConsultas.eliminarDestino(mDestino1))
                    {
                        MessageBox.Show("PAIS ELIMINADO");
                        cargarDESTINO();
                        limpiarCampos();
                        btnDestino.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvEquipo.Rows[e.RowIndex];
            txtIdEquipo.Text = Convert.ToString(fila.Cells["idEquipo"].Value);
            txtEquipo.Text = Convert.ToString(fila.Cells["equipo"].Value);

            if (dgvEquipo.Columns[e.ColumnIndex].Name == "editarEquipo")
            {
                btnEquipo.Text = "EDITAR";
            }

            if (dgvEquipo.Columns[e.ColumnIndex].Name == "eliminarEquipo")
            {
                btnEquipo.Text = "ELIMINAR";
            }
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            if (btnEquipo.Text == "AGREGAR")
            {
                cargarDatosGuardadosEquipo();
                if (mEquipoConsultas.agregarEquipo(mEquipo1))
                {
                    MessageBox.Show("EQUIPO AGREGADO");
                    cargarEQUIPO();
                    limpiarCampos();
                }

            }
            else if (btnEquipo.Text == "EDITAR")
            {
                cargarDatosGuardadosEquipo();
                if (mEquipoConsultas.modificarEquipo(mEquipo1))
                {
                    MessageBox.Show("EQUIPO MODIFICADO");
                    cargarEQUIPO();
                    limpiarCampos();
                    btnEquipo.Text = "AGREGAR";
                }
            }
            else if (btnEquipo.Text == "ELIMINAR")
            {

                if (getIdEquipoIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL EQUIPO?", "ELIMINAR EQUIPO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosEquipo();

                    if (mEquipoConsultas.eliminarEquipo(mEquipo1))
                    {
                        MessageBox.Show("EQUIPO ELIMINADO");
                        cargarEQUIPO();
                        limpiarCampos();
                        btnEquipo.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvModalidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvModalidad.Rows[e.RowIndex];
            txtIdModalidad.Text = Convert.ToString(fila.Cells["idModalidad"].Value);
            txtModalidad.Text = Convert.ToString(fila.Cells["modalidad"].Value);

            if (dgvModalidad.Columns[e.ColumnIndex].Name == "editarModalidad")
            {
                btnModalidad.Text = "EDITAR";
            }

            if (dgvModalidad.Columns[e.ColumnIndex].Name == "eliminarModalidad")
            {
                btnModalidad.Text = "ELIMINAR";
            }
        }

        private void btnModalidad_Click(object sender, EventArgs e)
        {
            if (btnModalidad.Text == "AGREGAR")
            {
                cargarDatosGuardadosModalidad();
                if (mModalidadConsultas.agregarModalidad(mModalidad1))
                {
                    MessageBox.Show("MODALIDAD AGREGADA");
                    cargarMODALIDAD();
                    limpiarCampos();
                }

            }
            else if (btnEquipo.Text == "EDITAR")
            {
                cargarDatosGuardadosModalidad();
                if (mModalidadConsultas.modificarModalidad(mModalidad1))
                {
                    MessageBox.Show("MODALIDAD MODIFICADA");
                    cargarMODALIDAD();
                    limpiarCampos();
                    btnModalidad.Text = "AGREGAR";
                }
            }
            else if (btnModalidad.Text == "ELIMINAR")
            {

                if (getIdModalidadIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR LA MODALIDAD?", "ELIMINAR MODALIDAD", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosModalidad();

                    if (mModalidadConsultas.eliminarModalidad(mModalidad1))
                    {
                        MessageBox.Show("MODALIDAD ELIMINADA");
                        cargarMODALIDAD();
                        limpiarCampos();
                        btnModalidad.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvAgenteOrigen_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            clbAgenteOrigen.Items.Clear();
            DataGridViewRow fila = dgvAgenteOrigen.Rows[e.RowIndex];
            int fila1 = dgvAgenteOrigen.CurrentCell.RowIndex;
            txtIdAgenteOrigen.Text = Convert.ToString(fila.Cells["idAgenteOrigen"].Value);
            txtAgenteOrigen.Text = Convert.ToString(fila.Cells["proveedorAgenteOrigen"].Value);
            txtHblAgenteOrigen.Text = Convert.ToString(fila.Cells["hblAgenteOrigen"].Value);
            txtManejosAgenteOrigen.Text = Convert.ToString(fila.Cells["manejosAgenteOrigen"].Value);
            if (mAgenteOrigen[fila1].alemania == 1)
            {
                clbAgenteOrigen.Items.Add("ALEMANIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ALEMANIA", false);
            }
            if (mAgenteOrigen[fila1].arabia_saudi == 1)
            {
                clbAgenteOrigen.Items.Add("ARABIA SAUDITA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ARABIA SAUDITA", false);
            }
            if (mAgenteOrigen[fila1].argelia == 1)
            {
                clbAgenteOrigen.Items.Add("ARGELIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ARGELIA", false);
            }
            if (mAgenteOrigen[fila1].argentina == 1)
            {
                clbAgenteOrigen.Items.Add("ARGENTINA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ARGENTINA", false);
            }
            if (mAgenteOrigen[fila1].australia == 1)
            {
                clbAgenteOrigen.Items.Add("AUSTRALIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("AUSTRALIA", false);
            }
            if (mAgenteOrigen[fila1].austria == 1)
            {
                clbAgenteOrigen.Items.Add("AUSTRIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("AUSTRIA", false);
            }
            if (mAgenteOrigen[fila1].bahamas == 1)
            {
                clbAgenteOrigen.Items.Add("BAHAMAS", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("BAHAMAS", false);
            }
            if (mAgenteOrigen[fila1].bangladesh == 1)
            {
                clbAgenteOrigen.Items.Add("BANGLADESH", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("BANGLADESH", false);
            }
            if (mAgenteOrigen[fila1].barbados == 1)
            {
                clbAgenteOrigen.Items.Add("BARBADOS", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("BARBADOS", false);
            }
            if (mAgenteOrigen[fila1].belgica == 1)
            {
                clbAgenteOrigen.Items.Add("BELGICA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("BELGICA", false);
            }
            if (mAgenteOrigen[fila1].belice == 1)
            {
                clbAgenteOrigen.Items.Add("BELICE", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("BELICE", false);
            }
            if (mAgenteOrigen[fila1].bolivia == 1)
            {
                clbAgenteOrigen.Items.Add("BOLIVIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("BOLIVIA", false);
            }
            if (mAgenteOrigen[fila1].brasil == 1)
            {
                clbAgenteOrigen.Items.Add("BRASIL", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("BRASIL", false);
            }
            if (mAgenteOrigen[fila1].canada == 1)
            {
                clbAgenteOrigen.Items.Add("CANADA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("CANADA", false);
            }
            if (mAgenteOrigen[fila1].chile == 1)
            {
                clbAgenteOrigen.Items.Add("CHILE", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("CHILE", false);
            }
            if (mAgenteOrigen[fila1].china == 1)
            {
                clbAgenteOrigen.Items.Add("CHINA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("CHINA", false);
            }
            if (mAgenteOrigen[fila1].colombia == 1)
            {
                clbAgenteOrigen.Items.Add("COLOMBIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("COLOMBIA", false);
            }
            if (mAgenteOrigen[fila1].crc == 1)
            {
                clbAgenteOrigen.Items.Add("COSTA RICA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("COSTA RICA", false);
            }
            if (mAgenteOrigen[fila1].croacia == 1)
            {
                clbAgenteOrigen.Items.Add("CROACIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("CROACIA", false);
            }
            if (mAgenteOrigen[fila1].cuba == 1)
            {
                clbAgenteOrigen.Items.Add("CUBA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("CUBA", false);
            }
            if (mAgenteOrigen[fila1].dinamarca == 1)
            {
                clbAgenteOrigen.Items.Add("DINAMARCA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("DINAMARCA", false);
            }
            if (mAgenteOrigen[fila1].dominica == 1)
            {
                clbAgenteOrigen.Items.Add("DOMINICA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("DOMINICA", false);
            }
            if (mAgenteOrigen[fila1].dubai == 1)
            {
                clbAgenteOrigen.Items.Add("DUBAI", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("DUBAI", false);
            }
            if (mAgenteOrigen[fila1].ecuador == 1)
            {
                clbAgenteOrigen.Items.Add("ECUADOR", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ECUADOR", false);
            }
            if (mAgenteOrigen[fila1].egipto == 1)
            {
                clbAgenteOrigen.Items.Add("EGIPTO", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("EGIPTO", false);
            }
            if (mAgenteOrigen[fila1].eslovaquia == 1)
            {
                clbAgenteOrigen.Items.Add("ESLOVAQUIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ESLOVAQUIA", false);
            }
            if (mAgenteOrigen[fila1].eslovenia == 1)
            {
                clbAgenteOrigen.Items.Add("ESLOVENIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ESLOVENIA", false);
            }
            if (mAgenteOrigen[fila1].espana == 1)
            {
                clbAgenteOrigen.Items.Add("ESPAÑA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ESPAÑA", false);
            }
            if (mAgenteOrigen[fila1].finlandia == 1)
            {
                clbAgenteOrigen.Items.Add("FINLANDIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("FINLANDIA", false);
            }
            if (mAgenteOrigen[fila1].flipinas == 1)
            {
                clbAgenteOrigen.Items.Add("FILIPINAS", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("FILIPINAS", false);
            }
            if (mAgenteOrigen[fila1].francia == 1)
            {
                clbAgenteOrigen.Items.Add("FRANCIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("FRANCIA", false);
            }
            if (mAgenteOrigen[fila1].grecia == 1)
            {
                clbAgenteOrigen.Items.Add("GRECIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("GRECIA", false);
            }
            if (mAgenteOrigen[fila1].guatemala == 1)
            {
                clbAgenteOrigen.Items.Add("GUATEMALA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("GUATEMALA", false);
            }
            if (mAgenteOrigen[fila1].haiti == 1)
            {
                clbAgenteOrigen.Items.Add("HAITI", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("HAITI", false);
            }
            if (mAgenteOrigen[fila1].holanda == 1)
            {
                clbAgenteOrigen.Items.Add("HOLANDA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("HOLANDA", false);
            }
            if (mAgenteOrigen[fila1].honduras == 1)
            {
                clbAgenteOrigen.Items.Add("HONDURAS", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("HONDURAS", false);
            }
            if (mAgenteOrigen[fila1].hungria == 1)
            {
                clbAgenteOrigen.Items.Add("HUNGRIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("HUNGRIA", false);
            }
            if (mAgenteOrigen[fila1].india == 1)
            {
                clbAgenteOrigen.Items.Add("INDIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("INDIA", false);
            }
            if (mAgenteOrigen[fila1].indonesia == 1)
            {
                clbAgenteOrigen.Items.Add("INDONESIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("INDONESIA", false);
            }
            if (mAgenteOrigen[fila1].irlandia == 1)
            {
                clbAgenteOrigen.Items.Add("IRLANDIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("IRLANDIA", false);
            }
            if (mAgenteOrigen[fila1].islandia == 1)
            {
                clbAgenteOrigen.Items.Add("ISLANDIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ISLANDIA", false);
            }
            if (mAgenteOrigen[fila1].israel == 1)
            {
                clbAgenteOrigen.Items.Add("ISRAEL", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ISRAEL", false);
            }
            if (mAgenteOrigen[fila1].italia == 1)
            {
                clbAgenteOrigen.Items.Add("ITALIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("ITALIA", false);
            }
            if (mAgenteOrigen[fila1].jamaica == 1)
            {
                clbAgenteOrigen.Items.Add("JAMAICA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("JAMAICA", false);
            }
            if (mAgenteOrigen[fila1].japon == 1)
            {
                clbAgenteOrigen.Items.Add("JAPON", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("JAPON", false);
            }
            if (mAgenteOrigen[fila1].korea == 1)
            {
                clbAgenteOrigen.Items.Add("KOREA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("KOREA", false);
            }
            if (mAgenteOrigen[fila1].luxemburgo == 1)
            {
                clbAgenteOrigen.Items.Add("LUXEMBURGO", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("LUXEMBURGO", false);
            }
            if (mAgenteOrigen[fila1].malasia == 1)
            {
                clbAgenteOrigen.Items.Add("MALASIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("MALASIA", false);
            }
            if (mAgenteOrigen[fila1].maldivas == 1)
            {
                clbAgenteOrigen.Items.Add("MALDIVAS", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("MALDIVAS", false);
            }
            if (mAgenteOrigen[fila1].marruecos == 1)
            {
                clbAgenteOrigen.Items.Add("MARRUECOS", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("MARRUECOS", false);
            }
            if (mAgenteOrigen[fila1].maxico == 1)
            {
                clbAgenteOrigen.Items.Add("MEXICO", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("MEXICO", false);
            }
            if (mAgenteOrigen[fila1].monaco == 1)
            {
                clbAgenteOrigen.Items.Add("MONACO", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("MONACO", false);
            }
            if (mAgenteOrigen[fila1].mongolia == 1)
            {
                clbAgenteOrigen.Items.Add("MONGOLIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("MONGOLIA", false);
            }
            if (mAgenteOrigen[fila1].nepal == 1)
            {
                clbAgenteOrigen.Items.Add("NEPAL", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("NEPAL", false);
            }
            if (mAgenteOrigen[fila1].nicaragua == 1)
            {
                clbAgenteOrigen.Items.Add("NICARAGUA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("NICARAGUA", false);
            }
            if (mAgenteOrigen[fila1].noruega == 1)
            {
                clbAgenteOrigen.Items.Add("NORUEGA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("NORUEGA", false);
            }
            if (mAgenteOrigen[fila1].nueva_zelanda == 1)
            {
                clbAgenteOrigen.Items.Add("NUEVA ZELANDA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("NUEVA ZELANDA", false);
            }
            if (mAgenteOrigen[fila1].panama == 1)
            {
                clbAgenteOrigen.Items.Add("PANAMA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("PANAMA", false);
            }
            if (mAgenteOrigen[fila1].paraguay == 1)
            {
                clbAgenteOrigen.Items.Add("PARAGUAY", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("PARAGUAY", false);
            }
            if (mAgenteOrigen[fila1].peru == 1)
            {
                clbAgenteOrigen.Items.Add("PERU", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("PERU", false);
            }
            if (mAgenteOrigen[fila1].polonia == 1)
            {
                clbAgenteOrigen.Items.Add("POLONIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("POLONIA", false);
            }
            if (mAgenteOrigen[fila1].portugal == 1)
            {
                clbAgenteOrigen.Items.Add("PORTUGAL", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("PORTUGAL", false);
            }
            if (mAgenteOrigen[fila1].qatar == 1)
            {
                clbAgenteOrigen.Items.Add("QATAR", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("QATAR", false);
            }
            if (mAgenteOrigen[fila1].reino_unido == 1)
            {
                clbAgenteOrigen.Items.Add("REINO UNIDO", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("REINO UNIDO", false);
            }
            if (mAgenteOrigen[fila1].republica_dominicana == 1)
            {
                clbAgenteOrigen.Items.Add("REPUBLICA DOMINICANA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("REPUBLICA DOMINICANA", false);
            }
            if (mAgenteOrigen[fila1].rusia == 1)
            {
                clbAgenteOrigen.Items.Add("RUSIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("RUSIA", false);
            }
            if (mAgenteOrigen[fila1].salvador == 1)
            {
                clbAgenteOrigen.Items.Add("EL SALVADOR", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("EL SALVADOR", false);
            }
            if (mAgenteOrigen[fila1].singapur == 1)
            {
                clbAgenteOrigen.Items.Add("SINGAPUR", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("SINGAPUR", false);
            }
            if (mAgenteOrigen[fila1].sudafrica == 1)
            {
                clbAgenteOrigen.Items.Add("SUDAFRICA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("SUDAFRICA", false);
            }
            if (mAgenteOrigen[fila1].suecia == 1)
            {
                clbAgenteOrigen.Items.Add("SUECIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("SUECIA", false);
            }
            if (mAgenteOrigen[fila1].suiza == 1)
            {
                clbAgenteOrigen.Items.Add("SUIZA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("SUIZA", false);
            }
            if (mAgenteOrigen[fila1].thailandia == 1)
            {
                clbAgenteOrigen.Items.Add("THAILANDIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("THAILANDIA", false);
            }
            if (mAgenteOrigen[fila1].taiwan == 1)
            {
                clbAgenteOrigen.Items.Add("TAIWAN", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("TAIWAN", false);
            }
            if (mAgenteOrigen[fila1].tunez == 1)
            {
                clbAgenteOrigen.Items.Add("TUNEZ", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("TUNEZ", false);
            }
            if (mAgenteOrigen[fila1].turquia == 1)
            {
                clbAgenteOrigen.Items.Add("TURQUIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("TURQUIA", false);
            }
            if (mAgenteOrigen[fila1].ucrania == 1)
            {
                clbAgenteOrigen.Items.Add("UCRANIA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("UCRANIA", false);
            }
            if (mAgenteOrigen[fila1].uruguay == 1)
            {
                clbAgenteOrigen.Items.Add("URUGUAY", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("URUGUAY", false);
            }
            if (mAgenteOrigen[fila1].usa == 1)
            {
                clbAgenteOrigen.Items.Add("USA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("USA", false);
            }
            if (mAgenteOrigen[fila1].venezuela == 1)
            {
                clbAgenteOrigen.Items.Add("VENEZUELA", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("VENEZUELA", false);
            }
            if (mAgenteOrigen[fila1].vietnam == 1)
            {
                clbAgenteOrigen.Items.Add("VIETNAM", true);
            }
            else
            {
                clbAgenteOrigen.Items.Add("VIETNAM", false);
            }

            if (dgvAgenteOrigen.Columns[e.ColumnIndex].Name == "editarAgenteOrigen")
            {
                btnAgenteOrigen.Text = "EDITAR";
            }

            if (dgvAgenteOrigen.Columns[e.ColumnIndex].Name == "eliminarAgenteOrigen")
            {
                btnAgenteOrigen.Text = "ELIMINAR";
            }
        }

        private void btnAgenteOrigen_Click_1(object sender, EventArgs e)
        {
            if (btnAgenteOrigen.Text == "AGREGAR")
            {
                cargarDatosGuardadosAgenteOrigen();
                if (mAgenteOrigenConsultas.agregarAgenteOrigen(mAgenteOrigen1))
                {
                    MessageBox.Show("AGENTE ORIGEN AGREGADO");
                    cargarAGENTEORIGEN();
                    limpiarCampos();
                }

            }
            else if (btnAgenteOrigen.Text == "EDITAR")
            {
                cargarDatosGuardadosAgenteOrigen();
                if (mAgenteOrigenConsultas.modificarAgenteOrigen(mAgenteOrigen1))
                {
                    MessageBox.Show("AGENTE ORIGEN MODIFICADO");
                    cargarAGENTEORIGEN();
                    limpiarCampos();
                    btnAgenteOrigen.Text = "AGREGAR";
                }
            }
            else if (btnAgenteOrigen.Text == "ELIMINAR")
            {

                if (getIdAgenteOrigenIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL AGENTE ORIGEN?", "ELIMINAR AGENTE ORIGEN", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosAgenteOrigen();

                    if (mAgenteOrigenConsultas.eliminarAgenteOrigen(mAgenteOrigen1))
                    {
                        MessageBox.Show("AGENTE ORIGEN ELIMINADO");
                        cargarAGENTEORIGEN();
                        limpiarCampos();
                        btnAgenteOrigen.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvFleteInternacional_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            clbPaisesFleteInternacional.Items.Clear();
            clbViasFleteInternacional.Items.Clear();
            DataGridViewRow fila = dgvFleteInternacional.Rows[e.RowIndex];
            int fila1 = dgvFleteInternacional.CurrentCell.RowIndex;
            txtIdFleteInternacional.Text = Convert.ToString(fila.Cells["idFleteInternacional"].Value);
            txtFleteInternacional.Text = Convert.ToString(fila.Cells["proveedorFleteInternacional"].Value);
            txtThcFleteInternacional.Text = Convert.ToString(fila.Cells["thcFleteInternacional"].Value);
            txtDocFeeFleteInternacional.Text = Convert.ToString(fila.Cells["docFeeFleteInternacional"].Value);
            txtSecurityFleteInternacional.Text = Convert.ToString(fila.Cells["securityFleteInternacional"].Value);
            txtImpresionBLFleteInternacional.Text = Convert.ToString(fila.Cells["impresionBLFleteInternacional"].Value);
            txtPortFacilityFleteInternacional.Text = Convert.ToString(fila.Cells["portFacilityFleteInternacional"].Value);
            txtVacFleteInternacional.Text = Convert.ToString(fila.Cells["vacFleteInternacional"].Value);
            txtCanalFeeFleteInternacional.Text = Convert.ToString(fila.Cells["canalFeeFleteInternacional"].Value);
            txtImpdoFleteInternacional.Text = Convert.ToString(fila.Cells["impdoFleteInternacional"].Value);
            txtMerchantFleteInternacional.Text = Convert.ToString(fila.Cells["merchantFleteInternacional"].Value);
            if (mFleteInternacional[fila1].alemania == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ALEMANIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ALEMANIA", false);
            }
            if (mFleteInternacional[fila1].arabia_saudi == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ARABIA SAUDITA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ARABIA SAUDITA", false);
            }
            if (mFleteInternacional[fila1].argelia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ARGELIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ARGELIA", false);
            }
            if (mFleteInternacional[fila1].argentina == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ARGENTINA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ARGENTINA", false);
            }
            if (mFleteInternacional[fila1].australia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("AUSTRALIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("AUSTRALIA", false);
            }
            if (mFleteInternacional[fila1].austria == 1)
            {
                clbPaisesFleteInternacional.Items.Add("AUSTRIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("AUSTRIA", false);
            }
            if (mFleteInternacional[fila1].bahamas == 1)
            {
                clbPaisesFleteInternacional.Items.Add("BAHAMAS", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("BAHAMAS", false);
            }
            if (mFleteInternacional[fila1].bangladesh == 1)
            {
                clbPaisesFleteInternacional.Items.Add("BANGLADESH", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("BANGLADESH", false);
            }
            if (mFleteInternacional[fila1].barbados == 1)
            {
                clbPaisesFleteInternacional.Items.Add("BARBADOS", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("BARBADOS", false);
            }
            if (mFleteInternacional[fila1].belgica == 1)
            {
                clbPaisesFleteInternacional.Items.Add("BELGICA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("BELGICA", false);
            }
            if (mFleteInternacional[fila1].belice == 1)
            {
                clbPaisesFleteInternacional.Items.Add("BELICE", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("BELICE", false);
            }
            if (mFleteInternacional[fila1].bolivia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("BOLIVIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("BOLIVIA", false);
            }
            if (mFleteInternacional[fila1].brasil == 1)
            {
                clbPaisesFleteInternacional.Items.Add("BRASIL", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("BRASIL", false);
            }
            if (mFleteInternacional[fila1].canada == 1)
            {
                clbPaisesFleteInternacional.Items.Add("CANADA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("CANADA", false);
            }
            if (mFleteInternacional[fila1].chile == 1)
            {
                clbPaisesFleteInternacional.Items.Add("CHILE", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("CHILE", false);
            }
            if (mFleteInternacional[fila1].china == 1)
            {
                clbPaisesFleteInternacional.Items.Add("CHINA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("CHINA", false);
            }
            if (mFleteInternacional[fila1].colombia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("COLOMBIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("COLOMBIA", false);
            }
            if (mFleteInternacional[fila1].crc == 1)
            {
                clbPaisesFleteInternacional.Items.Add("COSTA RICA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("COSTA RICA", false);
            }
            if (mFleteInternacional[fila1].croacia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("CROACIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("CROACIA", false);
            }
            if (mFleteInternacional[fila1].cuba == 1)
            {
                clbPaisesFleteInternacional.Items.Add("CUBA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("CUBA", false);
            }
            if (mFleteInternacional[fila1].dinamarca == 1)
            {
                clbPaisesFleteInternacional.Items.Add("DINAMARCA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("DINAMARCA", false);
            }
            if (mFleteInternacional[fila1].dominica == 1)
            {
                clbPaisesFleteInternacional.Items.Add("DOMINICA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("DOMINICA", false);
            }
            if (mFleteInternacional[fila1].dubai == 1)
            {
                clbPaisesFleteInternacional.Items.Add("DUBAI", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("DUBAI", false);
            }
            if (mFleteInternacional[fila1].ecuador == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ECUADOR", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ECUADOR", false);
            }
            if (mFleteInternacional[fila1].egipto == 1)
            {
                clbPaisesFleteInternacional.Items.Add("EGIPTO", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("EGIPTO", false);
            }
            if (mFleteInternacional[fila1].eslovaquia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ESLOVAQUIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ESLOVAQUIA", false);
            }
            if (mFleteInternacional[fila1].eslovenia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ESLOVENIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ESLOVENIA", false);
            }
            if (mFleteInternacional[fila1].espana == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ESPAÑA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ESPAÑA", false);
            }
            if (mFleteInternacional[fila1].finlandia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("FINLANDIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("FINLANDIA", false);
            }
            if (mFleteInternacional[fila1].flipinas == 1)
            {
                clbPaisesFleteInternacional.Items.Add("FILIPINAS", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("FILIPINAS", false);
            }
            if (mFleteInternacional[fila1].francia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("FRANCIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("FRANCIA", false);
            }
            if (mFleteInternacional[fila1].grecia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("GRECIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("GRECIA", false);
            }
            if (mFleteInternacional[fila1].guatemala == 1)
            {
                clbPaisesFleteInternacional.Items.Add("GUATEMALA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("GUATEMALA", false);
            }
            if (mFleteInternacional[fila1].haiti == 1)
            {
                clbPaisesFleteInternacional.Items.Add("HAITI", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("HAITI", false);
            }
            if (mFleteInternacional[fila1].holanda == 1)
            {
                clbPaisesFleteInternacional.Items.Add("HOLANDA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("HOLANDA", false);
            }
            if (mFleteInternacional[fila1].honduras == 1)
            {
                clbPaisesFleteInternacional.Items.Add("HONDURAS", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("HONDURAS", false);
            }
            if (mFleteInternacional[fila1].hungria == 1)
            {
                clbPaisesFleteInternacional.Items.Add("HUNGRIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("HUNGRIA", false);
            }
            if (mFleteInternacional[fila1].india == 1)
            {
                clbPaisesFleteInternacional.Items.Add("INDIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("INDIA", false);
            }
            if (mFleteInternacional[fila1].indonesia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("INDONESIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("INDONESIA", false);
            }
            if (mFleteInternacional[fila1].irlandia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("IRLANDIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("IRLANDIA", false);
            }
            if (mFleteInternacional[fila1].islandia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ISLANDIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ISLANDIA", false);
            }
            if (mFleteInternacional[fila1].israel == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ISRAEL", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ISRAEL", false);
            }
            if (mFleteInternacional[fila1].italia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("ITALIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("ITALIA", false);
            }
            if (mFleteInternacional[fila1].jamaica == 1)
            {
                clbPaisesFleteInternacional.Items.Add("JAMAICA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("JAMAICA", false);
            }
            if (mFleteInternacional[fila1].japon == 1)
            {
                clbPaisesFleteInternacional.Items.Add("JAPON", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("JAPON", false);
            }
            if (mFleteInternacional[fila1].korea == 1)
            {
                clbPaisesFleteInternacional.Items.Add("KOREA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("KOREA", false);
            }
            if (mFleteInternacional[fila1].luxemburgo == 1)
            {
                clbPaisesFleteInternacional.Items.Add("LUXEMBURGO", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("LUXEMBURGO", false);
            }
            if (mFleteInternacional[fila1].malasia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("MALASIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("MALASIA", false);
            }
            if (mFleteInternacional[fila1].maldivas == 1)
            {
                clbPaisesFleteInternacional.Items.Add("MALDIVAS", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("MALDIVAS", false);
            }
            if (mFleteInternacional[fila1].marruecos == 1)
            {
                clbPaisesFleteInternacional.Items.Add("MARRUECOS", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("MARRUECOS", false);
            }
            if (mFleteInternacional[fila1].maxico == 1)
            {
                clbPaisesFleteInternacional.Items.Add("MEXICO", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("MEXICO", false);
            }
            if (mFleteInternacional[fila1].monaco == 1)
            {
                clbPaisesFleteInternacional.Items.Add("MONACO", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("MONACO", false);
            }
            if (mFleteInternacional[fila1].mongolia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("MONGOLIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("MONGOLIA", false);
            }
            if (mFleteInternacional[fila1].nepal == 1)
            {
                clbPaisesFleteInternacional.Items.Add("NEPAL", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("NEPAL", false);
            }
            if (mFleteInternacional[fila1].nicaragua == 1)
            {
                clbPaisesFleteInternacional.Items.Add("NICARAGUA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("NICARAGUA", false);
            }
            if (mFleteInternacional[fila1].noruega == 1)
            {
                clbPaisesFleteInternacional.Items.Add("NORUEGA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("NORUEGA", false);
            }
            if (mFleteInternacional[fila1].nueva_zelanda == 1)
            {
                clbPaisesFleteInternacional.Items.Add("NUEVA ZELANDA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("NUEVA ZELANDA", false);
            }
            if (mFleteInternacional[fila1].panama == 1)
            {
                clbPaisesFleteInternacional.Items.Add("PANAMA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("PANAMA", false);
            }
            if (mFleteInternacional[fila1].paraguay == 1)
            {
                clbPaisesFleteInternacional.Items.Add("PARAGUAY", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("PARAGUAY", false);
            }
            if (mFleteInternacional[fila1].peru == 1)
            {
                clbPaisesFleteInternacional.Items.Add("PERU", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("PERU", false);
            }
            if (mFleteInternacional[fila1].polonia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("POLONIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("POLONIA", false);
            }
            if (mFleteInternacional[fila1].portugal == 1)
            {
                clbPaisesFleteInternacional.Items.Add("PORTUGAL", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("PORTUGAL", false);
            }
            if (mFleteInternacional[fila1].qatar == 1)
            {
                clbPaisesFleteInternacional.Items.Add("QATAR", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("QATAR", false);
            }
            if (mFleteInternacional[fila1].reino_unido == 1)
            {
                clbPaisesFleteInternacional.Items.Add("REINO UNIDO", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("REINO UNIDO", false);
            }
            if (mFleteInternacional[fila1].republica_dominicana == 1)
            {
                clbPaisesFleteInternacional.Items.Add("REPUBLICA DOMINICANA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("REPUBLICA DOMINICANA", false);
            }
            if (mFleteInternacional[fila1].rusia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("RUSIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("RUSIA", false);
            }
            if (mFleteInternacional[fila1].salvador == 1)
            {
                clbPaisesFleteInternacional.Items.Add("EL SALVADOR", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("EL SALVADOR", false);
            }
            if (mFleteInternacional[fila1].singapur == 1)
            {
                clbPaisesFleteInternacional.Items.Add("SINGAPUR", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("SINGAPUR", false);
            }
            if (mFleteInternacional[fila1].sudafrica == 1)
            {
                clbPaisesFleteInternacional.Items.Add("SUDAFRICA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("SUDAFRICA", false);
            }
            if (mFleteInternacional[fila1].suecia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("SUECIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("SUECIA", false);
            }
            if (mFleteInternacional[fila1].suiza == 1)
            {
                clbPaisesFleteInternacional.Items.Add("SUIZA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("SUIZA", false);
            }
            if (mFleteInternacional[fila1].thailandia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("THAILANDIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("THAILANDIA", false);
            }
            if (mFleteInternacional[fila1].taiwan == 1)
            {
                clbPaisesFleteInternacional.Items.Add("TAIWAN", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("TAIWAN", false);
            }
            if (mFleteInternacional[fila1].tunez == 1)
            {
                clbPaisesFleteInternacional.Items.Add("TUNEZ", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("TUNEZ", false);
            }
            if (mFleteInternacional[fila1].turquia == 1)
            {
                clbPaisesFleteInternacional.Items.Add("TURQUIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("TURQUIA", false);
            }
            if (mFleteInternacional[fila1].ucrania == 1)
            {
                clbPaisesFleteInternacional.Items.Add("UCRANIA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("UCRANIA", false);
            }
            if (mFleteInternacional[fila1].uruguay == 1)
            {
                clbPaisesFleteInternacional.Items.Add("URUGUAY", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("URUGUAY", false);
            }
            if (mFleteInternacional[fila1].usa == 1)
            {
                clbPaisesFleteInternacional.Items.Add("USA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("USA", false);
            }
            if (mFleteInternacional[fila1].venezuela == 1)
            {
                clbPaisesFleteInternacional.Items.Add("VENEZUELA", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("VENEZUELA", false);
            }
            if (mFleteInternacional[fila1].vietnam == 1)
            {
                clbPaisesFleteInternacional.Items.Add("VIETNAM", true);
            }
            else
            {
                clbPaisesFleteInternacional.Items.Add("VIETNAM", false);
            }

            if (mFleteInternacional[fila1].rodman == 1)
            {
                clbViasFleteInternacional.Items.Add("RODMAN", true);
            }
            else
            {
                clbViasFleteInternacional.Items.Add("RODMAN", false);
            }
            if (mFleteInternacional[fila1].cristobal == 1)
            {
                clbViasFleteInternacional.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbViasFleteInternacional.Items.Add("CRISTOBAL", false);
            }
            if (mFleteInternacional[fila1].manzanillo == 1)
            {
                clbViasFleteInternacional.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbViasFleteInternacional.Items.Add("MANZANILLO", false);
            }
            if (mFleteInternacional[fila1].balboa == 1)
            {
                clbViasFleteInternacional.Items.Add("BALBOA", true);
            }
            else
            {
                clbViasFleteInternacional.Items.Add("BALBOA", false);
            }
            if (mFleteInternacional[fila1].moin == 1)
            {
                clbViasFleteInternacional.Items.Add("MOIN", true);
            }
            else
            {
                clbViasFleteInternacional.Items.Add("MOIN", false);
            }
            if (mFleteInternacional[fila1].caldera == 1)
            {
                clbViasFleteInternacional.Items.Add("CALDERA", true);
            }
            else
            {
                clbViasFleteInternacional.Items.Add("CALDERA", false);
            }
            if (mFleteInternacional[fila1].no_aplica == 1)
            {
                clbViasFleteInternacional.Items.Add("NO APLICA", true);
            }
            else
            {
                clbViasFleteInternacional.Items.Add("NO APLICA", false);
            }

            if (dgvFleteInternacional.Columns[e.ColumnIndex].Name == "editarFleteInternacional")
            {
                btnFleteInternacional.Text = "EDITAR";
            }

            if (dgvFleteInternacional.Columns[e.ColumnIndex].Name == "eliminarFleteInternacional")
            {
                btnFleteInternacional.Text = "ELIMINAR";
            }
        }

        private void btnFleteInternacional_Click_1(object sender, EventArgs e)
        {
            if (btnFleteInternacional.Text == "AGREGAR")
            {
                cargarDatosGuardadosFleteInternacional();
                if (mFleteInternacionalConsultas.agregarFleteInternacional(mFleteInternacional1))
                {
                    MessageBox.Show("FLETE INTERNACIONAL AGREGADO");
                    cargarFLETEINTERNACIONAL();
                    limpiarCampos();
                }

            }
            else if (btnFleteInternacional.Text == "EDITAR")
            {
                cargarDatosGuardadosFleteInternacional();
                if (mFleteInternacionalConsultas.modificarFleteInternacional(mFleteInternacional1))
                {
                    MessageBox.Show("FLETE INTERNACIONAL MODIFICADO");
                    cargarFLETEINTERNACIONAL();
                    limpiarCampos();
                    btnFleteInternacional.Text = "AGREGAR";
                }
            }
            else if (btnFleteInternacional.Text == "ELIMINAR")
            {

                if (getIdFleteInternacionalIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL FLETE INTERNACIONAL?", "ELIMINAR FLETE INTERNACIONAL", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosFleteInternacional();

                    if (mFleteInternacionalConsultas.eliminarFleteInternacional(mFleteInternacional1))
                    {
                        MessageBox.Show("FLETE INTERNCIONAL ELIMINADO");
                        cargarFLETEINTERNACIONAL();
                        limpiarCampos();
                        btnFleteInternacional.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvGastosPortuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbGastosPortuarios.Items.Clear();
            DataGridViewRow fila = dgvGastosPortuarios.Rows[e.RowIndex];
            int fila1 = dgvGastosPortuarios.CurrentCell.RowIndex;
            txtIdGastosPortuarios.Text = Convert.ToString(fila.Cells["idGastosPortuarios"].Value);
            txtProveedorGastosPortuarios.Text = Convert.ToString(fila.Cells["proveedorGastosPortuarios"].Value);
            txtGastosPortuarios.Text = Convert.ToString(fila.Cells["gastosPortuarios"].Value);
            if (mGastosPortuarios[fila1].rodman == 1)
            {
                clbGastosPortuarios.Items.Add("RODMAN", true);
            }
            else
            {
                clbGastosPortuarios.Items.Add("RODMAN", false);
            }
            if (mGastosPortuarios[fila1].cristobal == 1)
            {
                clbGastosPortuarios.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbGastosPortuarios.Items.Add("CRISTOBAL", false);
            }
            if (mGastosPortuarios[fila1].manzanillo == 1)
            {
                clbGastosPortuarios.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbGastosPortuarios.Items.Add("MANZANILLO", false);
            }
            if (mGastosPortuarios[fila1].balboa == 1)
            {
                clbGastosPortuarios.Items.Add("BALBOA", true);
            }
            else
            {
                clbGastosPortuarios.Items.Add("BALBOA", false);
            }

            if (dgvGastosPortuarios.Columns[e.ColumnIndex].Name == "editarGastosPortuarios")
            {
                btnGastosPortuarios.Text = "EDITAR";
            }

            if (dgvGastosPortuarios.Columns[e.ColumnIndex].Name == "eliminarGastosPortuarios")
            {
                btnGastosPortuarios.Text = "ELIMINAR";
            }
        }

        private void dgvMovimientoPuertoBodega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbMovimientoPuertoBodega.Items.Clear();
            DataGridViewRow fila = dgvMovimientoPuertoBodega.Rows[e.RowIndex];
            int fila1 = dgvMovimientoPuertoBodega.CurrentCell.RowIndex;
            txtIdMovimientoPuertoBodega.Text = Convert.ToString(fila.Cells["idMovimientoPuertoBodega"].Value);
            txtProveedorMovimientoPuertoBodega.Text = Convert.ToString(fila.Cells["proveedorMovimientoPuertoBodega"].Value);
            txtMovimientoPuertoBodega.Text = Convert.ToString(fila.Cells["movimientoPuertoBodega"].Value);
            if (mMovimientoPuertoBodega[fila1].rodman == 1)
            {
                clbMovimientoPuertoBodega.Items.Add("RODMAN", true);
            }
            else
            {
                clbMovimientoPuertoBodega.Items.Add("RODMAN", false);
            }
            if (mMovimientoPuertoBodega[fila1].cristobal == 1)
            {
                clbMovimientoPuertoBodega.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbMovimientoPuertoBodega.Items.Add("CRISTOBAL", false);
            }
            if (mMovimientoPuertoBodega[fila1].manzanillo == 1)
            {
                clbMovimientoPuertoBodega.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbMovimientoPuertoBodega.Items.Add("MANZANILLO", false);
            }
            if (mMovimientoPuertoBodega[fila1].balboa == 1)
            {
                clbMovimientoPuertoBodega.Items.Add("BALBOA", true);
            }
            else
            {
                clbMovimientoPuertoBodega.Items.Add("BALBOA", false);
            }

            if (dgvMovimientoPuertoBodega.Columns[e.ColumnIndex].Name == "editarMovimientoPuertoBodega")
            {
                btnMovimientoPuertoBodega.Text = "EDITAR";
            }

            if (dgvMovimientoPuertoBodega.Columns[e.ColumnIndex].Name == "eliminarMovimientoPuertoBodega")
            {
                btnMovimientoPuertoBodega.Text = "ELIMINAR";
            }
        }

        private void btnMovimientoPuertoBodega_Click(object sender, EventArgs e)
        {
            if (btnMovimientoPuertoBodega.Text == "AGREGAR")
            {
                cargarDatosGuardadosMovimientoPuertoBodega();
                if (mMovimientoPuertoBodegaConsultas.agregarMovimientoPuertoBodega(mMovimientoPuertoBodega1))
                {
                    MessageBox.Show("MOVIMIENTO PUERTO BODEGA AGREGADO");
                    cargarMOVIMIENTOPUERTOBODEGA();
                    limpiarCampos();
                }

            }
            else if (btnMovimientoPuertoBodega.Text == "EDITAR")
            {
                cargarDatosGuardadosMovimientoPuertoBodega();
                if (mMovimientoPuertoBodegaConsultas.modificarMovimientoPuertoBodega(mMovimientoPuertoBodega1))
                {
                    MessageBox.Show("MOVIMIENTO PUERTO BODEGA MODIFICADO");
                    cargarMOVIMIENTOPUERTOBODEGA();
                    limpiarCampos();
                    btnMovimientoPuertoBodega.Text = "AGREGAR";
                }
            }
            else if (btnMovimientoPuertoBodega.Text == "ELIMINAR")
            {

                if (getIdMovimientoPuertoBodegaIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL MOVIMIENTO PUERTO BODEGA?", "ELIMINAR MOVIMIENTO PUERTO BODEGA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosMovimientoPuertoBodega();

                    if (mMovimientoPuertoBodegaConsultas.eliminarMovimientoPuertoBodega(mMovimientoPuertoBodega1))
                    {
                        MessageBox.Show("MOVIMIENTO PUERTO BODEGA ELIMINADO");
                        cargarMOVIMIENTOPUERTOBODEGA();
                        limpiarCampos();
                        btnMovimientoPuertoBodega.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvOtrasCategorias_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            clbOtrasCategorias.Items.Clear();
            DataGridViewRow fila = dgvOtrasCategorias.Rows[e.RowIndex];
            int fila1 = dgvOtrasCategorias.CurrentCell.RowIndex;
            txtIdOtrasCategorias.Text = Convert.ToString(fila.Cells["idOtrasCategorias"].Value);
            txtProveedorOtrasCategorias.Text = Convert.ToString(fila.Cells["proveedorOtrasCategorias"].Value);
            txtServicioOtrasCategorias.Text = Convert.ToString(fila.Cells["servicioOtrasCategorias"].Value);
            txtCostoOtrasCategorias.Text = Convert.ToString(fila.Cells["costoOtrasCategorias"].Value);
            if (mOtrasCategorias[fila1].rodman == 1)
            {
                clbOtrasCategorias.Items.Add("RODMAN", true);
            }
            else
            {
                clbOtrasCategorias.Items.Add("RODMAN", false);
            }
            if (mOtrasCategorias[fila1].cristobal == 1)
            {
                clbOtrasCategorias.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbOtrasCategorias.Items.Add("CRISTOBAL", false);
            }
            if (mOtrasCategorias[fila1].manzanillo == 1)
            {
                clbOtrasCategorias.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbOtrasCategorias.Items.Add("MANZANILLO", false);
            }
            if (mOtrasCategorias[fila1].balboa == 1)
            {
                clbOtrasCategorias.Items.Add("BALBOA", true);
            }
            else
            {
                clbOtrasCategorias.Items.Add("BALBOA", false);
            }

            if (dgvOtrasCategorias.Columns[e.ColumnIndex].Name == "editarOtrasCategorias")
            {
                btnOtrasCategorias.Text = "EDITAR";
            }

            if (dgvOtrasCategorias.Columns[e.ColumnIndex].Name == "eliminarOtrasCategorias")
            {
                btnOtrasCategorias.Text = "ELIMINAR";
            }
        }

        private void btnOtrasCategorias_Click_1(object sender, EventArgs e)
        {
            if (btnOtrasCategorias.Text == "AGREGAR")
            {
                cargarDatosGuardadosOtrasCategorias();
                if (mOtrasCategoriasConsultas.agregarOtrasCategorias(mOtrasCategorias1))
                {
                    MessageBox.Show("OTRAS CATEGORIAS AGREGADO");
                    cargarOTRASCATEGORIAS();
                    limpiarCampos();
                }

            }
            else if (btnOtrasCategorias.Text == "EDITAR")
            {
                cargarDatosGuardadosOtrasCategorias();
                if (mOtrasCategoriasConsultas.modificarOtrasCategorias(mOtrasCategorias1))
                {
                    MessageBox.Show("OTRAS CATEGORIAS MODIFICADO");
                    cargarOTRASCATEGORIAS();
                    limpiarCampos();
                    btnOtrasCategorias.Text = "AGREGAR";
                }
            }
            else if (btnOtrasCategorias.Text == "ELIMINAR")
            {

                if (getIdOtrasCategoriasIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR LAS OTRAS CATEGORIAS?", "ELIMINAR OTRAS CATEGORIAS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosOtrasCategorias();

                    if (mOtrasCategoriasConsultas.eliminarOtrasCategorias(mOtrasCategorias1))
                    {
                        MessageBox.Show("OTRAS CATEGORIAS ELIMINADO");
                        cargarOTRASCATEGORIAS();
                        limpiarCampos();
                        btnOtrasCategorias.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvOtrosServicios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            clbOtrosServicios.Items.Clear();
            DataGridViewRow fila = dgvOtrosServicios.Rows[e.RowIndex];
            int fila1 = dgvOtrosServicios.CurrentCell.RowIndex;
            txtIdOtrosServicios.Text = Convert.ToString(fila.Cells["idOtrosServicios"].Value);
            txtProveedorOtrosServicios.Text = Convert.ToString(fila.Cells["proveedorOtrosServicios"].Value);
            txtServiciosOtrosServicios.Text = Convert.ToString(fila.Cells["servicioOtrosServicios"].Value);
            txtCostoOtrosServicios.Text = Convert.ToString(fila.Cells["costoOtrosServicios"].Value);
            if (mOtrosServicios[fila1].rodman == 1)
            {
                clbOtrosServicios.Items.Add("RODMAN", true);
            }
            else
            {
                clbOtrosServicios.Items.Add("RODMAN", false);
            }
            if (mOtrosServicios[fila1].cristobal == 1)
            {
                clbOtrosServicios.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbOtrosServicios.Items.Add("CRISTOBAL", false);
            }
            if (mOtrosServicios[fila1].manzanillo == 1)
            {
                clbOtrosServicios.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbOtrosServicios.Items.Add("MANZANILLO", false);
            }
            if (mOtrosServicios[fila1].balboa == 1)
            {
                clbOtrosServicios.Items.Add("BALBOA", true);
            }
            else
            {
                clbOtrosServicios.Items.Add("BALBOA", false);
            }

            if (dgvOtrosServicios.Columns[e.ColumnIndex].Name == "editarOtrosServicios")
            {
                btnOtrosServicios.Text = "EDITAR";
            }

            if (dgvOtrosServicios.Columns[e.ColumnIndex].Name == "eliminarOtrosServicios")
            {
                btnOtrosServicios.Text = "ELIMINAR";
            }
        }

        private void btnGastosPortuarios_Click_1(object sender, EventArgs e)
        {
            if (btnGastosPortuarios.Text == "AGREGAR")
            {
                cargarDatosGuardadosGastosPortuarios();
                if (mGastosPortuariosConsultas.agregarGastosPortuarios(mGastosPortuarios1))
                {
                    MessageBox.Show("GASTOS PORTUARIOS AGREGADO");
                    cargarGASTOSPORTUARIOS();
                    limpiarCampos();
                }

            }
            else if (btnGastosPortuarios.Text == "EDITAR")
            {
                cargarDatosGuardadosGastosPortuarios();
                if (mGastosPortuariosConsultas.modificarGastosPortuarios(mGastosPortuarios1))
                {
                    MessageBox.Show("GASTOS PORTUARIOS MODIFICADO");
                    cargarGASTOSPORTUARIOS();
                    limpiarCampos();
                    btnGastosPortuarios.Text = "AGREGAR";
                }
            }
            else if (btnGastosPortuarios.Text == "ELIMINAR")
            {

                if (getIdGastosPortuariosIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL GASTOS PORTUARIOS?", "ELIMINAR GASTOS PORTUARIOS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosGastosPortuarios();

                    if (mGastosPortuariosConsultas.eliminarGastosPortuarios(mGastosPortuarios1))
                    {
                        MessageBox.Show("GASTOS PORTUARIOS ELIMINADO");
                        cargarGASTOSPORTUARIOS();
                        limpiarCampos();
                        btnGastosPortuarios.Text = "AGREGAR";
                    }
                }
            }
        }

        private void btnOtrosServicios_Click_1(object sender, EventArgs e)
        {
            if (btnOtrosServicios.Text == "AGREGAR")
            {
                cargarDatosGuardadosOtrosServicios();
                if (mOtrosServiciosConsultas.agregarOtrosServicios(mOtrosServicios1))
                {
                    MessageBox.Show("OTROS SERVICIOS AGREGADO");
                    cargarOTROSSERVICIOS();
                    limpiarCampos();
                }

            }
            else if (btnOtrosServicios.Text == "EDITAR")
            {
                cargarDatosGuardadosOtrosServicios();
                if (mOtrosServiciosConsultas.modificarOtrosServicios(mOtrosServicios1))
                {
                    MessageBox.Show("OTROS SERVICIOS MODIFICADO");
                    cargarOTROSSERVICIOS();
                    limpiarCampos();
                    btnOtrosServicios.Text = "AGREGAR";
                }
            }
            else if (btnOtrosServicios.Text == "ELIMINAR")
            {

                if (getIdOtrosServiciosIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR LOS OTROS SERVICIOS?", "ELIMINAR OTROS SERVICIOS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosOtrosServicios();

                    if (mOtrosServiciosConsultas.eliminarOtrosServicios(mOtrosServicios1))
                    {
                        MessageBox.Show("OTROS SERVICIOS ELIMINADO");
                        cargarOTROSSERVICIOS();
                        limpiarCampos();
                        btnOtrosServicios.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvCargpsDestino_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            clbCargosDestino.Items.Clear();
            clbViasDestino.Items.Clear();
            DataGridViewRow fila = dgvCargpsDestino.Rows[e.RowIndex];
            int fila1 = dgvCargpsDestino.CurrentCell.RowIndex;
            txtIdCargosDestino.Text = Convert.ToString(fila.Cells["idCargosDestino"].Value);
            txtCargosDestino.Text = Convert.ToString(fila.Cells["proveedorCargosDestino"].Value);
            txtFleteCargosDestino.Text = Convert.ToString(fila.Cells["fleteCargosDestino"].Value);
            if (mCargosDestino[fila1].alemania == 1)
            {
                clbCargosDestino.Items.Add("ALEMANIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ALEMANIA", false);
            }
            if (mCargosDestino[fila1].arabia_saudi == 1)
            {
                clbCargosDestino.Items.Add("ARABIA SAUDITA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ARABIA SAUDITA", false);
            }
            if (mCargosDestino[fila1].argelia == 1)
            {
                clbCargosDestino.Items.Add("ARGELIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ARGELIA", false);
            }
            if (mCargosDestino[fila1].argentina == 1)
            {
                clbCargosDestino.Items.Add("ARGENTINA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ARGENTINA", false);
            }
            if (mCargosDestino[fila1].australia == 1)
            {
                clbCargosDestino.Items.Add("AUSTRALIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("AUSTRALIA", false);
            }
            if (mCargosDestino[fila1].austria == 1)
            {
                clbCargosDestino.Items.Add("AUSTRIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("AUSTRIA", false);
            }
            if (mCargosDestino[fila1].bahamas == 1)
            {
                clbCargosDestino.Items.Add("BAHAMAS", true);
            }
            else
            {
                clbCargosDestino.Items.Add("BAHAMAS", false);
            }
            if (mCargosDestino[fila1].bangladesh == 1)
            {
                clbCargosDestino.Items.Add("BANGLADESH", true);
            }
            else
            {
                clbCargosDestino.Items.Add("BANGLADESH", false);
            }
            if (mCargosDestino[fila1].barbados == 1)
            {
                clbCargosDestino.Items.Add("BARBADOS", true);
            }
            else
            {
                clbCargosDestino.Items.Add("BARBADOS", false);
            }
            if (mCargosDestino[fila1].belgica == 1)
            {
                clbCargosDestino.Items.Add("BELGICA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("BELGICA", false);
            }
            if (mCargosDestino[fila1].belice == 1)
            {
                clbCargosDestino.Items.Add("BELICE", true);
            }
            else
            {
                clbCargosDestino.Items.Add("BELICE", false);
            }
            if (mCargosDestino[fila1].bolivia == 1)
            {
                clbCargosDestino.Items.Add("BOLIVIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("BOLIVIA", false);
            }
            if (mCargosDestino[fila1].brasil == 1)
            {
                clbCargosDestino.Items.Add("BRASIL", true);
            }
            else
            {
                clbCargosDestino.Items.Add("BRASIL", false);
            }
            if (mCargosDestino[fila1].canada == 1)
            {
                clbCargosDestino.Items.Add("CANADA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("CANADA", false);
            }
            if (mCargosDestino[fila1].chile == 1)
            {
                clbCargosDestino.Items.Add("CHILE", true);
            }
            else
            {
                clbCargosDestino.Items.Add("CHILE", false);
            }
            if (mCargosDestino[fila1].china == 1)
            {
                clbCargosDestino.Items.Add("CHINA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("CHINA", false);
            }
            if (mCargosDestino[fila1].colombia == 1)
            {
                clbCargosDestino.Items.Add("COLOMBIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("COLOMBIA", false);
            }
            if (mCargosDestino[fila1].crc == 1)
            {
                clbCargosDestino.Items.Add("COSTA RICA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("COSTA RICA", false);
            }
            if (mCargosDestino[fila1].croacia == 1)
            {
                clbCargosDestino.Items.Add("CROACIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("CROACIA", false);
            }
            if (mCargosDestino[fila1].cuba == 1)
            {
                clbCargosDestino.Items.Add("CUBA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("CUBA", false);
            }
            if (mCargosDestino[fila1].dinamarca == 1)
            {
                clbCargosDestino.Items.Add("DINAMARCA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("DINAMARCA", false);
            }
            if (mCargosDestino[fila1].dominica == 1)
            {
                clbCargosDestino.Items.Add("DOMINICA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("DOMINICA", false);
            }
            if (mCargosDestino[fila1].dubai == 1)
            {
                clbCargosDestino.Items.Add("DUBAI", true);
            }
            else
            {
                clbCargosDestino.Items.Add("DUBAI", false);
            }
            if (mCargosDestino[fila1].ecuador == 1)
            {
                clbCargosDestino.Items.Add("ECUADOR", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ECUADOR", false);
            }
            if (mCargosDestino[fila1].egipto == 1)
            {
                clbCargosDestino.Items.Add("EGIPTO", true);
            }
            else
            {
                clbCargosDestino.Items.Add("EGIPTO", false);
            }
            if (mCargosDestino[fila1].eslovaquia == 1)
            {
                clbCargosDestino.Items.Add("ESLOVAQUIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ESLOVAQUIA", false);
            }
            if (mCargosDestino[fila1].eslovenia == 1)
            {
                clbCargosDestino.Items.Add("ESLOVENIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ESLOVENIA", false);
            }
            if (mCargosDestino[fila1].espana == 1)
            {
                clbCargosDestino.Items.Add("ESPAÑA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ESPAÑA", false);
            }
            if (mCargosDestino[fila1].finlandia == 1)
            {
                clbCargosDestino.Items.Add("FINLANDIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("FINLANDIA", false);
            }
            if (mCargosDestino[fila1].flipinas == 1)
            {
                clbCargosDestino.Items.Add("FILIPINAS", true);
            }
            else
            {
                clbCargosDestino.Items.Add("FILIPINAS", false);
            }
            if (mCargosDestino[fila1].francia == 1)
            {
                clbCargosDestino.Items.Add("FRANCIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("FRANCIA", false);
            }
            if (mCargosDestino[fila1].grecia == 1)
            {
                clbCargosDestino.Items.Add("GRECIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("GRECIA", false);
            }
            if (mCargosDestino[fila1].guatemala == 1)
            {
                clbCargosDestino.Items.Add("GUATEMALA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("GUATEMALA", false);
            }
            if (mCargosDestino[fila1].haiti == 1)
            {
                clbCargosDestino.Items.Add("HAITI", true);
            }
            else
            {
                clbCargosDestino.Items.Add("HAITI", false);
            }
            if (mCargosDestino[fila1].holanda == 1)
            {
                clbCargosDestino.Items.Add("HOLANDA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("HOLANDA", false);
            }
            if (mCargosDestino[fila1].honduras == 1)
            {
                clbCargosDestino.Items.Add("HONDURAS", true);
            }
            else
            {
                clbCargosDestino.Items.Add("HONDURAS", false);
            }
            if (mCargosDestino[fila1].hungria == 1)
            {
                clbCargosDestino.Items.Add("HUNGRIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("HUNGRIA", false);
            }
            if (mCargosDestino[fila1].india == 1)
            {
                clbCargosDestino.Items.Add("INDIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("INDIA", false);
            }
            if (mCargosDestino[fila1].indonesia == 1)
            {
                clbCargosDestino.Items.Add("INDONESIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("INDONESIA", false);
            }
            if (mCargosDestino[fila1].irlandia == 1)
            {
                clbCargosDestino.Items.Add("IRLANDIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("IRLANDIA", false);
            }
            if (mCargosDestino[fila1].islandia == 1)
            {
                clbCargosDestino.Items.Add("ISLANDIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ISLANDIA", false);
            }
            if (mCargosDestino[fila1].israel == 1)
            {
                clbCargosDestino.Items.Add("ISRAEL", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ISRAEL", false);
            }
            if (mCargosDestino[fila1].italia == 1)
            {
                clbCargosDestino.Items.Add("ITALIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("ITALIA", false);
            }
            if (mCargosDestino[fila1].jamaica == 1)
            {
                clbCargosDestino.Items.Add("JAMAICA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("JAMAICA", false);
            }
            if (mCargosDestino[fila1].japon == 1)
            {
                clbCargosDestino.Items.Add("JAPON", true);
            }
            else
            {
                clbCargosDestino.Items.Add("JAPON", false);
            }
            if (mCargosDestino[fila1].korea == 1)
            {
                clbCargosDestino.Items.Add("KOREA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("KOREA", false);
            }
            if (mCargosDestino[fila1].luxemburgo == 1)
            {
                clbCargosDestino.Items.Add("LUXEMBURGO", true);
            }
            else
            {
                clbCargosDestino.Items.Add("LUXEMBURGO", false);
            }
            if (mCargosDestino[fila1].malasia == 1)
            {
                clbCargosDestino.Items.Add("MALASIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("MALASIA", false);
            }
            if (mCargosDestino[fila1].maldivas == 1)
            {
                clbCargosDestino.Items.Add("MALDIVAS", true);
            }
            else
            {
                clbCargosDestino.Items.Add("MALDIVAS", false);
            }
            if (mCargosDestino[fila1].marruecos == 1)
            {
                clbCargosDestino.Items.Add("MARRUECOS", true);
            }
            else
            {
                clbCargosDestino.Items.Add("MARRUECOS", false);
            }
            if (mCargosDestino[fila1].maxico == 1)
            {
                clbCargosDestino.Items.Add("MEXICO", true);
            }
            else
            {
                clbCargosDestino.Items.Add("MEXICO", false);
            }
            if (mCargosDestino[fila1].monaco == 1)
            {
                clbCargosDestino.Items.Add("MONACO", true);
            }
            else
            {
                clbCargosDestino.Items.Add("MONACO", false);
            }
            if (mCargosDestino[fila1].mongolia == 1)
            {
                clbCargosDestino.Items.Add("MONGOLIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("MONGOLIA", false);
            }
            if (mCargosDestino[fila1].nepal == 1)
            {
                clbCargosDestino.Items.Add("NEPAL", true);
            }
            else
            {
                clbCargosDestino.Items.Add("NEPAL", false);
            }
            if (mCargosDestino[fila1].nicaragua == 1)
            {
                clbCargosDestino.Items.Add("NICARAGUA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("NICARAGUA", false);
            }
            if (mCargosDestino[fila1].noruega == 1)
            {
                clbCargosDestino.Items.Add("NORUEGA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("NORUEGA", false);
            }
            if (mCargosDestino[fila1].nueva_zelanda == 1)
            {
                clbCargosDestino.Items.Add("NUEVA ZELANDA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("NUEVA ZELANDA", false);
            }
            if (mCargosDestino[fila1].panama == 1)
            {
                clbCargosDestino.Items.Add("PANAMA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("PANAMA", false);
            }
            if (mCargosDestino[fila1].paraguay == 1)
            {
                clbCargosDestino.Items.Add("PARAGUAY", true);
            }
            else
            {
                clbCargosDestino.Items.Add("PARAGUAY", false);
            }
            if (mCargosDestino[fila1].peru == 1)
            {
                clbCargosDestino.Items.Add("PERU", true);
            }
            else
            {
                clbCargosDestino.Items.Add("PERU", false);
            }
            if (mCargosDestino[fila1].polonia == 1)
            {
                clbCargosDestino.Items.Add("POLONIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("POLONIA", false);
            }
            if (mCargosDestino[fila1].portugal == 1)
            {
                clbCargosDestino.Items.Add("PORTUGAL", true);
            }
            else
            {
                clbCargosDestino.Items.Add("PORTUGAL", false);
            }
            if (mCargosDestino[fila1].qatar == 1)
            {
                clbCargosDestino.Items.Add("QATAR", true);
            }
            else
            {
                clbCargosDestino.Items.Add("QATAR", false);
            }
            if (mCargosDestino[fila1].reino_unido == 1)
            {
                clbCargosDestino.Items.Add("REINO UNIDO", true);
            }
            else
            {
                clbCargosDestino.Items.Add("REINO UNIDO", false);
            }
            if (mCargosDestino[fila1].republica_dominicana == 1)
            {
                clbCargosDestino.Items.Add("REPUBLICA DOMINICANA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("REPUBLICA DOMINICANA", false);
            }
            if (mCargosDestino[fila1].rusia == 1)
            {
                clbCargosDestino.Items.Add("RUSIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("RUSIA", false);
            }
            if (mCargosDestino[fila1].salvador == 1)
            {
                clbCargosDestino.Items.Add("EL SALVADOR", true);
            }
            else
            {
                clbCargosDestino.Items.Add("EL SALVADOR", false);
            }
            if (mCargosDestino[fila1].singapur == 1)
            {
                clbCargosDestino.Items.Add("SINGAPUR", true);
            }
            else
            {
                clbCargosDestino.Items.Add("SINGAPUR", false);
            }
            if (mCargosDestino[fila1].sudafrica == 1)
            {
                clbCargosDestino.Items.Add("SUDAFRICA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("SUDAFRICA", false);
            }
            if (mCargosDestino[fila1].suecia == 1)
            {
                clbCargosDestino.Items.Add("SUECIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("SUECIA", false);
            }
            if (mCargosDestino[fila1].suiza == 1)
            {
                clbCargosDestino.Items.Add("SUIZA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("SUIZA", false);
            }
            if (mCargosDestino[fila1].thailandia == 1)
            {
                clbCargosDestino.Items.Add("THAILANDIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("THAILANDIA", false);
            }
            if (mCargosDestino[fila1].taiwan == 1)
            {
                clbCargosDestino.Items.Add("TAIWAN", true);
            }
            else
            {
                clbCargosDestino.Items.Add("TAIWAN", false);
            }
            if (mCargosDestino[fila1].tunez == 1)
            {
                clbCargosDestino.Items.Add("TUNEZ", true);
            }
            else
            {
                clbCargosDestino.Items.Add("TUNEZ", false);
            }
            if (mCargosDestino[fila1].turquia == 1)
            {
                clbCargosDestino.Items.Add("TURQUIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("TURQUIA", false);
            }
            if (mCargosDestino[fila1].ucrania == 1)
            {
                clbCargosDestino.Items.Add("UCRANIA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("UCRANIA", false);
            }
            if (mCargosDestino[fila1].uruguay == 1)
            {
                clbCargosDestino.Items.Add("URUGUAY", true);
            }
            else
            {
                clbCargosDestino.Items.Add("URUGUAY", false);
            }
            if (mCargosDestino[fila1].usa == 1)
            {
                clbCargosDestino.Items.Add("USA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("USA", false);
            }
            if (mCargosDestino[fila1].venezuela == 1)
            {
                clbCargosDestino.Items.Add("VENEZUELA", true);
            }
            else
            {
                clbCargosDestino.Items.Add("VENEZUELA", false);
            }
            if (mCargosDestino[fila1].vietnam == 1)
            {
                clbCargosDestino.Items.Add("VIETNAM", true);
            }
            else
            {
                clbCargosDestino.Items.Add("VIETNAM", false);
            }

            if (mCargosDestino[fila1].rodman == 1)
            {
                clbViasDestino.Items.Add("RODMAN", true);
            }
            else
            {
                clbViasDestino.Items.Add("RODMAN", false);
            }
            if (mCargosDestino[fila1].cristobal == 1)
            {
                clbViasDestino.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbViasDestino.Items.Add("CRISTOBAL", false);
            }
            if (mCargosDestino[fila1].manzanillo == 1)
            {
                clbViasDestino.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbViasDestino.Items.Add("MANZANILLO", false);
            }
            if (mCargosDestino[fila1].balboa == 1)
            {
                clbViasDestino.Items.Add("BALBOA", true);
            }
            else
            {
                clbViasDestino.Items.Add("BALBOA", false);
            }
            if (mCargosDestino[fila1].moin == 1)
            {
                clbViasDestino.Items.Add("MOIN", true);
            }
            else
            {
                clbViasDestino.Items.Add("MOIN", false);
            }
            if (mCargosDestino[fila1].caldera == 1)
            {
                clbViasDestino.Items.Add("CALDERA", true);
            }
            else
            {
                clbViasDestino.Items.Add("CALDERA", false);
            }
            if (mCargosDestino[fila1].no_aplica == 1)
            {
                clbViasDestino.Items.Add("NO APLICA", true);
            }
            else
            {
                clbViasDestino.Items.Add("NO APLICA", false);
            }

            if (dgvCargpsDestino.Columns[e.ColumnIndex].Name == "editarCargosDestino")
            {
                btnCargosDestino.Text = "EDITAR";
            }

            if (dgvCargpsDestino.Columns[e.ColumnIndex].Name == "eliminarCargosDestino")
            {
                btnCargosDestino.Text = "ELIMINAR";
            }


        }

        private void btnCargosDestino_Click_1(object sender, EventArgs e)
        {
            if (btnCargosDestino.Text == "AGREGAR")
            {
                cargarDatosGuardadosCargosDestino();
                if (mCargosDestinoConsultas.agregarCargosDestino(mCargosDestino1))
                {
                    MessageBox.Show("CARGOS DESTINO AGREGADO");
                    cargarCARGOSDESTINO();
                    limpiarCampos();
                }

            }
            else if (btnCargosDestino.Text == "EDITAR")
            {
                cargarDatosGuardadosCargosDestino();
                if (mCargosDestinoConsultas.modificarCargosDestino(mCargosDestino1))
                {
                    MessageBox.Show("CARGOS DESTINO MODIFICADO");
                    cargarCARGOSDESTINO();
                    limpiarCampos();
                    btnCargosDestino.Text = "AGREGAR";
                }
            }
            else if (btnCargosDestino.Text == "ELIMINAR")
            {

                if (getIdCargosDestinoIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL CARGOS DESTINO?", "ELIMINAR CARGOS DESTINO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosCargosDestino();

                    if (mCargosDestinoConsultas.eliminarCargosDestino(mCargosDestino1))
                    {
                        MessageBox.Show("CARGOS DESTINO ELIMINADO");
                        cargarCARGOSDESTINO();
                        limpiarCampos();
                        btnCargosDestino.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvAgenteOrigenLCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbAgenteOrigenLCL.Items.Clear();
            DataGridViewRow fila = dgvAgenteOrigenLCL.Rows[e.RowIndex];
            int fila1 = dgvAgenteOrigenLCL.CurrentCell.RowIndex;
            txtIdAgenteOrigenLCL.Text = Convert.ToString(fila.Cells["idAgenteOrigenLCL"].Value);
            txtAgenteOrigenLCL.Text = Convert.ToString(fila.Cells["proveedorAgenteOrigenLCL"].Value);
            txtHblAgenteOrigenLCL.Text = Convert.ToString(fila.Cells["hblAgenteOrigenLCL"].Value);
            txtManejosAgenteOrigenLCL.Text = Convert.ToString(fila.Cells["manejosAgenteOrigenLCL"].Value);
            if (mAgenteOrigenLCL[fila1].alemania == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ALEMANIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ALEMANIA", false);
            }
            if (mAgenteOrigenLCL[fila1].arabia_saudi == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ARABIA SAUDITA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ARABIA SAUDITA", false);
            }
            if (mAgenteOrigenLCL[fila1].argelia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ARGELIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ARGELIA", false);
            }
            if (mAgenteOrigenLCL[fila1].argentina == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ARGENTINA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ARGENTINA", false);
            }
            if (mAgenteOrigenLCL[fila1].australia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("AUSTRALIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("AUSTRALIA", false);
            }
            if (mAgenteOrigenLCL[fila1].austria == 1)
            {
                clbAgenteOrigenLCL.Items.Add("AUSTRIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("AUSTRIA", false);
            }
            if (mAgenteOrigenLCL[fila1].bahamas == 1)
            {
                clbAgenteOrigenLCL.Items.Add("BAHAMAS", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("BAHAMAS", false);
            }
            if (mAgenteOrigenLCL[fila1].bangladesh == 1)
            {
                clbAgenteOrigenLCL.Items.Add("BANGLADESH", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("BANGLADESH", false);
            }
            if (mAgenteOrigenLCL[fila1].barbados == 1)
            {
                clbAgenteOrigenLCL.Items.Add("BARBADOS", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("BARBADOS", false);
            }
            if (mAgenteOrigenLCL[fila1].belgica == 1)
            {
                clbAgenteOrigenLCL.Items.Add("BELGICA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("BELGICA", false);
            }
            if (mAgenteOrigenLCL[fila1].belice == 1)
            {
                clbAgenteOrigenLCL.Items.Add("BELICE", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("BELICE", false);
            }
            if (mAgenteOrigenLCL[fila1].bolivia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("BOLIVIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("BOLIVIA", false);
            }
            if (mAgenteOrigenLCL[fila1].brasil == 1)
            {
                clbAgenteOrigenLCL.Items.Add("BRASIL", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("BRASIL", false);
            }
            if (mAgenteOrigenLCL[fila1].canada == 1)
            {
                clbAgenteOrigenLCL.Items.Add("CANADA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("CANADA", false);
            }
            if (mAgenteOrigenLCL[fila1].chile == 1)
            {
                clbAgenteOrigenLCL.Items.Add("CHILE", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("CHILE", false);
            }
            if (mAgenteOrigenLCL[fila1].china == 1)
            {
                clbAgenteOrigenLCL.Items.Add("CHINA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("CHINA", false);
            }
            if (mAgenteOrigenLCL[fila1].colombia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("COLOMBIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("COLOMBIA", false);
            }
            if (mAgenteOrigenLCL[fila1].crc == 1)
            {
                clbAgenteOrigenLCL.Items.Add("COSTA RICA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("COSTA RICA", false);
            }
            if (mAgenteOrigenLCL[fila1].croacia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("CROACIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("CROACIA", false);
            }
            if (mAgenteOrigenLCL[fila1].cuba == 1)
            {
                clbAgenteOrigenLCL.Items.Add("CUBA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("CUBA", false);
            }
            if (mAgenteOrigenLCL[fila1].dinamarca == 1)
            {
                clbAgenteOrigenLCL.Items.Add("DINAMARCA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("DINAMARCA", false);
            }
            if (mAgenteOrigenLCL[fila1].dominica == 1)
            {
                clbAgenteOrigenLCL.Items.Add("DOMINICA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("DOMINICA", false);
            }
            if (mAgenteOrigenLCL[fila1].dubai == 1)
            {
                clbAgenteOrigenLCL.Items.Add("DUBAI", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("DUBAI", false);
            }
            if (mAgenteOrigenLCL[fila1].ecuador == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ECUADOR", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ECUADOR", false);
            }
            if (mAgenteOrigenLCL[fila1].egipto == 1)
            {
                clbAgenteOrigenLCL.Items.Add("EGIPTO", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("EGIPTO", false);
            }
            if (mAgenteOrigenLCL[fila1].eslovaquia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ESLOVAQUIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ESLOVAQUIA", false);
            }
            if (mAgenteOrigenLCL[fila1].eslovenia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ESLOVENIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ESLOVENIA", false);
            }
            if (mAgenteOrigenLCL[fila1].espana == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ESPAÑA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ESPAÑA", false);
            }
            if (mAgenteOrigenLCL[fila1].finlandia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("FINLANDIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("FINLANDIA", false);
            }
            if (mAgenteOrigenLCL[fila1].flipinas == 1)
            {
                clbAgenteOrigenLCL.Items.Add("FILIPINAS", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("FILIPINAS", false);
            }
            if (mAgenteOrigenLCL[fila1].francia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("FRANCIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("FRANCIA", false);
            }
            if (mAgenteOrigenLCL[fila1].grecia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("GRECIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("GRECIA", false);
            }
            if (mAgenteOrigenLCL[fila1].guatemala == 1)
            {
                clbAgenteOrigenLCL.Items.Add("GUATEMALA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("GUATEMALA", false);
            }
            if (mAgenteOrigenLCL[fila1].haiti == 1)
            {
                clbAgenteOrigenLCL.Items.Add("HAITI", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("HAITI", false);
            }
            if (mAgenteOrigenLCL[fila1].holanda == 1)
            {
                clbAgenteOrigenLCL.Items.Add("HOLANDA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("HOLANDA", false);
            }
            if (mAgenteOrigenLCL[fila1].honduras == 1)
            {
                clbAgenteOrigenLCL.Items.Add("HONDURAS", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("HONDURAS", false);
            }
            if (mAgenteOrigenLCL[fila1].hungria == 1)
            {
                clbAgenteOrigenLCL.Items.Add("HUNGRIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("HUNGRIA", false);
            }
            if (mAgenteOrigenLCL[fila1].india == 1)
            {
                clbAgenteOrigenLCL.Items.Add("INDIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("INDIA", false);
            }
            if (mAgenteOrigenLCL[fila1].indonesia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("INDONESIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("INDONESIA", false);
            }
            if (mAgenteOrigenLCL[fila1].irlandia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("IRLANDIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("IRLANDIA", false);
            }
            if (mAgenteOrigenLCL[fila1].islandia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ISLANDIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ISLANDIA", false);
            }
            if (mAgenteOrigenLCL[fila1].israel == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ISRAEL", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ISRAEL", false);
            }
            if (mAgenteOrigenLCL[fila1].italia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("ITALIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("ITALIA", false);
            }
            if (mAgenteOrigenLCL[fila1].jamaica == 1)
            {
                clbAgenteOrigenLCL.Items.Add("JAMAICA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("JAMAICA", false);
            }
            if (mAgenteOrigenLCL[fila1].japon == 1)
            {
                clbAgenteOrigenLCL.Items.Add("JAPON", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("JAPON", false);
            }
            if (mAgenteOrigenLCL[fila1].korea == 1)
            {
                clbAgenteOrigenLCL.Items.Add("KOREA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("KOREA", false);
            }
            if (mAgenteOrigenLCL[fila1].luxemburgo == 1)
            {
                clbAgenteOrigenLCL.Items.Add("LUXEMBURGO", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("LUXEMBURGO", false);
            }
            if (mAgenteOrigenLCL[fila1].malasia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("MALASIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("MALASIA", false);
            }
            if (mAgenteOrigenLCL[fila1].maldivas == 1)
            {
                clbAgenteOrigenLCL.Items.Add("MALDIVAS", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("MALDIVAS", false);
            }
            if (mAgenteOrigenLCL[fila1].marruecos == 1)
            {
                clbAgenteOrigenLCL.Items.Add("MARRUECOS", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("MARRUECOS", false);
            }
            if (mAgenteOrigenLCL[fila1].maxico == 1)
            {
                clbAgenteOrigenLCL.Items.Add("MEXICO", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("MEXICO", false);
            }
            if (mAgenteOrigenLCL[fila1].monaco == 1)
            {
                clbAgenteOrigenLCL.Items.Add("MONACO", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("MONACO", false);
            }
            if (mAgenteOrigenLCL[fila1].mongolia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("MONGOLIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("MONGOLIA", false);
            }
            if (mAgenteOrigenLCL[fila1].nepal == 1)
            {
                clbAgenteOrigenLCL.Items.Add("NEPAL", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("NEPAL", false);
            }
            if (mAgenteOrigenLCL[fila1].nicaragua == 1)
            {
                clbAgenteOrigenLCL.Items.Add("NICARAGUA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("NICARAGUA", false);
            }
            if (mAgenteOrigenLCL[fila1].noruega == 1)
            {
                clbAgenteOrigenLCL.Items.Add("NORUEGA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("NORUEGA", false);
            }
            if (mAgenteOrigenLCL[fila1].nueva_zelanda == 1)
            {
                clbAgenteOrigenLCL.Items.Add("NUEVA ZELANDA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("NUEVA ZELANDA", false);
            }
            if (mAgenteOrigenLCL[fila1].panama == 1)
            {
                clbAgenteOrigenLCL.Items.Add("PANAMA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("PANAMA", false);
            }
            if (mAgenteOrigenLCL[fila1].paraguay == 1)
            {
                clbAgenteOrigenLCL.Items.Add("PARAGUAY", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("PARAGUAY", false);
            }
            if (mAgenteOrigenLCL[fila1].peru == 1)
            {
                clbAgenteOrigenLCL.Items.Add("PERU", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("PERU", false);
            }
            if (mAgenteOrigenLCL[fila1].polonia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("POLONIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("POLONIA", false);
            }
            if (mAgenteOrigenLCL[fila1].portugal == 1)
            {
                clbAgenteOrigenLCL.Items.Add("PORTUGAL", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("PORTUGAL", false);
            }
            if (mAgenteOrigenLCL[fila1].qatar == 1)
            {
                clbAgenteOrigenLCL.Items.Add("QATAR", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("QATAR", false);
            }
            if (mAgenteOrigenLCL[fila1].reino_unido == 1)
            {
                clbAgenteOrigenLCL.Items.Add("REINO UNIDO", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("REINO UNIDO", false);
            }
            if (mAgenteOrigenLCL[fila1].republica_dominicana == 1)
            {
                clbAgenteOrigenLCL.Items.Add("REPUBLICA DOMINICANA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("REPUBLICA DOMINICANA", false);
            }
            if (mAgenteOrigenLCL[fila1].rusia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("RUSIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("RUSIA", false);
            }
            if (mAgenteOrigenLCL[fila1].salvador == 1)
            {
                clbAgenteOrigenLCL.Items.Add("EL SALVADOR", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("EL SALVADOR", false);
            }
            if (mAgenteOrigenLCL[fila1].singapur == 1)
            {
                clbAgenteOrigenLCL.Items.Add("SINGAPUR", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("SINGAPUR", false);
            }
            if (mAgenteOrigenLCL[fila1].sudafrica == 1)
            {
                clbAgenteOrigenLCL.Items.Add("SUDAFRICA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("SUDAFRICA", false);
            }
            if (mAgenteOrigenLCL[fila1].suecia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("SUECIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("SUECIA", false);
            }
            if (mAgenteOrigenLCL[fila1].suiza == 1)
            {
                clbAgenteOrigenLCL.Items.Add("SUIZA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("SUIZA", false);
            }
            if (mAgenteOrigenLCL[fila1].thailandia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("THAILANDIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("THAILANDIA", false);
            }
            if (mAgenteOrigenLCL[fila1].taiwan == 1)
            {
                clbAgenteOrigenLCL.Items.Add("TAIWAN", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("TAIWAN", false);
            }
            if (mAgenteOrigenLCL[fila1].tunez == 1)
            {
                clbAgenteOrigenLCL.Items.Add("TUNEZ", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("TUNEZ", false);
            }
            if (mAgenteOrigenLCL[fila1].turquia == 1)
            {
                clbAgenteOrigenLCL.Items.Add("TURQUIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("TURQUIA", false);
            }
            if (mAgenteOrigenLCL[fila1].ucrania == 1)
            {
                clbAgenteOrigenLCL.Items.Add("UCRANIA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("UCRANIA", false);
            }
            if (mAgenteOrigenLCL[fila1].uruguay == 1)
            {
                clbAgenteOrigenLCL.Items.Add("URUGUAY", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("URUGUAY", false);
            }
            if (mAgenteOrigenLCL[fila1].usa == 1)
            {
                clbAgenteOrigenLCL.Items.Add("USA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("USA", false);
            }
            if (mAgenteOrigenLCL[fila1].venezuela == 1)
            {
                clbAgenteOrigenLCL.Items.Add("VENEZUELA", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("VENEZUELA", false);
            }
            if (mAgenteOrigenLCL[fila1].vietnam == 1)
            {
                clbAgenteOrigenLCL.Items.Add("VIETNAM", true);
            }
            else
            {
                clbAgenteOrigenLCL.Items.Add("VIETNAM", false);
            }

            if (dgvAgenteOrigenLCL.Columns[e.ColumnIndex].Name == "editarAgenteOrigenLCL")
            {
                btnAgenteOrigenLCL.Text = "EDITAR";
            }

            if (dgvAgenteOrigenLCL.Columns[e.ColumnIndex].Name == "eliminarAgenteOrigenLCL")
            {
                btnAgenteOrigenLCL.Text = "ELIMINAR";
            }
        }

        private void btnAgenteOrigenLCL_Click(object sender, EventArgs e)
        {
            if (btnAgenteOrigenLCL.Text == "AGREGAR")
            {
                cargarDatosGuardadosAgenteOrigenLCL();
                if (mAgenteOrigenLCLConsultas.agregarAgenteOrigen(mAgenteOrigenLCL1))
                {
                    MessageBox.Show("AGENTE ORIGEN AGREGADO");
                    cargarAGENTEORIGENLCL();
                    limpiarCampos();
                }

            }
            else if (btnAgenteOrigenLCL.Text == "EDITAR")
            {
                cargarDatosGuardadosAgenteOrigenLCL();
                if (mAgenteOrigenLCLConsultas.modificarAgenteOrigen(mAgenteOrigenLCL1))
                {
                    MessageBox.Show("AGENTE ORIGEN MODIFICADO");
                    cargarAGENTEORIGENLCL();
                    limpiarCampos();
                    btnAgenteOrigenLCL.Text = "AGREGAR";
                }
            }
            else if (btnAgenteOrigenLCL.Text == "ELIMINAR")
            {

                if (getIdAgenteOrigenLCLIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL AGENTE ORIGEN?", "ELIMINAR AGENTE ORIGEN", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosAgenteOrigenLCL();

                    if (mAgenteOrigenLCLConsultas.eliminarAgenteOrigen(mAgenteOrigenLCL1))
                    {
                        MessageBox.Show("AGENTE ORIGEN ELIMINADO");
                        cargarAGENTEORIGENLCL();
                        limpiarCampos();
                        btnAgenteOrigenLCL.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvFleteInternacionalLCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbPaisesFleteInternacionalLCL.Items.Clear();
            clbViasFleteInternacionalLCL.Items.Clear();
            DataGridViewRow fila = dgvFleteInternacionalLCL.Rows[e.RowIndex];
            int fila1 = dgvFleteInternacionalLCL.CurrentCell.RowIndex;
            txtIdFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["idFleteInternacionalLCL"].Value);
            txtFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["proveedorFleteInternacionalLCL"].Value);
            txtThcDCBMFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["thcDCbmFleteInternacionalLCL"].Value);
            txtThcDMinimoFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["thcDMinimoFleteInternacionalLCL"].Value);
            txtVgmMinimoFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["vgmMinimoFleteInternacionalLCL"].Value);
            txtBunkerCBMFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["bunkerCbmFleteInternacionalLCL"].Value);
            txtBunkerMinimoFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["bunkerMinimoFleteInternacionalLCL"].Value);
            txtSedMinimoFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["sedMinimoFleteInternacionalLCL"].Value);
            txtTicaMinimoFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["ticaMinimoFleteInternacionalLCL"].Value);
            txtForwardingMinimoFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["forwardingMinimoFleteInternacionalLCL"].Value);
            txtManejosMinimoFleteInternacionalLCL.Text = Convert.ToString(fila.Cells["manejosMinimoFleteInternacionalLCL"].Value);
            txtCargaPeligrosaMinimoFleteInternacional.Text = Convert.ToString(fila.Cells["cargaPeligrosaMinimoFleteInternacionalLCL"].Value);
            if (mFleteInternacionalLCL[fila1].alemania == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ALEMANIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ALEMANIA", false);
            }
            if (mFleteInternacionalLCL[fila1].arabia_saudi == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ARABIA SAUDITA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ARABIA SAUDITA", false);
            }
            if (mFleteInternacionalLCL[fila1].argelia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ARGELIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ARGELIA", false);
            }
            if (mFleteInternacionalLCL[fila1].argentina == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ARGENTINA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ARGENTINA", false);
            }
            if (mFleteInternacionalLCL[fila1].australia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("AUSTRALIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("AUSTRALIA", false);
            }
            if (mFleteInternacionalLCL[fila1].austria == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("AUSTRIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("AUSTRIA", false);
            }
            if (mFleteInternacionalLCL[fila1].bahamas == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BAHAMAS", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BAHAMAS", false);
            }
            if (mFleteInternacionalLCL[fila1].bangladesh == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BANGLADESH", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BANGLADESH", false);
            }
            if (mFleteInternacionalLCL[fila1].barbados == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BARBADOS", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BARBADOS", false);
            }
            if (mFleteInternacionalLCL[fila1].belgica == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BELGICA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BELGICA", false);
            }
            if (mFleteInternacionalLCL[fila1].belice == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BELICE", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BELICE", false);
            }
            if (mFleteInternacionalLCL[fila1].bolivia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BOLIVIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BOLIVIA", false);
            }
            if (mFleteInternacionalLCL[fila1].brasil == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BRASIL", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("BRASIL", false);
            }
            if (mFleteInternacionalLCL[fila1].canada == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("CANADA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("CANADA", false);
            }
            if (mFleteInternacionalLCL[fila1].chile == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("CHILE", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("CHILE", false);
            }
            if (mFleteInternacionalLCL[fila1].china == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("CHINA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("CHINA", false);
            }
            if (mFleteInternacionalLCL[fila1].colombia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("COLOMBIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("COLOMBIA", false);
            }
            if (mFleteInternacionalLCL[fila1].crc == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("COSTA RICA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("COSTA RICA", false);
            }
            if (mFleteInternacionalLCL[fila1].croacia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("CROACIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("CROACIA", false);
            }
            if (mFleteInternacionalLCL[fila1].cuba == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("CUBA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("CUBA", false);
            }
            if (mFleteInternacionalLCL[fila1].dinamarca == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("DINAMARCA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("DINAMARCA", false);
            }
            if (mFleteInternacionalLCL[fila1].dominica == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("DOMINICA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("DOMINICA", false);
            }
            if (mFleteInternacionalLCL[fila1].dubai == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("DUBAI", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("DUBAI", false);
            }
            if (mFleteInternacionalLCL[fila1].ecuador == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ECUADOR", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ECUADOR", false);
            }
            if (mFleteInternacionalLCL[fila1].egipto == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("EGIPTO", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("EGIPTO", false);
            }
            if (mFleteInternacionalLCL[fila1].eslovaquia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ESLOVAQUIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ESLOVAQUIA", false);
            }
            if (mFleteInternacionalLCL[fila1].eslovenia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ESLOVENIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ESLOVENIA", false);
            }
            if (mFleteInternacionalLCL[fila1].espana == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ESPAÑA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ESPAÑA", false);
            }
            if (mFleteInternacionalLCL[fila1].finlandia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("FINLANDIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("FINLANDIA", false);
            }
            if (mFleteInternacionalLCL[fila1].flipinas == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("FILIPINAS", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("FILIPINAS", false);
            }
            if (mFleteInternacionalLCL[fila1].francia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("FRANCIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("FRANCIA", false);
            }
            if (mFleteInternacionalLCL[fila1].grecia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("GRECIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("GRECIA", false);
            }
            if (mFleteInternacionalLCL[fila1].guatemala == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("GUATEMALA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("GUATEMALA", false);
            }
            if (mFleteInternacionalLCL[fila1].haiti == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("HAITI", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("HAITI", false);
            }
            if (mFleteInternacionalLCL[fila1].holanda == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("HOLANDA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("HOLANDA", false);
            }
            if (mFleteInternacionalLCL[fila1].honduras == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("HONDURAS", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("HONDURAS", false);
            }
            if (mFleteInternacionalLCL[fila1].hungria == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("HUNGRIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("HUNGRIA", false);
            }
            if (mFleteInternacionalLCL[fila1].india == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("INDIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("INDIA", false);
            }
            if (mFleteInternacionalLCL[fila1].indonesia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("INDONESIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("INDONESIA", false);
            }
            if (mFleteInternacionalLCL[fila1].irlandia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("IRLANDIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("IRLANDIA", false);
            }
            if (mFleteInternacionalLCL[fila1].islandia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ISLANDIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ISLANDIA", false);
            }
            if (mFleteInternacionalLCL[fila1].israel == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ISRAEL", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ISRAEL", false);
            }
            if (mFleteInternacionalLCL[fila1].italia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ITALIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("ITALIA", false);
            }
            if (mFleteInternacionalLCL[fila1].jamaica == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("JAMAICA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("JAMAICA", false);
            }
            if (mFleteInternacionalLCL[fila1].japon == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("JAPON", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("JAPON", false);
            }
            if (mFleteInternacionalLCL[fila1].korea == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("KOREA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("KOREA", false);
            }
            if (mFleteInternacionalLCL[fila1].luxemburgo == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("LUXEMBURGO", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("LUXEMBURGO", false);
            }
            if (mFleteInternacionalLCL[fila1].malasia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MALASIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MALASIA", false);
            }
            if (mFleteInternacionalLCL[fila1].maldivas == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MALDIVAS", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MALDIVAS", false);
            }
            if (mFleteInternacionalLCL[fila1].marruecos == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MARRUECOS", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MARRUECOS", false);
            }
            if (mFleteInternacionalLCL[fila1].maxico == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MEXICO", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MEXICO", false);
            }
            if (mFleteInternacionalLCL[fila1].monaco == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MONACO", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MONACO", false);
            }
            if (mFleteInternacionalLCL[fila1].mongolia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MONGOLIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("MONGOLIA", false);
            }
            if (mFleteInternacionalLCL[fila1].nepal == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("NEPAL", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("NEPAL", false);
            }
            if (mFleteInternacionalLCL[fila1].nicaragua == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("NICARAGUA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("NICARAGUA", false);
            }
            if (mFleteInternacionalLCL[fila1].noruega == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("NORUEGA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("NORUEGA", false);
            }
            if (mFleteInternacionalLCL[fila1].nueva_zelanda == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("NUEVA ZELANDA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("NUEVA ZELANDA", false);
            }
            if (mFleteInternacionalLCL[fila1].panama == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("PANAMA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("PANAMA", false);
            }
            if (mFleteInternacionalLCL[fila1].paraguay == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("PARAGUAY", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("PARAGUAY", false);
            }
            if (mFleteInternacionalLCL[fila1].peru == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("PERU", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("PERU", false);
            }
            if (mFleteInternacionalLCL[fila1].polonia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("POLONIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("POLONIA", false);
            }
            if (mFleteInternacionalLCL[fila1].portugal == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("PORTUGAL", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("PORTUGAL", false);
            }
            if (mFleteInternacionalLCL[fila1].qatar == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("QATAR", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("QATAR", false);
            }
            if (mFleteInternacionalLCL[fila1].reino_unido == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("REINO UNIDO", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("REINO UNIDO", false);
            }
            if (mFleteInternacionalLCL[fila1].republica_dominicana == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("REPUBLICA DOMINICANA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("REPUBLICA DOMINICANA", false);
            }
            if (mFleteInternacionalLCL[fila1].rusia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("RUSIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("RUSIA", false);
            }
            if (mFleteInternacionalLCL[fila1].salvador == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("EL SALVADOR", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("EL SALVADOR", false);
            }
            if (mFleteInternacionalLCL[fila1].singapur == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("SINGAPUR", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("SINGAPUR", false);
            }
            if (mFleteInternacionalLCL[fila1].sudafrica == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("SUDAFRICA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("SUDAFRICA", false);
            }
            if (mFleteInternacionalLCL[fila1].suecia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("SUECIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("SUECIA", false);
            }
            if (mFleteInternacionalLCL[fila1].suiza == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("SUIZA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("SUIZA", false);
            }
            if (mFleteInternacionalLCL[fila1].thailandia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("THAILANDIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("THAILANDIA", false);
            }
            if (mFleteInternacionalLCL[fila1].taiwan == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("TAIWAN", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("TAIWAN", false);
            }
            if (mFleteInternacionalLCL[fila1].tunez == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("TUNEZ", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("TUNEZ", false);
            }
            if (mFleteInternacionalLCL[fila1].turquia == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("TURQUIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("TURQUIA", false);
            }
            if (mFleteInternacionalLCL[fila1].ucrania == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("UCRANIA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("UCRANIA", false);
            }
            if (mFleteInternacionalLCL[fila1].uruguay == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("URUGUAY", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("URUGUAY", false);
            }
            if (mFleteInternacionalLCL[fila1].usa == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("USA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("USA", false);
            }
            if (mFleteInternacionalLCL[fila1].venezuela == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("VENEZUELA", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("VENEZUELA", false);
            }
            if (mFleteInternacionalLCL[fila1].vietnam == 1)
            {
                clbPaisesFleteInternacionalLCL.Items.Add("VIETNAM", true);
            }
            else
            {
                clbPaisesFleteInternacionalLCL.Items.Add("VIETNAM", false);
            }

            if (mFleteInternacionalLCL[fila1].rodman == 1)
            {
                clbViasFleteInternacionalLCL.Items.Add("RODMAN", true);
            }
            else
            {
                clbViasFleteInternacionalLCL.Items.Add("RODMAN", false);
            }
            if (mFleteInternacionalLCL[fila1].cristobal == 1)
            {
                clbViasFleteInternacionalLCL.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbViasFleteInternacionalLCL.Items.Add("CRISTOBAL", false);
            }
            if (mFleteInternacionalLCL[fila1].manzanillo == 1)
            {
                clbViasFleteInternacionalLCL.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbViasFleteInternacionalLCL.Items.Add("MANZANILLO", false);
            }
            if (mFleteInternacionalLCL[fila1].balboa == 1)
            {
                clbViasFleteInternacionalLCL.Items.Add("BALBOA", true);
            }
            else
            {
                clbViasFleteInternacionalLCL.Items.Add("BALBOA", false);
            }
            if (mFleteInternacionalLCL[fila1].moin == 1)
            {
                clbViasFleteInternacionalLCL.Items.Add("MOIN", true);
            }
            else
            {
                clbViasFleteInternacionalLCL.Items.Add("MOIN", false);
            }
            if (mFleteInternacionalLCL[fila1].caldera == 1)
            {
                clbViasFleteInternacionalLCL.Items.Add("CALDERA", true);
            }
            else
            {
                clbViasFleteInternacionalLCL.Items.Add("CALDERA", false);
            }
            if (mFleteInternacionalLCL[fila1].no_aplica == 1)
            {
                clbViasFleteInternacionalLCL.Items.Add("NO APLICA", true);
            }
            else
            {
                clbViasFleteInternacionalLCL.Items.Add("NO APLICA", false);
            }

            if (dgvFleteInternacionalLCL.Columns[e.ColumnIndex].Name == "editarFleteInternacionalLCL")
            {
                btnFleteInternacionalLCL.Text = "EDITAR";
            }

            if (dgvFleteInternacionalLCL.Columns[e.ColumnIndex].Name == "eliminarFleteInternacionalLCL")
            {
                btnFleteInternacionalLCL.Text = "ELIMINAR";
            }
        }

        private void btnFleteInternacionalLCL_Click(object sender, EventArgs e)
        {
            if (btnFleteInternacionalLCL.Text == "AGREGAR")
            {
                cargarDatosGuardadosFleteInternacionalLCL();
                if (mFleteInternacionalLCLConsultas.agregarFleteInternacional(mFleteInternacionalLCL1))
                {
                    MessageBox.Show("FLETE INTERNACIONAL AGREGADO");
                    cargarFLETEINTERNACIONALLCL();
                    limpiarCampos();
                }

            }
            else if (btnFleteInternacionalLCL.Text == "EDITAR")
            {
                cargarDatosGuardadosFleteInternacionalLCL();
                if (mFleteInternacionalLCLConsultas.modificarFleteInternacional(mFleteInternacionalLCL1))
                {
                    MessageBox.Show("FLETE INTERNACIONAL MODIFICADO");
                    cargarFLETEINTERNACIONALLCL();
                    limpiarCampos();
                    btnFleteInternacionalLCL.Text = "AGREGAR";
                }
            }
            else if (btnFleteInternacionalLCL.Text == "ELIMINAR")
            {

                if (getIdFleteInternacionalLCLIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL FLETE INTERNACIONAL?", "ELIMINAR FLETE INTERNACIONAL", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosFleteInternacionalLCL();

                    if (mFleteInternacionalLCLConsultas.eliminarFleteInternacional(mFleteInternacionalLCL1))
                    {
                        MessageBox.Show("FLETE INTERNCIONAL ELIMINADO");
                        cargarFLETEINTERNACIONALLCL();
                        limpiarCampos();
                        btnFleteInternacionalLCL.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvGastosPortuariosLCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbGastosPortuariosLCL.Items.Clear();
            DataGridViewRow fila = dgvGastosPortuariosLCL.Rows[e.RowIndex];
            int fila1 = dgvGastosPortuariosLCL.CurrentCell.RowIndex;
            txtIdGastosPortuariosLCL.Text = Convert.ToString(fila.Cells["idGastosPortuariosLCL"].Value);
            txtProveedorGastosPortuariosLCL.Text = Convert.ToString(fila.Cells["proveedorGastosPortuariosLCL"].Value);
            txtGastosPortuariosLCL.Text = Convert.ToString(fila.Cells["gastosPortuariosLCL"].Value);
            if (mGastosPortuariosLCL[fila1].rodman == 1)
            {
                clbGastosPortuariosLCL.Items.Add("RODMAN", true);
            }
            else
            {
                clbGastosPortuariosLCL.Items.Add("RODMAN", false);
            }
            if (mGastosPortuariosLCL[fila1].cristobal == 1)
            {
                clbGastosPortuariosLCL.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbGastosPortuariosLCL.Items.Add("CRISTOBAL", false);
            }
            if (mGastosPortuariosLCL[fila1].manzanillo == 1)
            {
                clbGastosPortuariosLCL.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbGastosPortuariosLCL.Items.Add("MANZANILLO", false);
            }
            if (mGastosPortuariosLCL[fila1].balboa == 1)
            {
                clbGastosPortuariosLCL.Items.Add("BALBOA", true);
            }
            else
            {
                clbGastosPortuariosLCL.Items.Add("BALBOA", false);
            }

            if (dgvGastosPortuariosLCL.Columns[e.ColumnIndex].Name == "editarGastosPortuariosLCL")
            {
                btnGastosPortuariosLCL.Text = "EDITAR";
            }

            if (dgvGastosPortuariosLCL.Columns[e.ColumnIndex].Name == "eliminarGastosPortuariosLCL")
            {
                btnGastosPortuariosLCL.Text = "ELIMINAR";
            } 
        }

        private void btnGastosPortuariosLCL_Click(object sender, EventArgs e)
        {
            if (btnGastosPortuariosLCL.Text == "AGREGAR")
            {
                cargarDatosGuardadosGastosPortuariosLCL();
                if (mGastosPortuariosLCLConsultas.agregarGastosPortuarios(mGastosPortuariosLCL1))
                {
                    MessageBox.Show("CARGO EN DESTINO AGREGADO");
                    cargarGASTOSPORTUARIOSLCL();
                    limpiarCampos();
                }

            }
            else if (btnGastosPortuariosLCL.Text == "EDITAR")
            {
                cargarDatosGuardadosGastosPortuariosLCL();
                if (mGastosPortuariosLCLConsultas.modificarGastosPortuarios(mGastosPortuariosLCL1))
                {
                    MessageBox.Show("CARGO EN DESTINO MODIFICADO");
                    cargarGASTOSPORTUARIOSLCL();
                    limpiarCampos();
                    btnGastosPortuariosLCL.Text = "AGREGAR";
                }
            }
            else if (btnGastosPortuariosLCL.Text == "ELIMINAR")
            {

                if (getIdGastosPortuariosLCLIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL CARGO EN DESTINO?", "ELIMINAR CARGO EN DESTINO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosGastosPortuariosLCL();

                    if (mGastosPortuariosLCLConsultas.eliminarGastosPortuarios(mGastosPortuariosLCL1))
                    {
                        MessageBox.Show("CARGO EN DESTINO ELIMINADO");
                        cargarGASTOSPORTUARIOSLCL();
                        limpiarCampos();
                        btnGastosPortuariosLCL.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvMovimientoPuertoBodegaLCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbMovimientoPuertoBodegaLCL.Items.Clear();
            DataGridViewRow fila = dgvMovimientoPuertoBodegaLCL.Rows[e.RowIndex];
            int fila1 = dgvMovimientoPuertoBodegaLCL.CurrentCell.RowIndex;
            txtIdMovimientoPuertoBodegaLCL.Text = Convert.ToString(fila.Cells["idMovimientoPuertoBodegaLCL"].Value);
            txtProveedorMovimientoPuertoBodegaLCL.Text = Convert.ToString(fila.Cells["proveedorMovimientoPuertoBodegaLCL"].Value);
            txtMovimientoPuertoBodegaLCL.Text = Convert.ToString(fila.Cells["movimientoPuertoBodegaLCL"].Value);
            if (mMovimientoPuertoBodegaLCL[fila1].rodman == 1)
            {
                clbMovimientoPuertoBodegaLCL.Items.Add("RODMAN", true);
            }
            else
            {
                clbMovimientoPuertoBodegaLCL.Items.Add("RODMAN", false);
            }
            if (mMovimientoPuertoBodegaLCL[fila1].cristobal == 1)
            {
                clbMovimientoPuertoBodegaLCL.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbMovimientoPuertoBodegaLCL.Items.Add("CRISTOBAL", false);
            }
            if (mMovimientoPuertoBodegaLCL[fila1].manzanillo == 1)
            {
                clbMovimientoPuertoBodegaLCL.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbMovimientoPuertoBodegaLCL.Items.Add("MANZANILLO", false);
            }
            if (mMovimientoPuertoBodegaLCL[fila1].balboa == 1)
            {
                clbMovimientoPuertoBodegaLCL.Items.Add("BALBOA", true);
            }
            else
            {
                clbMovimientoPuertoBodegaLCL.Items.Add("BALBOA", false);
            }

            if (dgvMovimientoPuertoBodegaLCL.Columns[e.ColumnIndex].Name == "editarMovimientoPuertoBodegaLCL")
            {
                btnMovimientoPuertoBodegaLCL.Text = "EDITAR";
            }

            if (dgvMovimientoPuertoBodegaLCL.Columns[e.ColumnIndex].Name == "eliminarMovimientoPuertoBodegaLCL")
            {
                btnMovimientoPuertoBodegaLCL.Text = "ELIMINAR";
            }
        }

        private void btnMovimientoPuertoBodegaLCL_Click(object sender, EventArgs e)
        {
            if (btnMovimientoPuertoBodegaLCL.Text == "AGREGAR")
            {
                cargarDatosGuardadosMovimientoPuertoBodegaLCL();
                if (mMovimientoPuertoBodegaLCLConsultas.agregarMovimientoPuertoBodega(mMovimientoPuertoBodegaLCL1))
                {
                    MessageBox.Show("MOVIMIENTO BODEGA AGREGADO");
                    cargarMOVIMIENTOPUERTOBODEGALCL();
                    limpiarCampos();
                }

            }
            else if (btnMovimientoPuertoBodegaLCL.Text == "EDITAR")
            {
                cargarDatosGuardadosMovimientoPuertoBodegaLCL();
                if (mMovimientoPuertoBodegaLCLConsultas.modificarMovimientoPuertoBodega(mMovimientoPuertoBodegaLCL1))
                {
                    MessageBox.Show("MOVIMIENTO BODEGA MODIFICADO");
                    cargarMOVIMIENTOPUERTOBODEGALCL();
                    limpiarCampos();
                    btnMovimientoPuertoBodegaLCL.Text = "AGREGAR";
                }
            }
            else if (btnMovimientoPuertoBodegaLCL.Text == "ELIMINAR")
            {

                if (getIdMovimientoPuertoBodegaLCLIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL MOVIMIENTO BODEGA?", "ELIMINAR MOVIMIENTO BODEGA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosMovimientoPuertoBodegaLCL();

                    if (mMovimientoPuertoBodegaLCLConsultas.eliminarMovimientoPuertoBodega(mMovimientoPuertoBodegaLCL1))
                    {
                        MessageBox.Show("MOVIMIENTO BODEGA ELIMINADO");
                        cargarMOVIMIENTOPUERTOBODEGALCL();
                        limpiarCampos();
                        btnMovimientoPuertoBodegaLCL.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvOtrasCategoriasLCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbOtrasCategoriasLCL.Items.Clear();
            DataGridViewRow fila = dgvOtrasCategoriasLCL.Rows[e.RowIndex];
            int fila1 = dgvOtrasCategoriasLCL.CurrentCell.RowIndex;
            txtIdOtrasCategoriasLCL.Text = Convert.ToString(fila.Cells["idOtrasCategoriasLCL"].Value);
            txtProveedorOtrasCategoriasLCL.Text = Convert.ToString(fila.Cells["proveedorOtrasCategoriasLCL"].Value);
            txtServicioOtrasCategoriasLCL.Text = Convert.ToString(fila.Cells["servicioOtrasCategoriasLCL"].Value);
            txtCostoOtrasCategoriasLCL.Text = Convert.ToString(fila.Cells["costoOtrasCategoriasLCL"].Value);
            if (mOtrasCategoriasLCL[fila1].rodman == 1)
            {
                clbOtrasCategoriasLCL.Items.Add("RODMAN", true);
            }
            else
            {
                clbOtrasCategoriasLCL.Items.Add("RODMAN", false);
            }
            if (mOtrasCategoriasLCL[fila1].cristobal == 1)
            {
                clbOtrasCategoriasLCL.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbOtrasCategoriasLCL.Items.Add("CRISTOBAL", false);
            }
            if (mOtrasCategoriasLCL[fila1].manzanillo == 1)
            {
                clbOtrasCategoriasLCL.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbOtrasCategoriasLCL.Items.Add("MANZANILLO", false);
            }
            if (mOtrasCategoriasLCL[fila1].balboa == 1)
            {
                clbOtrasCategoriasLCL.Items.Add("BALBOA", true);
            }
            else
            {
                clbOtrasCategoriasLCL.Items.Add("BALBOA", false);
            }

            if (dgvOtrasCategoriasLCL.Columns[e.ColumnIndex].Name == "editarOtrasCategoriasLCL")
            {
                btnOtrasCategoriasLCL.Text = "EDITAR";
            }

            if (dgvOtrasCategoriasLCL.Columns[e.ColumnIndex].Name == "eliminarOtrasCategoriasLCL")
            {
                btnOtrasCategoriasLCL.Text = "ELIMINAR";
            }
        }

        private void btnOtrasCategoriasLCL_Click(object sender, EventArgs e)
        {
            if (btnOtrasCategoriasLCL.Text == "AGREGAR")
            {
                cargarDatosGuardadosOtrasCategoriasLCL();
                if (mOtrasCategoriasLCLConsultas.agregarOtrasCategorias(mOtrasCategoriasLCL1))
                {
                    MessageBox.Show("OTRAS CATEGORIAS AGREGADO");
                    cargarOTRASCATEGORIASLCL();
                    limpiarCampos();
                }

            }
            else if (btnOtrasCategoriasLCL.Text == "EDITAR")
            {
                cargarDatosGuardadosOtrasCategoriasLCL();
                if (mOtrasCategoriasLCLConsultas.modificarOtrasCategorias(mOtrasCategoriasLCL1))
                {
                    MessageBox.Show("OTRAS CATEGORIAS MODIFICADO");
                    cargarOTRASCATEGORIASLCL();
                    limpiarCampos();
                    btnOtrasCategoriasLCL.Text = "AGREGAR";
                }
            }
            else if (btnOtrasCategoriasLCL.Text == "ELIMINAR")
            {

                if (getIdOtrasCategoriasLCLIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR LAS OTRAS CATEGORIAS?", "ELIMINAR OTRAS CATEGORIAS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosOtrasCategoriasLCL();

                    if (mOtrasCategoriasConsultas.eliminarOtrasCategorias(mOtrasCategorias1))
                    {
                        MessageBox.Show("OTRAS CATEGORIAS ELIMINADO");
                        cargarOTRASCATEGORIASLCL();
                        limpiarCampos();
                        btnOtrasCategoriasLCL.Text = "AGREGAR";
                    }
                }
            }
        }

        private void dgvCargpsDestinoLCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbCargosDestinoLCL.Items.Clear();
            clbViasDestinoLCL.Items.Clear();
            DataGridViewRow fila = dgvCargpsDestinoLCL.Rows[e.RowIndex];
            int fila1 = dgvCargpsDestinoLCL.CurrentCell.RowIndex;
            txtIdCargosDestinoLCL.Text = Convert.ToString(fila.Cells["idCargosDestinoLCL"].Value);
            txtCargosDestinoLCL.Text = Convert.ToString(fila.Cells["proveedorCargosDestinoLCL"].Value);
            txtFleteCargosDestinoLCL.Text = Convert.ToString(fila.Cells["fleteCargosDestinoLCL"].Value);
            if (mCargosDestinoLCL[fila1].alemania == 1)
            {
                clbCargosDestinoLCL.Items.Add("ALEMANIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ALEMANIA", false);
            }
            if (mCargosDestinoLCL[fila1].arabia_saudi == 1)
            {
                clbCargosDestinoLCL.Items.Add("ARABIA SAUDITA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ARABIA SAUDITA", false);
            }
            if (mCargosDestinoLCL[fila1].argelia == 1)
            {
                clbCargosDestinoLCL.Items.Add("ARGELIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ARGELIA", false);
            }
            if (mCargosDestinoLCL[fila1].argentina == 1)
            {
                clbCargosDestinoLCL.Items.Add("ARGENTINA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ARGENTINA", false);
            }
            if (mCargosDestinoLCL[fila1].australia == 1)
            {
                clbCargosDestinoLCL.Items.Add("AUSTRALIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("AUSTRALIA", false);
            }
            if (mCargosDestinoLCL[fila1].austria == 1)
            {
                clbCargosDestinoLCL.Items.Add("AUSTRIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("AUSTRIA", false);
            }
            if (mCargosDestinoLCL[fila1].bahamas == 1)
            {
                clbCargosDestinoLCL.Items.Add("BAHAMAS", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("BAHAMAS", false);
            }
            if (mCargosDestinoLCL[fila1].bangladesh == 1)
            {
                clbCargosDestinoLCL.Items.Add("BANGLADESH", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("BANGLADESH", false);
            }
            if (mCargosDestinoLCL[fila1].barbados == 1)
            {
                clbCargosDestinoLCL.Items.Add("BARBADOS", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("BARBADOS", false);
            }
            if (mCargosDestinoLCL[fila1].belgica == 1)
            {
                clbCargosDestinoLCL.Items.Add("BELGICA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("BELGICA", false);
            }
            if (mCargosDestinoLCL[fila1].belice == 1)
            {
                clbCargosDestinoLCL.Items.Add("BELICE", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("BELICE", false);
            }
            if (mCargosDestinoLCL[fila1].bolivia == 1)
            {
                clbCargosDestinoLCL.Items.Add("BOLIVIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("BOLIVIA", false);
            }
            if (mCargosDestinoLCL[fila1].brasil == 1)
            {
                clbCargosDestinoLCL.Items.Add("BRASIL", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("BRASIL", false);
            }
            if (mCargosDestinoLCL[fila1].canada == 1)
            {
                clbCargosDestinoLCL.Items.Add("CANADA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("CANADA", false);
            }
            if (mCargosDestinoLCL[fila1].chile == 1)
            {
                clbCargosDestinoLCL.Items.Add("CHILE", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("CHILE", false);
            }
            if (mCargosDestinoLCL[fila1].china == 1)
            {
                clbCargosDestinoLCL.Items.Add("CHINA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("CHINA", false);
            }
            if (mCargosDestinoLCL[fila1].colombia == 1)
            {
                clbCargosDestinoLCL.Items.Add("COLOMBIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("COLOMBIA", false);
            }
            if (mCargosDestinoLCL[fila1].crc == 1)
            {
                clbCargosDestinoLCL.Items.Add("COSTA RICA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("COSTA RICA", false);
            }
            if (mCargosDestinoLCL[fila1].croacia == 1)
            {
                clbCargosDestinoLCL.Items.Add("CROACIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("CROACIA", false);
            }
            if (mCargosDestinoLCL[fila1].cuba == 1)
            {
                clbCargosDestinoLCL.Items.Add("CUBA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("CUBA", false);
            }
            if (mCargosDestinoLCL[fila1].dinamarca == 1)
            {
                clbCargosDestinoLCL.Items.Add("DINAMARCA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("DINAMARCA", false);
            }
            if (mCargosDestinoLCL[fila1].dominica == 1)
            {
                clbCargosDestinoLCL.Items.Add("DOMINICA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("DOMINICA", false);
            }
            if (mCargosDestinoLCL[fila1].dubai == 1)
            {
                clbCargosDestinoLCL.Items.Add("DUBAI", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("DUBAI", false);
            }
            if (mCargosDestinoLCL[fila1].ecuador == 1)
            {
                clbCargosDestinoLCL.Items.Add("ECUADOR", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ECUADOR", false);
            }
            if (mCargosDestinoLCL[fila1].egipto == 1)
            {
                clbCargosDestinoLCL.Items.Add("EGIPTO", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("EGIPTO", false);
            }
            if (mCargosDestinoLCL[fila1].eslovaquia == 1)
            {
                clbCargosDestinoLCL.Items.Add("ESLOVAQUIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ESLOVAQUIA", false);
            }
            if (mCargosDestinoLCL[fila1].eslovenia == 1)
            {
                clbCargosDestinoLCL.Items.Add("ESLOVENIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ESLOVENIA", false);
            }
            if (mCargosDestinoLCL[fila1].espana == 1)
            {
                clbCargosDestinoLCL.Items.Add("ESPAÑA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ESPAÑA", false);
            }
            if (mCargosDestinoLCL[fila1].finlandia == 1)
            {
                clbCargosDestinoLCL.Items.Add("FINLANDIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("FINLANDIA", false);
            }
            if (mCargosDestinoLCL[fila1].flipinas == 1)
            {
                clbCargosDestinoLCL.Items.Add("FILIPINAS", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("FILIPINAS", false);
            }
            if (mCargosDestinoLCL[fila1].francia == 1)
            {
                clbCargosDestinoLCL.Items.Add("FRANCIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("FRANCIA", false);
            }
            if (mCargosDestinoLCL[fila1].grecia == 1)
            {
                clbCargosDestinoLCL.Items.Add("GRECIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("GRECIA", false);
            }
            if (mCargosDestinoLCL[fila1].guatemala == 1)
            {
                clbCargosDestinoLCL.Items.Add("GUATEMALA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("GUATEMALA", false);
            }
            if (mCargosDestinoLCL[fila1].haiti == 1)
            {
                clbCargosDestinoLCL.Items.Add("HAITI", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("HAITI", false);
            }
            if (mCargosDestinoLCL[fila1].holanda == 1)
            {
                clbCargosDestinoLCL.Items.Add("HOLANDA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("HOLANDA", false);
            }
            if (mCargosDestinoLCL[fila1].honduras == 1)
            {
                clbCargosDestinoLCL.Items.Add("HONDURAS", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("HONDURAS", false);
            }
            if (mCargosDestinoLCL[fila1].hungria == 1)
            {
                clbCargosDestinoLCL.Items.Add("HUNGRIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("HUNGRIA", false);
            }
            if (mCargosDestinoLCL[fila1].india == 1)
            {
                clbCargosDestinoLCL.Items.Add("INDIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("INDIA", false);
            }
            if (mCargosDestinoLCL[fila1].indonesia == 1)
            {
                clbCargosDestinoLCL.Items.Add("INDONESIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("INDONESIA", false);
            }
            if (mCargosDestinoLCL[fila1].irlandia == 1)
            {
                clbCargosDestinoLCL.Items.Add("IRLANDIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("IRLANDIA", false);
            }
            if (mCargosDestinoLCL[fila1].islandia == 1)
            {
                clbCargosDestinoLCL.Items.Add("ISLANDIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ISLANDIA", false);
            }
            if (mCargosDestinoLCL[fila1].israel == 1)
            {
                clbCargosDestinoLCL.Items.Add("ISRAEL", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ISRAEL", false);
            }
            if (mCargosDestinoLCL[fila1].italia == 1)
            {
                clbCargosDestinoLCL.Items.Add("ITALIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("ITALIA", false);
            }
            if (mCargosDestinoLCL[fila1].jamaica == 1)
            {
                clbCargosDestinoLCL.Items.Add("JAMAICA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("JAMAICA", false);
            }
            if (mCargosDestinoLCL[fila1].japon == 1)
            {
                clbCargosDestinoLCL.Items.Add("JAPON", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("JAPON", false);
            }
            if (mCargosDestinoLCL[fila1].korea == 1)
            {
                clbCargosDestinoLCL.Items.Add("KOREA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("KOREA", false);
            }
            if (mCargosDestinoLCL[fila1].luxemburgo == 1)
            {
                clbCargosDestinoLCL.Items.Add("LUXEMBURGO", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("LUXEMBURGO", false);
            }
            if (mCargosDestinoLCL[fila1].malasia == 1)
            {
                clbCargosDestinoLCL.Items.Add("MALASIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("MALASIA", false);
            }
            if (mCargosDestinoLCL[fila1].maldivas == 1)
            {
                clbCargosDestinoLCL.Items.Add("MALDIVAS", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("MALDIVAS", false);
            }
            if (mCargosDestinoLCL[fila1].marruecos == 1)
            {
                clbCargosDestinoLCL.Items.Add("MARRUECOS", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("MARRUECOS", false);
            }
            if (mCargosDestinoLCL[fila1].maxico == 1)
            {
                clbCargosDestinoLCL.Items.Add("MEXICO", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("MEXICO", false);
            }
            if (mCargosDestinoLCL[fila1].monaco == 1)
            {
                clbCargosDestinoLCL.Items.Add("MONACO", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("MONACO", false);
            }
            if (mCargosDestinoLCL[fila1].mongolia == 1)
            {
                clbCargosDestinoLCL.Items.Add("MONGOLIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("MONGOLIA", false);
            }
            if (mCargosDestinoLCL[fila1].nepal == 1)
            {
                clbCargosDestinoLCL.Items.Add("NEPAL", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("NEPAL", false);
            }
            if (mCargosDestinoLCL[fila1].nicaragua == 1)
            {
                clbCargosDestinoLCL.Items.Add("NICARAGUA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("NICARAGUA", false);
            }
            if (mCargosDestinoLCL[fila1].noruega == 1)
            {
                clbCargosDestinoLCL.Items.Add("NORUEGA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("NORUEGA", false);
            }
            if (mCargosDestinoLCL[fila1].nueva_zelanda == 1)
            {
                clbCargosDestinoLCL.Items.Add("NUEVA ZELANDA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("NUEVA ZELANDA", false);
            }
            if (mCargosDestinoLCL[fila1].panama == 1)
            {
                clbCargosDestinoLCL.Items.Add("PANAMA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("PANAMA", false);
            }
            if (mCargosDestinoLCL[fila1].paraguay == 1)
            {
                clbCargosDestinoLCL.Items.Add("PARAGUAY", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("PARAGUAY", false);
            }
            if (mCargosDestinoLCL[fila1].peru == 1)
            {
                clbCargosDestinoLCL.Items.Add("PERU", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("PERU", false);
            }
            if (mCargosDestinoLCL[fila1].polonia == 1)
            {
                clbCargosDestinoLCL.Items.Add("POLONIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("POLONIA", false);
            }
            if (mCargosDestinoLCL[fila1].portugal == 1)
            {
                clbCargosDestinoLCL.Items.Add("PORTUGAL", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("PORTUGAL", false);
            }
            if (mCargosDestinoLCL[fila1].qatar == 1)
            {
                clbCargosDestinoLCL.Items.Add("QATAR", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("QATAR", false);
            }
            if (mCargosDestinoLCL[fila1].reino_unido == 1)
            {
                clbCargosDestinoLCL.Items.Add("REINO UNIDO", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("REINO UNIDO", false);
            }
            if (mCargosDestinoLCL[fila1].republica_dominicana == 1)
            {
                clbCargosDestinoLCL.Items.Add("REPUBLICA DOMINICANA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("REPUBLICA DOMINICANA", false);
            }
            if (mCargosDestinoLCL[fila1].rusia == 1)
            {
                clbCargosDestinoLCL.Items.Add("RUSIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("RUSIA", false);
            }
            if (mCargosDestinoLCL[fila1].salvador == 1)
            {
                clbCargosDestinoLCL.Items.Add("EL SALVADOR", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("EL SALVADOR", false);
            }
            if (mCargosDestinoLCL[fila1].singapur == 1)
            {
                clbCargosDestinoLCL.Items.Add("SINGAPUR", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("SINGAPUR", false);
            }
            if (mCargosDestinoLCL[fila1].sudafrica == 1)
            {
                clbCargosDestinoLCL.Items.Add("SUDAFRICA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("SUDAFRICA", false);
            }
            if (mCargosDestinoLCL[fila1].suecia == 1)
            {
                clbCargosDestinoLCL.Items.Add("SUECIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("SUECIA", false);
            }
            if (mCargosDestinoLCL[fila1].suiza == 1)
            {
                clbCargosDestinoLCL.Items.Add("SUIZA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("SUIZA", false);
            }
            if (mCargosDestinoLCL[fila1].thailandia == 1)
            {
                clbCargosDestinoLCL.Items.Add("THAILANDIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("THAILANDIA", false);
            }
            if (mCargosDestinoLCL[fila1].taiwan == 1)
            {
                clbCargosDestinoLCL.Items.Add("TAIWAN", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("TAIWAN", false);
            }
            if (mCargosDestinoLCL[fila1].tunez == 1)
            {
                clbCargosDestinoLCL.Items.Add("TUNEZ", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("TUNEZ", false);
            }
            if (mCargosDestinoLCL[fila1].turquia == 1)
            {
                clbCargosDestinoLCL.Items.Add("TURQUIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("TURQUIA", false);
            }
            if (mCargosDestinoLCL[fila1].ucrania == 1)
            {
                clbCargosDestinoLCL.Items.Add("UCRANIA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("UCRANIA", false);
            }
            if (mCargosDestinoLCL[fila1].uruguay == 1)
            {
                clbCargosDestinoLCL.Items.Add("URUGUAY", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("URUGUAY", false);
            }
            if (mCargosDestinoLCL[fila1].usa == 1)
            {
                clbCargosDestinoLCL.Items.Add("USA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("USA", false);
            }
            if (mCargosDestinoLCL[fila1].venezuela == 1)
            {
                clbCargosDestinoLCL.Items.Add("VENEZUELA", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("VENEZUELA", false);
            }
            if (mCargosDestinoLCL[fila1].vietnam == 1)
            {
                clbCargosDestinoLCL.Items.Add("VIETNAM", true);
            }
            else
            {
                clbCargosDestinoLCL.Items.Add("VIETNAM", false);
            }

            if (mCargosDestinoLCL[fila1].rodman == 1)
            {
                clbViasDestinoLCL.Items.Add("RODMAN", true);
            }
            else
            {
                clbViasDestinoLCL.Items.Add("RODMAN", false);
            }
            if (mCargosDestinoLCL[fila1].cristobal == 1)
            {
                clbViasDestinoLCL.Items.Add("CRISTOBAL", true);
            }
            else
            {
                clbViasDestinoLCL.Items.Add("CRISTOBAL", false);
            }
            if (mCargosDestinoLCL[fila1].manzanillo == 1)
            {
                clbViasDestinoLCL.Items.Add("MANZANILLO", true);
            }
            else
            {
                clbViasDestinoLCL.Items.Add("MANZANILLO", false);
            }
            if (mCargosDestinoLCL[fila1].balboa == 1)
            {
                clbViasDestinoLCL.Items.Add("BALBOA", true);
            }
            else
            {
                clbViasDestinoLCL.Items.Add("BALBOA", false);
            }
            if (mCargosDestinoLCL[fila1].moin == 1)
            {
                clbViasDestinoLCL.Items.Add("MOIN", true);
            }
            else
            {
                clbViasDestinoLCL.Items.Add("MOIN", false);
            }
            if (mCargosDestinoLCL[fila1].caldera == 1)
            {
                clbViasDestinoLCL.Items.Add("CALDERA", true);
            }
            else
            {
                clbViasDestinoLCL.Items.Add("CALDERA", false);
            }
            if (mCargosDestinoLCL[fila1].no_aplica == 1)
            {
                clbViasDestinoLCL.Items.Add("NO APLICA", true);
            }
            else
            {
                clbViasDestinoLCL.Items.Add("NO APLICA", false);
            }

            if (dgvCargpsDestinoLCL.Columns[e.ColumnIndex].Name == "editarCargosDestinoLCL")
            {
                btnCargosDestinoLCL.Text = "EDITAR";
            }

            if (dgvCargpsDestinoLCL.Columns[e.ColumnIndex].Name == "eliminarCargosDestinoLCL")
            {
                btnCargosDestinoLCL.Text = "ELIMINAR";
            }
        }

        private void btnCargosDestinoLCL_Click(object sender, EventArgs e)
        {
            if (btnCargosDestinoLCL.Text == "AGREGAR")
            {
                cargarDatosGuardadosCargosDestinoLCL();
                if (mCargosDestinoLCLConsultas.agregarCargosDestino(mCargosDestinoLCL1))
                {
                    MessageBox.Show("CARGOS DESTINO AGREGADO");
                    cargarCARGOSDESTINOLCL();
                    limpiarCampos();
                }

            }
            else if (btnCargosDestinoLCL.Text == "EDITAR")
            {
                cargarDatosGuardadosCargosDestinoLCL();
                if (mCargosDestinoLCLConsultas.modificarCargosDestino(mCargosDestinoLCL1))
                {
                    MessageBox.Show("CARGOS DESTINO MODIFICADO");
                    cargarCARGOSDESTINOLCL();
                    limpiarCampos();
                    btnCargosDestinoLCL.Text = "AGREGAR";
                }
            }
            else if (btnCargosDestinoLCL.Text == "ELIMINAR")
            {

                if (getIdCargosDestinoLCLIfExist() == -1)
                {
                    return;
                }

                if (MessageBox.Show("¿DESEAS ELIMINAR EL CARGOS DESTINO?", "ELIMINAR CARGOS DESTINO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cargarDatosGuardadosCargosDestinoLCL();

                    if (mCargosDestinoLCLConsultas.eliminarCargosDestino(mCargosDestinoLCL1))
                    {
                        MessageBox.Show("CARGOS DESTINO ELIMINADO");
                        cargarCARGOSDESTINOLCL();
                        limpiarCampos();
                        btnCargosDestinoLCL.Text = "AGREGAR";
                    }
                }
            }
        }
    }
}