using System;
using System.Collections.Generic;

namespace SpEntity.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; } = null!;
        public byte[]? Picture { get; set; }
    }
}
