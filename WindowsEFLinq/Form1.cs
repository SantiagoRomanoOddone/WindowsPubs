using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFLinq.Data; // A

namespace WindowsEFLinq
{
    public partial class Form1 : Form
    {
        PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodosAutores_Click(object sender, EventArgs e)
        {
            var lista = (from a in context.authors
                         select a).ToList();
            gridGeneral.DataSource = lista;


        }

        private void btnTraerTodosPublicadores_Click(object sender, EventArgs e)
        {
            var lista = (from p in context.publishers
                         select p).ToList();
            gridGeneral.DataSource = lista;
        }

        private void btnTraerAutoresPorCiudad_Click(object sender, EventArgs e)
        {
            var lista = (from a in context.authors
                         where a.city == txtTraerAutoresPorCiudad.Text
                         select a).ToList();
            gridGeneral.DataSource = lista;

        }

        private void btnTraerAutorPorId_Click(object sender, EventArgs e)
        {
            var autor = (from a in context.authors
                         where a.au_id == txtTraerAutorPorId.Text
                         select a).SingleOrDefault();
            MessageBox.Show("Id:" + autor.au_id + " Nombre y Apellido:" + autor.au_lname + "\n" + autor.au_fname);
        }

        private void btnTraerAutorNombre_Click(object sender, EventArgs e)
        {
            var autor = (from a in context.authors
                         where a.au_fname == txtTraerAutorPorNombre.Text
                         select a).SingleOrDefault();
            MessageBox.Show("Id:" + autor.au_id + " Nombre y Apellido:" + autor.au_lname + "\n" + autor.au_fname);
        }

        private void btnTraerSalesYStores_Click(object sender, EventArgs e)
        {
            var lista = (
                         from st in context.stores
                         join
                         s in context.sales
                         on st.stor_id equals s.stor_id
                         select new
                         {
                             Id = st.stor_id,
                             NombreTienda = st.stor_name,
                             Ciudad = st.city,
                             NroOrden = s.ord_num,
                             Fecha = s.ord_date,
                             Cantidad = s.qty,
                             IdTitulo = s.title_id

                         }
                ).ToList();
            gridGeneral.DataSource = lista;

        }

        private void btnTraerEmployeesPublishers_Click(object sender, EventArgs e)
        {
            var lista = (
                         from em in context.employees
                         join
                         p in context.publishers                        
                         on em.pub_id equals p.pub_id
                         select new
                         {
                             Nombre = em.lname,
                             Apellido = em.fname,
                             NombrePublicador = p.pub_name,
                         }
                ).ToList();
            gridGeneral.DataSource = lista;

        }

        private void btnTraerEmpPubPorPais_Click(object sender, EventArgs e)
        {
            string country = "Germany";
            var lista = (
                         from em in context.employees
                         join
                         p in context.publishers
                         on em.pub_id equals p.pub_id
                         where p.country == country
                         select new
                         {
                             Nombre = em.lname,
                             Apellido = em.fname,
                             NombrePublicador = p.pub_name,
                             Country = p.country
                         }
                ).ToList();
            gridGeneral.DataSource = lista;

        }
    }
}
