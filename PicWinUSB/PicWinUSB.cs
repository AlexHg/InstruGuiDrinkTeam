////////////////////////////////////////////////////////////////////////////
////                                                                    ////
////    This aplication shows how to use Microsoft WinUSB driver with   ////
////    a PIC 18F2550. Information has been extracted from MSDN:        ////
////                                                                    ////
////    - How to Use WinUSB to Communicate with a USB Device:           ////
////    http://www.microsoft.com/whdc/device/connect/WinUsb_HowTo.mspx  ////
////    - WinUSB:                                                       ////
////    http://msdn2.microsoft.com/en-us/library/aa476426.aspx          ////
////    - WinUSB User-Mode Client Support Routines:                     ////
////    http://msdn2.microsoft.com/en-us/library/aa476437.aspx          ////
////                                                                    ////
////    PicWinUSB is offered AS-IS and without warranty of any kind.    ////
////    You cannot copy, distribute or sell this code.                  ////
////                                                                    ////
////////////////////////////////////////////////////////////////////////////

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PicWinUSB
{
    public partial class PicWinUSB : Form
    {
        IntPtr iHandle;     // global device handle definition
        PicWinUSBAPI picwinusbapi = new PicWinUSBAPI();
        Bitmap Osciloscopio = new Bitmap(401, 256);
        Int16 x=0;

        //******************************************************************
        //Constructor de la clase (Asigna Guid USB)
        //******************************************************************
        public PicWinUSB()
        {
            Guid InterfaceGuid = new Guid("31415926-5358-9793-2384-626433832795"); // .Inf defined Guid                        
            InitializeComponent();
            iHandle = picwinusbapi.Init_PicWinUSB(InterfaceGuid);
        }
     
        //******************************************************************
        //Iniciar el timer ADC para solicitar conversiones del canal AN0
        //******************************************************************
        private void BtAdc_Click(object sender, EventArgs e)
        {
            timerADC.Start();
        }


        //******************************************************************
        //Cada tick del timer solicitar una conversión de AN0 del PIC
        //******************************************************************
        private void timerADC_Tick(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[3];           // Define send DataBuffer size
            byte[] rdBuffer = new byte[1];           // Define recieve DataBuffer size

            sdBuffer[0] = 0x0A;    //Modo ADC
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
            bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);

            if (rdBuffer[0] > 0) //Si se recibe un valor mayor a 0
            {
                AdcBar.Value = (int)(rdBuffer[0] * 100 / 254); //Dibujar en la barra
                if (x > 400)
                {
                    x = 0;
                    Osciloscopio.Dispose();
                    Osciloscopio = new Bitmap(401, 256);
                }           
                Osciloscopio.SetPixel(x++, 255 - rdBuffer[0]/2, Color.Red);              
            }
            PicBoxOsciloscopio.Image = Osciloscopio;
        }

        //******************************************************************
        //LEDS ON
        //******************************************************************
        private void BtLeds_on_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
            sdBuffer[0] = 0X09;                                     //Modo Led
            sdBuffer[1] = 0X03;                                     //Leds ON
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar

        }
        
        //******************************************************************
        //LEDS TOGGLE
        //******************************************************************
        private void BtLedToggle_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
            sdBuffer[0] = 0X09;                                     //Modo Led
            sdBuffer[1] = 0X04;                                     //Led Toggle
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
        }

        //******************************************************************
        //LED ROJO ON LED VERDE OFF
        //******************************************************************
        private void BtLed_rojo_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
            sdBuffer[0] = 0X09;                                     //Modo Led
            sdBuffer[1] = 0X02;                                     //Led ROJO ON Led Verde OFF
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
        }

        //******************************************************************
        //LED ROJO OFF LED VERDE ON
        //******************************************************************
        private void BtLed_verde_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
            sdBuffer[0] = 0X09;                                     //Modo Led
            sdBuffer[1] = 0X01;                                     //Led ROJO OFF Led Verde ON
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
        }

        //******************************************************************
        //LEDS OFF
        //******************************************************************
        private void BtLeds_off_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
            sdBuffer[0] = 0X09;                                     //Modo Led
            sdBuffer[1] = 0X00;                                     //Leds OFF
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
        }

        //******************************************************************
        //SUMA
        //******************************************************************
        private void BtPICsuma_Click(object sender, EventArgs e)
        {
            bool bres;
            byte[] sdBuffer = new byte[3];           // Define send DataBuffer size
            byte[] rdBuffer = new byte[1];           // Define recieve DataBuffer size

            sdBuffer[0] = 0x00;    //Modo PIR

            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
            bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);
            TextBoxResultadosuma.Text = rdBuffer[0].ToString();
            if (rdBuffer[0].ToString() == "0")
                pictureBox4.Hide();
            else
                pictureBox4.Show();
        }

        //******************************************************************
        //RESTA
        //******************************************************************
        private void BtPICresta_Click(object sender, EventArgs e)
        {
            bool bres;//temperatura
            byte[] sdBuffer = new byte[3];           // Define send DataBuffer size
            byte[] rdBuffer = new byte[1];           // Define recieve DataBuffer size

            sdBuffer[0] = 0x01;    //Modo RESTA
           
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
            bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);
            String aux = rdBuffer[0].ToString();
            double grados=int.Parse(aux)*1.96;
            TextBoxResultadoresta.Text = grados+"°";
        }

        //******************************************************************
        //MULTIPLICA
        //******************************************************************
        private void BtPICmultiplica_Click(object sender, EventArgs e)
        {
            bool bres;//Gas
            byte[] sdBuffer = new byte[3];           // Define send DataBuffer size
            byte[] rdBuffer = new byte[1];           // Define recieve DataBuffer size

            sdBuffer[0] = 0x02;    //Modo MULTIPLICACION
            
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
            bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);
            String aux = rdBuffer[0].ToString();
            double particulas =Math.Pow(1.1,int.Parse(aux));
            TextBoxResultadomultiplica.Text =particulas+"ppm" ;
        }

        //******************************************************************
        //DIVIDE
        //******************************************************************
        private void BtPICdivide_Click(object sender, EventArgs e)
        {
            bool bres;//Luz
            byte[] sdBuffer = new byte[3];           // Define send DataBuffer size
            byte[] rdBuffer = new byte[1];           // Define recieve DataBuffer size

            sdBuffer[0] = 0x03;    //Modo DIVISION
            
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
            bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);
            String aux = rdBuffer[0].ToString();
            double lux = Math.Pow(int.Parse(aux) ,2)/7;
            TextBoxResultadodivide.Text=lux+" lx";
            
        }

        private void AdcBar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxResultadosuma_TextChanged(object sender, EventArgs e)
        {

        }

        private void PicWinUSB_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxDivisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxResultadodivide_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
