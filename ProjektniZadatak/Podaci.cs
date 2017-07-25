using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;

namespace ProjektniZadatak
{
    class Podaci
    {
        public const string ConnectionString = @"Integrated Security=true;
                                                      Initial Catalog=Projekat_c#;
                                                      Data Source=SRDJAN-PC";

        static void UcitajKorisnike()
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"SELECT * FROM KORISNIK";

                    DataSet ds = new DataSet();
                    SqlDataAdapter custDA = new SqlDataAdapter();
                    custDA.SelectCommand = dataCommand;

                    custDA.Fill(ds, "Korisnik");

                    foreach (DataRow row in ds.Tables["Korisnik"].Rows)
                    {
                        Korisnik k = new Korisnik();
                        k.id=(int)row["Id_Korisnik"];
                        k.ime = row["Ime"] as String;
                        k.prezime = row["Prezime"] as String;
                        k.korIme = row["KorIme"] as String;
                        k.sifra = row["Sifra"] as String;
                        k.tipKorisnika = row["TipKorisnika"] as String;
                        Korisnici.Add(k);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }


        public static void DodajKorisnika(Korisnik k)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Insert INTO KORISNIK (Ime, Prezime, KorIme, Sifra, TipKorisnika) values(@Ime, @Prezime, @KorIme, @Sifra, @TipKorisnika); SET @Id_Korisnik=SCOPE_IDENTITY()";

                    SqlParameter param1 = new SqlParameter("@Id_Korisnik", k.id);
                    SqlParameter param2 = new SqlParameter("@Ime", k.ime);
                    SqlParameter param3 = new SqlParameter("@Prezime", k.prezime);
                    SqlParameter param4 = new SqlParameter("@KorIme", k.korIme);
                    SqlParameter param5 = new SqlParameter("@Sifra", k.sifra);
                    SqlParameter param6 = new SqlParameter("@TipKorisnika", k.tipKorisnika);


                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    dataCommand.Parameters.Add(param5);
                    dataCommand.Parameters.Add(param6);



                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void IzmeniKorisnika(Korisnik k)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Update KORISNIK SET Ime=@Ime,
                                              Prezime=@Prezime ,KorIme=@KorIme ,Sifra=@Sifra,
                                              TipKorisnika=@TipKorisnika where Id_Korisnik=@Id_Korisnik";



                    SqlParameter param1 = new SqlParameter("@Id_Korisnik", k.id);
                    SqlParameter param2 = new SqlParameter("@Ime", k.ime);
                    SqlParameter param3 = new SqlParameter("@Prezime", k.prezime);
                    SqlParameter param4 = new SqlParameter("@KorIme", k.korIme);
                    SqlParameter param5 = new SqlParameter("@Sifra", k.sifra);
                    SqlParameter param6 = new SqlParameter("@TipKorisnika", k.tipKorisnika);


                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    dataCommand.Parameters.Add(param5);
                    dataCommand.Parameters.Add(param6);



                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void ObrisiKorisnika(Korisnik k)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Delete From KORISNIK where Id_Korisnik=@Id_Korisnik";

                    SqlParameter param1 = new SqlParameter("@Id_Korisnik", k.id);
                    

                    dataCommand.Parameters.Add(param1);
                    
