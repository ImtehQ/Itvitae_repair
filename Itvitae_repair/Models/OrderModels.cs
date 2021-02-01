using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itvitae_repair.Models
{
    public class OrderModels
    {
        //All models that are part of Order or interects directly with anything to do with order controller
        //Will go in this 1 file, this way I know where to look when im looking for shit.
        //If you dont like this go make it yourself or hire a asp.net developer, as I'm NOT one of them!
    }
    public static class Status
    {

    }

    /// <summary>
    /// View list but admin will see more
    /// </summary>
    public class AdminViewList
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public string Discription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    /// <summary>
    /// View list but worker sees less
    /// </summary>
    public class WorkerViewList
    {
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public string Status { get; set; }
        public string Discription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    /// <summary>
    /// View list but user see least
    /// </summary>
    public class UserViewList
    {
        public string EmployeeName { get; set; }
        public string Status { get; set; }
        public string Discription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }



    /// <summary>
    /// Edit model for admin, sees all
    /// </summary>
    public class AdminEdit
    {
        public bool Completed { get; set; }

        public DateTime EndDate { get; set; }
        public string Discription { get; set; }
        public int StatusId { get; set; }
    }
    /// <summary>
    /// Edit model for admin, sees most
    /// </summary>
    public class WorkerEdit
    {
        public bool Completed { get; set; }

        public DateTime EndDate { get; set; }
        public string Discription { get; set; }
        public int StatusId { get; set; }
    }
    /// <summary>
    /// Edit model for admin, sees barly anything
    /// </summary>
    public class UserEdit
    {
        public bool Completed { get; set; }
    }




    /// <summary>
    /// Create order for admin
    /// </summary>
    public class CreateOrder
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public string Discription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }



    /// <summary>
    /// Create order for user, can only enter discription
    /// </summary>
    public class CreateUserOrder
    {
        public string Discription { get; set; }
    }
    /// <summary>
    /// Add parts to existing orders same for admin and worker
    /// </summary>
    public class AddPartsToOrder
    {
        public int OderID { get; set; }
        public int PartsListId { get; set; }
        public int PartId { get; set; }
    }
    /// <summary>
    /// Add parts to the database
    /// </summary>
    public class AddParts
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}