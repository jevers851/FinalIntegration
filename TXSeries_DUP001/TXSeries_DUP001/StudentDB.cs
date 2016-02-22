using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using IBM.CTG;

namespace TXSeries_DUP001
{
    public class StudentDB
    {
        //Name of the CICS program to execute
        private const string ProgramName = "STP001";

        //The size of the COMMAREA to send to the program
        private const int CommareaLength = 1768;
        private static String commareaStr; 
        //Maximum number of flow attempts
        private const int MaxFlowAttempts = 3;

        //Objects used by the class
        private static string gwyHostName = "VS26.COT.DAVENPORT.EDU";
        private static int gwyPort = 2006;
        private static String cicsServer = "TESTCICS";

        private static String RESP_DESC; 
        private static String RESP2_DESC;
        private static int RESP_CODE;
        private static int RESP2_CODE;

        public static Student Inquire(String STUD_ID)
        {

            EciRequest eciReq;

            //Open the Gateway connection with an infinite timeout period
            //The 'using' C# construct ensures the GatewayConnection is closed
            //when it goes out of scope, even if an exception is thrown

            //A System.Net.SocketException will be thrown if the connection
            //attempt fails, and an IBM.CTG.GatewayException will be thrown if
            //an error occurs in the Gateway daemon
            using (GatewayConnection gwyConnection = new GatewayConnection(gwyHostName, gwyPort))
            {
                //Prepare the EciRequest
                eciReq = new EciRequest();
                eciReq.ServerName = cicsServer;
                eciReq.Program = ProgramName;
                eciReq.ExtendMode = EciExtendMode.EciNoExtend;

                //String commareaString = "L 999999999";
                String commareaString = String.Format("{0}  {1}", "I", STUD_ID);
                commareaString = commareaString.PadRight(CommareaLength);

                //eciReq.SetCommareaData(new byte[CommareaLength]);
                eciReq.SetCommareaData(ASCIIEncoding.ASCII.GetBytes(commareaString));

                //Flow the request
                if (FlowRequest(gwyConnection, eciReq))
                {

                    //Display returned COMMAREA
                    byte[] commarea = eciReq.GetCommareaData();

                    //Display as hex
                    //               Console.Write("  HEX: ");
                    //               for (int i = 0; i < commarea.Length; i++) {
                    //                  Console.Write("{0:x2}", commarea[i]);
                    //               }

                    //Convert the byte data into a string, treating the data
                    //as ASCII encoded characters. This relies on the CICS program
                    //returning ASCII text in the COMMAREA

                    for (int i = 3; i < commarea.Length; i++)
                    {
                        if (commarea[i] == 0)
                            commarea[i] = 32; 
                    }

                    commareaStr = Encoding.ASCII.GetString(commarea);

                    Console.WriteLine("ASCII: {0}", commareaStr);
                    Console.WriteLine("Message: {0}", commareaStr.Substring(commareaStr.Length - 40, 40)); 
                }
            }

            Student s = new Student();
            IntPtr pBuf = Marshal.StringToBSTR(commareaStr.Substring(3, Student.Size));
            s = (Student)Marshal.PtrToStructure(pBuf, typeof(Student));
            Marshal.FreeBSTR(pBuf);

            return s;
        }

        public static Boolean Update(Student s)
        {
            Boolean results = true;

            String commareaStr = String.Empty;
            Boolean result = false;
            EciRequest eciReq;

            using (GatewayConnection gwyConnection = new GatewayConnection(gwyHostName, gwyPort))
            {
                //Prepare the EciRequest
                eciReq = new EciRequest();
                eciReq.ServerName = StudentDB.cicsServer;
                eciReq.Program = ProgramName;
                eciReq.ExtendMode = EciExtendMode.EciNoExtend;

                String commareaString = String.Format("{0}  {1}", "M", s.ToString());
                commareaString = commareaString.PadRight(CommareaLength);

                //eciReq.SetCommareaData(new byte[CommareaLength]);
                eciReq.SetCommareaData(ASCIIEncoding.ASCII.GetBytes(commareaString));
                eciReq.UserId = "CICSUSER";
                eciReq.Password = "";
                Console.WriteLine("ASCII: {0}", commareaStr);
                //Flow the request
                if (FlowRequest(gwyConnection, eciReq))
                {
                    byte[] commarea = eciReq.GetCommareaData();
                    commareaStr = Encoding.ASCII.GetString(commarea);
                    result = true;
                    Console.WriteLine("Message: {0}", commareaStr.Substring(commareaStr.Length - 40, 40)); 
                }
            }
            return results;
        }


