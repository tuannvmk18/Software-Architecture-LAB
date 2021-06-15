using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Model;
using System.Configuration;
using System.Data.SqlClient;
namespace WinFormsApp.Dao
{
    class PokemonDao
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<Pokemon> SelectAll()
        {
            db.ObjectTrackingEnabled = false;
            List<Pokemon> pokemons = db.Pokemons.ToList();
            return pokemons;
        }

        public List<Pokemon> SelectAllByKeyword(String keyword)
        {
            List<Pokemon> pokemons = db.Pokemons.Where(b => b.Name.Contains(keyword)).ToList();
            return pokemons;
        }

        public bool Insert(Pokemon pokemon)
        {
            try
            {
                db.Pokemons.InsertOnSubmit(pokemon);
                db.SubmitChanges();
                return true;
            } catch
            {
                return false;
            }
        }

        public bool Update(Pokemon pokemon)
        {
            Pokemon dbPokemon = db.Pokemons.SingleOrDefault(p => p.ID == pokemon.ID);
            if(dbPokemon != null)
            {
                try
                {
                    dbPokemon.Name = pokemon.Name;
                    dbPokemon.Height = pokemon.Height;
                    dbPokemon.Weight = pokemon.Weight;
                    dbPokemon.Type = pokemon.Type;
                    db.SubmitChanges();
                    return true;
                } catch
                {
                    return false;
                }
            }
            return true;
        }

        public bool Delete(string ID)
        {
            Pokemon dbPokemon = db.Pokemons.SingleOrDefault(p => p.ID == ID);
            if (dbPokemon != null)
            {
                try
                {
                    db.Pokemons.DeleteOnSubmit(dbPokemon);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public List<Pokemon> GetDetails(string ID)
        {
            List<Pokemon> pokemons = db.Pokemons.Where(p => p.ID == ID).ToList();
            return pokemons;
        }

        /*public List<Pokemon> SelectAll()
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT * FROM Pokemon";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                Pokemon pokemon = new Pokemon()
                {
                    ID = (string)dr["ID"],
                    Name = (string)dr["Name"],
                    Height = (float)dr["Height"],
                    Weight = (float)dr["Weight"],
                    Type = (string)dr["Type"]
                };
                pokemons.Add(pokemon);
            }
            con.Close();
            return pokemons;
        }*/

        /*public List<Pokemon> SelectAllByKeyword(String keyword)
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT * FROM Pokemon Where Name LIKE @keyword";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@keyword", "%" + keyword + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Pokemon pokemon = new Pokemon()
                {
                    ID = (string)dr["ID"],
                    Name = (string)dr["Name"],
                    Height = (float)dr["Height"],
                    Weight = (float)dr["Weight"],
                    Type = (string)dr["Type"]
                };
                pokemons.Add(pokemon);
            }
            return pokemons;
        }*/

        /*public bool Insert(Pokemon pokemon)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "INSERT INTO Pokemon VALUES(@ID, @Name, @Height, @Weight, @Type)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@ID", pokemon.ID));
            com.Parameters.Add(new SqlParameter("@Name", pokemon.Name));
            com.Parameters.Add(new SqlParameter("@Height", pokemon.Height));
            com.Parameters.Add(new SqlParameter("@Weight", pokemon.Weight));
            com.Parameters.Add(new SqlParameter("@Type", pokemon.Type));

            try
            {
                return com.ExecuteNonQuery() > 0;
            } catch
            {
                return false;
            }
        }*/

        /*public bool Update(Pokemon pokemon)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "Update Pokemon Set Name = @Name, Height = @Height,Weight = @Weight, Type =  @Type Where ID = @ID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@ID", pokemon.ID));
            com.Parameters.Add(new SqlParameter("@Name", pokemon.Name));
            com.Parameters.Add(new SqlParameter("@Height", pokemon.Height));
            com.Parameters.Add(new SqlParameter("@Weight", pokemon.Weight));
            com.Parameters.Add(new SqlParameter("@Type", pokemon.Type));

            try
            {
                return com.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }*/

        /*public bool Delete(string ID)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "DELETE FROM Pokemon WHERE ID = @ID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@ID", ID));
            try
            {
                return com.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }*/

        /*public List<Pokemon> GetDetails(string ID)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT * FROM Pokemon WHERE ID = @ID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@ID", ID));
            List<Pokemon> pokemons =new List<Pokemon>();
            try
            {
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Pokemon pokemon = new Pokemon()
                    {
                        ID = (string)dr["ID"],
                        Name = (string)dr["Name"],
                        Height = (float)dr["Height"],
                        Weight = (float)dr["Weight"],
                        Type = (string)dr["Type"]
                    };
                    pokemons.Add(pokemon);
                }
                con.Close();
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }
            return pokemons;
        }*/
    }
}
