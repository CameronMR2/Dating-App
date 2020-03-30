using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.DTOs
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public String KnownAs { get; set; }   
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }  
        public string Interests { get; set; }       
        public string City { get; set; }    
        public string County { get; set; }      
        public string PhotUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
    }
}