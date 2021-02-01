﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C3_Visitor
{
    /// <summary>
    /// 抽象元素类：Employee
    /// </summary>
    public interface IEmployee
    {
        void Accept(Department handler);
    }

    /// <summary>
    /// 具体元素类：FullTimeEmployee
    /// </summary>
    public class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public double WeeklyWage { get; set; }
        public int WorkTime { get; set; }

        public FullTimeEmployee(string name, double weeklyWage, int workTime)
        {
            this.Name = name;
            this.WeeklyWage = weeklyWage;
            this.WorkTime = workTime;
        }

        public void Accept(Department handler)
        {
            handler.Visit(this);
        }
    }

    /// <summary>
    /// 具体元素类：PartTimeEmployee
    /// </summary>
    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public double HourWage { get; set; }
        public int WorkTime { get; set; }

        public PartTimeEmployee(string name, double hourWage, int workTime)
        {
            this.Name = name;
            this.HourWage = hourWage;
            this.WorkTime = workTime;
        }

        /// <summary>
        /// 接受一个访问者
        /// </summary>
        /// <param name="handler"></param>
        public void Accept(Department handler)
        {
            handler.Visit(this);
        }
    }
}
