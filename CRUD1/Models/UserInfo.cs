﻿namespace CRUD1.Entities
{
    public class UserInfo
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }

    }
}
