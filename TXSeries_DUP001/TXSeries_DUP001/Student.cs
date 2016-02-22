using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TXSeries_DUP001
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public class Student
    {

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public String STUD_ID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public String STUD_FIRST_NM;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 25)]
        public String STUD_LAST_NM;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public String STUD_GPA;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public String STUD_MAJOR_CD;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public String STUD_DOB;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public String STUD_ADD_USER_ID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public String STUD_ADD_DT;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public String STUD_ADD_TM;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public String STUD_CHNG_USER_ID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public String STUD_CHNG_DT;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public String STUD_CHNG_TM;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public String STUD_DEL_FLG;

        public Student()
        {
            STUD_ID = String.Empty;
            STUD_FIRST_NM = String.Empty;
            STUD_LAST_NM = String.Empty;
            STUD_GPA = String.Empty;
            STUD_MAJOR_CD = String.Empty;
            STUD_DOB = String.Empty;
            STUD_ADD_USER_ID = String.Empty;
            STUD_ADD_DT = String.Empty;
            STUD_ADD_TM = String.Empty;
            STUD_CHNG_USER_ID = String.Empty;
            STUD_CHNG_DT = String.Empty;
            STUD_CHNG_TM = String.Empty;
            STUD_DEL_FLG = String.Empty;
        }

        public Student(String student)
        {
            Student s = new Student();
            IntPtr pBuf = Marshal.StringToBSTR(student);
            s = (Student)Marshal.PtrToStructure(pBuf, typeof(Student));
            Marshal.FreeBSTR(pBuf);

            STUD_ID = s.STUD_ID;
            STUD_FIRST_NM = s.STUD_FIRST_NM;
            STUD_LAST_NM = s.STUD_LAST_NM;
            STUD_GPA = s.STUD_GPA;
            STUD_MAJOR_CD = s.STUD_MAJOR_CD;
            STUD_DOB = s.STUD_DOB;
            STUD_ADD_USER_ID = s.STUD_ADD_USER_ID;
            STUD_ADD_DT = s.STUD_ADD_DT;
            STUD_ADD_TM = s.STUD_ADD_TM;
            STUD_CHNG_USER_ID = s.STUD_CHNG_USER_ID;
            STUD_CHNG_DT = s.STUD_CHNG_DT;
            STUD_CHNG_TM = s.STUD_CHNG_TM;
            STUD_DEL_FLG = s.STUD_DEL_FLG;

            s = null;
        }

        public Student(Student student)
        {
            STUD_ID = student.STUD_ID;
            STUD_FIRST_NM = student.STUD_FIRST_NM;
            STUD_LAST_NM = student.STUD_LAST_NM;
            STUD_GPA = student.STUD_GPA;
            STUD_MAJOR_CD = student.STUD_MAJOR_CD;
            STUD_DOB = student.STUD_DOB;
            STUD_ADD_USER_ID = student.STUD_ADD_USER_ID;
            STUD_ADD_DT = student.STUD_ADD_DT;
            STUD_ADD_TM = student.STUD_ADD_TM;
            STUD_CHNG_USER_ID = student.STUD_CHNG_USER_ID;
            STUD_CHNG_DT = student.STUD_CHNG_DT;
            STUD_CHNG_TM = student.STUD_CHNG_TM;
            STUD_DEL_FLG = student.STUD_DEL_FLG;
        }

        public static int Size
        {
            get
            {
                return 115;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(STUD_ID.PadRight(9));
            sb.Append(STUD_FIRST_NM.PadRight(20));
            sb.Append(STUD_LAST_NM.PadRight(25));

            STUD_GPA = STUD_GPA.Replace(".", String.Empty); 

            sb.Append(STUD_GPA.PadRight(3));
            sb.Append(STUD_MAJOR_CD.PadRight(5));

            STUD_DOB = STUD_DOB.Replace(@"/", String.Empty);

            sb.Append(STUD_DOB.PadRight(8));
            sb.Append(STUD_ADD_USER_ID.PadRight(8));

            STUD_ADD_DT = STUD_ADD_DT.Replace(@"/", String.Empty);

            sb.Append(STUD_ADD_DT.PadRight(8));
            sb.Append(STUD_ADD_TM.PadRight(6));
            sb.Append(STUD_CHNG_USER_ID.PadRight(8));

            STUD_CHNG_DT = STUD_CHNG_DT.Replace(@"/", String.Empty);

            sb.Append(STUD_CHNG_DT.PadRight(8));
            sb.Append(STUD_CHNG_TM.PadRight(6));
            sb.Append(STUD_DEL_FLG);

            return sb.ToString();
        }

    }
}
