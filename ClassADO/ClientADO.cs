using ClassBL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassADO
{
    public class ClientADO
    {
        public static void Inserer(Client c)
        {
            SqlCommand cmdaj = new SqlCommand("insert into Client (CIN_Cl,Nom_Cl,Pren_Cl,Ville_Cl,Tel_Cl) values (@Cin,@Nom,@Pren," +
                "@Ville,@Tel)", Connexion.cn);

            cmdaj.Parameters.AddWithValue("@Cin", c.CIN_Cl);
            cmdaj.Parameters.AddWithValue("@Nom", c.Nom_Cl);
            cmdaj.Parameters.AddWithValue("@Pren", c.Pren_Cl);
            cmdaj.Parameters.AddWithValue("@Ville", c.Ville_Cl);
            cmdaj.Parameters.AddWithValue("@Tel", c.Tel_Cl);
            cmdaj.ExecuteNonQuery();
        }

        public static void Supprimer(int cin)
        {
            string req = "Delete from Client where CIN_Cl=@Cin";
            SqlCommand cmdsupp = new SqlCommand(req, Connexion.cn);
            cmdsupp.Parameters.AddWithValue("@Cin", cin);
            cmdsupp.ExecuteNonQuery();
        }

        public static void Modifier(Client c)
        {
            string req = "update Client set Nom_Cl=@Nom, Pren_Cl=@Pren,Ville_Cl=@Ville,Tel_Cl=@Tel where CIN_Cl=@Cin";
            SqlCommand cmdmaj = new SqlCommand(req, Connexion.cn);
            cmdmaj.Parameters.AddWithValue("@Cin", c.CIN_Cl);
            cmdmaj.Parameters.AddWithValue("@Nom", c.Nom_Cl);
            cmdmaj.Parameters.AddWithValue("@Pren", c.Pren_Cl);
            cmdmaj.Parameters.AddWithValue("@Ville", c.Ville_Cl);
            cmdmaj.Parameters.AddWithValue("@Tel", c.Tel_Cl);
            cmdmaj.ExecuteNonQuery();
        }

        public static DataTable Liste_Client()
        {
            DataTable dtcl = new DataTable();
            string req = "select * from Client";
            SqlDataAdapter da = new SqlDataAdapter(req, Connexion.cn);
            da.Fill(dtcl);
            return dtcl;
        }

        public static DataTable Recherche_Client_Cin(int NCde)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select cl.* from Client cl, Commande c where cl.Cin_Cl=c.Cin_Cl and c.Num_Cde=@Num", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Num", NCde);
            da.Fill(dtcl);
            return dtcl;
        }

        public static DataTable Recherche_Client_Cde(int NCde)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Client where CIN_Cl=@Cin", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Num", NCde);
            da.Fill(dtcl);
            return dtcl;
        }

        public static List<Client> Get_clients()
        {
            List<Client> l = new List<Client>();
            DataTable dtcl = new DataTable();
            string req = "select * from Client";
            SqlDataAdapter da = new SqlDataAdapter(req, Connexion.cn);
            da.Fill(dtcl);
            for (int i = 0; i < dtcl.Rows.Count; i++)
            {
                Client c = new Client
                { 
                    CIN_Cl = int.Parse(dtcl.Rows[i][0].ToString()),
                    Nom_Cl = dtcl.Rows[i][1].ToString(),
                    Pren_Cl = dtcl.Rows[i][2].ToString(),
                    Ville_Cl = dtcl.Rows[i][3].ToString(),
                    Tel_Cl = dtcl.Rows[i][4].ToString()

                };
                l.Add(c);
            }
            return l;
        }

        public static Client Recherche_cin(int cin)
        {
            return Get_clients().SingleOrDefault(XmlReadMode => XmlReadMode.CIN_Cl == cin);
        }

        public static List<Client> Recherche_NomPren(string val)
        {
            return Get_clients().Where(x => x.Nom_Cl.Contains(val) || x.Pren_Cl.Contains(val)).ToList();
        }

        public static List<Client> Recherche_ville(string ville)
        {
            return Get_clients().Where(x => x.Ville_Cl.Contains(ville)).ToList();
        }
    }
}
