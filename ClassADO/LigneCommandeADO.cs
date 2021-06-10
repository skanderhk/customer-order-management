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
    public class LigneCommandeADO
    {
        public static void Inserer(LigneCommande lc)
        {
            SqlCommand cmdaj = new SqlCommand("insert into LigneCommande (Num_Cde,Ref_Prod,Qte)" +
                " values (@Num,@Ref,@Qte)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@Num", lc.NumCde);
            cmdaj.Parameters.AddWithValue("@Ref", lc.RefProd);
            cmdaj.Parameters.AddWithValue("@Qte", lc.Qte);
            cmdaj.ExecuteNonQuery();
        }

        public static void Supprimer(int NumCde)
        {
            string req = "Delete from LigneCommande where Num_Cde=@Num_Cde";
            SqlCommand cmdsupp = new SqlCommand(req, Connexion.cn);
            cmdsupp.Parameters.AddWithValue("@Num_Cde", NumCde);
            cmdsupp.ExecuteNonQuery();
        }

        public static void Modifier(LigneCommande lc)
        {
            string req = "update LigneCommande set Num_Cde=@Num, Ref_Prod=@Ref, Qte=@Qte where Num_Cde=@Num";
            SqlCommand cmdmaj = new SqlCommand(req, Connexion.cn);
            cmdmaj.Parameters.AddWithValue("@Num", lc.NumCde);
            cmdmaj.Parameters.AddWithValue("@Ref", lc.RefProd);
            cmdmaj.Parameters.AddWithValue("@Qte", lc.Qte);
            cmdmaj.ExecuteNonQuery();
        }

        public static bool Existe_LigneCommande(int Num_Cde)
        {
            SqlCommand cverif = new SqlCommand("select * from LigneCommande where Num_Cde=@Num");
            cverif.Parameters.AddWithValue("@Num", Num_Cde);
            SqlDataReader drverif = cverif.ExecuteReader();
            var res = drverif.HasRows;
            drverif.Close();
            return res;
        }

        public static LigneCommande LigneCommande(int NumCde)
        {

            DataTable dtcl = new DataTable();
            string req = "select * from LigneCommande where Num_Cde=@Num";

            SqlDataAdapter da = new SqlDataAdapter(req, Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Num", NumCde);
            da.Fill(dtcl);
            if(dtcl.Rows.Count > 0)
            {
                return new LigneCommande
                {
                    NumCde = int.Parse(dtcl.Rows[0][0].ToString()),
                    RefProd = int.Parse(dtcl.Rows[0][1].ToString()),
                    Qte = int.Parse(dtcl.Rows[0][2].ToString()),

                };
            } 
                return new LigneCommande();
            
            


        }

        public static List<LigneCommande> Liste_LigneCommande()
        {
            List<LigneCommande> lcs = new List<LigneCommande>();
            DataTable dtcl = new DataTable();
            string req = "select * from LigneCommande";
            SqlDataAdapter da = new SqlDataAdapter(req, Connexion.cn);
            da.Fill(dtcl);
            for (int i = 0; i < dtcl.Rows.Count; i++)
            {
                LigneCommande lc = new LigneCommande
                {
                    NumCde = int.Parse(dtcl.Rows[i][0].ToString()),
                    RefProd = int.Parse(dtcl.Rows[i][1].ToString()),
                    Qte = int.Parse(dtcl.Rows[i][2].ToString()),

                };
                lcs.Add(lc);
            }
            return lcs;

        }

        public static DataTable Liste_LigneCommande_Num(int NumCde)
        {
            DataTable dtpr = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from LigneCommande where Num_Cde=@Num", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Num", NumCde);
            da.Fill(dtpr);
            return dtpr;
        }

        public static DataTable Liste_LigneCommande_CIN(int RefProd)
        {
            DataTable dtpr = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from LigneCommande where Ref_Prod=@RefProd", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@RefProd", RefProd);
            da.Fill(dtpr);
            return dtpr;
        }


    }
}
