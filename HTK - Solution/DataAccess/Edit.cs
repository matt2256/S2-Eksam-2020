using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccess
{
    public class Edit
    {
        //Method need for Editing data 
        // Player - done
        // Pitch - done
        // Classification - make it later -- need to figure out how to make it
        // Reservation - done 


        /// <summary>
        /// Represent a method for editing palyer data
        /// </summary>
        /// <param name="_id">Represent the Id (int)</param>
        /// <param name="_name">Represent the Name (string)</param>
        /// <param name="_adress">Represnt the Adress (string)</param>
        /// <param name="_cellNumber">Represnt the CellNumber (string)</param>
        /// <param name="_email">Represnt the Email (string)</param>
        /// <param name="_datatime">Represnt Birthday (datetime)</param>
        public void EditPlayer(int _id, string _name, string _adress, string _cellNumber, string _email, DateTime _birthday)
        {
            //Represnt a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //Used to find a specifik client i the players table
            Player _client = _context.Players.First(i => i.Id == _id);

            //Represent the specifik name found
            _client.Name = _name;

            //Represent the specifik adress found
            _client.Adress = _adress;

            //Represent the specifik CellNumer found
            _client.CellNumbers = _cellNumber;

            //Represent the specifik Email found 
            _client.Email = _email;

            //Represent the specifik Birthday
            _client.Birthday = _birthday;

            //save changes made to the database
            _context.SaveChanges();
  
        }


        /// <summary>
        /// Represent a method for editing pitch data
        /// </summary>
        /// <param name="_id">Represent the Id (int)</param>
        /// <param name="_name">Represnt the Name (string)</param>
        public void EditPitch(int _id, string _name)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //used to find a specifik pitch id
            Pitch _pitch = _context.Pitches.First(i => i.Id == _id);

            //Represent the specifik Name found
            _pitch.Name = _name;

            _context.SaveChanges();
        }

        /// <summary>
        /// Represent a method used for editing reservation data
        /// </summary>
        /// <param name="_id">Repesent Id (int)</param>
        /// <param name="_start">Represent Start (string)</param>
        /// <param name="_end">Represnt End (string)</param>
        public void EditReservation(int _id, string _start, string _end)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //used to find a specifik reservation id 
            Reservation _reservation = _context.Reservations.First(i => i.Id == _id);

            //Represent the specifik Start found
            _reservation.Start = _start;

            //Represent the specifik End found
            _reservation.End = _end;

            //Save changes made to database
            _context.SaveChanges();
        }
    }
}
