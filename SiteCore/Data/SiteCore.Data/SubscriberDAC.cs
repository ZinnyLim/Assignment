using Microsoft.Practices.EnterpriseLibrary.Data;
using SiteCore.Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCore.Data
{
    public partial class SubscriberDAC : DataAccessComponent, ISubscriberDAC
    {
        public Boolean Create(Subscriber subscriber)
        {
            const string SQL_STATEMENT =
                "INSERT INTO Subscribers (Name, SubscribeDate, Status) " +
                "VALUES(@Name, @SubscribeDate, @Status);  ";

            // Connect to database.
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Name", DbType.AnsiString, subscriber.Name);
                db.AddInParameter(cmd, "@SubscribeDate", DbType.DateTime, subscriber.SubscribeDate);
                db.AddInParameter(cmd, "@Status", DbType.Boolean, subscriber.Status);

                db.ExecuteNonQuery(cmd); 

            }

            return true;
        }


        public List<Subscriber> List()
        {
            List<Subscriber> subscribers = new List<Subscriber>();

            const string SQL_STATEMENT =
                "SELECT SubID, Name, SubscribeDate, TerminateDate, Status FROM Subscribers ";

            // Connect to database.
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create(CONNECTION_NAME);
            //Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))

            using (IDataReader dr = db.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    Subscriber sub = new Subscriber(); 

                    // Read values.
                    sub.SubID = base.GetDataValue<int>(dr, "SubID");
                    sub.Name  = base.GetDataValue<string>(dr, "Name");
                    sub.SubscribeDate = base.GetDataValue<DateTime>(dr, "SubscribeDate");
                    sub.TerminateDate = base.GetDataValue<DateTime>(dr, "TerminateDate");
                    sub.Status = base.GetDataValue<Boolean>(dr, "Status");

                    // Add to List.
                    subscribers.Add(sub);
                }
            }

            return subscribers;
        }



    }
}
