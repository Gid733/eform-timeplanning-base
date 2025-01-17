﻿/*
The MIT License (MIT)

Copyright (c) 2007 - 2019 Microting A/S

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
namespace Microting.TimePlanningBase.Infrastructure.Extensions.Seed.CodeFirstLists
{
    using System.Collections.Generic;
    using Data.Entities;

    public class MessagesCodeFirst
    {
        public static readonly Message DayOffMessage = new (1, "Day Off");
        public static readonly Message VacationMessage = new(2, "Vacation");
        public static readonly Message SickMessage = new(3, "Sick");
        public static readonly Message CourseMessage = new(4, "Course");
        public static readonly Message LeaveOfAbsenceMessage = new(5, "Leave of absence");
        public static readonly Message CareMessage = new(6, "Care");
        public static readonly Message ChildrenFirstSickMessage = new(7, "Children's 1st sick");
        public static readonly Message ChildrenSecondSickMessage = new(8, "Children's 2nd sick");
        public static readonly Message TimeOffMessage = new(9, "Time off");
        public static readonly Message EmptyMessage = new(10, " ");

        public static List<Message> GetList()
        {
            var entryList = new List<Message>()
            {
                DayOffMessage,
                VacationMessage,
                SickMessage,
                CourseMessage,
                LeaveOfAbsenceMessage,
                CareMessage,
                ChildrenFirstSickMessage,
                ChildrenSecondSickMessage,
                TimeOffMessage,
                EmptyMessage,
            };

            return entryList;
        }
    }
}