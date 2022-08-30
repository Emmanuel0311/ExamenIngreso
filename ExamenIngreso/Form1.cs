using System.Data;

namespace ExamenIngreso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Acura = new DataTable();
            Acura.Columns.Add("marcas");
            DataRow row = Acura.NewRow();
            row["marcas"] = "ILX";
            Acura.Rows.Add(row);
            DataRow row2 = Acura.NewRow();
            row2["marcas"] = "MDX";
            Acura.Rows.Add(row2);
            DataRow row3 = Acura.NewRow();
            row3["marcas"] = "RDX";
            Acura.Rows.Add(row3);
            DataRow row4 = Acura.NewRow();
            row4["marcas"] = "RL";
            Acura.Rows.Add(row4);
            DataRow row5 = Acura.NewRow();
            row5["marcas"] = "RLX";
            Acura.Rows.Add(row5);

            DataTable AFRomero = new DataTable();
            AFRomero.Columns.Add("marcas");
            DataRow row6 = AFRomero.NewRow();
            row6["marcas"] = "BRERA";
            AFRomero.Rows.Add(row6);
            DataRow row7 = AFRomero.NewRow();
            row7["marcas"] = "GT";
            AFRomero.Rows.Add(row7);
            DataRow row8 = AFRomero.NewRow();
            row8["marcas"] = "GTV";
            AFRomero.Rows.Add(row8);
            DataRow row9 = AFRomero.NewRow();
            row9["marcas"] = "MITO";
            AFRomero.Rows.Add(row9);

            DataTable Audi = new DataTable();
            Audi.Columns.Add("marcas");
            DataRow row10 = Audi.NewRow();
            row10["marcas"] = "A1";
            Audi.Rows.Add(row10);
            DataRow row11 = Audi.NewRow();
            row11["marcas"] = "A3";
            Audi.Rows.Add(row11);
            DataRow row12 = Audi.NewRow();
            row12["marcas"] = "A4";
            Audi.Rows.Add(row12);


            if (cboMarca.SelectedIndex == 0)
            {
                cboSubMarca.DataSource = Acura;
                cboSubMarca.DisplayMember = "marcas";
            }else if (cboMarca.SelectedIndex == 2) {
                cboSubMarca.DataSource = AFRomero;
                cboSubMarca.DisplayMember = "marcas";
            }
            else if(cboMarca.SelectedIndex == 1)
            {
                cboSubMarca.DataSource = Audi;
                cboSubMarca.DisplayMember = "marcas";
            }
            else if (cboMarca.SelectedIndex == 3)
            {
                cboSubMarca.DataSource = null;
            }
            else if (cboMarca.SelectedIndex == 4)
            {
                cboSubMarca.DataSource = null;
            }
        }

        private void cboSubMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable ILX = new DataTable();
            ILX.Columns.Add("modelo");
            DataRow row = ILX.NewRow();
            row["modelo"] = "2013";
            ILX.Rows.Add(row);
            DataRow row2 = ILX.NewRow();
            row2["modelo"] = "2014";
            ILX.Rows.Add(row2);
            DataRow row3 = ILX.NewRow();
            row3["modelo"] = "2015";

            DataTable MDX = new DataTable();
            MDX.Columns.Add("modelo");
            DataRow row4 = MDX.NewRow();
            row4["modelo"] = "2013";
            MDX.Rows.Add(row4);
            DataRow row5 = MDX.NewRow();
            row5["modelo"] = "2014";
            MDX.Rows.Add(row5);
            DataRow row6 = MDX.NewRow();
            row6["modelo"] = "2015";
            MDX.Rows.Add(row6);

            DataTable Brera = new DataTable();
            Brera.Columns.Add("modelo");
            DataRow row7 = Brera.NewRow();
            row7["modelo"] = "2016";
            Brera.Rows.Add(row7);
            DataRow row8 = Brera.NewRow();
            row8["modelo"] = "2017";

            if(cboSubMarca.SelectedValue == ILX)
            {
                cboModelo.DataSource = ILX;
                cboModelo.DisplayMember = "modelo";
            }


        }

        private void cboCodPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable COD1 = new DataTable();
            COD1.Columns.Add("postal");
            DataRow row = COD1.NewRow();
            row["postal"] = "Tulpan";
            COD1.Rows.Add(row);

            DataTable COD2 = new DataTable();
            COD2.Columns.Add("postal");
            DataRow row2 = COD2.NewRow();
            row2["postal"] = "Tlanepantla";
            COD2.Rows.Add(row2);

            DataTable COD3 = new DataTable();
            COD3.Columns.Add("postal");
            DataRow row3 = COD3.NewRow();
            row3["postal"] = "Rivera";
            COD3.Rows.Add(row3);

            if (cboCodPostal.SelectedIndex == 0)
            {
                cboEstado.DataSource = COD1;
                cboEstado.DisplayMember = "postal";
            }

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            Mensaje();
            if (validar()) {
                MessageBox.Show("Datos Cotizados correctamente");
            }
           
        }

        private bool validar()
        {
            bool ok = true;
            if (cboModelo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboModelo, "Selecciona modelo");
            }
            if (cboModelo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboMarca, "Selecciona marca");
            }
            if (cboModelo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboCodPostal, "Selecciona CP");
            }
            if (cboModelo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboEstado, "Selecciona estado");
            }
            if (cboModelo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboSubMarca, "Selecciona Sub-marca");
            }

            if (cboDescripcion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboDescripcion, "Selecciona Descripcion");
            }

            if (cboMunicipio.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboMunicipio, "Seleccione Municipio");
            }

            if (cboColonia.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboColonia, "No hay Colonia");
            }
            return ok;
        }

        private void Mensaje()
        {
            errorProvider1.SetError(cboMarca, "");
            errorProvider1.SetError(cboModelo, "");
            errorProvider1.SetError(cboEstado, "");
            errorProvider1.SetError(cboCodPostal, "");
            errorProvider1.SetError(cboColonia, "");
            errorProvider1.SetError(cboDescripcion, "");
            errorProvider1.SetError(cboMunicipio, "");
            errorProvider1.SetError(cboSubMarca, "");
        }
    }
}