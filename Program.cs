
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//argument:A B C D
namespace CSharpHelloWorld
{
   
    class Box
    {
        private int m_nVal;
        public int Val
        {
            get {
                return m_nVal;
            
            }
            set {
                m_nVal = value; 
            }
        }
        public Box(int val)
        {
            m_nVal = val;
        }
        public Box()
        {
            m_nVal = 0;
        }

    };
    struct SBox
    {
        private int m_nVal;
        public int Val
        {
            get
            {
                return m_nVal;

            }
            set
            {
                m_nVal = value;
            }
        }
    };

    class OperatorTest
    {

        public int m_i, m_j, m_k;
        public OperatorTest(int i = 0,int j = 0,int k = 0)
        {
            m_i = i;
            m_j = j;
            m_k = k;
        }
        public static OperatorTest operator +(OperatorTest r,OperatorTest l)
        {
            OperatorTest result = new OperatorTest();
            result.m_i = r.m_i + l.m_i;
            result.m_j = r.m_j + l.m_j;
            result.m_k = r.m_k + l.m_k;

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //test 1
            {
                int i = 5;
                object o = i;//装箱
                i = 10;
                int j = (int)o;//拆箱
                j = 15;
                int k = (int)o;

                System.Console.WriteLine("{0},{1},{2}", i, j, k);

            }
            //test 2 
            {
                Box i = new Box(5);
                object o = i;
                i.Val = 10;
                Box j = (Box)o;
                j.Val = 15;
                Box k = (Box)o;

                System.Console.WriteLine("{0},{1},{2}", i.Val, j.Val, k.Val);

            }
            //test 3 use struct
            {
                SBox i = new SBox();
                i.Val = 5;
                object o = i;
                i.Val = 10;
                SBox j = (SBox)o;
                j.Val = 15;
                SBox k = (SBox)o;
                System.Console.WriteLine("{0},{1},{2}", i.Val, j.Val, k.Val);
            }
            //test 4 operator + test  
            {
                OperatorTest i = new OperatorTest(1, 2, 3);
                OperatorTest j = new OperatorTest(4, 5, 6);
                OperatorTest k = i + j;
                System.Console.WriteLine("{0},{1},{2}", k.m_i,k.m_j,k.m_k);
            }

            Console.ReadLine();
        }
    }
}


