using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen_nTest
{
	public partial class MainScreen : Form
	{
		public MainScreen()
		{
			Thread t = new Thread(new ThreadStart(StartForm));
			t.Start();
			Thread.Sleep(5000);
			InitializeComponent();
			t.Abort();
		}

		public void StartForm()
		{
			Application.Run(new SplashScreen());
		}

		private void MainScreen_Load(object sender, EventArgs e)
		{

		}
	}
}
