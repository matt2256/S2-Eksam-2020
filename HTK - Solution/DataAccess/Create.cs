using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class Create
    {
        //methods needed for creating data 
        // Player - done
        // Reservation - done 
        // Pitch - done
        // Classification - only used for setting a client in specifik age groups -- make it later (need to figure out how to make it)


        /// <summary>
        /// Represent a method for creating Player data 
        /// </summary>
        /// <param name="_name">Represent the Name (string)</param>
        /// <param name="_address">Represent the Adress (string)</param>
        /// <param name="_cellphoneNumber">Represent the CellNumber (string)</param>
        /// <param name="_email">Represent the Email (string)</param>
        /// <param name="_birhtday">Represent the birthday (datetime) (datetime</param>
        public void CreatePlayer(string _name, string _address, string _cellNumber, string _email, DateTime _birhtday)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to HTK_Databse 
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            Player _client = new Player
            {
                //Represent the Name (string) of the client
                Name = _name,

                //Represnet the Adress (string) of the clint
                Adress = _address,

                //Represent the CellNumber (string) of the client
                CellNumbers = _cellNumber,

                //Represent the Email (string) of the client
                Email = _email,

                //Represent the Birthday (datetime) of the client
                Birthday = _birhtday,
            };

            //Adding a _client to the Player table in the database 
            _context.Players.Add(_client);

            //Saving the changes made to the database
            _context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for creating Reservation data
        /// </summary>
        /// <param name="_start">Reprsent the Start (string)</param>
        /// <param name="_end">Represent the End (string)</param>
        public void CreateReservation(string _start, string _end)
        {
            //Represent a obejct of HTK_DatabaseEntities callle _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            Reservation _reservation = new Reservation
            {
                //Represent the Start (string) of the reservation
                Start = _start,

                //Represent the End (string) of the reservation
                End = _end
            };

            //Adding a _reservation to the Reservation table in the database
            _context.Reservations.Add(_reservation);

            //Save changes made to the database
            _context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for creating Pitch data 
        /// </summary>
        /// <param name="_name">Represent the Name (string)</param>
        public void CreatePitch(string _name)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            Pitch _pitch = new Pitch
            {
                //Represent the Name (string) of the pitch
                Name = _name
            };

            //Adding a _pitch to Pitch table in the database
            _context.Pitches.Add(_pitch);

            //Save changes made to the database
            _context.SaveChanges();
        }
    }
}
