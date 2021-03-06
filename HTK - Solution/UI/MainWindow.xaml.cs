﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Entities;
using DataAccess;
using System.Data.Entity;
using API;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Window
        public MainWindow()
        {
            InitializeComponent();
            LoadPlayerDtg();
            LoadPitchDtg();
            LoadReservationDtg();
        }

        /// <summary>
        /// Represent a method that fires a eventhandler called Window_loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPlayerDtg();
            LoadPitchDtg();
            LoadReservationDtg();
        }
        #endregion

        #region Window load methods

        /// <summary>
        /// Represent a method for loading player data into DtgPlayerInfo
        /// </summary>
        public void LoadPlayerDtg()
        {
            //Represent a object of CollectionViewSource called _playerSource, used to find a specifik rescource called PlayerSource
            CollectionViewSource _playerSource = (CollectionViewSource)this.FindResource("PlayerSource");

            //Represent a object of HTK_DatabaseEntities called _context, used to access database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //uses _context to access the player table a loads the data 
            _context.Players.Load();

            //sets _playerSource to what data that are in the player table
            _playerSource.Source = _context.Players.Local;
        }

        /// <summary>
        /// Represent a method for loading pitch data into DtgPitchInfo
        /// </summary>
        public void LoadPitchDtg()
        {
            //Represent a object of CollectionViewSource called _pitchSource, used to find a specifik resource called PitchSource
            CollectionViewSource _pitchSource = (CollectionViewSource)this.FindResource("PitchSource");

            //Represent a object of HTK_DatabaseEntities called _context, used to access database 
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //uses _context to acces pitch table and loads the data
            _context.Pitches.Load();

            //sets _pitchSource to what data are in the pitch table 
            _pitchSource.Source = _context.Pitches.Local;
        }

        /// <summary>
        /// Represent a method for load reservation data into DtgReservationInfo
        /// </summary>
        public void LoadReservationDtg()
        {
            //Represent a object of CollectionViewSource called _reservationSource, used to find a specifik resource called ReservationSource
            CollectionViewSource _reservationSource = (CollectionViewSource)this.FindResource("ReservationSource");

            //Represent a object of HTK_DatabaseEntities called _context, used to access database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //uses _context to acces reservation table and loads data
            _context.Reservations.Load();

            //sets _reservationSource to what data are in the reservation table
            _reservationSource.Source = _context.Reservations.Local;
        }
        #endregion

        #region Player
        /// <summary>
        /// Represent a method for creating a new player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database 
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //Represent a obejct of Create called _create, used to acces DataAcces to use for CRUD
            Create _create = new Create();

            //used to take input of user to make a new player
            _create.CreatePlayer(TbNameClient.Text, TbAddresseClient.Text, TbCellNumberClient.Text, TbEmailClient.Text, Convert.ToDateTime(DpBirthdayClient.Text));

            //Shows a messagebox to inform that a user has been added
            MessageBox.Show("Bruger er oprette");

            //Load datagrid with new data 
            LoadPlayerDtg();
        }

        /// <summary>
        /// Represent a method for editing a specifik players data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditClient_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database 
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //Represent a object of Edit called _edit, used for access to DataAccess to use for CRUD
            Edit _edit = new Edit();

            //used to take input of user to edit a specifik player´s data
            _edit.EditPlayer(Convert.ToInt32(TbIdClient.Text), TbNameClient.Text, TbAddresseClient.Text, TbCellNumberClient.Text, TbEmailClient.Text, Convert.ToDateTime(DpBirthdayClient.Text));

            //Shows a messagebox to inform that a user´s data has been edited
            MessageBox.Show("Bruger data er blevet ændret");

            //Load datagrid with new data 
            LoadPlayerDtg();
        }

        /// <summary>
        /// Represent a method for deleting a specifik players data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFjernClient_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //Represent a object of Delete called _delete, used for access to DataAccess to use for CRUD
            Delete _delete = new Delete();

            //used to take input of user to select a specifik player, and delete´s that player
            _delete.DeletePlayer(Convert.ToInt32(TbIdClient.Text));

            //Shows a messagebox to inform that a player has been deleted
            MessageBox.Show("Bruger er blevet fjernet");

            //Load datagrid with new data 
            LoadPlayerDtg();
        }

        #endregion

        #region Reservation
        /// <summary>
        /// Represent a method for creating reservation data 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddReservation_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //Represent a object of Create called _create, used for access to DataAccess, used for CRUD 
            Create _create = new Create();

            //Used to take input from user to make a new pitch
            _create.CreateReservation(TbStartReservation.Text, TbEndReservation.Text);

            //Shows a messagebox to inform user, that a pitch has been created
            MessageBox.Show("Reservation er blevet oprette");

            //Load datagrid with new data 
            LoadReservationDtg();
        }

        /// <summary>
        /// Represent a method for editing reservation data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditReservation_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //Represent a object of Edit, used for access to DataAccess to use for CRUD
            Edit _edit = new Edit();
            
            //used to take a input of user to select a specifik reservation, and edit that reservation´s data
            _edit.EditReservation(Convert.ToInt32(TbIdReservation.Text), TbStartReservation.Text, TbEndReservation.Text);

            //Shows a messagebox to inform user that a reservation´s data has been changed
            MessageBox.Show("Reservation data er blevet ændret");

            //Load datagrid with updatated data
            LoadReservationDtg();
        }

        /// <summary>
        /// Represent a method for deleting reservation data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFjernReservation_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //Represent a object of Delete called _delete, used to access DataAccess to use CRUD
            Delete _delete = new Delete();

            //used to take input of user to select a specifik player, and delete´s that player
            _delete.DeleteReservation(Convert.ToInt32(TbIdReservation.Text));

            //Shows a messagebox, to inform user that a reservation has been removed
            MessageBox.Show("Reservation er blevet fjernet");

            //Load datagrid with updatated data
            LoadReservationDtg();
        }

        #endregion

        /// <summary>
        /// Represent a method for creating new pitch data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Pitch
        private void BtnAddPitch_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //Represent a object of Create called _create, used for access to DataAccess to use CRUD
            Create _create = new Create();

            //Used to take input from user, to make a new pitch
            _create.CreatePitch(TbNamePitch.Text);

            //Shows a messagebox to inform the user, that a new pitch has been made
            MessageBox.Show("Bane er blevet oprettet");

            //Load datagrid with new data
            LoadPitchDtg();
        }

        private void BtnEditPitch_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of HTK_DatabaseEntities called _context used for access to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //Represen a object of Edit called _edit, used for access to DataAccess to use for CRUD
            Edit _edit = new Edit();

            //Used to take input of user to select a specifik pitch and change that pitch´s data
            _edit.EditPitch(Convert.ToInt32(TbIdPitch.Text), TbNamePitch.Text);

            //Shows a messagebox to inform a user, that a pitch´s data has been changed 
            MessageBox.Show("Bane data er blevet ændret");

            //Load datagrid with updated data
            LoadPitchDtg();
        }

        /// <summary>
        /// Represent a method for deleting pitch data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFjernPitch_Click(object sender, RoutedEventArgs e)
        {
            //Represent a object of HTK_DatabaseEntities called _context, used for acces to database
            HTK_DatabaseEntities _context = new HTK_DatabaseEntities();

            //Represent a object of Delete called _delete, used for access to DataAccess to use for CRUD
            Delete _delete = new Delete();

            //Used to take a input of user to select a specifik pitch and delete that´s pitches data
            _delete.DeletePitch(Convert.ToInt32(TbIdPitch.Text));

            //Shows a messagebox to inform user, that a pitch has been removed
            MessageBox.Show("Bane er blevet fjernet");

            //Load datagrid with updated data
            LoadPitchDtg();
        }
        #endregion

        private void BtnGetWeather_Click(object sender, RoutedEventArgs e)
        {
            API.Control _control = new API.Control();
            API.Control _key = new API.Control();

            _control.GetWeather(TbCity.Text, _key.ApiKey(), TbWeatherStatus.Text, TbWeatherStausDetailed.Text, TbTemperature.Text, TbTempFeelsLike.Text, TbHumidity.Text, TbWindSpeed.Text, TbCountry.Text);
        }
    }   
}
