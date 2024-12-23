﻿using Core.Security.Entities;

namespace ECommerce.Domain.Entities;

public sealed class AppUser : User
{
    public ICollection<AppUserOperationClaim> UserOperationClaims { get; set; } = null!;
    public ICollection<Order> Orders { get; set; }
}