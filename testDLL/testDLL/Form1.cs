using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDLL
{
    public partial class Form1 : Form
    {
        [DllImport(@"\..\..\..\..\Dll2\Debug\Dll2.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "fibonacci_init")]
        public static extern void fibonacci_init(long a, long b);

        [DllImport(@"\..\..\..\..\Dll2\Debug\Dll2.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "fibonacci_next")]
        public static extern bool fibonacci_next();

        [DllImport(@"\..\..\..\..\Dll2\Debug\Dll2.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "fibonacci_current")]
        public static extern int fibonacci_current();

        [DllImport(@"\..\..\..\..\Dll2\Debug\Dll2.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "fibonacci_index")]
        public static extern short fibonacci_index();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fibonacci_init(int.Parse(txtA.Text), int.Parse(txtB.Text));

            fibonacci_next();
            MessageBox.Show(fibonacci_current().ToString());
            fibonacci_next();
            MessageBox.Show(fibonacci_current().ToString());
            fibonacci_next();
            MessageBox.Show(fibonacci_current().ToString());
            fibonacci_next();
            MessageBox.Show(fibonacci_current().ToString());
            fibonacci_next();

            MessageBox.Show(fibonacci_current().ToString());
        }
    }
}
