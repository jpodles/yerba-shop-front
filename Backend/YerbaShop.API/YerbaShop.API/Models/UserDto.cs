﻿using YerbaShop.API.Entities;

namespace YerbaShop.API.Models
{
    public class UserDto
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
