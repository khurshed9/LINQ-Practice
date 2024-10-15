namespace Practice.Entities;

using System;
using System.Collections.Generic;

public class User : BaseEntity
{
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public virtual ICollection<Order> Orders { get; set; } = [];
}