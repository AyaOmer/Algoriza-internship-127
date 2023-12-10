using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veezeta.Models;


namespace Vezeeta.DTOs
{
    public class AddDoctorDTO
    {
        //add string image, string fname, string lname, string email, string phone, string specialization,
        ///string gender, DateTime dateofBirth

        [Required]
       public string Image {  get; set; }
        [Required]
        public string Fullname { get; set; }
     
        [Required]
        public string Email {  get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public int SpecializationID {  get; set; }
        [Required]

        public float Price { get; set; }
        public Gender Gender {  get; set; }
        public DateTime DateOfBirth { get; set; }


    }
}
