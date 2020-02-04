using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._3
{
    public class Polynom
    {
        public double[] Coefficients { get; set; } 


        public Polynom (params double [] Coeff)
        {
            Coefficients = new double[Coeff.Length];
            Coeff.CopyTo(Coefficients, 0);
        }

        public double this [int index]
        {
            get
            {
                return Coefficients[index];
            }
            set
            {
                Coefficients[index] = value;
            }
        }

        public static Polynom operator + (Polynom FirstArr, Polynom SecondArr)
        {
            int x = (FirstArr.Coefficients.Length > SecondArr.Coefficients.Length ? FirstArr.Coefficients.Length : SecondArr.Coefficients.Length);

            double[] Result = new double[x];
            if (FirstArr.Coefficients.Length>SecondArr.Coefficients.Length)
            {
                for (int i = 0; i < SecondArr.Coefficients.Length; i++)
                {
                    Result[i] = FirstArr[i] + SecondArr[i];
                }
                Array.Copy(FirstArr.Coefficients, SecondArr.Coefficients.Length, Result, SecondArr.Coefficients.Length, FirstArr.Coefficients.Length - SecondArr.Coefficients.Length);
            }

            if (FirstArr.Coefficients.Length < SecondArr.Coefficients.Length)
            {
                for (int i = 0; i < FirstArr.Coefficients.Length; i++)
                {
                    Result[i] = FirstArr[i] + SecondArr[i];
                }
                Array.Copy(SecondArr.Coefficients, FirstArr.Coefficients.Length, Result, FirstArr.Coefficients.Length, SecondArr.Coefficients.Length - FirstArr.Coefficients.Length);
            }

            if (FirstArr.Coefficients.Length == SecondArr.Coefficients.Length)
            {
                for (int i = 0; i < FirstArr.Coefficients.Length; i++)
                {
                    Result[i] = FirstArr[i] + SecondArr[i];
                }
            }

            return new Polynom(Result);
        }

        public static Polynom operator -(Polynom FirstArr, Polynom SecondArr)
        {
            int x = (FirstArr.Coefficients.Length > SecondArr.Coefficients.Length ? FirstArr.Coefficients.Length : SecondArr.Coefficients.Length);

            double[] Result = new double[x];
            if (FirstArr.Coefficients.Length > SecondArr.Coefficients.Length)
            {
                for (int i = 0; i < SecondArr.Coefficients.Length; i++)
                {
                    Result[i] = FirstArr[i] - SecondArr[i];
                }
                Array.Copy(FirstArr.Coefficients, SecondArr.Coefficients.Length, Result, SecondArr.Coefficients.Length, FirstArr.Coefficients.Length - SecondArr.Coefficients.Length);
            }

            if (FirstArr.Coefficients.Length < SecondArr.Coefficients.Length)
            {
                for (int i = 0; i < FirstArr.Coefficients.Length; i++)
                {
                    Result[i] = FirstArr[i] - SecondArr[i];
                }
                Array.Copy(SecondArr.Coefficients, FirstArr.Coefficients.Length, Result, FirstArr.Coefficients.Length, SecondArr.Coefficients.Length - FirstArr.Coefficients.Length);
            }

            if (FirstArr.Coefficients.Length == SecondArr.Coefficients.Length)
            {
                for (int i = 0; i < FirstArr.Coefficients.Length; i++)
                {
                    Result[i] = FirstArr[i] - SecondArr[i];
                }
            }

            return new Polynom(Result);
        }

        public static Polynom operator * (Polynom FirstArr, Polynom SecondArr)
        {
            int x = (FirstArr.Coefficients.Length + SecondArr.Coefficients.Length - 1);

            double[] Result = new double[x];
            for (int i = 0; i < FirstArr.Coefficients.Length; i++)
            {
                for (int j = 0; j < SecondArr.Coefficients.Length; j++)
                {
                    Result[i + j] += FirstArr[i] * SecondArr[j];
                }
            }

            return new Polynom(Result);
        }

        public static bool operator == (Polynom FirstArr, Polynom SecondArr)
        {

            int x = (FirstArr.Coefficients.Length > SecondArr.Coefficients.Length ? FirstArr.Coefficients.Length : SecondArr.Coefficients.Length);
            int sum = 0;
            
            if (FirstArr.Coefficients.Length > SecondArr.Coefficients.Length)
            {
                for (int i = x-1; i>=0; i--)
                {
                    if (FirstArr[i]==0)
                        sum += 1;

                    if (FirstArr[i] != 0)
                        break;
                }

                double[] Buffer = new double[x - sum];

                if (sum == 0)
                    return false;

                if (sum > 0)
                    Array.Copy(FirstArr.Coefficients, 0, Buffer, 0, x - sum);

                if ( Buffer.Length!=SecondArr.Coefficients.Length)
                    return false;

            }

            if (SecondArr.Coefficients.Length > FirstArr.Coefficients.Length)
            {
                for (int i = x-1; i >= 0; i--)
                {
                    if (SecondArr[i] == 0)
                        sum += 1;

                    if (SecondArr[i] != 0)
                        break;
                }

                double[] Buffer = new double[x - sum];

                if (sum == 0)
                    return false;

                if (sum > 0)
                    Array.Copy(SecondArr.Coefficients, 0, Buffer, 0, x - sum);

                if (Buffer.Length != FirstArr.Coefficients.Length)
                    return false;
            }

            if (FirstArr.Coefficients.Length == SecondArr.Coefficients.Length)
            {
                for (int i = 0; i < FirstArr.Coefficients.Length; i++)
                {
                    if (FirstArr[i] != SecondArr[i])
                        return false;
                }
            }

            return true;
        }

        public static bool operator != (Polynom FirstArr, Polynom SecondArr)
        {
            if (FirstArr.Coefficients.Length == SecondArr.Coefficients.Length)
            {
                return false;
            }

            for (int i = 0; i < FirstArr.Coefficients.Length; i++)
            {
                if (FirstArr[i] == SecondArr[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder Line = new StringBuilder();

            Line.AppendFormat($"{Coefficients[0]}");

            for (int i=1; i < Coefficients.Length; i++)
            {
                Line.AppendFormat($" + {Coefficients[i]}*x^{i}");
            }

            return Line.ToString();
        }

        public static Polynom operator / (Polynom FirstArr, Polynom SecondArr)
        {
            List<double> PolynomResult = new List<double>(FirstArr.Coefficients.Length - 1);

            double Result;
            double Buffer;
            double Remainder;

            for (int i = FirstArr.Coefficients.Length - 1; i >= 1; i--)
            {

                Buffer = FirstArr[i] / SecondArr[SecondArr.Coefficients.Length - 1];

                PolynomResult.Add(Buffer);

                for (int j = SecondArr.Coefficients.Length - 2; j >= 0; j--)
                {
                    int x = i - 1;

                    Result = FirstArr[x] - (SecondArr[j] * Buffer);

                    if (x == 0 && Result == 0)
                        FirstArr[0] = 0;

                    if (Result == 0)
                    {
                        x = x - 1;
                        continue;
                    }

                    if (x == 0 && Result == 0)
                        FirstArr[0] = 0;

                    if (Result != 0)
                    {
                        FirstArr[x] = Result;
                        x = x - 1;
                    }
                }
            }

            if (FirstArr[0] != 0)
                Remainder = FirstArr[0];

            PolynomResult.Reverse();

            double[] Res = PolynomResult.ToArray();

            return new Polynom(Res);
        }

        public override bool Equals(object obj)
        {
            Polynom p = obj as Polynom;

            if ((object)p == null)
                return false;
            
            return true;
        }

        public override int GetHashCode()
        {
            return -971426165 + EqualityComparer<double[]>.Default.GetHashCode(Coefficients);
        }
    }
}
