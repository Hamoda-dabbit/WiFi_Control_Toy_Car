using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SlimDX.DirectInput;
using System.Runtime.InteropServices;

namespace jostick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    //        GetSticks();
     //       Sticks = GetSticks();
            timer1.Enabled = true;
        }
 
        string ip;
  /*      DirectInput input = new DirectInput();
        SlimDX.DirectInput.Joystick stick; 
       Joystick[] Sticks;
       bool mouseClicked = false;
       int yValue = 0;
       int xValue = 0;
       int zValue = 0;     
     
          
      [DllImport("user32.dll", CharSet = CharSet.Auto)]
       public static extern void mouse_event(uint flage,uint _x,uint _y,uint btn,uint exInfo);
    
        private const int MouseEvent_LeftDown=0x02;
        private const int MouseEvent_LeftUp=0x04;

        
        public Joystick[] GetSticks()
       {
           List<SlimDX.DirectInput.Joystick> sticks = new List<SlimDX.DirectInput.Joystick>();
           foreach (DeviceInstance device in input.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
           {
               try
               {
                   stick = new SlimDX.DirectInput.Joystick(input, device.InstanceGuid);
                   stick.Acquire();
                   foreach (DeviceObjectInstance deviceObject in stick.GetObjects())
                   {
                       if ((deviceObject.ObjectType&ObjectDeviceType.Axis)!=0)
                       { 
                           stick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-100, 100);
                       }
                   }
                   sticks.Add(stick);
               }
               catch (DirectInputException)
               {
                 
               }
           }
           return sticks.ToArray();          
       }
       void sticklandle(Joystick stick,int id)
       {
           JoystickState state = new JoystickState();
           state = stick.GetCurrentState();

           yValue = state.Y;
           xValue = state.X;
           zValue = state.Z;
           MouseMove(xValue, yValue);

           bool[] buttons = state.GetButtons();
        //   txtr.Text = buttons.Length.ToString();
           if (id==0)
           {
               if (buttons[0])
               {if (mouseClicked==false)
                   {//mouse_event(MouseEvent_LeftDown,0,0,0,0);textBox1.Text += ".";
                   mouseClicked = true;
                   webBrowser1.Navigate(ip + "forward"); txtl.Text = "forward"; txtdown.Text += ".";
                   }
               }
               else if (!buttons[0])
               {if (mouseClicked==true)
                   {//mouse_event(MouseEvent_LeftUp,0,0,0,0);
                   mouseClicked = false;
                  
                   }   
               }

               if (buttons[2])
               {
                   if (mouseClicked == false)
                   { webBrowser1.Navigate(ip + "backward"); txtl.Text = "backward"; textBox1.Text += "."; mouseClicked = true; }
               }
               else if (!buttons[2])
               {
                   if (mouseClicked == true)
                   {  mouseClicked = false; }
               }             

               if (buttons[7])
               {
                   if (mouseClicked == false)
                   { textBox1.Text += "."; mouseClicked = true; webBrowser1.Navigate(ip + "stop"); txtl.Text = "stop"; }
               }
               else if (!buttons[7])
               {
                   if (mouseClicked == true)
                   { mouse_event(MouseEvent_LeftUp, 0, 0, 0, 0); mouseClicked = false; }
               }
           }
       }

       public void MouseMove(int posx,int posy)
       {
         //  Cursor.Position = new Point(Cursor.Position.X + posx/3, Cursor.Position.Y + posy/3);
          // Cursor.Clip = new Rectangle(this.Location, this.Size);
           txtr.Text = posx.ToString();
           txtuup.Text = posy.ToString();
           if (posx==100)
           { webBrowser1.Navigate(ip + "r"); txtl.Text = "right"; txtdown.Text += "."; }
           if (posx == -100)
           { webBrowser1.Navigate(ip + "l"); txtl.Text = "left"; txtdown.Text += "."; }
           if (posy == 100)
           { webBrowser1.Navigate(ip + "b"); txtl.Text = "down"; txtdown.Text += "."; }
           if (posy == -100)
           { webBrowser1.Navigate(ip + "f"); txtl.Text = "up"; txtdown.Text += "."; }
           
       }
 */
       private void timer1_Tick(object sender, EventArgs e)
       {
         //  for (int i = 0; i < Sticks.Length; i++)
           {
         ///      sticklandle(Sticks[i], i);
           }
       }
       

       private void Form1_Load(object sender, EventArgs e)
       {
         //  Joystick[] jouystick = GetSticks();
       }   

       private void btnFarward_Click(object sender, EventArgs e)
       {
           webBrowser1.Navigate(ip + "f");
           textBox2.Text = ip + "f";
       }

       private void btnDown_Click(object sender, EventArgs e)
       {
           webBrowser1.Navigate(ip + "b"); textBox2.Text = ip + "b";
       }

       private void btnRight_Click(object sender, EventArgs e)
       {
           webBrowser1.Navigate(ip + "r"); textBox2.Text = ip + "r";
       }

       private void btnLeft_Click(object sender, EventArgs e)
       {
           webBrowser1.Navigate(ip + "l"); textBox2.Text = ip + "l";
       }

       private void button2_Click(object sender, EventArgs e)
       {
           ip = "http://" + txtip.Text + "/"; groupBox1.Enabled = true;
       }

       private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
       {

       }

       
    }  
}
