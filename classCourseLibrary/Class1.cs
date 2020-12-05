using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classCourseLibrary
{
    public abstract class BasicInfo
    {
        public string name;
        public string major;
        public string minor;
        public string immersion;
        public string credit;
    }

    public abstract class ClassInfo
    {
        public string department; // ex: IGME
        public string courseCode; // ex: 201
        public string className;
        public string classType; // ex: minor
        public string classCredit;
        public double classGP; // grade points
    }

    public abstract class Schedule
    {
        public string semester;
        public int creditCount;
    }

    public enum type
    {
        major,
        immersion,
        minor,
        genEd,
        genEdPer,
        free,
        adEl,
        wellness,
        coop,
        otherClasses

    }
}
