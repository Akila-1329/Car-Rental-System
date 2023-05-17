using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class CarRentalIntermediaryClass
    {
        public string LastError { get; set; }

        public DataTable GetCustomerReviews()
        {
            CarRentalDataAccessClass carRentalDataAccess = new CarRentalDataAccessClass();
            string sqlQuery = "select * from Reviews";

            try
            {
                return carRentalDataAccess.GetTable(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }//end GetReservations() 
        public DataTable GetPickupReport()
        {
            CarRentalDataAccessClass carRentalDataAccess = new CarRentalDataAccessClass();
            string sqlQuery = "Select u.user_name, r.reservation_id, r.reservation_slot, r.status, r.price, r.current_odometer from" +
                " Users u join Reservations r On (r.user_id = u.user_id) Where r.status = N'Approved'";
            
            try
            {
                return carRentalDataAccess.GetTable(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
        public DataTable GetReturnReport()
        {
            CarRentalDataAccessClass carRentalDataAccess = new CarRentalDataAccessClass();
            string sqlQuery = "Select u.user_name, r.reservation_id, r.reservation_slot, r.status, r.price, r.current_odometer from" +
                " Users u join Reservations r On (r.user_id = u.user_id) Where r.status = N'Completed'";

            try
            {
                return carRentalDataAccess.GetTable(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
        public int ReserveCar(int reservationId, string resrevationSlot, string status, decimal price, int userId)
        {
            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            //create the query string with place holders for pararmeters
            string sqlQuery = "Insert into Reservations values (@ReservationId, @ReservationSlot, @Status, @Price, @UserID, 0);";
            SqlParameter param1 = new SqlParameter("@ReservationId", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@ReservationSlot", SqlDbType.NChar);
            SqlParameter param3 = new SqlParameter("@Status", SqlDbType.NChar);
            SqlParameter param4 = new SqlParameter("@Price", SqlDbType.Decimal);
            SqlParameter param5 = new SqlParameter("@UserId", SqlDbType.Int);

            //supply the values for parameters
            param1.Value = reservationId;
            param2.Value = resrevationSlot;
            param3.Value = status;
            param4.Value = price;
            param5.Value = userId;

            try
            {
                var res = carRentalDataAccessClass.ExecNonQuery(sqlQuery, CommandType.Text, param1, param2, param3, param4, param5);
                return res;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//reserve car db entries after reservations

        public int GetCount()
        {
            string queryString = "Select Count(*) from Reservations;";

            try
            {
                //instantiate class
                CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
                return Convert.ToInt32(carRentalDataAccessClass.ExecScalarQuery(queryString, System.Data.CommandType.Text));
                //scalar method requires query string and command type , which is sent
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//GetCount()

        public DataTable GetAvailableSlots()
        {
            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            string SqlQuery = "Select slot_id, slot_available, status from Slots where status = 'available';";

            try
            {
                return carRentalDataAccessClass.GetTable(SqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }

        public DataTable getUserForLogin(string username, string pwd)
        {
            CarRentalDataAccessClass carRentalDataAccess = new CarRentalDataAccessClass();
            string sqlQuery = "Select * from Users where user_name = @user_name and password = @password";
            SqlParameter param1 = new SqlParameter("@user_name", SqlDbType.NChar);
            SqlParameter param2 = new SqlParameter("@password", SqlDbType.NChar);
            param1.Value = username;
            param2.Value = pwd;
            
            try
            {
                return carRentalDataAccess.GetTable(sqlQuery, CommandType.Text, param1, param2);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
        public DataTable getReservationById(int reservationid, int userid)
        {
            CarRentalDataAccessClass carRentalDataAccess = new CarRentalDataAccessClass();
            string sqlQuery = "Select * from Reservations where reservation_id = @reservation_id and user_id = @user_id;";
            SqlParameter param1 = new SqlParameter("@reservation_id", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@user_id", SqlDbType.Int);

            param1.Value = reservationid;
            param2.Value = userid;

            try
            {
                return carRentalDataAccess.GetTable(sqlQuery, CommandType.Text, param1, param2);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
        public DataTable getSlotByReservationDate(string slotAvailable)
        {
            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            //Select * from Users where user_name = @user_name and password = @password"
            //Select slot_id, slot_available, status from Slots where status = 'available';
            string sqlQuery = "Select slot_id, slot_available, status from Slots where slot_available = @slot_available;";
            SqlParameter param1 = new SqlParameter("@slot_available", SqlDbType.NChar);

            param1.Value = slotAvailable;

            try
            {
                return carRentalDataAccessClass.GetTable(sqlQuery, CommandType.Text, param1);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
        public int changeStatusToAvailable(int slotId)
        {
            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            string sqlQuery = "Update Slots SET status = 'available' where slot_id = @slot_id;";

            SqlParameter param1 = new SqlParameter("@slot_id", SqlDbType.Int);

            param1.Value = slotId;

            try
            {
                return carRentalDataAccessClass.ExecNonQuery(sqlQuery, CommandType.Text, param1);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//change status
        public int changeStatusToCancelled(int reservationId)
        {
            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            string sqlQuery = "Update Reservations SET status = 'cancelled' where reservation_id = @reservation_id;";

            SqlParameter param1 = new SqlParameter("@reservation_id", SqlDbType.Int);

            param1.Value = reservationId;

            try
            {
                return carRentalDataAccessClass.ExecNonQuery(sqlQuery, CommandType.Text, param1);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//change status to cancelled
        public int changeStatusToUnavailable(int slotId)
        {
            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            string sqlQuery = "Update Slots SET status = 'unavailable' where slot_id = @slot_id;";

            SqlParameter param1 = new SqlParameter("@slot_id", SqlDbType.Int);

            param1.Value = slotId;

            try
            {
                return carRentalDataAccessClass.ExecNonQuery(sqlQuery, CommandType.Text, param1);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//change status
        public int addUser()
        //public int addUser(int userId, string username, string pwd, string role)
        //public int addReview(int reviewId, string username, string desc)
        {
            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            //create the query string with place holders for pararmeters
            string sqlQuery = "Insert into Slots values (3, 'Nov11th', 'available');";
            //string sqlQuery = "Delete from Slots where slot_id=3";
            //string sqlQuery = "Insert into Users values (@review_id, @user_name, @description);";
            /*SqlParameter param1 = new SqlParameter("@review_id", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@user_name", SqlDbType.NChar);
            SqlParameter param3 = new SqlParameter("@description", SqlDbType.NChar);

            //supply the values for parameters
            param1.Value = reviewId;
            param2.Value = username;
            param3.Value = desc;*/

            try
            {
                return carRentalDataAccessClass.ExecNonQuery(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//reserve car db entries after reservations

        public int GetReservationsWithUserNameCount<T>(T userName)
        {
            string queryString = "Select COUNT(*) from Reservations R join Users U On (R.user_id = U.user_id) Where U.user_name = @userName";
            //string queryString = "Select * from Reservations R join Users U On (R.user_id = U.user_id) Where U.user_name = @UserName";
            SqlParameter param1 = new SqlParameter("@UserName", SqlDbType.NChar);
            //supply the values for paramete

            param1.Value = userName;
            try
            {
                //instantiate class
                CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
                return Convert.ToInt32(carRentalDataAccessClass.ExecScalarQuery(queryString, System.Data.CommandType.Text, param1));
                //scalar method requires query string and command type , which is sent
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//GetCount()

        public DataTable GetProcessPickUPReservations(string userName)
        {
            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            string SqlQuery = "Select reservation_id from Reservations R join Users U On (R.user_id = U.user_id) where U.user_name = @UserName";
            //string SqlQuery = "Select user_id from Users where user_name = '@user_name'";
            SqlParameter param1 = new SqlParameter("@UserName", SqlDbType.NChar);

            param1.Value = userName;

            try
            {
                var res = carRentalDataAccessClass.GetTable(SqlQuery, CommandType.Text, param1);
                return res;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }


        public int ConfirmPickUP(int reservationId, int odometerReading)
        {
            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            //create the query string with place holders for pararmeters
            string sqlQuery = "Update Reservations SET current_odometer = @CurrentOdometer, status = N'Approved' where reservation_id = @ReservationId";
            SqlParameter param1 = new SqlParameter("@CurrentOdometer", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@ReservationId", SqlDbType.Int);
            //supply the values for parameter

            param1.Value = odometerReading;
            param2.Value = reservationId;
            
            try
            {
                return carRentalDataAccessClass.ExecNonQuery(sqlQuery, CommandType.Text, param1, param2);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }

        public DataTable GetProcessReturnOdometerReading(string reservationID)
        {

            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            string SqlQuery = "select current_odometer, price from Reservations where reservation_id = @ReservationID";
            SqlParameter param1 = new SqlParameter("@ReservationID", SqlDbType.Int);

            param1.Value = reservationID;

            try
            {
                return carRentalDataAccessClass.GetTable(SqlQuery, CommandType.Text, param1);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }

        public int CompleteReservation(int odometerReading, int price, int reservationId)
        {

            CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
            //create the query string with place holders for pararmeters
            string sqlQuery = "Update Reservations SET current_odometer = @CurrentOdometer, status = N'Completed', price = @Price where reservation_id = @ReservationId";
            SqlParameter param1 = new SqlParameter("@CurrentOdometer", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@Price", SqlDbType.Int);
            SqlParameter param3 = new SqlParameter("@ReservationId", SqlDbType.Int);
            //supply the values for parameter

            param1.Value = odometerReading;
            param2.Value = price;
            param3.Value = reservationId;

            try
            {
                var res = carRentalDataAccessClass.ExecNonQuery(sqlQuery, CommandType.Text, param1, param2, param3);
                return res;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }

        public int GetReservationsWithreservationIDeCount(string reservationId)
        {
            int changedReservationId;
            bool isParsable = int.TryParse(reservationId, out changedReservationId);
            if (isParsable)
            {
                string queryString = "Select COUNT(*) from Reservations where reservation_id = @ReservationId";
                SqlParameter param1 = new SqlParameter("@ReservationId", SqlDbType.Int);
                //supply the values for paramete

                param1.Value = changedReservationId;
                try
                {
                    //instantiate class
                    CarRentalDataAccessClass carRentalDataAccessClass = new CarRentalDataAccessClass();
                    return Convert.ToInt32(carRentalDataAccessClass.ExecScalarQuery(queryString, System.Data.CommandType.Text, param1));
                    //scalar method requires query string and command type , which is sent
                }
                catch (Exception ex)
                {
                    LastError = ex.Message;
                    return -1;
                }
            }
            else
            {
                return 0;
            }

        }//GetCount()
    }
}
