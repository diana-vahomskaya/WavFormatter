using System;

namespace WavSin
{
    public class Sin
    {
        double lastPhase = 0;

        public double[] SinFunc(double A, double P, double F, double N, double FD)
        {
            double[] Func = new double[(int)(N * FD)];
            double dt = 1.0 / FD;
            lastPhase += P;
            for(int i = 0; i < Func.Length; i++)
            {
                Func[i] = A * Math.Sin(lastPhase);
                lastPhase += F * dt;
                if (lastPhase > 2.0 * Math.PI)
                    lastPhase -= 2.0 * Math.PI;
            }
            return Func;
        }

        public double[] SInFuncFreq(double A, double P, double F1, double F2, double N, double FD)
        {
            double[] Func = new double[(int)(N * FD)];
            double dt = 1.0 / FD;
            lastPhase += P;
            double F = F1;
            for (int i = 0; i < Func.Length; i++)
            {
                Func[i] = A * Math.Sin(lastPhase);
                lastPhase += F * dt;
                if (lastPhase > 2.0 * Math.PI)
                    lastPhase -= 2.0 * Math.PI;
                F += (F2 - F1) / N * dt;
            }
            return Func;
        }
    }
}
