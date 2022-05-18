﻿namespace Core.Entities.Abstract
{
    public class BaseEntity:IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
