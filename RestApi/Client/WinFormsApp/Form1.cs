using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp.Bus;
using WinFormsApp.Model;
namespace WinFormsApp
{
    public partial class Pokemon_ : Form
    {
        public Pokemon_()
        {
            InitializeComponent();
            this.Load += PokemonFormLoad;
        }

        public void PokemonFormLoad(object sender, EventArgs e)
        {
            List<Pokemon> pokemons = new PokemonBus().GetAll();
            PokemonGirdView.DataSource = pokemons;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon()
            {
                ID = IDTb.Text.Trim(),
                Name = NameTb.Text.Trim(),
                Height = (float)System.Math.Round(HeightTb.Value, 4),
                Weight = (float)System.Math.Round(WeightTb.Value, 4),
                Type = TypeTb.Text.Trim()
            };
            bool result = new PokemonBus().Addnew(pokemon);
            if(result)
            {
                List<Pokemon> list = new PokemonBus().GetAll();
                PokemonGirdView.DataSource = list;
            } else
            {
                MessageBox.Show("ADD FAILED");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon()
            {
                ID = IDTb.Text.Trim(),
                Name = NameTb.Text.Trim(),
                Height = (float)System.Math.Round(HeightTb.Value, 4),
                Weight = (float)System.Math.Round(WeightTb.Value, 4),
                Type = TypeTb.Text.Trim()
            };
            bool result = new PokemonBus().Update(pokemon);
            if (result)
            {
                List<Pokemon> list = new PokemonBus().GetAll();
                PokemonGirdView.DataSource = list;
            }
            else
            {
                MessageBox.Show("UPDATE FAILED");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE", "CONFIRMATION", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                string ID = IDTb.Text.Trim();
                bool result = new PokemonBus().Delete(ID);
                if(result)
                {
                    List<Pokemon> list = new PokemonBus().GetAll();
                    PokemonGirdView.DataSource = list;
                } else
                {
                    MessageBox.Show("DELETE FAILED");
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Length != 0)
            {
                List<Pokemon> list = new PokemonBus().Search(searchBox.Text.Trim());
                PokemonGirdView.DataSource = list;
            }
            else
            {
                List<Pokemon> list = new PokemonBus().GetAll();
                PokemonGirdView.DataSource = list;
            }
        }

        private void PokemonGirdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pokemon SelectedPokemon = (Pokemon)PokemonGirdView.Rows[e.RowIndex].DataBoundItem;
            IDTb.Text = SelectedPokemon.ID;
            NameTb.Text = SelectedPokemon.Name;
            HeightTb.Value = (decimal)SelectedPokemon.Height;
            WeightTb.Value = (decimal)SelectedPokemon.Weight;
            TypeTb.Text = SelectedPokemon.Type;
        }
    }
}