        public static Boolean Add(Student s)
        {
            Boolean results = true;

            String commareaStr = String.Empty;
            Boolean result = false;
            EciRequest eciReq;

            using (GatewayConnection gwyConnection = new GatewayConnection(gwyHostName, gwyPort))
            {
                //Prepare the EciRequest
                eciReq = new EciRequest();
                eciReq.ServerName = StudentDB.cicsServer;
                eciReq.Program = ProgramName;
                eciReq.ExtendMode = EciExtendMode.EciNoExtend;

                String commareaString = String.Format("{0}  {1}", "A", s.ToString());
                commareaString = commareaString.PadRight(CommareaLength);
                Console.WriteLine("ASCII REQUEST: {0}", commareaStr);
                eciReq.SetCommareaData(ASCIIEncoding.ASCII.GetBytes(commareaString));
                eciReq.UserId = "CICSUSER";
                eciReq.Password = "";

                //Flow the request
                if (FlowRequest(gwyConnection, eciReq))
                {
                    byte[] commarea = eciReq.GetCommareaData();
                    commareaStr = Encoding.ASCII.GetString(commarea);
                    setResponse(commareaStr); 
                    result = true;
                    Console.WriteLine("ASCII RESPONSE: {0}", commareaStr);
                    Console.WriteLine("Message: {0}", commareaStr.Substring(commareaStr.Length - 40, 40)); 

                    
                }
            }
            return results;
        }

        public static Boolean UnDelete(Student s)
        {
            Boolean results = true;

            String commareaStr = String.Empty;
            Boolean result = false;
            EciRequest eciReq;

            using (GatewayConnection gwyConnection = new GatewayConnection(gwyHostName, gwyPort))
            {
                //Prepare the EciRequest
                eciReq = new EciRequest();
                eciReq.ServerName = StudentDB.cicsServer;
                eciReq.Program = ProgramName;
                eciReq.ExtendMode = EciExtendMode.EciNoExtend;

                String commareaString = String.Format("{0}  {1}", "U", s.ToString());
                commareaString = commareaString.PadRight(CommareaLength);
                Console.WriteLine("ASCII: {0}", commareaStr);
                //eciReq.SetCommareaData(new byte[CommareaLength]);
                eciReq.SetCommareaData(ASCIIEncoding.ASCII.GetBytes(commareaString));
                eciReq.UserId = "CICSUSER";
                eciReq.Password = "";

                //Flow the request
                if (FlowRequest(gwyConnection, eciReq))
                {
                    byte[] commarea = eciReq.GetCommareaData();
                    commareaStr = Encoding.ASCII.GetString(commarea);
                    setResponse(commareaStr);
                    result = true;
                    Console.WriteLine("ASCII: {0}", commareaStr);
                    Console.WriteLine("Message: {0}", commareaStr.Substring(commareaStr.Length - 40, 40)); 
                }
            }
            return results;
        }

        public static Boolean Purge(Student s)
        {
            Boolean results = true;

            String commareaStr = String.Empty;
            Boolean result = false;
            EciRequest eciReq;

            using (GatewayConnection gwyConnection = new GatewayConnection(gwyHostName, gwyPort))
            {
                //Prepare the EciRequest
                eciReq = new EciRequest();
                eciReq.ServerName = StudentDB.cicsServer;
                eciReq.Program = ProgramName;
                eciReq.ExtendMode = EciExtendMode.EciNoExtend;

                String commareaString = String.Format("{0}  {1}", "P", s.ToString());
                commareaString = commareaString.PadRight(CommareaLength);
                Console.WriteLine("ASCII: {0}", commareaStr);
                //eciReq.SetCommareaData(new byte[CommareaLength]);
                eciReq.SetCommareaData(ASCIIEncoding.ASCII.GetBytes(commareaString));
                eciReq.UserId = "CICSUSER";
                eciReq.Password = "";

                //Flow the request
                if (FlowRequest(gwyConnection, eciReq))
                {
                    byte[] commarea = eciReq.GetCommareaData();
                    commareaStr = Encoding.ASCII.GetString(commarea);
                    setResponse(commareaStr);
                    result = true;
                    Console.WriteLine("ASCII: {0}", commareaStr);
                    Console.WriteLine("Message: {0}", commareaStr.Substring(commareaStr.Length - 40, 40)); 
                }
            }
            return results;
        }


