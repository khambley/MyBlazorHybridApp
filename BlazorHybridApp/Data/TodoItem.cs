﻿using System;
namespace BlazorHybridApp.Data;

public class TodoItem
{
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
}
