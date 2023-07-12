﻿namespace SIBLEYBLAYOPERA.Models
{
    public class RefreshToken
    {
        public int Id { get; set; }

        public required string Token { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime Expires { get; set; }
    }
}
