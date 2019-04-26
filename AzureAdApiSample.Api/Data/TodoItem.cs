﻿using System;

namespace AzureAdApiSample.Api.Data
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool IsDone { get; set; }
        public string UserId { get; set; }
    }
}
