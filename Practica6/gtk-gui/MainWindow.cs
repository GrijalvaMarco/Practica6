
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Label lProd1;
	private global::Gtk.Label lProd2;
	private global::Gtk.Label lProd3;
	private global::Gtk.Entry eProd1;
	private global::Gtk.Entry eProd2;
	private global::Gtk.Entry eProd3;
	private global::Gtk.Entry eSubtot;
	private global::Gtk.Entry eIva;
	private global::Gtk.Entry eTot;
	private global::Gtk.Label lIva;
	private global::Gtk.Label lSubtot;
	private global::Gtk.Label lTot;
	private global::Gtk.Button bFact;
	private global::Gtk.Button bLimp;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lProd1 = new global::Gtk.Label ();
		this.lProd1.Name = "lProd1";
		this.lProd1.LabelProp = global::Mono.Unix.Catalog.GetString ("Producto1");
		this.fixed1.Add (this.lProd1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lProd1]));
		w1.X = 59;
		w1.Y = 24;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lProd2 = new global::Gtk.Label ();
		this.lProd2.Name = "lProd2";
		this.lProd2.LabelProp = global::Mono.Unix.Catalog.GetString ("Producto2");
		this.fixed1.Add (this.lProd2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lProd2]));
		w2.X = 57;
		w2.Y = 67;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lProd3 = new global::Gtk.Label ();
		this.lProd3.Name = "lProd3";
		this.lProd3.LabelProp = global::Mono.Unix.Catalog.GetString ("Producto3");
		this.fixed1.Add (this.lProd3);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lProd3]));
		w3.X = 55;
		w3.Y = 105;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.eProd1 = new global::Gtk.Entry ();
		this.eProd1.CanFocus = true;
		this.eProd1.Name = "eProd1";
		this.eProd1.IsEditable = true;
		this.eProd1.InvisibleChar = '•';
		this.fixed1.Add (this.eProd1);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.eProd1]));
		w4.X = 174;
		w4.Y = 21;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.eProd2 = new global::Gtk.Entry ();
		this.eProd2.CanFocus = true;
		this.eProd2.Name = "eProd2";
		this.eProd2.IsEditable = true;
		this.eProd2.InvisibleChar = '•';
		this.fixed1.Add (this.eProd2);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.eProd2]));
		w5.X = 175;
		w5.Y = 58;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.eProd3 = new global::Gtk.Entry ();
		this.eProd3.CanFocus = true;
		this.eProd3.Name = "eProd3";
		this.eProd3.IsEditable = true;
		this.eProd3.InvisibleChar = '•';
		this.fixed1.Add (this.eProd3);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.eProd3]));
		w6.X = 175;
		w6.Y = 101;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.eSubtot = new global::Gtk.Entry ();
		this.eSubtot.CanFocus = true;
		this.eSubtot.Name = "eSubtot";
		this.eSubtot.IsEditable = true;
		this.eSubtot.InvisibleChar = '•';
		this.fixed1.Add (this.eSubtot);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.eSubtot]));
		w7.X = 176;
		w7.Y = 144;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.eIva = new global::Gtk.Entry ();
		this.eIva.CanFocus = true;
		this.eIva.Name = "eIva";
		this.eIva.IsEditable = true;
		this.eIva.InvisibleChar = '•';
		this.fixed1.Add (this.eIva);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.eIva]));
		w8.X = 178;
		w8.Y = 181;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.eTot = new global::Gtk.Entry ();
		this.eTot.CanFocus = true;
		this.eTot.Name = "eTot";
		this.eTot.IsEditable = true;
		this.eTot.InvisibleChar = '•';
		this.fixed1.Add (this.eTot);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.eTot]));
		w9.X = 175;
		w9.Y = 223;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lIva = new global::Gtk.Label ();
		this.lIva.Name = "lIva";
		this.lIva.LabelProp = global::Mono.Unix.Catalog.GetString ("IVA");
		this.fixed1.Add (this.lIva);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lIva]));
		w10.X = 98;
		w10.Y = 182;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lSubtot = new global::Gtk.Label ();
		this.lSubtot.Name = "lSubtot";
		this.lSubtot.LabelProp = global::Mono.Unix.Catalog.GetString ("Subtotal");
		this.fixed1.Add (this.lSubtot);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lSubtot]));
		w11.X = 65;
		w11.Y = 141;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lTot = new global::Gtk.Label ();
		this.lTot.Name = "lTot";
		this.lTot.LabelProp = global::Mono.Unix.Catalog.GetString ("Total");
		this.fixed1.Add (this.lTot);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lTot]));
		w12.X = 89;
		w12.Y = 226;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.bFact = new global::Gtk.Button ();
		this.bFact.CanFocus = true;
		this.bFact.Name = "bFact";
		this.bFact.UseUnderline = true;
		this.bFact.Label = global::Mono.Unix.Catalog.GetString ("Facturar");
		this.fixed1.Add (this.bFact);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.bFact]));
		w13.X = 109;
		w13.Y = 301;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.bLimp = new global::Gtk.Button ();
		this.bLimp.CanFocus = true;
		this.bLimp.Name = "bLimp";
		this.bLimp.UseUnderline = true;
		this.bLimp.Label = global::Mono.Unix.Catalog.GetString ("Limpiar");
		this.fixed1.Add (this.bLimp);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.bLimp]));
		w14.X = 271;
		w14.Y = 300;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 420;
		this.DefaultHeight = 472;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.bFact.Clicked += new global::System.EventHandler (this.OnBFactClicked);
		this.bLimp.Clicked += new global::System.EventHandler (this.OnBLimpClicked);
	}
}
