using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class Delete
    {
        //Methods need for deleting data 
        // Player - done 
        // Classification - make it later -- need to figure out how to do it
        // Pitch - done
        // Reservation - done

        /// <summary>
        /// Represent a method for deleting player data
        /// </summary>
        /// <param name="_id">Represnt the Id(int)</param>
        public void DeletePlayer(int _id)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for acces to database
            HTK_DatabaseEntities _conetext = new HTK_DatabaseEntities();

            //used to find a specifik client i Player table
            Player _client = _conetext.Players.First(i => i.Id == _id);

            //used to remove a specifik client from the Player table
            _conetext.Players.Remove(_client);

            //save changes made to the database
            _conetext.SaveChanges();
        }

        /// <summary>
        /// Represent a method for deleting pitch data
        /// </summary>
        /// <param name="_id">Represent the Id (int)</param>
        public void DeletePitch(int _id)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //used to find a specifik pitch i Pitch table
            Pitch _pitch = _context.Pitches.First(i => i.Id == _id);

            //used to remove a specifik pitch from the Pitch table
            _context.Pitches.Remove(_pitch);

            //Save changes made to database
            _context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for deleting reservation data
        /// </summary>
        /// <param name="_id">Represent the Id (int)</param>
        public void DeleteReservation(int _id)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //used to find a specifik reservation i Reservation table
            Reservation _reservation = _context.Reservations.First(i => i.Id == _id);

            //used to remove a specifik reservation from the Reservation table 
            _context.Reservations.Remove(_reservation);

            //Save changes made to database
            _context.SaveChanges();
        }

    }
}
