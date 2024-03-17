using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pneumatic_Robotic_Manipulator_Module
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            initializeVars();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_Unknown_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_Unknown.Checked)
            {
                unknownVar_dis = true;
                disMotionByte = 0x01;
            }
            else
            {
                unknownVar_dis = false;
                disMotionByte = 0x00;
            }
            serialPort1.Write(new byte[] { disMotionByte }, 0, 1);
        }
        private void checkBox1_Gripper_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_Gripper.Checked)
            {
                gripperVar_dis = true;
                disMotionByte = 0x11;
            }
            else
            {
                gripperVar_dis = false;
                disMotionByte = 0x10;
            }
            serialPort1.Write(new byte[] { disMotionByte }, 0, 1);
        }

        private void checkBox2_EE_Rotation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_EE_Rotation.Checked)
            {
                EERotationVar_dis = true;
                disMotionByte = 0x21;
            }
            else
            {
                EERotationVar_dis = false;
                disMotionByte = 0x20;
            }
            serialPort1.Write(new byte[] { disMotionByte }, 0, 1);
        }

        private void checkBox3_Vertical_XY_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_Vertical_XY.Checked)
            {
                verticalXYVar_dis = true;
                disMotionByte = 0x31;
            }
            else
            {
                verticalXYVar_dis = false;
                disMotionByte = 0x30;
            }
            serialPort1.Write(new byte[] { disMotionByte }, 0, 1);
        }

        private void checkBox4_Horizontal_XY_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4_Horizontal_XY.Checked)
            {
                horizontalXYVar_dis = true;
                disMotionByte = 0x41;
            }
            else
            {
                horizontalXYVar_dis = false;
                disMotionByte = 0x40;
            }
            serialPort1.Write(new byte[] { disMotionByte }, 0, 1);
        }

        private void checkBox5_Horizontal_XZ_Planar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5_Horizontal_XZ_Planar.Checked)
            {
                horizontalXZVar_dis = true;
                disMotionByte = 0x51;
            }
            else
            {
                horizontalXZVar_dis = false;
                disMotionByte = 0x50;
            }
            serialPort1.Write(new byte[] { disMotionByte }, 0, 1);
        }

        private void button1_GotoHome1_Click(object sender, EventArgs e)
        {
            disMotionByte = 0x60;
            serialPort1.Write(new byte[] { disMotionByte }, 0, 1);
        }

        private void button2_GotoHome2_Click(object sender, EventArgs e)
        {
            disMotionByte = 0x70;
            serialPort1.Write(new byte[] { disMotionByte }, 0, 1);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Update the GUI
            if (unknownVar_dis)
                label3_Unknown.Text = "ON";
            else
                label3_Unknown.Text = "OFF";

            if (gripperVar_dis)
                label4_Gripper.Text = "ON";
            else
                label4_Gripper.Text = "OFF";

            if (EERotationVar_dis)
                label5_EE_Rotation.Text = "ON";
            else
                label5_EE_Rotation.Text = "OFF";

            if (verticalXYVar_dis)
                label6_Vertical_XY.Text = "ON";
            else
                label6_Vertical_XY.Text = "OFF";

            if (horizontalXYVar_dis)
                label7_Horizontal_XY.Text = "ON";
            else
                label7_Horizontal_XY.Text = "OFF";

            if (horizontalXZVar_dis)
                label8_Horizontal_XZ.Text = "ON";
            else
                label8_Horizontal_XZ.Text = "OFF";

            if (startStopVar_cont)
                button1_startStop.Text = "Stop";
            else
                button1_startStop.Text = "Start";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_startStop_Click(object sender, EventArgs e)
        {
            if (startStopVar_cont)  //Stop Thread
            {
                startStopVar_cont = false;
                isContThreadRunning = false;
                contThread.Join();
            }
            else //Run Thread
            {
                createThread();
                startStopVar_cont = true;
                isContThreadRunning = true;
                contThread.Start();
            }
            button_addPoint.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string information;
            information = "This software is developed as a part of ";
            information += "making AUTOMATION WORK BENCH functional.";
            information += "\r\n\n\n";
            information += "HOW TO OPERATE THE SOFTWARE";
            information += "\r\n";
            information += "--------------------------------------------";
            information += "\r\n";
            information += "First you need to connect with the correct COM port. ";
            information += "If your device doesn't have a COM port, use USB to RS232 TTL converter.";
            information += "\r\n";
            information += "\r\n";
            information += "Software has two modes of operation.";
            information += "\r\n";
            information += "i. Individual Control";
            information += "\r\n";
            information += "   You can control individual links to see the individual motions.";
            information += "\r\n";
            information += "ii. Develop Trajectory";
            information += "\r\n";
            information += "   You may develop a desired trajectory with the desired delays.";
            MessageBox.Show(information, "About Software");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadTrajectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_Unknown_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1_Unknown.Checked)
                unknownVar_cont = true;
            else
                unknownVar_cont = false;
        }

        private void radioButton2_gripper_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2_gripper.Checked)
                gripperVar_cont = true;
            else
                gripperVar_cont = false;
        }

        private void radioButton1_EE_Rotation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1_EE_Rotation.Checked)
                EERotationVar_cont = true;
            else
                gripperVar_cont = false;
        }

        private void radioButton4_vertXY_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4_vertXY.Checked)
                verticalXYVar_cont = true;
            else
                verticalXYVar_cont = false;
        }

        private void radioButton5_horXY_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5_horXY.Checked)
                horizontalXYVar_cont = true;
            else
                horizontalXYVar_cont = false;
        }

        private void radioButton6_horXZ_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6_horXZ.Checked)
                horizontalXZVar_cont = true;
            else
                horizontalXZVar_cont = false;
        }

        private void button_addPoint_Click(object sender, EventArgs e)
        {
            string tab = " ";
            string text = "";
            string text2 = "";
            string actionString = "";
            bool isSelected = false;
            byte currLink = 0xFF;
            byte currAction = 0xFF;
            
            if (unknownVar_cont)
            {
                text = "Unknown";
                currLink = 0x00;
                isSelected = true;
            }

            if (gripperVar_cont)
            {
                text = "Gripper";
                currLink = 0x10;
                isSelected = true;
            }
            if (EERotationVar_cont)
            {
                text = "EE Rotation";
                currLink = 0x20;
                isSelected = true;
            }

            if (verticalXYVar_cont)
            {
                text = "Vertical XY";
                currLink = 0x30;
                isSelected = true;
            }

            if (horizontalXYVar_cont)
            {
                text = "Horizontal XY";
                currLink = 0x40;
                isSelected = true;
            }

            if (horizontalXZVar_cont)
            {
                text = "Horizontal XZ";
                currLink = 0x50;
                isSelected = true;
            }

            if (!isSelected)
            {
                MessageBox.Show("Please select the link first.", "Caution");
                return;
            }

            logCnt++;
            if (logCnt > MAX_MOVEMENTS)
            {
                MessageBox.Show("Can't add more than 10 points.", "Error");
                return;
            }

            if (action)
            {
                actionString = "ON";
                currAction = 0x01;
            }
            else
            {
                actionString = "OFF";
                currAction = 0x00;
            }

            preDelayArray[arrayIndex] = preDelayVar;
            currLinkArray[arrayIndex] = currLink;
            currActionArray[arrayIndex] = currAction;
            postDelayArray[arrayIndex] = postDelayVar;
            arrayIndex++;

            text2 = tab + Convert.ToString(logCnt) + "  ";
            text2 = text2 + Convert.ToString(preDelayVar) + "ms  ";
            text2 = text2 + text + "  " + actionString + "  ";
            text2 = text2 + Convert.ToString(postDelayVar) + "ms" + "\r\n";
            logText = logText + text2;
            label9_trajectoryLog.Text = logText;
        }

        private void comboBox1_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1_status.SelectedIndex == 0)
                action = true;
            else if (comboBox1_status.SelectedIndex == 1)
                action = false;
        }

        private void preDelay_ValueChanged(object sender, EventArgs e)
        {
            preDelayVar = (int)preDelay.Value;
            if (preDelayVar <= 10)
                preDelayVar = 10;
            preDelayVar = preDelayVar * 100;
        }

        private void postDelay_ValueChanged(object sender, EventArgs e)
        {
            postDelayVar = (int)postDelay.Value;
            if (postDelayVar <= 10)
                postDelayVar = 10;
            postDelayVar = postDelayVar * 100;
        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String information = "This is beta version. You may suggest any upgradation at a.tahir@uet.edu.pk" + "\r\n\n";
            information += "This 'free' software is developed by" + "\r\n";
            information += "  " + "Engr. Abdullah Tahir" + "\r\n";
            information += "  " + "Lecturer" + "\r\n";
            information += "  " + "Department of Mechatronics and Control Engineering" + "\r\n";
            information += "  " + "Faisalabad Campus of UET Lahore" + "\r\n";
            information += "  " + "\r\n";
            information += "Electric circuitry is fabricated by" + "\r\n";
            information += "  " + "Talha Ilyas                2015-MC-112" + "\r\n";
            information += "  " + "Mashood Rehman  2015-MC-102";
            information += "\r\n";
            information += "\r\n";
            information += "                                                                     December 2017";
            MessageBox.Show(information, "Developers");
        }

        private void comboBox_comPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedComIndex = comboBox_comPort.SelectedIndex;
            if (selectedComIndex == 0)
                portName = "COM1";
            else if (selectedComIndex == 1)
                portName = "COM2";
            else if (selectedComIndex == 2)
                portName = "COM3";
            else if (selectedComIndex == 3)
                portName = "COM4";
            else if (selectedComIndex == 4)
                portName = "COM5";
            else if (selectedComIndex == 5)
                portName = "COM6";
            else if (selectedComIndex == 6)
                portName = "COM7";
            else
                portName = "COM1";
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = portName;
            serialPort1.BaudRate = 8190;// baudRate;
            serialPort1.Open();
            button_connect.Enabled = false;
        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}