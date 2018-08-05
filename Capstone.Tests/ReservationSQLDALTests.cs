using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Transactions;
using Capstone.Models;
using Capstone.DAL;

namespace Capstone.Tests
{
    [TestClass]
    public class ReservationSQLDALTests
    {
        [TestClass()]
        public class ReservationSqlDALTests
        {
            private TransactionScope tran;
            private string connectionString = ConfigurationManager.ConnectionStrings["CapstoneDatabase"].ConnectionString;
            private int reservationId;

            [TestInitialize]
            public void Initialize()
            {
                tran = new TransactionScope();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd;

                    conn.Open();

                    cmd = new SqlCommand("INSERT INTO ();", conn);
                    cmd.ExecuteNonQuery();
                }
            }

            [TestCleanup]
            public void Cleanup()
            {
                tran.Dispose();
            }

            [TestMethod]
        }
    }
}
