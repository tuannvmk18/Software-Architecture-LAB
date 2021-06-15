using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Bus;
namespace WebApplication1.View
{
    public partial class PokemonForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                List<Pokemon> pokemons = new PokemonBus().GetAll();
                gvPokemons.DataSource = pokemons;
                gvPokemons.DataBind();
            }
        }

        protected void gvPokemons_SelectIndexChanged(object sender, EventArgs e)
        {
            string ID = (String)gvPokemons.SelectedRow.Cells[1].Text.Trim();
            Pokemon pokemon = new PokemonBus().GetDetails(ID)[0];
            if(pokemon != null)
            {
                txtID.Text = pokemon.ID;
                txtName.Text = pokemon.Name;
                txtHeight.Text = pokemon.Height.ToString();
                txtWeight.Text = pokemon.Weight.ToString();
                txtType.Text = pokemon.Type;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Pokemon> pokemons = new PokemonBus().SelectAllByKeyword(keyword);
            gvPokemons.DataSource = pokemons;
            gvPokemons.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon()
            {
                ID = txtID.Text.Trim(),
                Name = txtName.Text.Trim(),
                Height = (float?)Double.Parse(txtHeight.Text.Trim()),
                Weight = (float?)Double.Parse(txtWeight.Text.Trim()),
                Type = txtType.Text.Trim()
            };
            bool result = new PokemonBus().AddNew(pokemon);
            if(result)
            {
                List<Pokemon> pokemons = new PokemonBus().GetAll();
                gvPokemons.DataSource = pokemons;
                gvPokemons.DataBind();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon()
            {
                ID = txtID.Text.Trim(),
                Name = txtName.Text.Trim(),
                Height = (float?)Double.Parse(txtHeight.Text.Trim()),
                Weight = (float?)Double.Parse(txtWeight.Text.Trim()),
                Type = txtType.Text.Trim()
            };
            bool result = new PokemonBus().Update(pokemon);
            if (result)
            {
                List<Pokemon> pokemons = new PokemonBus().GetAll();
                gvPokemons.DataSource = pokemons;
                gvPokemons.DataBind();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text.Trim();
            bool result = new PokemonBus().Delete(ID);
            if (result)
            {
                List<Pokemon> pokemons = new PokemonBus().GetAll();
                gvPokemons.DataSource = pokemons;
                gvPokemons.DataBind();
            }
        }
    }
}