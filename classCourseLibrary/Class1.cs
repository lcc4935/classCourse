using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classCourseLibrary
{
    public class BasicInfo
    {
        public string name;
        public string major;
        public string minor;
        public string immersion;
        public string credit;
    }

    public class ClassInfo
    {
        public string department; // ex: IGME
        public string courseCode; // ex: 201
        public string className;
        public types classType;
        public string classCredit;
        public semesters semester;
        public double classGP; // grade points
    }

    public enum types
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

    public enum semesters
    {
        freshFall,
        freshSpring,
        sophFall,
        sophSpring,
        juniorFall,
        juniorSpring,
        seniorFall,
        seniorSpring,
        undecided
    }
}
