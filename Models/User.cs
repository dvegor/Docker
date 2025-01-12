﻿using System.ComponentModel.DataAnnotations;

namespace Docker.Models
{
    public class User
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid();

        public required string Email { get; set; }
        public byte[] Password { get; set; } = [];
        public byte[] Salt { get; set; } = [];
        public Guid RoleId { get; set; }
    }
}
