using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES
{
    class DesExecute
    {
        int[] pc1 = { 57, 49, 41, 33, 25, 17, 9, 
                       1, 58, 50, 42, 34, 26, 18,
                      10, 2, 59, 51, 43, 35, 27,
                     19,11,3,60,52,44,36,
                    63,55,47,39,31,23,15,
                    7,62,54,46,38,30,22,
                    14,6,61,53,45,37,29,
                    21,13,5,28,20,12,4};
        int[] pc2 ={14,17,11,24,1,5,
                  3,28,15,6,21,10,
                  23,19,12,4,26,8,
                   16,7,27,20,13,2,
                   41,52,31,37,47,55,
                   30,40,51,45,33,48,
                   44,49,39,56,34,53,
                   46,42,50,36,29,32
                  };
        int[] hoanviip ={58,50,42,34,26,18,10,2,
                         60,52,44,36,28,20,12,4,
        62,54,46,38,30,22,14,6,
        64,56,48,40,32,24,16,8,
        57,49,41,33,25,17,9,1,
        59,51,43,35,27,19,11,3,
        61,53,45,37,29,21,13,5,
        63,55,47,39,31,23,15,7,
                      };
        int[] ip1 = { 40, 8, 48, 16, 56, 24, 64, 
					32, 39, 7, 47, 15, 55, 
					23, 63, 31, 38, 6, 46, 
					14, 54, 22, 62, 30, 37, 
					5, 45, 13, 53, 21, 61, 
					29, 36, 4, 44, 12, 52, 
					20, 60, 28, 35, 3, 43, 
					11, 51, 19, 59, 27, 34, 
					2, 42, 10, 50, 18, 58, 
					26, 33, 1, 41, 9, 49, 
					17, 57, 25 };
      
        static string xor(char[] a, char[] b, int n)
        {
            string kq = "";
            for (int i = 0; i < n; i++)
            {
                if (a[i] == b[i])
                {
                    kq += "0";
                }
                else
                {
                    kq += "1";
                }
            }
            return kq;
        }
        static string hoanvip(string b)
        {
            char[] a = new char[33];
            char[] s = b.ToCharArray();
            for (int i = 0; i < 32; i++)
            {
                a[i + 1] = s[i];
            }
            int[] so = { 16, 7, 20, 21, 29, 12, 28, 17, 1, 15, 23, 26, 5, 18, 31, 10, 2, 8, 24, 14, 32, 27, 3, 9, 19, 13, 30, 6, 22, 11, 4, 25 };
            string kq = "";
            for (int i = 0; i < so.Length; i++)
            {
                kq += a[so[i]];
            }
            return kq;
        }
        static char[] hoanvie(string b)
        {
            char[] s = new char[33];
            for (int i = 0; i < b.Length; i++)
            {
                s[i + 1] = b[i];
            }

            int[] E = { 32, 1, 2, 3, 4, 5, 4, 
					5, 6, 7, 8, 9, 8, 9, 10, 
					11, 12, 13, 12, 13, 14, 15, 
					16, 17, 16, 17, 18, 19, 20, 
					21, 20, 21, 22, 23, 24, 25, 
					24, 25, 26, 27, 28, 29, 28, 
					29, 30, 31, 32, 1 };
            char[] kq = new char[48];
            for (int i = 0; i < E.Length; i++)
            {
                kq[i] = s[E[i]];
            }
            return kq;
        }
        static int todecimal(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                return 0;
            }
            else if (a == 0 && b == 1)
            {
                return 1;
            }
            else if (a == 1 && b == 0)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        static int timcot(int a, int b, int c, int d)
        {
            int kq = 0;
            if (a == 1)
                kq += 8;
            if (b == 1)
                kq += 4;
            if (c == 1)
                kq += 2;
            if (d == 1)
                kq += 1;
            return kq;
        }
        static string timchuoi(int n)
        {
            if (n == 0)
            {
                return "0000";
            }
            else if (n == 1)
            {
                return "0001";
            }
            else if (n == 2)
            {
                return "0010";
            }
            else if (n == 3)
            {
                return "0011";
            }
            else if (n == 4)
            {
                return "0100";
            }
            else if (n == 5)
            {
                return "0101";
            }
            else if (n == 6)
            {
                return "0110";
            }
            else if (n == 7)
            {
                return "0111";
            }
            else if (n == 8)
            {
                return "1000";
            }
            else if (n == 9)
            {
                return "1001";
            }
            else if (n == 10)
            {
                return "1010";
            }
            else if (n == 11)
            {
                return "1011";
            }
            else if (n == 12)
            {
                return "1100";
            }
            else if (n == 13)
            {
                return "1101";
            }
            else if (n == 14)
            {
                return "1110";
            }
            else
            {
                return "1111";
            }
        }
        public string hoanviketthuc(string text,int n)
        {
            string kq="";
            char[] temp = text.ToCharArray();
            for(int i=0;i<n;i++)
            {
                kq += temp[ip1[i] - 1].ToString();
            }
            return kq;
        }
        static string sbox(string b)
        {
            int[,] s1 ={ { 14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7 }, 
			{ 0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8 }, 
			{ 4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0 }, 
			{ 15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13 } };
            int[,] s2 ={ { 15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10 }, 
			{ 3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5 }, 
			{ 0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15 }, 
			{ 13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9 } };
            int[,] s3 ={ { 10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8 }, 
			{ 13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1 }, 
			{ 13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7 }, 
			{ 1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12 } };
            int[,] s4 ={ { 7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15 }, 
			{ 13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9 }, 
			{ 10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4 }, 
			{ 3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14 } };
            int[,] s5 ={ { 2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9 }, 
			{ 14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6 }, 
			{ 4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14 }, 
			{ 11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3 } };
            int[,] s6 ={ { 12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11 }, 
			{ 10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8 }, 
			{ 9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6 }, 
			{ 4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13 } };
            int[,] s7 ={ { 4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1 }, 
			{ 13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6 }, 
			{ 1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2 }, 
			{ 6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12 } };
            int[,] s8 ={ { 13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7 }, 
			{ 1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2 }, 
			{ 7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8 }, 
			{ 2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 } };
            char[] bi = b.ToCharArray();
            int[] a = new int[48];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] =int.Parse(bi[i].ToString());
            }
            int[] b1 = { a[0], a[1], a[2], a[3], a[4], a[5] };
            int[] b2 = { a[6], a[7], a[8], a[9], a[10], a[11] };
            int[] b3 = { a[12], a[13], a[14], a[15], a[16], a[17] };
            int[] b4 = { a[18], a[19], a[20], a[21], a[22], a[23] };
            int[] b5 = { a[24], a[25], a[26], a[27], a[28], a[29] };
            int[] b6 = { a[30], a[31], a[32], a[33], a[34], a[35] };
            int[] b7 = { a[36], a[37], a[38], a[39], a[40], a[41] };
            int[] b8 = { a[42], a[43], a[44], a[45], a[46], a[47] };
            string ketqua = "";
            string kq1 = timchuoi(s1[todecimal(a[0], a[5]),timcot(a[1], a[2], a[3], a[4])]);
            ketqua += kq1;
            string kq2 = timchuoi(s2[todecimal(a[6], a[11]),timcot(a[7], a[8], a[9], a[10])]);
            ketqua += kq2;
            string kq3 = timchuoi(s3[todecimal(a[12], a[17]),timcot(a[13], a[14], a[15], a[16])]);
            ketqua += kq3;
            string kq4 = timchuoi(s4[todecimal(a[18], a[23]),timcot(a[19], a[20], a[21], a[22])]);
            ketqua += kq4;
            string kq5 = timchuoi(s5[todecimal(a[24], a[29]),timcot(a[25], a[26], a[27], a[28])]);
            ketqua += kq5;
            string kq6 = timchuoi(s6[todecimal(a[30], a[35]),timcot(a[31], a[32], a[33], a[34])]);
            ketqua += kq6;
            string kq7 = timchuoi(s7[todecimal(a[36], a[41]),timcot(a[37], a[38], a[39], a[40])]);
            ketqua += kq7;
            string kq8 = timchuoi(s8[todecimal(a[42], a[47]),timcot(a[43], a[44], a[45], a[46])]);
            ketqua += kq8;

            return ketqua;
        }
        private string hex2binary(string hexvalue)
        {
            string binary= "";
            binary = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
            return binary;
        }
        private string dec2binary(string decvalue)
        {
            string binary= "";
            binary = Convert.ToString(Convert.ToInt32(decvalue, 10), 2);
            return binary;
        }
        public string binary2hex(string binary)
        {
            string hex = "";
            hex = Convert.ToString(Convert.ToInt32(binary, 2), 16);
            return hex;
        }
        public string chuyennhiphan(string khoa)
        {
            string kq = "";
            foreach (char x in khoa)
            {
                if (char.IsDigit(x))
                {
                    string s = x.ToString();
                    string rs = dec2binary(s);
                    if (rs.Length == 1)
                    {
                        rs = "000" + rs;
                    }
                    else if (rs.Length == 2)
                    {
                        rs = "00" + rs;
                    }
                    else if (rs.Length == 3)
                    {
                        rs = "0" + rs;
                    }

                    kq += rs;

                }
                else
                {
                    string s = x.ToString();
                    kq += hex2binary(s);
                }
            }
            return kq;
        }
        public string hoanvipc1(string khoanhiphan)
        {
            char[] arr = khoanhiphan.ToCharArray();
            char[] kq = new char[56];

            for(int i=0;i<56;i++)
            {
                kq[i] = arr[pc1[i]-1];
            }
            string rs="";
            foreach(char c in kq)
            {
                rs += c.ToString();
            }
            return rs;
        }
        public string[] CnDn(string khoanhiphan)
        {
            string[] cndn = new string[17];
            string[] c = new string[17];
            string[] d = new string[17];
            cndn[0] = hoanvipc1(khoanhiphan);
            c[0]=cndn[0].Substring(0, cndn[0].Length/2);
            d[0] = cndn[0].Substring(28, cndn[0].Length / 2);
            for(int i=1;i<=16;i++)
            {
                char[] oldc = c[i - 1].ToCharArray();
                char[] oldd = d[i - 1].ToCharArray();
                if(i==1||i==2||i==9||i==16)
                {
                    char[] newc = new char[28];
                    char[] newd = new char[28];
                    for(int j=0;j<28;j++)
                    {
                        if(j==27)
                        {
                           newc[j] = oldc[0];
                           newd[j] = oldd[0];
                        }
                        else
                        {
                            newc[j] = oldc[j+1];
                            newd[j] = oldd[j+1];
                        }
                        
                    }
                    foreach(char x in newc)
                    {
                        c[i] += x.ToString();
                    }
                    foreach (char x in newd)
                    {
                        d[i] += x.ToString();
                    }
                    cndn[i] = c[i] + d[i];
                }
                else
                {
                    char[] newc = new char[28];
                    char[] newd = new char[28];
                    for (int j = 0; j < 28; j++)
                    {
                        if (j == 26)
                        {
                            newc[j] = oldc[0];
                            newd[j] = oldd[0];
                        }
                        else if(j==27)
                        {
                            newc[j] = oldc[1];
                            newd[j] = oldd[1];
                        }
                        else
                        {
                            newc[j] = oldc[j + 2];
                            newd[j] = oldd[j + 2];
                        }

                    }
                    foreach (char x in newc)
                    {
                        c[i] += x.ToString();
                    }
                    foreach (char x in newd)
                    {
                        d[i] += x.ToString();
                    }
                    cndn[i] = c[i] + d[i];
                }
            }
            return cndn;
        }
        public string[] sinhk(string[] cndn)
        {
            string[] k = new string[17];
            for(int i=1;i<=16;i++)
            {
                char[] cidi=cndn[i].ToCharArray();
                char[] tempk = new char[48];
                for(int j=0;j<48;j++)
                {
                    tempk[j] = cidi[pc2[j]-1];
                }
                foreach(char x in tempk)
                {
                    k[i] += x.ToString();
                }
            }
            return k;
        }
        public string[] LiRi(string banro,string[] k)
        {
            string[] liri = new string[17];
            string temp = chuyennhiphan(banro);
            for(int i=0;i<64;i++)
            {
                liri[0] += temp[hoanviip[i] - 1];
            }
            string[] li = new string[32];
            string[] ri = new string[32];
            li[0] = liri[0].Substring(0, 32);
            ri[0] = liri[0].Substring(32, 32);
            for (int i = 1; i <=16;i++)
            {
                li[i] = ri[i - 1];
                char[] hve = hoanvie(li[i]);
                string xorekn = xor(hve, k[i].ToCharArray(),48);
                string sb = sbox(xorekn);
                string f = hoanvip(sb);
                string kq=xor(li[i-1].ToCharArray(),f.ToCharArray(),32);
                ri[i] = kq;
                liri[i] = li[i] + ri[i];
            }
            return liri;
        }

        public string mahoa(string banro,string key)
        {
            string banma = "";
            string khoa = chuyennhiphan(key);
            string[] kq = CnDn(khoa);
            string[] k = sinhk(kq);
            string[] lr = LiRi(banro, k);
            string l16 = lr[16].Substring(0, 32);
            string r16 = lr[16].Substring(32, 32);
            string newlr = r16 + l16;
            string final = hoanviketthuc(newlr, 64);
            string[] temp = new string[16];
            int count = 0;
            int b = 0;
            for (int i = 0; i < 16;i++)
            {
                temp[count] = final.Substring(b, 4);
                b += 4;
                count++;
            }
                foreach (string x in temp)
                {
                    banma += binary2hex(x);
                }
            return banma;
        }
        public string giaima(string banma,string key)
        {
            string banro = "";
            string khoa = chuyennhiphan(key);
            string[] kq = CnDn(khoa);
            string[] k = sinhk(kq);
            string[] kdao = new string[17];
            int c = 1;
            for(int i=16;i>=1;i--)
            {
                kdao[c] = k[i];
                c++;
            }
            string[] lr = LiRi(banma, kdao);
            string l16 = lr[16].Substring(0, 32);
            string r16 = lr[16].Substring(32, 32);
            string newlr = r16 + l16;
            string final = hoanviketthuc(newlr, 64);
            string[] temp = new string[16];
            int count = 0;
            int b = 0;
            for (int i = 0; i < 16; i++)
            {
                temp[count] = final.Substring(b, 4);
                b += 4;
                count++;
            }
            foreach (string x in temp)
            {
                banro += binary2hex(x);
            }
            return banro;
        }
    }
}
