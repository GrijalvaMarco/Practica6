using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
		
	}

	protected void OnBFactClicked (object sender, System.EventArgs e)
	{
		//throw new System.NotImplementedException ();
	     double producto1;
	     double producto2;
		 double producto3;
		 double subtotal;
		 double iva;
		 double total;
		
		
		producto1 = double.Parse (this.eProd1.Text);
		producto2 = double.Parse (this.eProd2.Text);
		producto3 = double.Parse (this.eProd3.Text);
		
		subtotal = producto1+producto2+producto3;
		iva = subtotal*.16;
		total = subtotal + iva;
		
		eSubtot.Text = subtotal.ToString();
		eIva.Text = iva.ToString();
		eTot.Text = total.ToString();	
		
		
		
	}

	protected void OnBLimpClicked (object sender, System.EventArgs e)
	{
		//throw new System.NotImplementedException ();
		eProd1.Text = " ";
		eProd2.Text = " ";
		eProd3.Text = " ";
		eSubtot.Text = " ";
		eIva.Text = " ";
		eTot.Text = " ";
	}
}
