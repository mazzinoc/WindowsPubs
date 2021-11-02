using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPubs3.Data;

namespace WindowsPubs3
{
    public partial class Form1 : Form
    {
        PubsContext context = new PubsContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerAutores_Click(object sender, EventArgs e)
        {
            var listaAutores = (from a in context.authors
                                select a).ToList();
            gridMostrar.DataSource = listaAutores;
        }

        private void btnTraerPublicadores_Click(object sender, EventArgs e)
        {
            var listaPublicadores = (from p in context.publishers
                                     select p).ToList();
            gridMostrar.DataSource = listaPublicadores;
        }

        private void btnAutoresCiudad_Click(object sender, EventArgs e)
        {
            var ciudad = "Oakland";
            var listaAutoresCiudad = (from a in context.authors
                                      where a.city == ciudad
                                      select a).ToList();
            gridMostrar.DataSource = listaAutoresCiudad;
        }

        private void btnTraerAutorId_Click(object sender, EventArgs e)
        {
            string id = "213-46-8915";
            var listaAutorId = (from a in context.authors
                                where a.au_id == id
                                select a).ToList();
            gridMostrar.DataSource = listaAutorId;
        }

        private void btnPublicadorNombre_Click(object sender, EventArgs e)
        {
            string nombre = "GGG&G";
            var listaPublicadorNombre = (from p in context.publishers
                                         where p.pub_name == nombre
                                         select p).ToList();
            gridMostrar.DataSource = listaPublicadorNombre;
        }

        private void btnLista1_Click(object sender, EventArgs e)
        {
            var lista1 = (from
                          s in context.sales
                          join
                          t in context.stores
                          on s.stor_id equals t.stor_id
                          select new
                          {
                              s.stor_id,
                              t.stor_name,
                              t.city,
                              s.ord_num,
                              s.ord_date,
                              s.qty,
                              s.title_id
                          }
                          ).ToList();
            gridMostrar.DataSource = lista1;
        }

        private void btnLista2_Click(object sender, EventArgs e)
        {
            var lista2 = (from
                          em in context.employees
                          join
                          pu in context.publishers
                          on em.pub_id equals pu.pub_id
                          select new
                          {
                              em.fname,
                              em.lname,
                              pu.pub_name
                          }).ToList();
            gridMostrar.DataSource = lista2;
        }

        private void btnLista3_Click(object sender, EventArgs e)
        {
            string ciudad = "Paris";
            var lista2 = (from
                          em in context.employees
                          join
                          pu in context.publishers
                          on em.pub_id equals pu.pub_id
                          where pu.city == ciudad
                          select new
                          {
                              em.fname,
                              em.lname,
                              pu.pub_name,
                              pu.city
                          }).ToList();
            gridMostrar.DataSource = lista2;
        }
    }
}
