﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsCPU
{
    public partial class Form1 : Form
    {
        //public static int[,] A.addr;
        public class A
        {
            public static int[,] addr = new int[10000,8];
        }

        public static string[] sr = { "0", "0", "0", "0", "0", "0", "0", "0", "0" };

        public Form1()
        {
            InitializeComponent();

            //Input.Text = "00000000";
            SR_text.Text = "00000000";
            PC_text.Text = "1000";
            //string[] sr = { "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j < 4)
                    {
                        A.addr[i, j] = 0;
                    }
                    else if (j < 8)
                    {
                        A.addr[i, j] = 1;
                    }
                }
            }
            reR_text();

        }



        static public void Add(int Rd,int Rs)
        {
            //A.addr[Rd,0] += A.addr[Rs,0];

            int x,j = 0;

            for (int i = 7; i >= 0; i--)
            {
                x = 0;
                if (A.addr[Rd,i] == 1)
                {
                    x++;
                }
                if (A.addr[Rs,i] == 1)
                {
                    x++;
                }
                if (j == 1)
                {
                    x++;
                    j = 0;//用过之后进位清除
                }
                if (x == 0)
                {
                    A.addr[Rd,i] = 0;

                }
                if (x == 1)
                {
                    A.addr[Rd,i] = 1;
                    j = 0;
                }
                if (x == 2)
                {
                    A.addr[Rd,i] = 0;
                    j = 1;
                }
                if (x == 3)
                {
                    A.addr[Rd,i] = 1;
                    j = 1;
                }
            }

            if(j == 1)
            {
                sr[3] = "1";
            }
        }

        static public void Sub(int Rd, int Rs)
        {
            int x = 0, j = 0, z = 0;

            for (int i = 7; i >= 0; i--)
            {
                if (A.addr[Rs,i] > A.addr[Rd,i])
                {
                    z = 1;
                }
                if (A.addr[Rd, i] < A.addr[Rs, i])
                {
                    z = 0;
                }
            }
            if (z == 1)
            {
                int[] barr;
                barr = new int[8];
                for (int i = 0; i <= 7; i++)
                {
                    barr[i] = A.addr[Rd, i];
                    A.addr[Rd, i] = A.addr[Rs, i];
                    A.addr[Rd, i] = barr[i];
                }
            }
            for (int i = 7; i >= 0 ; i--)
            {
                x = 0;
                x = A.addr[Rd, i] - A.addr[Rs, i] + j;
                if (x == -2)
                {
                    A.addr[Rd, i] = 0;
                    j = -1;
                }
                if (x == -1)
                {
                    A.addr[Rd, i] = 1;
                    j = -1;
                }
                if (x == 0)
                {
                    A.addr[Rd, i] = 0;
                    j = 0;
                }
                if (x == 1)
                {
                    A.addr[Rd, i] = 1;
                    j = 0;
                }
                if (j == -1&&i==4)
                {
                    sr[5] = "1";
                }
            }

            if (z == 1)
            {
                sr[0] = "1";
                sr[2] = "1";
            }
        }

        static public void And(int Rd, int Rs)
        {
            for(int i = 7; i >= 0;i--)
            {
                if (A.addr[Rd, i] != A.addr[Rs, i] )
                    A.addr[Rd, i] = 1;
                else
                    A.addr[Rd, i] = 0;
            }
        }

        static public void Inc(int Rd)
        {
            int x, j = 0;
            int[] arry = { 0, 0, 0, 0, 0, 0, 0, 1};

            for (int i = 7; i >= 0; i--)
            {
                x = 0;
                if (A.addr[Rd, i] == 1)
                {
                    x++;
                }
                if (arry[i] == 1)
                {
                    x++;
                }
                if (j == 1)
                {
                    x++;
                    j = 0;//用过之后进位清除
                }
                if (x == 0)
                {
                    A.addr[Rd, i] = 0;

                }
                if (x == 1)
                {
                    A.addr[Rd, i] = 1;
                    j = 0;
                }
                if (x == 2)
                {
                    A.addr[Rd, i] = 0;
                    j = 1;
                }
                if (x == 3)
                {
                    A.addr[Rd, i] = 1;
                    j = 1;
                }
            }

            if (j == 1)
            {
                sr[3] = "1";
            }
        }

        static public void Dec(int Rd)
        {
            int x = 0, j = 0, z = 0;
            int[] g = new int[] { 0, 0, 0, 0, 0, 0, 0, 1 };

            for (int i = 7; i >= 0; i--)
            {
                if (g[i] > A.addr[Rd, i])
                {
                    z = 1;
                }
                if (A.addr[Rd, i] < g[i])
                {
                    z = 0;
                }
            }
            if (z == 1)
            {
                int[] barr;
                barr = new int[8];
                for (int i = 7; i >= 0; i--)
                {
                    barr[i] = A.addr[Rd, i];
                    A.addr[Rd, i] = g[i];
                    A.addr[Rd, i] = barr[i];
                }
            }
            for (int i = 0; i <= 7; i++)
            {
                x = 0;
                x = A.addr[Rd, i] - g[i] + j;
                if (x == -2)
                {
                    A.addr[Rd, i] = 0;
                    j = -1;
                }
                if (x == -1)
                {
                    A.addr[Rd, i] = 1;
                    j = -1;
                }
                if (x == 0)
                {
                    A.addr[Rd, i] = 0;
                    j = 0;
                }
                if (x == 1)
                {
                    A.addr[Rd, i] = 1;
                    j = 0;
                }
                if (j == -1 && i == 4)
                {
                    sr[5] = "1";
                }
            }

            if (z == 1)
            {
                sr[0] = "1";
                sr[2] = "1";
            }
        }

        static public string Jmp(int Rd)
        {
            string i;
            i = "" + A.addr[0, 7] + A.addr[0, 6] + A.addr[0, 5] + A.addr[0, 4] + A.addr[0, 3] + A.addr[0, 2] + A.addr[0, 1] + A.addr[0, 0]; ;
            return i;
        }

        static public void Mov(int Rd, int Rs)
        {
            for (int i = 0; i <= 7; i++)
            {
                A.addr[Rd, i] = A.addr[Rs, i];
            }
        }

        static public void Ldi(int Rd, string K)
        {

            for (int i = 0; i <= 7 && i < K.Length; i++)
            {
                if (K[i] == '1')
                {
                    A.addr[Rd, i] = 1;
                }
                else
                    A.addr[Rd, i] = 0;
            }
            for (int i = K.Length; i <= 7; i++)
            {
                A.addr[Rd, i] = 0;
            }
        }

        static public void Ld(int Rd, string K)
        {
            int Rs;
            Rs = Convert.ToInt32(K, 2);
            for (int i = 0; i <= 7; i++)
            {
                A.addr[Rd, i] = A.addr[Rs, i];
            }
        }

        private void SR_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void reSR()
        {
            for(int i = 0;i<=7;i++)
            {
                sr[i] = "0";
            }
        }

        public void reR_text()
        {
                
            R0_text.Text = "" + A.addr[0, 0] + A.addr[0, 1] + A.addr[0, 2] + A.addr[0, 3] + A.addr[0, 4] + A.addr[0, 5] + A.addr[0, 6] + A.addr[0, 7];
            R1_text.Text = "" + A.addr[1, 0] + A.addr[1, 1] + A.addr[1, 2] + A.addr[1, 3] + A.addr[1, 4] + A.addr[1, 5] + A.addr[1, 6] + A.addr[1, 7];
            R2_text.Text = "" + A.addr[2, 0] + A.addr[2, 1] + A.addr[2, 2] + A.addr[2, 3] + A.addr[2, 4] + A.addr[2, 5] + A.addr[2, 6] + A.addr[2, 7];
            R3_text.Text = "" + A.addr[3, 0] + A.addr[3, 1] + A.addr[3, 2] + A.addr[3, 3] + A.addr[3, 4] + A.addr[3, 5] + A.addr[3, 6] + A.addr[3, 7];
            R4_text.Text = "" + A.addr[4, 0] + A.addr[4, 1] + A.addr[4, 2] + A.addr[4, 3] + A.addr[4, 4] + A.addr[4, 5] + A.addr[4, 6] + A.addr[4, 7];
            R5_text.Text = "" + A.addr[5, 0] + A.addr[5, 1] + A.addr[5, 2] + A.addr[5, 3] + A.addr[5, 4] + A.addr[5, 5] + A.addr[5, 6] + A.addr[5, 7];
            R6_text.Text = "" + A.addr[6, 0] + A.addr[6, 1] + A.addr[6, 2] + A.addr[6, 3] + A.addr[6, 4] + A.addr[6, 5] + A.addr[6, 6] + A.addr[6, 7];
            R7_text.Text = "" + A.addr[7, 0] + A.addr[7, 1] + A.addr[7, 2] + A.addr[7, 3] + A.addr[7, 4] + A.addr[7, 5] + A.addr[7, 6] + A.addr[7, 7];


            R0_text.Text = string.Format("{0:x}", Convert.ToInt32(R0_text.Text, 2));
            R1_text.Text = string.Format("{0:x}", Convert.ToInt32(R1_text.Text, 2));
            R2_text.Text = string.Format("{0:x}", Convert.ToInt32(R2_text.Text, 2));
            R3_text.Text = string.Format("{0:x}", Convert.ToInt32(R3_text.Text, 2));
            R4_text.Text = string.Format("{0:x}", Convert.ToInt32(R4_text.Text, 2));
            R5_text.Text = string.Format("{0:x}", Convert.ToInt32(R5_text.Text, 2));
            R6_text.Text = string.Format("{0:x}", Convert.ToInt32(R6_text.Text, 2));
            R7_text.Text = string.Format("{0:x}", Convert.ToInt32(R7_text.Text, 2));
        }

        public string Findcode(int i)
        {
            if( i == 1)
            {
                if (Input.Text[Input.Text.IndexOf(" ") + 1] == 'R')
                {

                    return "000";
                }
                if (Input.Text[Input.Text.IndexOf(" ") + 1] == '(')
                {
                    if (Input.Text[Input.Text.IndexOf(",") - 1] != '+')
                    {
                        return "001";
                    }
                }
                if (Input.Text[Input.Text.IndexOf(" ") + 1] == 'X')
                {
                    return "100";
                }
                if (Input.Text[Input.Text.IndexOf(",") - 1] == '+')
                {
                    if(Input.Text[Input.Text.IndexOf(" ") + 1] == '@')
                    {
                        return "011";
                    }
                    if (Input.Text[Input.Text.IndexOf(" ") + 1] == '(')
                    {
                        return "010";
                    }
                }
            }
            if (i == 2)
            {                
                if (Input.Text[Input.Text.IndexOf(",") + 1] == 'R')
                {
                    return "000";
                }
                if (Input.Text[Input.Text.IndexOf(",") + 1] == '(')
                {
                    if (Input.Text[Input.Text.Length - 1] != '+')
                        return "001";
                }
                if (Input.Text[Input.Text.IndexOf(",") + 1] == 'X')
                {
                    return "100";
                }
                if (Input.Text[Input.Text.Length - 1] == '+')
                {
                    if (Input.Text[Input.Text.IndexOf(",") + 1] == '@')
                    {
                        return "011";
                    }
                    if (Input.Text[Input.Text.IndexOf(",") + 1] == '(')
                    {
                        return "010";
                    }
                }
            }
            if (i == 3)
            {
                if (Input.Text[Input.Text.IndexOf(" ") + 1] == 'R')
                {
                    return "000";
                }
                if (Input.Text[Input.Text.IndexOf(" ") + 1] == '(')
                {
                    if (Input.Text[Input.Text.Length - 1] != '+')
                        return "001";
                }
                if (Input.Text[Input.Text.IndexOf(" ") + 1] == 'X')
                {
                    return "100";
                }
                if (Input.Text[Input.Text.Length - 1] == '+')
                {
                    if (Input.Text[Input.Text.IndexOf(" ") + 1] == '@')
                    {
                        return "011";
                    }
                    if (Input.Text[Input.Text.IndexOf(" ") + 1] == '(')
                    {
                        return "010";
                    }
                }
            }

            return "000";            
        }

        public int Findaddr(string p,string num)
        {
            if (p == "000")
                return Convert.ToInt32(num, 2);
            if (p == "001")
            {
                int j = Convert.ToInt32(num, 2);

                num = "" + A.addr[j, 0] + A.addr[j, 1] + A.addr[j, 2] + A.addr[j, 3] + A.addr[j, 4] + A.addr[j, 5] + A.addr[j, 6] + A.addr[j, 7];
                j = Convert.ToInt32(num, 2);
                return j;
            }
            if (p == "010")
            {
                int j = Convert.ToInt32(num, 2);

                num = "" + A.addr[j, 0] + A.addr[j, 1] + A.addr[j, 2] + A.addr[j, 3] + A.addr[j, 4] + A.addr[j, 5] + A.addr[j, 6] + A.addr[j, 7];
                
                Inc(j);
                return Convert.ToInt32(num, 2);
            }
            if (p == "011")
            {
                int j = Convert.ToInt32(num, 2);
                num = "" + A.addr[j, 0] + A.addr[j, 1] + A.addr[j, 2] + A.addr[j, 3] + A.addr[j, 4] + A.addr[j, 5] + A.addr[j, 6] + A.addr[j, 7];
                
                Inc(j);
                j = Convert.ToInt32(num, 2);
                num = "" + A.addr[j, 0] + A.addr[j, 1] + A.addr[j, 2] + A.addr[j, 3] + A.addr[j, 4] + A.addr[j, 5] + A.addr[j, 6] + A.addr[j, 7];
                            
                return Convert.ToInt32(num, 2);
            }
            if (p == "100")
            {
                int j = Convert.ToInt32(num, 2);
                num = "" + A.addr[j, 0] + A.addr[j, 1] + A.addr[j, 2] + A.addr[j, 3] + A.addr[j, 4] + A.addr[j, 5] + A.addr[j, 6] + A.addr[j, 7];
                
                j = Convert.ToInt32(PC_text.Text, 16) + Convert.ToInt32(num, 2);
                return j;
            }
            return 0;
        }

        public string Changetol(string p)
        {
            if (p == "0")
            {
                return "0000";
            }
            if (p == "1")
            {
                return "0001";
            }
            if (p == "2")
            {
                return "0010";
            }
            if (p == "3")
            {
                return "0011";
            }
            if (p == "4")
            {
                return "0100";
            }
            if (p == "5")
            {
                return "0101";
            }
            if (p == "6")
            {
                return "0110";
            }
            if (p == "7")
            {
                return "0111";
            }
            if (p == "8")
            {
                return "1000";
            }
            if (p == "9")
            {
                return "1001";
            }
            if (p == "A")
            {
                return "1010";
            }
            if (p == "B")
            {
                return "1011";
            }
            if (p == "C")
            {
                return "1100";
            }
            if (p == "D")
            {
                return "1101";
            }
            if (p == "E")
            {
                return "1110";
            }
            if (p == "F")
            {
                return "1111";
            }
            return "errer";
        }

        public string Changeto(string p)
        {
            if( p == "0")
            {
                return "000";
            }
            if (p == "1")
            {
                return "001";
            }
            if (p == "2")
            {
                return "010";
            }
            if (p == "3")
            {
                return "011";
            }
            if (p == "4")
            {
                return "100";
            }
            if (p == "5")
            {
                return "101";
            }
            if (p == "6")
            {
                return "110";
            }
            if (p == "7")
            {
                return "111";
            }
            return "errer";
        }

        public string Change(int i)
        {
            string p;
            if (i == 1)
            {
                p = Convert.ToString(Input.Text[Input.Text.IndexOf("R") + 1]);
                return Changeto(p);
            }
            if (i == 2)
            {
                p = Convert.ToString(Input.Text[Input.Text.IndexOf("R", Input.Text.IndexOf(",")) + 1]);
                return Changeto(p);
            }
            if (i == 3)
            {
                p = Convert.ToString(Input.Text[Input.Text.IndexOf(",") + 1]);
                return Changetol(p);
            }
            if (i == 4)
            {
                p = Convert.ToString(Input.Text[Input.Text.IndexOf(",") + 2]);
                return Changetol(p);
            }
            return "000";
        }

        public string[] Read()
        {
            string[] OP = new string[5];

            if (Input.Text.IndexOf("add") != -1)
            {
                OP[0] = "0001";
                OP[1] = Findcode(1);
                OP[2] = Change(1); 
                OP[3] = Findcode(2);
                OP[4] = Change(2);
                OPcode_text.Text = OP[0] + " " + OP[1] + " " + OP[2] + " " + OP[3] + " " + OP[4];
            }
            if (Input.Text.IndexOf("sub") != -1)
            {
                OP[0] = "0010";
                OP[1] = Findcode(1);
                OP[2] = Change(1);
                OP[3] = Findcode(2);
                OP[4] = Change(2);
                OPcode_text.Text = OP[0] + " " + OP[1] + " " + OP[2] + " " + OP[3] + " " + OP[4];
            }
            if (Input.Text.IndexOf("and") != -1)
            {
                OP[0] = "0011";
                OP[1] = Findcode(1);
                OP[2] = Change(1);
                OP[3] = Findcode(2);
                OP[4] = Change(2);
                OPcode_text.Text = OP[0] + " " + OP[1] + " " + OP[2] + " " + OP[3] + " " + OP[4];
            }
            if (Input.Text.IndexOf("inc") != -1)
            {
                OP[0] = "0100";
                OP[1] = Findcode(3);
                OP[2] = Change(1);
                OPcode_text.Text = OP[0] + " " + OP[1] + " " + OP[2] + " " + OP[3] + " " + OP[4];
            }
            if (Input.Text.IndexOf("dec") != -1)
            {
                OP[0] = "0101";
                OP[1] = Findcode(1);
                OP[2] = Change(1);
                OPcode_text.Text = OP[0] + " " + OP[1] + " " + OP[2] + " " + OP[3] + " " + OP[4];
            }
            if (Input.Text.IndexOf("neg") != -1)
            {
                OP[0] = "0110";
                OP[1] = Findcode(1);
                OP[2] = Change(1);
                OPcode_text.Text = OP[0] + " " + OP[1] + " " + OP[2] + " " + OP[3] + " " + OP[4];
            }
            if (Input.Text.IndexOf("jmp") != -1)
            {
                OP[0] = "0111";
                OP[1] = Findcode(1);
                OP[2] = Change(1);
                OPcode_text.Text = OP[0] + " kkkk kkkk k" + OP[2];
            }
            if (Input.Text.IndexOf("jc") != -1)
            {
                OP[0] = "1000";
                OP[1] = Findcode(1);
                OP[2] = Change(1);
                OPcode_text.Text = OP[0] + " kkkk kkkk k" + OP[2];
            }

            if (Input.Text.IndexOf("mov") != -1)
            {
                OP[0] = "1010";
                OP[1] = Findcode(1);
                OP[2] = Change(1);
                OP[3] = Findcode(2);
                OP[4] = Change(2);
                OPcode_text.Text = OP[0] + " " + OP[1] + " " + OP[2] + " " + OP[3] + " " + OP[4];
            }

            if (Input.Text.IndexOf("ldi") != -1)
            {
                OP[0] = "1110";
                OP[1] = Findcode(1);
                OP[2] = Change(1);
                OP[3] = Change(3);
                OP[4] = Change(4);
                OPcode_text.Text = OP[0] + " " + OP[3] + " " + OP[4] + " 0" + OP[2];
                return OP;
            }
            if (Input.Text.IndexOf("ld") != -1)
            {
                OP[0] = "1001";
                OP[1] = Findcode(1);
                OP[2] = Change(1);
                OP[3] = Change(3);
                OP[4] = Change(4);
                OPcode_text.Text = OP[0] + " " + OP[3] + " " + OP[4] + " 1" + OP[2];
                return OP;
            }
            if (Input.Text.IndexOf("nop") != -1)
            {
                OP[0] = "0000";
                OPcode_text.Text = "0000 0000 0000 0000";
            }

            return OP;
        }

        private void Do_Click(object sender, EventArgs e)
        {
            int PC;
            int Rd;
            int Rs;

            reSR();

            //A.addr[0, 0] = 1;
            //A.addr[1, 0] = 1;
            string[] OPcode = new string[5];
            //OPcode = Input.Text;
            OPcode = Read();
            //Console.WriteLine(OPcode);

            if (OPcode[0] == "0001")
            {
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC += 2;
                PC_text.Text = Convert.ToString(PC, 16);

                Rd = Findaddr(OPcode[1],OPcode[2]);
                Rs = Findaddr(OPcode[3],OPcode[4]);

                Add(Rd, Rs);
                reR_text();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];

            }

            if (OPcode[0] == "0010")
            {
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC = PC + 2;
                PC_text.Text = Convert.ToString(PC, 16);

                Rd = Findaddr(OPcode[1], OPcode[2]);
                Rs = Findaddr(OPcode[3], OPcode[4]);

                Sub(Rd, Rs);
                reR_text();
                SR_text.Text = "" + sr[7]+ sr[6]+ sr[5]+ sr[4]+ sr[3]+ sr[2]+ sr[1]+ sr[0];

            }

            if (OPcode[0] == "0011")
            {
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC = PC + 2;
                PC_text.Text = Convert.ToString(PC, 16);

                Rd = Findaddr(OPcode[1], OPcode[2]);
                Rs = Findaddr(OPcode[3], OPcode[4]);

                And(Rd, Rs);
                reR_text();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];

            }

            if (OPcode[0] == "0100")
            {
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC = PC + 2;
                PC_text.Text = Convert.ToString(PC, 16);

                Rd = Findaddr(OPcode[1], OPcode[2]);

                Inc(Rd);
                reR_text();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];

            }

            if (OPcode[0] == "0101")
            {
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC = PC + 2;
                PC_text.Text = Convert.ToString(PC, 16);

                Rd = Findaddr(OPcode[1], OPcode[2]);

                Dec(Rd);
                reR_text();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];

            }

            if (OPcode[0] == "0110")
            {
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC = PC + 2;
                PC_text.Text = Convert.ToString(PC, 16);


                reR_text();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];

            }

            if (OPcode[0] == "0111")
            {
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC = PC + 2;
                PC_text.Text = Convert.ToString(PC, 16);

                Rd = Findaddr(OPcode[1], OPcode[2]);

                string bin;
                bin = Jmp(Rd);
                //Console.WriteLine(bin);
                PC_text.Text = string.Format("{0:x}", Convert.ToInt32(bin, 2));

                PC = Convert.ToInt32(PC_text.Text, 16);
            }

            if (OPcode[0] == "1000"&&sr[5]=="1")
            {
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC = PC + 2;
                PC_text.Text = Convert.ToString(PC, 16);

                Rd = Findaddr(OPcode[1], OPcode[2]);

                string bin;
                bin = Jmp(Rd);

                PC = int.Parse(string.Format("{0:x}", Convert.ToInt32(bin, 2)));
                PC_text.Text = Convert.ToString(PC, 16);
            }

            if (OPcode[0] == "1010")
            {
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC += 2;
                PC_text.Text = Convert.ToString(PC, 16);

                Rd = Findaddr(OPcode[1], OPcode[2]);
                Rs = Findaddr(OPcode[3], OPcode[4]);

                Mov(Rd, Rs);
                reR_text();
            }

            if (OPcode[0] == "1110")
            {
                string K;
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC += 2;
                PC_text.Text = Convert.ToString(PC, 16);

                Rd = Findaddr(OPcode[1], OPcode[2]);
                K = OPcode[3] + OPcode[4];

                Ldi(Rd, K);
                reR_text();
            }

            if (OPcode[0] == "1001")
            {
                string K;
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC += 2;
                PC_text.Text = Convert.ToString(PC, 16);

                Rd = Findaddr(OPcode[1], OPcode[2]);
                K = OPcode[3] + OPcode[4];

                Ld(Rd, K);
                reR_text();
            }

            if (OPcode[0] == "0000")
            {
                reSR();
                SR_text.Text = "" + sr[7] + sr[6] + sr[5] + sr[4] + sr[3] + sr[2] + sr[1] + sr[0];
                PC = Convert.ToInt32(PC_text.Text, 16);
                PC += 2;
                PC_text.Text = Convert.ToString(PC, 16);

                reR_text();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void File_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg1 = new OpenFileDialog();

            dlg1.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";

            if (dlg1.ShowDialog() == DialogResult.OK)  //判断是否选择文件

            {
                StreamReader sr1 = new StreamReader(dlg1.FileName, Encoding.Default);

                richTextBox1.Text = sr1.ReadToEnd();

                sr1.Close();

            }
            File_do.Enabled = true;
            
        }

        private void File_do_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                Input.Text = richTextBox1.Lines[i];
                Do.PerformClick();
            }
        }
    }
}
