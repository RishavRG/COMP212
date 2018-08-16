﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rishav_Giri_Lab05_Ex04
{
    class Employee
    {
        //class variable
        public static int numberOfEmployees = 0;

    //public properties
    public int Id { get; }
    public string Name { get; set; }
    private double salary;
    public double Salary
    {
        get
        {
            return salary;
        }
        set
        {
            if (value > 0)
                salary = value;
            else
                salary = 0.0;
        }
    }

    // constructor
    public Employee(string name, double sal)
    {
        this.Id = numberOfEmployees++;
        Name = name;
        Salary = sal;
    }

    //ToString()
    public override string ToString()
    {
        return $"ID #{Id}, Name: {Name}, Salary: {Salary:C}";
    }
}
}
