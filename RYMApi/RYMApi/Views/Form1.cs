using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RYMApi.Controllers;
using RYMApi.Models;

namespace RYMApi
{
    public partial class Form1 : Form
    {
        private charactersControllers charactersControllers;
        private Characters Characters;
        public Form1()
        {
            InitializeComponent();
            charactersControllers = new charactersControllers();
            Characters = new Characters();
        }

        private async void GetCharacters()
        {
            Characters = await
            charactersControllers.GetAllCharacters();

            if (Characters != null)
            {
                foreach (var character in Characters?.results!)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvCharacters);

                    row.Cells[0].Value = character.name;
                    row.Cells[1].Value = character.gender;
                    row.Cells[2].Value = character.species;
                    row.Cells[3].Value = character.origin.name;

                    dgvCharacters.Rows.Add(row);
                }
            }

            else
            {
                MessageBox.Show("No se pudo obtener la peticion.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetCharacters();
        }
    }
}