                    dataCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }
        }



        static void UcitajUcenike()
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"SELECT * FROM UCENIK";

                    DataSet ds = new DataSet();
                    SqlDataAdapter custDA = new SqlDataAdapter();
                    custDA.SelectCommand = dataCommand;

                    custDA.Fill(ds, "Ucenik");

                    foreach (DataRow row in ds.Tables["Ucenik"].Rows)
                    {
                        Ucenik u = new Ucenik();
                        u.id = (int)row["Id_Ucenik"];
                        u.ime = row["Ime"] as String;
                        u.prezime = row["Prezime"] as String;
                        u.brTelefona = row["BrTelefona"] as String;
                        u.jmbg = row["Jmbg"] as String;
                        u.adresa = row["Adresa"] as String;
                        
                        Ucenici.Add(u);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void DodajUcenika(Ucenik u)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Insert INTO UCENIK (Ime, Prezime, BrTelefona, Jmbg, Adresa, Kurs) values(@Ime, @Prezime, @BrTelefona, @Jmbg, @Adresa, @Kurs); SET @Id_Ucenik=SCOPE_IDENTITY()";

                    SqlParameter param1 = new SqlParameter("@Id_Ucenik", u.id);
                    SqlParameter param2 = new SqlParameter("@Ime", u.ime);
                    SqlParameter param3 = new SqlParameter("@Prezime", u.prezime);
                    SqlParameter param4 = new SqlParameter("@BrTelefona", u.brTelefona);
                    SqlParameter param5 = new SqlParameter("@Jmbg", u.jmbg);
                    SqlParameter param6 = new SqlParameter("@Adresa", u.adresa);
                    foreach (Kurs k in Kursevi)
                    {
                        if (k.ucenici.Contains(u))
                        {
                            SqlParameter param7 = new SqlParameter("@Id_Kurs", u.kursevi.Contains(k));
                            dataCommand.Parameters.Add(param7);
                            param7.Direction = ParameterDirection.Output;
                        }

                    }

                    DodajPohadajUcenik(u);

                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    dataCommand.Parameters.Add(param5);
                    dataCommand.Parameters.Add(param6);

                    param1.Direction = ParameterDirection.Output;
                    

                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void DodajPohadajUcenik(Ucenik u)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Insert INTO Pohadja (Id_Ucenik) values(@Id_Ucenik) where Id_Ucenik=@Id_Ucenik; SET @Id_Ucenik=SCOPE_IDENTITY()";
                    
                    SqlParameter param1 = new SqlParameter("@Id_Ucenik", u.id);
                    foreach (Kurs k in Kursevi)
                    {

                        if (u.kursevi.Contains(k))
                        {
                            SqlParameter param2 = new SqlParameter("@Id_Kurs", k.id);
                            dataCommand.Parameters.Add(param2);
                        }
                    }

                    dataCommand.Parameters.Add(param1);
                    
                    

                    



                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        

        public static void IzmeniUcenika(Ucenik u)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Update Ucenik SET Ime=@Ime,
                                              Prezime=@Prezime ,BrTelefona=@BrTelefona ,Jmbg=@Jmbg,
                                              Adresa=@Adresa where Id_Ucenik=@Id_Ucenik";



                    SqlParameter param1 = new SqlParameter("@Id_Ucenik", u.id);
                    SqlParameter param2 = new SqlParameter("@Ime", u.ime);
                    SqlParameter param3 = new SqlParameter("@Prezime", u.prezime);
                    SqlParameter param4 = new SqlParameter("@BrTelefona", u.brTelefona);
                    SqlParameter param5 = new SqlParameter("@Jmbg", u.jmbg);
                    SqlParameter param6 = new SqlParameter("@Adresa", u.adresa);


                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    dataCommand.Parameters.Add(param5);
                    dataCommand.Parameters.Add(param6);



                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void ObrisiUcenika(Ucenik u)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Delete From Ucenik where Id_Ucenik=@Id_Ucenik";

                    SqlParameter param1 = new SqlParameter("@Id_Ucenik", u.id);

                    ObrisiPohadjaUcenika(u);
                    ObrisiUplateUcenika(u);
                    dataCommand.Parameters.Add(param1);

                    dataCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }
        }

        public static void ObrisiPohadjaUcenika(Ucenik u)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Delete Pohadja where Id_Ucenik=@Id_Ucenik";

                    SqlParameter param1 = new SqlParameter("@Id_Ucenik", u.id);
                    

                    dataCommand.Parameters.Add(param1);

                    dataCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void ObrisiUplateUcenika(Ucenik u)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Delete From Uplata where Id_Ucenik=@Id_Ucenik";

                    SqlParameter param1 = new SqlParameter("@Id_Ucenik", u.id);


                    dataCommand.Parameters.Add(param1);

                    dataCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        static void UcitajKurseve()
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"SELECT * FROM KURS";

                    DataSet ds = new DataSet();
                    SqlDataAdapter custDA = new SqlDataAdapter();
                    custDA.SelectCommand = dataCommand;

                    custDA.Fill(ds, "Kurs");
                    
                    foreach (DataRow row in ds.Tables["Kurs"].Rows)
                    {
                        Kurs ku = new Kurs();
                        ku.id = (int)row["Id_Kurs"];
                        ku.naziv = row["Naziv"] as String;
                        ku.jezik = row["Jezik"] as String;
                        ku.nivoJezika = row["NivoJezika"] as String;
                        ku.cena=(decimal)row["Cena"];
                        foreach (Nastavnik nas in Nastavnici)
                        {
                            if (row["Id_Nastavnik"] is int)
                            {

                                if ((int)row["Id_Nastavnik"] == nas.id)
                                {
                                    ku.nastavnik = nas;
                                }
                            }
                            
                            
                         }

                        
                        UcitajPohadjaKurs(ku);
                        Kursevi.Add(ku);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void DodajKrus(Kurs ku)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Insert INTO Kurs (Naziv, Jezik, NivoJezika, Cena, Id_Nastavnik) values(@Naziv, @Jezik, @NivoJezika, @Cena, @Id_Nastavnik); SET @Id_Kurs=SCOPE_IDENTITY()";

                    SqlParameter param1 = new SqlParameter("@Id_Kurs", ku.id);
                    SqlParameter param2 = new SqlParameter("@Naziv", ku.naziv );
                    SqlParameter param3 = new SqlParameter("@Jezik", ku.jezik);
                    SqlParameter param4 = new SqlParameter("@NivoJezika", ku.nivoJezika);
                    SqlParameter param5 = new SqlParameter("@Cena", ku.cena);
                    
                    foreach (Nastavnik n in Nastavnici)
                    {
                        if (ku.nastavnik==n)
                        {
                            SqlParameter param6 = new SqlParameter("@Id_Nastavnik", n.id);
                            dataCommand.Parameters.Add(param6);
                        }

                    }
                    

                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    dataCommand.Parameters.Add(param5);
                    



                    dataCommand.ExecuteNonQuery();

                    


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void IzmeniKurs(Kurs ku)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Update Kurs SET Naziv=@Naziv,
                                              Jezik=@Jezik ,NivoJezika=@NivoJezika,Cena=@Cena, Id_Nastavnik=@Id_Nastavnik
                                              where Id_Kurs=@Id_Kurs";



                    SqlParameter param1 = new SqlParameter("@Id_Kurs", ku.id);
                    SqlParameter param2 = new SqlParameter("@Naziv", ku.naziv);
                    SqlParameter param3 = new SqlParameter("@Jezik", ku.jezik);
                    SqlParameter param4 = new SqlParameter("@NivoJezika", ku.nivoJezika);
                    SqlParameter param5 = new SqlParameter("@Cena", ku.cena);
                    foreach (Nastavnik n in Nastavnici)
                    {
                        if (ku.nastavnik == n)
                        {
                            SqlParameter param6 = new SqlParameter("@Id_Nastavnik", n.id);
                            dataCommand.Parameters.Add(param6);
                        }

                    }
                    

                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    dataCommand.Parameters.Add(param5);

                    


                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        

        public static void ObrisiKurs(Kurs ku)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Delete From Kurs where Id_Kurs=@Id_Kurs";

                    SqlParameter param1 = new SqlParameter("@Id_Kurs", ku.id);
                    ObrisiPohadjaKurs(ku);
                    ObrisiUplateKursa(ku);
                    dataCommand.Parameters.Add(param1);

                    dataCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }
        }
        public static void ObrisiPohadjaKurs(Kurs ku)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Delete From Pohadja where Id_Kurs=@Id_Kurs";

                    SqlParameter param1 = new SqlParameter("@Id_Kurs", ku.id);


                    dataCommand.Parameters.Add(param1);

                    dataCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void ObrisiUplateKursa(Kurs ku)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Delete From Uplata where Id_Kurs=@Id_Kurs";

                    SqlParameter param1 = new SqlParameter("@Id_Kurs", ku.id);


                    dataCommand.Parameters.Add(param1);

                    dataCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        static void UcitajNastavnike()
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"SELECT * FROM NASTAVNIK";

                    DataSet ds = new DataSet();
                    SqlDataAdapter custDA = new SqlDataAdapter();
                    custDA.SelectCommand = dataCommand;

                    custDA.Fill(ds, "Nastavnik");

                    foreach (DataRow row in ds.Tables["Nastavnik"].Rows)
                    {
                        Nastavnik n = new Nastavnik();
                        n.id = (int)row["Id_Nastavnik"];
                        n.ime = row["Ime"] as String;
                        n.prezime = row["Prezime"] as String;
                        n.brTelefona = row["BrTelefona"] as String;
                        n.jmbg = row["Jmbg"] as String;
                        n.adresa = row["Adresa"] as String;
                        
                        Nastavnici.Add(n);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void DodajNastavnika(Nastavnik n)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Insert INTO NASTAVNIK (Ime, Prezime, BrTelefona, Jmbg, Adresa) values(@Ime, @Prezime, @BrTelefona, @Jmbg, @Adresa); SET @Id_Nastavnik=SCOPE_IDENTITY()";

                    SqlParameter param1 = new SqlParameter("@Id_Nastavnik", n.id);
                    SqlParameter param2 = new SqlParameter("@Ime", n.ime);
                    SqlParameter param3 = new SqlParameter("@Prezime", n.prezime);
                    SqlParameter param4 = new SqlParameter("@BrTelefona", n.brTelefona);
                    SqlParameter param5 = new SqlParameter("@Jmbg", n.jmbg);
                    SqlParameter param6 = new SqlParameter("@Adresa", n.adresa);


                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    dataCommand.Parameters.Add(param5);
                    dataCommand.Parameters.Add(param6);



                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void IzmeniNastavnika(Nastavnik n)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Update Nastavnik SET Ime=@Ime,
                                              Prezime=@Prezime ,BrTelefona=@BrTelefona ,Jmbg=@Jmbg,
                                              Adresa=@Adresa where Id_Nastavnik=@Id_Nastavnik";



                    SqlParameter param1 = new SqlParameter("@Id_Nastavnik", n.id);
                    SqlParameter param2 = new SqlParameter("@Ime", n.ime);
                    SqlParameter param3 = new SqlParameter("@Prezime", n.prezime);
                    SqlParameter param4 = new SqlParameter("@BrTelefona", n.brTelefona);
                    SqlParameter param5 = new SqlParameter("@Jmbg", n.jmbg);
                    SqlParameter param6 = new SqlParameter("@Adresa", n.adresa);


                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    dataCommand.Parameters.Add(param5);
                    dataCommand.Parameters.Add(param6);



                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        

        public static void ObrisiNastavnika(Nastavnik n)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Delete From Nastavnik where Id_Nastavnik=@Id_Nastavnik";

                    SqlParameter param1 = new SqlParameter("@Id_Nastavnik", n.id);
                    foreach (Kurs k in Kursevi)
                    {
                        if(n==k.nastavnik){
                        ObrisanNastavnikKursa(k);
                        }
                    }
                    dataCommand.Parameters.Add(param1);

                    dataCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }
        }

        public static void ObrisanNastavnikKursa(Kurs ku)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Update Kurs Set Id_Nastavnik=null
                                              where Id_Kurs=@Id_Kurs";



                    SqlParameter param1 = new SqlParameter("@Id_Kurs", ku.id); 
                    foreach (Nastavnik n in Nastavnici)
                    {
                        if (ku.nastavnik == n)
                        {
                            SqlParameter param6 = new SqlParameter("@Id_Nastavnik", n.id);
                            dataCommand.Parameters.Add(param6);
                        }

                    }


                    dataCommand.Parameters.Add(param1);
                    




                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        static void UcitajSkolu()
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"SELECT * FROM SKOLA";

                    DataSet ds = new DataSet();
                    SqlDataAdapter custDA = new SqlDataAdapter();
                    custDA.SelectCommand = dataCommand;

                    custDA.Fill(ds, "Skola");

                    foreach (DataRow row in ds.Tables["Skola"].Rows)
                    {
                        Skola s = new Skola();
                        s.id = (int)row["Id_Skola"];
                        s.naziv = row["Naziv"] as String;
                        s.adresa = row["Adresa"] as String;
                        s.brojTelefona = row["BrTelefona"] as String;
                        s.email = row["Email"] as String;
                        s.adresaSajta = row["AdresaSajta"] as String;
                        s.pib = row["Pib"] as String;
                        s.maticniBr = row["MaticniBr"] as String;
                        s.brZiroRacuna = row["brZiroRacuna"] as String;
                        Skole.Add(s);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void IzmeniSkolu(Skola s)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Update Skola SET Naziv=@Naziv,
                                              Adresa=@Adresa ,BrTelefona=@BrTelefona ,Email=@Email,
                                              AdresaSajta=@AdresaSajta, Pib=@Pib, MaticniBr=@MaticniBr, brZiroRacuna=@brZiroRacuna where Id_Skola=@Id_Skola";



                    SqlParameter param1 = new SqlParameter("@Id_Skola", s.id);
                    SqlParameter param2 = new SqlParameter("@Naziv", s.naziv);
                    SqlParameter param3 = new SqlParameter("@Adresa", s.adresa);
                    SqlParameter param4 = new SqlParameter("@BrTelefona", s.brojTelefona);
                    SqlParameter param5 = new SqlParameter("@Email", s.email);
                    SqlParameter param6 = new SqlParameter("@AdresaSajta", s.adresaSajta);
                    SqlParameter param7 = new SqlParameter("@Pib", s.pib);
                    SqlParameter param8 = new SqlParameter("@MaticniBr", s.maticniBr);
                    SqlParameter param9 = new SqlParameter("@brZiroRacuna", s.brZiroRacuna);



                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    dataCommand.Parameters.Add(param5);
                    dataCommand.Parameters.Add(param6);
                    dataCommand.Parameters.Add(param7);
                    dataCommand.Parameters.Add(param8);
                    dataCommand.Parameters.Add(param9);



                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        static void UcitajUplate()
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"SELECT * FROM UPLATA";

                    DataSet ds = new DataSet();
                    SqlDataAdapter custDA = new SqlDataAdapter();
                    custDA.SelectCommand = dataCommand;

                    custDA.Fill(ds, "Uplata");

                    foreach (DataRow row in ds.Tables["Uplata"].Rows)
                    {
                        Uplata up = new Uplata();
                        up.id = (int)row["Id_Uplata"];
                        up.iznos= (decimal)row["Iznos"];
                        foreach (Ucenik uc in Ucenici)
                        {
                            if ((int)row["Id_Ucenik"] == uc.id)
                            {
                                up.ucenik = uc;
                            }

                        }
                        foreach (Kurs ku in Kursevi)
                        {
                            if ((int)row["Id_Kurs"] == ku.id)
                            {
                                up.kurs = ku;
                            }
                        }
                        up.datum = (DateTime)row["Datum"];
                        up.valuta = row["Valuta"] as String;
                        Uplate.Add(up);
                       
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void ObrisiUplatu(Uplata up)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Delete From Uplata where Id_Uplata=@Id_Uplata";

                    SqlParameter param1 = new SqlParameter("@Id_Uplata", up.id);


                    dataCommand.Parameters.Add(param1);

                    dataCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }
        }

        public static void DodajUplatu(Uplata up)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Insert INTO Uplata (Iznos, Datum, Valuta, Id_Ucenik, Id_Kurs) values(@Iznos, @Datum, @Valuta, @Id_Ucenik, @Id_Kurs); SET @Id_Uplata=SCOPE_IDENTITY()";

                    SqlParameter param1 = new SqlParameter("@Id_Uplata", up.id);
                    SqlParameter param2 = new SqlParameter("@Iznos", up.iznos);
                    SqlParameter param3 = new SqlParameter("@Datum", up.datum);
                    SqlParameter param4 = new SqlParameter("@Valuta", up.valuta);
                    foreach (Ucenik u in Ucenici)
                    {
                        if (up.ucenik==u)
                        {
                            SqlParameter param5 = new SqlParameter("@Id_Ucenik", u.id);
                            dataCommand.Parameters.Add(param5);
                        }

                    }
                    foreach (Kurs k in Kursevi)
                    {
                        if (up.kurs==k)
                        {
                            SqlParameter param6 = new SqlParameter("@Id_Kurs", k.id);
                            dataCommand.Parameters.Add(param6);
                        }

                    }

                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    



                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        public static void IzmeniUplatu(Uplata up)
        {
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {

                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"Update Uplata SET Iznos=@Iznos,
                                              Datum=@Datum ,Valuta=@Valuta,Id_Ucenik=@Id_Ucenik,Id_Kurs=@Id_Kurs
                                              where Id_Uplata=@Id_Uplata";



                    SqlParameter param1 = new SqlParameter("@Id_Uplata", up.id);
                    SqlParameter param2 = new SqlParameter("@Iznos", up.iznos);
                    SqlParameter param3 = new SqlParameter("@Datum", up.datum);
                    SqlParameter param4 = new SqlParameter("@Valuta", up.valuta);
                    foreach (Ucenik u in Ucenici)
                    {
                        if (up.ucenik == u)
                        {
                            SqlParameter param5 = new SqlParameter("@Id_Ucenik", u.id);
                            dataCommand.Parameters.Add(param5);
                        }

                    }
                    foreach (Kurs k in Kursevi)
                    {
                        if (up.kurs == k)
                        {
                            SqlParameter param6 = new SqlParameter("@Id_Kurs", k.id);
                            dataCommand.Parameters.Add(param6);
                        }

                    }


                    dataCommand.Parameters.Add(param1);
                    dataCommand.Parameters.Add(param2);
                    dataCommand.Parameters.Add(param3);
                    dataCommand.Parameters.Add(param4);
                    



                    dataCommand.ExecuteNonQuery();



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        

        

        public static void UcitajPohadjaKurs(Kurs k)
        {
            
            using (SqlConnection dataConnection = new SqlConnection(Podaci.ConnectionString))
            {

                try
                {
                    dataConnection.Open();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;

                    dataCommand.CommandText = @"SELECT * FROM Pohadja";

                    DataSet ds = new DataSet();
                    SqlDataAdapter custDA = new SqlDataAdapter();
                    custDA.SelectCommand = dataCommand;

                    custDA.Fill(ds, "Pohadja");

                    foreach (DataRow row in ds.Tables["Pohadja"].Rows)
                    {
                        foreach (Ucenik u in Ucenici)
                        {
                            
                                if ((int)row["Id_Ucenik"] == u.id && (int)row["Id_kurs"] == k.id)
                                {

                                    k.ucenici.Add(u);

                                }
                        }

                    }

                }

                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database " + e.Message);

                }
            }

        }

        

        

        public static ObservableCollection<Korisnik> Korisnici { get; set; }
        public static ObservableCollection<Ucenik> Ucenici { get; set; }
        public static ObservableCollection<Kurs> Kursevi { get; set; }
        public static ObservableCollection<Nastavnik> Nastavnici { get; set; }
        public static ObservableCollection<Skola> Skole { get; set; }
        public static ObservableCollection<Uplata> Uplate { get; set; }


        public static void Inicijalizuj(){
            Korisnici = new ObservableCollection<Korisnik>();
            Ucenici = new ObservableCollection<Ucenik>();
            Kursevi = new ObservableCollection<Kurs>();
            Nastavnici = new ObservableCollection<Nastavnik>();
            Skole = new ObservableCollection<Skola>();
            Uplate = new ObservableCollection<Uplata>();

            UcitajKorisnike();
            UcitajUcenike();
            UcitajNastavnike();
            UcitajKurseve();
            UcitajSkolu();
            UcitajUplate();

            /*Korisnik kor1 = new Korisnik();
            kor1.ime = "Zoran";
            kor1.prezime = "Zoric";
            kor1.korIme = "zoki";
            kor1.sifra = "123";
            kor1.tipKorisnika = "Administrator";


            Korisnik kor2 = new Korisnik();
            kor2.ime = "Milos";
            kor2.prezime = "Milosevic";
            kor2.korIme = "miki";
            kor2.sifra = "123";
            kor2.tipKorisnika = "Zaposleni";


            Korisnici.Add(kor2);
            Korisnici.Add(kor1);
            

            Ucenik u1 = new Ucenik();
            
            u1.ime = "Goran";
            u1.prezime = "Gogic";
            u1.brTelefona = "0643331122";
            u1.jmbg = "1234567890123";
            u1.adresa = "Svetosavka 8 Zrenjanin";

            Ucenik u2 = new Ucenik();
            
            u2.ime = "Milan";
            u2.prezime = "Mikic";
            u2.brTelefona = "0643331122";
            u2.jmbg = "1111111111111";
            u2.adresa = "Svetosavka 8 Zrenjanin";

            Ucenici.Add(u1);
            Ucenici.Add(u2);

            Kurs k1 = new Kurs();
            k1.jezik = "Nemacki";
            k1.nivoJezika = "Nizi";
            k1.cena = 1200;
            Kursevi.Add(k1);


            Kurs k2 = new Kurs();
            k2.jezik = "Engleski";
            k2.nivoJezika = "Nizi";
            k2.cena = 1200;
            Kursevi.Add(k2);

            Kurs k3 = new Kurs();
            k3.jezik = "Engleski2";
            k3.nivoJezika = "Srednji";
            k3.cena = 1200;
            Kursevi.Add(k3);

            Nastavnik n1 = new Nastavnik();
            
            n1.ime = "Dragan";
            n1.prezime = "Dragic";
            n1.brTelefona = "0643331122";
            n1.jmbg = "1234567890123";
            n1.adresa = "Svetosavka 8 Zrenjanin";

            Nastavnik n2 = new Nastavnik();
            
            n2.ime = "Dusan";
            n2.prezime = "Dukic";
            n2.brTelefona = "0643331122";
            n2.jmbg = "22222222222222";
            n2.adresa = "Svetosavka 8 Zrenjanin";

            Nastavnici.Add(n1);
            Nastavnici.Add(n2);

            k1.ucenici.Add(u1);
            k1.nastavnik = n1;

            u1.kursevi.Add(k1);


            Skola s1 = new Skola();
            s1.naziv = "Skola stranih jezika";
            s1.adresa = "Hajduk Stanka 134 Beograd";
            s1.brojTelefona = "132312";
            s1.email = "ssj@gmail.com";
            s1.adresaSajta = "www.ssj.rs";
            s1.pib = "13553";
            s1.maticniBr = "54666";
            s1.brZiroRacuna = "123-421-11";
            Skole.Add(s1);


            Uplata up1 = new Uplata();
            up1.iznos = 1200;
            up1.valuta = "Dinar";

            Uplate.Add(up1);

            up1.ucenik = u1;
            */
           
        }
    }
}
