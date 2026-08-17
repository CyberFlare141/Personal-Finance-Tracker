using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace _20230104141_assingment_1
{
    // Handles all database (ADO.NET) operations for the Debt Tracker module.
    public class DebtRepository
    {
        private string strConnection = ConfigurationManager.ConnectionStrings["DBConn"].ToString();

        // Inserts a new debt record into the Debts table.
        public void AddDebt(Debt debt)
        {
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strCommand = "insert into Debts (Name, OriginalAmount, InterestRate, DueDate, DebtType, AmountPaid) "
                + "values (@name, @amount, @rate, @due, @type, 0)";

            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            objCommand.Parameters.AddWithValue("@name", debt.Name);
            objCommand.Parameters.AddWithValue("@amount", debt.OriginalAmount);
            objCommand.Parameters.AddWithValue("@rate", debt.InterestRate);
            objCommand.Parameters.AddWithValue("@due", debt.DueDate);
            objCommand.Parameters.AddWithValue("@type", debt.DebtType);
            objCommand.ExecuteNonQuery();

            objConnection.Close();
        }

        // Adds a repayment amount on top of whatever has already been paid for that debt.
        public void AddPayment(DebtPayment payment)
        {
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strCommand = "update Debts set AmountPaid = AmountPaid + @amount where DebtId = @id";

            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            objCommand.Parameters.AddWithValue("@amount", payment.Amount);
            objCommand.Parameters.AddWithValue("@id", payment.DebtId);
            objCommand.ExecuteNonQuery();

            objConnection.Close();
        }

        // Retrieves every debt record from the database.
        public List<Debt> GetAllDebts()
        {
            List<Debt> debts = new List<Debt>();

            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strCommand = "select DebtId, Name, OriginalAmount, InterestRate, DueDate, DebtType, AmountPaid from Debts";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            SqlDataReader objReader = objCommand.ExecuteReader();

            while (objReader.Read())
            {
                Debt debt = new Debt();
                debt.DebtId = Convert.ToInt32(objReader["DebtId"]);
                debt.Name = objReader["Name"].ToString() ?? "";
                debt.OriginalAmount = Convert.ToDecimal(objReader["OriginalAmount"]);
                debt.InterestRate = Convert.ToDecimal(objReader["InterestRate"]);
                debt.DueDate = Convert.ToDateTime(objReader["DueDate"]);
                debt.DebtType = objReader["DebtType"].ToString() ?? "";
                debt.AmountPaid = Convert.ToDecimal(objReader["AmountPaid"]);
                debts.Add(debt);
            }

            objReader.Close();
            objConnection.Close();

            return debts;
        }

        // Removes a debt record permanently.
        public void DeleteDebt(int debtId)
        {
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strCommand = "delete from Debts where DebtId = @id";

            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            objCommand.Parameters.AddWithValue("@id", debtId);
            objCommand.ExecuteNonQuery();

            objConnection.Close();
        }
    }
}
