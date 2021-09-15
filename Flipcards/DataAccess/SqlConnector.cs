using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Dapper;
using FlipCards.Models;

namespace Flipcards.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Flipcards";
        public DeckModel CreateDeck(DeckModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@DeckName", model.DeckName);
                p.Add("@id", 0, dbType: DbType.Int32, ParameterDirection.Output);

                connection.Execute("dbo.spDeck_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public CardModel CreateCard(CardModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Prompt", model.Prompt);
                p.Add("@Answer", model.Answer);
                p.Add("@DeckId", model.DeckId);
                p.Add("@id", 0, dbType: DbType.Int32, ParameterDirection.Output);

                connection.Execute("dbo.spCard_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public List<DeckModel> GetDeck_All()
        {
            List<DeckModel> output;

            using (IDbConnection connection = 
                new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DeckModel>("dbo.spDeck_GetAll").ToList();
            }

            return output;
        }

        public List<CardModel> GetCard_All()
        {
            List<CardModel> output;

            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<CardModel>("dbo.spCard_GetAll").ToList();
            }

            return output;
        }

        public void DeleteDeck(DeckModel model)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                //TODO maybe we don't need to use the DeckName here, consider removing
                var d = new DynamicParameters();
                d.Add("@DeckName", model.DeckName);
                d.Add("@id", model.Id);

                connection.Execute("dbo.spDeck_Delete", d, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteCard(CardModel model)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var d = new DynamicParameters();
                d.Add("@id", model.Id);

                connection.Execute("dbo.spCard_Delete", d, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateDeck(DeckModel model)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var d = new DynamicParameters();
                d.Add("@DeckName", model.DeckName);
                d.Add("@id", model.Id);

                connection.Execute("dbo.spDeck_Update", d, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateCard(CardModel model)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var d = new DynamicParameters();
                d.Add("@Prompt", model.Prompt);
                d.Add("@Answer", model.Answer);
                d.Add("@id", model.Id);

                connection.Execute("dbo.spCard_Update", d, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
