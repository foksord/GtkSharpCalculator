using System;

namespace Calc.View {

	public partial class MainWindow: Gtk.Window {

		public MainWindow() : base(Gtk.WindowType.Toplevel) {
			this.Build();
		}

		private void Build() {
			var vBox = new Gtk.VBox( false, 5 );

			var lbl = new Gtk.Label("<b>Calculator</b>");
			lbl.UseMarkup = true;

			this.edOp1 = new Gtk.Entry("0");
			this.edOp1.Alignment = 1;
			this.edOp2 = new Gtk.Entry("0");
			this.edOp2.Alignment = 1;
			this.edRes = new Gtk.Entry("0");
			this.edRes.Alignment = 1;
			this.edRes.IsEditable = false;
			this.cbOp = new Gtk.ComboBox(new string[]{ "+", "-", "*", "/" });
			this.cbOp.Active = 0;

			this.edOp1.Changed += (o, evt) => this.OnOperandsChanged();
			this.edOp2.Changed += (o, evt) => this.OnOperandsChanged();
			this.cbOp.Changed += (o, evt) => this.OnOperandsChanged();
			this.DeleteEvent += (o, args) => this.OnClose();

			vBox.PackStart(lbl, true, false, 5);
			vBox.PackStart(this.edOp1, true, false, 5);
			vBox.PackStart(this.edOp2, true, false, 5);
			vBox.PackStart(this.cbOp, true, false, 5);
			vBox.PackStart(this.edRes, true, false, 5);

			this.Add(vBox);
		}

		private Gtk.Entry edOp1;
		private Gtk.Entry edOp2;
		private Gtk.Entry edRes;
		private Gtk.ComboBox cbOp;
	}
}

