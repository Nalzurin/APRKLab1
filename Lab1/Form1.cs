using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public static double[] standardGearRatios = new double[] { 1.0, 1.25, 1.6, 2.0, 2.5, 3.15,
                                                                   1.12, 1.4, 1.8, 2.24, 2.8, 4.0,
                                                                   5.0, 6.3, 8.0, 10.0, 3.55, 4.5,
                                                                   5.6, 7.1, 9.0, 11.2 };
        public static string[,] engines = new string[,] {{ "3000", "0.09", "4АА50А2УЗ", "8.6", "2740", "2.2", "2" },
                                                  { "3000", "0.12", "4АА50В2УЗ", "9.7", "2700", "2.2", "2" },
                                                  { "3000", "0.18", "4АА56А2У3", "8.0", "2760", "2.2", "2" },
                                                  { "3000", "0.25", "4АА56В2УЗ", "8.0", "2760", "2.2", "2" },
                                                  { "3000", "0.37", "4А63А2УЗ", "8.3", "2750", "2.2", "2" },
                                                  { "3000", "0.55", "4А63В2УЗ", "8.5", "2745", "2.2", "2" },
                                                  { "3000", "0.75", "4А71А2У3", "5.9", "2840", "2.2", "2" },
                                                  { "3000", "1.1", "4А71В2УЗ", "6.3", "2810", "2.2", "2" },
                                                  { "3000", "1.5", "4А80А2УЗ", "4.2", "2850", "2.2", "2" },
                                                  { "3000", "2.2", "4А80В2УЗ", "4.3", "2850", "2.2", "2" },
                                                  { "3000", "3", "4A90L2У3", "4.3", "2840", "2.2", "2" },
                                                  { "3000", "4", "4А100S2УЗ", "3.3", "2880", "2.2", "2" },
                                                  { "3000", "5.5", "4А100L2УЗ", "3.4", "2880", "2.2", "2" },
                                                  { "3000", "7.5", "4А112М2УЗ", "2.5", "2900", "2.2", "2" },
                                                  { "3000", "11", "4А132М2УЗ", "2.3", "2900", "2.2", "1.6" },
                                                  { "3000", "15", "4А160S2УЗ", "2.1", "2940", "2.2", "1.4" },
                                                  { "3000", "18.5", "4А160М2УЗ", "2.1", "2940", "2.2", "1.4" },
                                                  { "3000", "22", "4A180S2Y3", "2.0", "2945", "2.2", "1.4" },
                                                  { "3000", "30", "4А180М2УЗ", "1.9", "2945", "2.2", "1.4" },
                                                  { "3000", "37", "4А200М2УЗ", "1.9", "2945", "2.2", "1.4" },
                                                  { "3000", "45", "4А200L2УЗ", "1.8", "2945", "2.2", "1.4" },
                                                  { "3000", "55", "4А225М2УЗ", "1.8", "2945", "2.2", "1.2" },
                                                  { "3000", "75", "4А250S2УЗ", "1.4", "2960", "2.2", "1.2" },
                                                  { "1500", "0.06", "4АА50А4УЗ", "8.1", "1380", "2.2", "2" },
                                                  { "1500", "0.09", "4AA50B4У3", "8.6", "1370", "2.2", "2" },
                                                  { "1500", "0.12", "4АА56А4УЗ", "8.0", "1380", "2.2", "2" },
                                                  { "1500", "0.18", "4А56В4УЗ", "8.7", "1370", "2.2", "2" },
                                                  { "1500", "0.25", "4АА63А4УЗ", "8.0", "1380", "2.2", "2" },
                                                  { "1500", "0.37", "4АА63В4УЗ", "9.0", "1365", "2.0", "2" },
                                                  { "1500", "0.55", "4А71А4УЗ", "7.3", "1390", "2.0", "2" },
                                                  { "1500", "0.75", "4А71В4УЗ", "7.5", "1390", "2.0", "2" },
                                                  { "1500", "1.5", "4А80В4УЗ", "5.8", "1415", "2.2", "2" },
                                                  { "1500", "2.2", "4А90L4УЗ", "4.3", "1425", "2.2", "2" },
                                                  { "1500", "3", "4A100S4У3", "4.4", "1435", "2.2", "2" },
                                                  { "1500", "4", "4А100L4УЗ", "4.7", "1430", "2.2", "2" },
                                                  { "1500", "5.5", "4А112M4УЗ", "3.7", "1445", "2.2", "2" },
                                                  { "1500", "7.5", "4А132S4УЗ", "3.0", "1455", "2.2", "2" },
                                                  { "1500", "11", "4А132М4УЗ", "2.8", "1460", "2.2", "2" },
                                                  { "1500", "15", "4А160S4УЗ", "2.3", "1465", "2.2", "1.4" },
                                                  { "1500", "18.5", "4А160М4УЗ", "2.2", "1465", "2.2", "1.4" },
                                                  { "1500", "22", "4A180S4Y3", "2.0", "1470", "2.2", "1.4" },
                                                  { "1500", "30", "4А180М4УЗ", "1.9", "1470", "2.2", "1.4" },
                                                  { "1500", "37", "4А200М4УЗ", "1.7", "1475", "2.2", "1.4" },
                                                  { "1500", "45", "4А200L4УЗ", "1.6", "1475", "2.2", "1.2" },
                                                  { "1500", "55", "4А225М4УЗ", "1.4", "1480", "2.2", "1.2" },
                                                  { "1500", "75", "4А250S4УЗ", "1.2", "1480", "2.2", "1.2" },
                                                  { "1500", "90", "4А250М4УЗ", "1.3", "1480", "2.2", "1.2" },
                                                  { "1000", "0.18", "4АА63А6УЗ", "11.5", "885", "2.2", "2" },
                                                  { "1000", "0.25", "4АА63В6УЗ", "10.8", "890", "2.2", "2" },
                                                  { "1000", "0.37", "4А71А6У3", "9.2", "910", "2.2", "2" },
                                                  { "1000", "0.55", "4А71В6УЗ", "10", "900", "2.2", "2" },
                                                  { "1000", "0.75", "4А80А6УЗ", "8.4", "915", "2.2", "2" },
                                                  { "1000", "1.1", "4А80В6УЗ", "8", "920", "2.2", "2" },
                                                  { "1000", "1.5", "4А90L6УЗ", "6.4", "935", "2.2", "2" },
                                                  { "1000", "2.2", "4A100L6У3", "5.1", "950", "2.2", "2" },
                                                  { "1000", "3.0", "4А112МА6УЗ", "4.7", "955", "2.2", "2" },
                                                  { "1000", "4.0", "4А112МВ6УЗ", "5.1", "950", "2.2", "2" },
                                                  { "1000", "5.5", "4А132S6УЗ", "3.3", "965", "2.2", "2" },
                                                  { "1000", "7.5", "4А132МУ3", "3.2", "970", "2.2", "2" },
                                                  { "1000", "11", "4А160S6У3", "2.7", "975", "2.0", "1.2" },
                                                  { "1000", "15", "4А160М6УЗ", "2.6", "975", "2.0", "1.2" },
                                                  { "1000", "18.5", "4А180М6УЗ", "2.7", "975", "2.0", "1.2" },
                                                  { "1000", "22.5", "4А200М6УЗ", "2.3", "975", "2.0", "1.2" },
                                                  { "1000", "30", "4А200L6УЗ", "2.1", "980", "2.0", "1.2" },
                                                  { "1000", "37", "4А225М6УЗ", "1.8", "980", "2.0", "1.2" },
                                                  { "1000", "45", "4А250S6УЗ", "1.4", "985", "2.0", "1.2" },
                                                  { "1000", "55", "4А250М6УЗ", "1.3", "985", "2.0", "1.2" },
                                                  { "750", "0.25", "4А71В8УЗ", "12.7", "680", "1.7", "1.3" },
                                                  { "750", "0.37", "4А80А8УЗ", "8.9", "675", "1.7", "1.6" },
                                                  { "750", "0.55", "4А80В8УЗ", "9.0", "700", "1.7", "1.6" },
                                                  { "750", "0.75", "4А90LА8УЗ", "6.0", "700", "1.7", "1.6" },
                                                  { "750", "1.1", "4A90LB8У3", "7.0", "700", "1.7", "1.6" },
                                                  { "750", "1.5", "4А100L8УЗ", "7.0", "700", "2.2", "1.8" },
                                                  { "750", "2.2", "4А112МА8УЗ", "6.8", "700", "2.2", "1.8" },
                                                  { "750", "3.0", "4А112МВ8УЗ", "5.8", "700", "2.2", "1.8" },
                                                  { "750", "4.0", "4A132S8У3", "4.1", "720", "2.2", "1.8" },
                                                  { "750", "5.5", "4А132М8УЗ", "4.1", "720", "2.2", "1.8" },
                                                  { "750", "7.5", "4А160S8УЗ", "2.5", "730", "2.2", "1.4" },
                                                  { "750", "11", "4А160М8УЗ", "2.5", "730", "2.2", "1.2" },
                                                  { "750", "15", "4А180М8УЗ", "2.6", "730", "2.2", "1.2" },
                                                  { "750", "18.5", "4А200М8УЗ", "2.3", "735", "2.2", "1.2" },
                                                  { "750", "22.5", "4А200L8У3", "2.7", "730", "2.0", "1.2" },
                                                  { "750", "30", "4А225М8УЗ", "1.8", "735", "2.0", "1.2" },
                                                  { "750", "37", "4А25058УЗ", "1.6", "740", "2.0", "1.2" },
                                                  { "750", "45", "4А250М8УЗ", "1.4", "740", "2.0", "1.2" }};

        public double powerReq, powerOutput, factor;
        public double ratioDrive, ratioRed, errorMargin;
        public double closestratio;
        public double Pshk1, Pshk2, Pz1, Pz2, Pout, deltaP;
        public double nshk1, nshk2, nz1, nz2, nout, deltan;
        public double Tshk1, Tshk2, Tz1, Tz2, Tout, deltaT;
        //Calculate the required power for engine, used to calculate which engine to use
        public void GearPowerCalc(int t, int n, bool isBelt)
        {
            logBox.Items.Add("Calculating power output:");
            powerOutput = Math.Round((double)t * n / 9550, 2);
            logBox.Items.Add($"Power Output Pвих = ({t} * {n}) / 9550 = {powerOutput}");

            logBox.Items.Add("Calculating factor:");
            logBox.Items.Add($"Has belt = {isBelt}");
            factor = isBelt ? (double)0.90 : (double)0.95;
            logBox.Items.Add($"Factor nзаг = {factor}");

            logBox.Items.Add("Calculating power requirement:");
            powerReq = Math.Round(powerOutput / factor, 2);
            logBox.Items.Add($"Power Requirement = {powerOutput} / {factor} = {powerReq}");
        }

        public (string Name, double Power, double Spin) EngineSearcher(int nc, double powerReq)
        {
            logBox.Items.Add("Searching for the best engine:");
            int closestEngine = 0;
            double powerDisparage = double.MaxValue;
            logBox.Items.Add("Accessing data bank:");
            for (int i = 0; i < engines.GetLength(0); i++)
            {
                if (int.Parse(engines[i, 0]) == nc)
                {
                    if (double.Parse(engines[i, 1]) == powerReq)
                    {
                        closestEngine = i;
                    }
                    if (Math.Abs(powerReq - double.Parse(engines[i, 1])) < powerDisparage)
                    {
                        powerDisparage = Math.Abs(powerReq - double.Parse(engines[i, 1]));
                        closestEngine = i;
                    }

                }
            }
            logBox.Items.Add("Engine found! Copying data...");
            logBox.Items.Add($"Best engine: {engines[closestEngine, 2]}, engine power: {engines[closestEngine, 1]} kW, nominal spin: {engines[closestEngine, 4]}.");
            return (engines[closestEngine, 2], double.Parse(engines[closestEngine, 1]), double.Parse(engines[closestEngine, 4]));
        }

        public void GearRatioCalculator(double spin, double n, double U, bool isBelt)
        {
            closestratio = double.MaxValue;
            logBox.Items.Add("Calculating Drive Gear Ratio:");
            ratioDrive = Math.Round(spin / n, 2);
            logBox.Items.Add($"{spin} / {n} = {ratioDrive}");
            logBox.Items.Add($"Has belt = {isBelt}");
            logBox.Items.Add("Calculating Reductor Gear Ratio:");
            ratioRed = isBelt ? Math.Round(ratioDrive / U, 2) : ratioDrive;
            logBox.Items.Add($"Reductor Gear Ratio U1-2 = Ured = {ratioRed}");
            logBox.Items.Add("Searching closest standard gear ratio...");

            foreach (double ratio in standardGearRatios)
            {
                if (Math.Abs(ratioRed - ratio) < Math.Abs(ratioRed - closestratio))
                {
                    closestratio = ratio;
                }
            }
            logBox.Items.Add("Closest ratio found!");
            logBox.Items.Add($"Closest ratio = {closestratio}");
            logBox.Items.Add("Calculating error margin, max error margin = 2.5%");
            errorMargin = Math.Round(Math.Abs((ratioRed - closestratio) / ratioRed) * 100, 2);
            logBox.Items.Add($"Error margin deltaU = {errorMargin}%");


        }
        public void DrivePowerCalculator(double EnginePower, bool HasBelt)
        {
            logBox.Items.Add("Calculating Drive Power:");
            logBox.Items.Add($"Has belt = {HasBelt}");

            if (HasBelt)
            {
                Pshk1 = Math.Round(EnginePower, 2);
                logBox.Items.Add($"Pшк1 = {Pshk1}");
                Pshk2 = Math.Round(Pshk1 * 0.95, 2);
                logBox.Items.Add($"Pшк2 = {Pshk2}");
                Pz1 = Math.Round(Pshk2 * 0.99, 2);

            }
            else
            {
                Pz1 = Math.Round(EnginePower * 0.97, 2);

            }
            logBox.Items.Add($"Pz1 = {Pz1}");
            Pz2 = Math.Round(Pz1 * 0.97, 2);
            logBox.Items.Add($"Pz2 = {Pz2}");
            Pout = Math.Round(Pz2 * 0.99, 2);
            logBox.Items.Add($"Pвих = {Pout}");
            deltaP = Math.Round(Math.Abs((powerOutput - Pout) / Pout) * 100, 2);
            logBox.Items.Add($"Delta P = {deltaP}");


        }
        public void SpinCalculator(double Spin, double U, double n, bool HasBelt)
        {
            logBox.Items.Add("Calculating Spin:");
            logBox.Items.Add($"Has belt = {HasBelt}");
            if (HasBelt)
            {
                nshk1 = Spin;
                logBox.Items.Add($"nшк1 = {nshk1}");
                nshk2 = Math.Round(nshk1 / U, 2);
                logBox.Items.Add($"nшк2 = {nshk2}");
                nz1 = nshk2;
            }
            else
            {
                nz1 = Spin;

            }
            logBox.Items.Add($"nz1 = {nz1}");
            nz2 = Math.Round(nz1 / closestratio, 2);
            logBox.Items.Add($"nz2 = {nz2}");
            nout = nz2;
            logBox.Items.Add($"nвих = {nout}");
            deltan = Math.Round(Math.Abs((nout - n) / n) * 100, 2);
            logBox.Items.Add($"Delta n = {deltan}");
        }

        public void TorqueCalculator(double T, bool HasBelt)
        {
            logBox.Items.Add("Calculating Torque:");
            logBox.Items.Add($"Has belt = {HasBelt}");
            if (HasBelt)
            {
                Tshk1 = Math.Round(9550 * Pshk1 / nshk1, 2);
                logBox.Items.Add($"Tшк1 = {Tshk1}");
                Tshk2 = Math.Round(9550 * Pshk2 / nshk2, 2);
                logBox.Items.Add($"Tшк2 = {Tshk2}");
            }
            Tz1 = Math.Round(9550 * Pz1 / nz1, 2);
            logBox.Items.Add($"Tz1 = {Tz1}");
            Tz2 = Math.Round(9550 * Pz2 / nz2, 2);
            logBox.Items.Add($"Tz2 = {Tz2}");
            Tout = Math.Round(9550 * Pout / nout, 2);
            logBox.Items.Add($"Tвих= {Tout}");
            deltaT = Math.Round(Math.Abs((Tout - T) / T) * 100, 2);
            logBox.Items.Add($"Delta T = {deltaT}");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(HasBelt.Checked)
            {
                if (valT.Text == null || valN.Text == null || valU.Text == null || valNC.Text == null)
                {
                    logBox.Items.Add("Error: One or more of the required input fields is empty");
                }
                else
                {
                    Calculate();
                }
            }
            else
            {
                if (valT.Text == null || valN.Text == null || valNC.Text == null)
                {
                    logBox.Items.Add("Error: One or more of the required input fields is empty");
                }
                else
                {
                    Calculate();
                }
            }
           
            

        }

        private void Calculate()
        {
            GearPowerCalc(int.Parse(valT.Text), int.Parse(valN.Text), HasBelt.Checked);
            (string Name, double Power, double Spin) engine = EngineSearcher(int.Parse(valNC.Text), powerReq);
            GearRatioCalculator(engine.Spin, double.Parse(valN.Text), HasBelt.Checked ? double.Parse(valU.Text) : 0d, HasBelt.Checked);
            DrivePowerCalculator(engine.Power, HasBelt.Checked);
            SpinCalculator(engine.Spin, HasBelt.Checked ? double.Parse(valU.Text) : 0d, double.Parse(valN.Text), HasBelt.Checked);
            TorqueCalculator(double.Parse(valT.Text), HasBelt.Checked);
        }
    }
}
