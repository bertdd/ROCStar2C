﻿namespace ROCStarBackend;

/// <summary>
/// Represents the data for a student
/// </summary>
public class Student : Person
{
  public int Id { get; set; }

  public DateTime Registered {  get; set; }

}