        public static Boolean Delete(Student s)
        {
            Boolean results = true;

            String commareaStr = String.Empty;
            Boolean result = false;
            EciRequest eciReq;

            using (GatewayConnection gwyConnection = new GatewayConnection(gwyHostName, gwyPort))
            {
                //Prepare the EciRequest
                eciReq = new EciRequest();
                eciReq.ServerName = StudentDB.cicsServer;
                eciReq.Program = ProgramName;
                eciReq.ExtendMode = EciExtendMode.EciNoExtend;

                String commareaString = String.Format("{0}  {1}", "D", s.ToString());
                commareaString = commareaString.PadRight(CommareaLength);
                Console.WriteLine("ASCII: {0}", commareaStr);
                //eciReq.SetCommareaData(new byte[CommareaLength]);
                eciReq.SetCommareaData(ASCIIEncoding.ASCII.GetBytes(commareaString));
                eciReq.UserId = "CICSUSER";
                eciReq.Password = "";

                //Flow the request
                if (FlowRequest(gwyConnection, eciReq))
                {
                    byte[] commarea = eciReq.GetCommareaData();
                    commareaStr = Encoding.ASCII.GetString(commarea);
                    setResponse(commareaStr);
                    result = true;
                    Console.WriteLine("ASCII: {0}", commareaStr);
                    Console.WriteLine("Message: {0}", commareaStr.Substring(commareaStr.Length - 40, 40)); 
                }
            }
            return results;
        }


        private static void setResponse(String commarea)
        {
            String message = commarea.Substring(1152, 40); 
        }


        private static bool FlowRequest(GatewayConnection gwyConnection, EciRequest eciReq)
        {

            int attempts = 0;

            while (attempts < MaxFlowAttempts)
            {

                //Flow throws a System.Net.SocketException if a connection
                //failure occurs, or an IBM.CTG.GatewayException if an error
                //occurs in the Gateway daemon
                gwyConnection.Flow(eciReq);

                //Test return code
                switch (eciReq.EciReturnCode)
                {
                    case EciReturnCode.EciNoError:
                        //Flow succeeded
                        return true;

                    case EciReturnCode.EciErrSecurityError:
                        //Security error, prompt for CICS logon credentials
                        Console.Write("Enter CICS user id : ");
                        //eciReq.UserId = Console.ReadLine();
                        eciReq.UserId = "CICSUSER";
                        Console.Write("Enter CICS password: ");
                        //eciReq.Password = Console.ReadLine();
                        eciReq.Password = String.Empty;
                        break;

                    case EciReturnCode.EciErrTransactionAbend:
                        //Transaction abended
                        Console.WriteLine("The transaction abended: {0}", eciReq.AbendCode);
                        return false;

                    case EciReturnCode.EciErrNoCics:
                        //CICS server not found
                        Console.WriteLine("CICS server not found");
                        return false;

                    default:
                        //Other error return code
                        Console.WriteLine("ECI return code: {0} ({1})", eciReq.EciReturnCode.ToString(), (int)eciReq.EciReturnCode);
                        return false;

                }

                //Increment number of attempts
                attempts++;
            }

            //Number of attempts exceeded MaxFlowAttempts
            return false;
        }


        public static Student[] List(Student s)
        {
            Boolean results = true;

            String commareaStr = String.Empty;
            Boolean result = false;
            EciRequest eciReq;
            byte[] commarea = null;
            Student[] students = null; 
            List<Student> list = null; 

            using (GatewayConnection gwyConnection = new GatewayConnection(gwyHostName, gwyPort))
            {
                //Prepare the EciRequest
                eciReq = new EciRequest();
                eciReq.ServerName = StudentDB.cicsServer;
                eciReq.Program = ProgramName;
                eciReq.ExtendMode = EciExtendMode.EciNoExtend;

                String commareaString = String.Format("{0}  {1}", "L", s.ToString());
                commareaString = commareaString.PadRight(CommareaLength);
                Console.WriteLine("ASCII: {0}", commareaStr);
                //eciReq.SetCommareaData(new byte[CommareaLength]);
                eciReq.SetCommareaData(ASCIIEncoding.ASCII.GetBytes(commareaString));
                eciReq.UserId = "CICSUSER";
                eciReq.Password = "";

                //Flow the request
                if (FlowRequest(gwyConnection, eciReq))
                {
                    commarea = eciReq.GetCommareaData();
                    for (int i = 3; i < commarea.Length; i++)
                    {
                        if (commarea[i] == 0)
                            commarea[i] = 32;
                    }
                    commareaStr = Encoding.ASCII.GetString(commarea);
                    setResponse(commareaStr); 
                    result = true;
                    Console.WriteLine("ASCII: {0}", commareaStr);
                    Console.WriteLine("Message: {0}", commareaStr.Substring(commareaStr.Length - 40, 40)); 
                }

                list = new List<Student>();
                int count = (int)commarea[2]; 
                for (int i = 0; i < count; i++)
                {
                    list.Add(new Student(commareaStr.Substring(3 + (115 * i), 115))); 
                }
            }

            if (list.Count > 0)
                students = list.ToArray<Student>(); 

            return students;
        }
    }
}
