using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class CountrySQLiteController
    {
        private SqliteConnection connection;

        public CountrySQLiteController()
        {
            connection = new SqliteConnection("Data Source=countriesDB.db");
        }

        public void Create(Country entity)
        {
            connection.Open();
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO countries values(@name, @shortName, @GDP, @InIndustry, @InAgriculture, @InService, @Unemployed, @Inflation)";
            SetParams(command, entity);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(string name, Country entity)
        {
            connection.Open();
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "Update countries SET name=@name, " +
                "shortName=@shortName, " +
                "GdpPerCapita=@GDP, percentInIndustry=@InIndustry, " +
                "percentInAgriculture=@InAgriculture, " +
                "percentInServiceSphere=@InService, " +
                "percentOfUnemployed=@Unemployed, " +
                "percentOfInflation=@Inflation" +
                " WHERE name=\'"+name+"\'";
            SetParams(command, entity);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(string name)
        {
            connection.Open();
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM countries WHERE name=@name";
            SqliteParameter namePar = new SqliteParameter("@name", name);
            command.Parameters.Add(namePar);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public List<Country> GetAll()
        {
            List<Country> countries = new List<Country>();
            connection.Open();
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM countries";
            SqliteDataReader reader =  command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    string shortName = reader.GetString(1);
                    float Gdp = reader.GetFloat(2);
                    float inIndustry = reader.GetFloat(3);
                    float inAgriculture = reader.GetFloat(4);
                    float inService = reader.GetFloat(5);
                    float unemployed = reader.GetFloat(6);
                    float inflation = reader.GetFloat(7);
                    countries.Add(new Country(name, shortName, Gdp, inIndustry, inAgriculture, inService, unemployed, inflation));
                }
            }
            connection.Close();
            return countries;
        }
        public Country GetByName(string name)
        {
            connection.Open();
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM countries WHERE name='"+name+"'";
            SqliteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                string shortName = reader.GetString(1);
                float Gdp = reader.GetFloat(2);
                float inIndustry = reader.GetFloat(3);
                float inAgriculture = reader.GetFloat(4);
                float inService = reader.GetFloat(5);
                float unemployed = reader.GetFloat(6);
                float inflation = reader.GetFloat(7);
                return new Country(name, shortName, Gdp, inIndustry, inAgriculture, inService, unemployed, inflation);
            }
            return null;
        }

        private void SetParams(SqliteCommand command, Country entity)
        {
            SqliteParameter nameParam = new SqliteParameter("@name", entity.Name);
            command.Parameters.Add(nameParam);
            SqliteParameter shortNameParam = new SqliteParameter("@shortName", entity.ShortName);
            command.Parameters.Add(shortNameParam);
            SqliteParameter GdpParam = new SqliteParameter("@GDP", entity.GDP);
            command.Parameters.Add(GdpParam);
            SqliteParameter industryParam = new SqliteParameter("@InIndustry", entity.PercentInIndustry);
            command.Parameters.Add(industryParam);
            SqliteParameter agrParam = new SqliteParameter("@InAgriculture", entity.PercentInAgricuture);
            command.Parameters.Add(agrParam);
            SqliteParameter serviceParam = new SqliteParameter("@InService", entity.PercentInServiceSphere);
            command.Parameters.Add(serviceParam);
            SqliteParameter unemployedParam = new SqliteParameter("@Unemployed", entity.PercentOfUnemployed);
            command.Parameters.Add(unemployedParam);
            SqliteParameter inflationParam = new SqliteParameter("@Inflation", entity.PercentOfInflation);
            command.Parameters.Add(inflationParam);
        }
    }
}
