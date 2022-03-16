using System;
using System.Windows.Forms;

namespace WavSin
{
    public partial class Form1 : Form
    {
        Sin sin;

        double amp, freq, phase, arraysize;
        double freq_disc;
        double[] signal;
        double freq2;

        private void WAVCreator_Click(object sender, EventArgs e)
        {
            CreateSignal();
            WAVFormatter.SignalToFile("signal.wav", signal, 8000, 16);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            CreateSignal();
            Visualization();
        }

        public Form1()
        {
            InitializeComponent();
            sin = new Sin();
        }

        public void CreateSignal()
        {
            amp = Convert.ToDouble(Ampl.Text);
            freq = Convert.ToDouble(Freq.Text, System.Globalization.CultureInfo.InvariantCulture);
            phase = Convert.ToDouble(Phas.Text);
            freq_disc = Convert.ToDouble(FREQ_DIS.Text);
            arraysize = Convert.ToDouble(Array.Text);
            freq2 = Convert.ToDouble(Freq_Second.Text);
            signal = new double[(int)arraysize];
            if (checkBox1.Checked)
                signal = sin.SInFuncFreq(amp, phase, freq, freq2, arraysize, freq_disc);
            else signal = sin.SinFunc(amp, phase, freq, arraysize, freq_disc);
        }

        public void Visualization()
        {
            Signal.Series[0].Points.Clear();
            Signal.ChartAreas[0].AxisX.Minimum = 0;
            Signal.ChartAreas[0].AxisX.Maximum = signal.Length;
            for(int i = 0; i < signal.Length; i++)
            {   
                Signal.Series[0].Points.AddXY(i, signal[i]);
            }

            if(checkBox1.Checked)
            {
                Signal.Series[0].Points.Clear();
                FreqGraph.Series[0].Points.Clear();
                for (int i = 0; i < signal.Length; i++)
                {
                    Signal.Series[0].Points.AddXY(i, signal[i]);
                    FreqGraph.Series[0].Points.AddXY(i, freq + (freq2 - freq) * i / signal.Length);
                }
            }
        }
    }
}
