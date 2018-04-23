namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.rangeControl1 = new DevExpress.XtraEditors.RangeControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 151);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.Size = new System.Drawing.Size(817, 335);
            this.schedulerControl.Start = new System.DateTime(2012, 6, 28, 0, 0, 0, 0);
            this.schedulerControl.Storage = this.schedulerStorage1;
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler3);
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler4);
            this.schedulerControl.RangeControlAutoAdjusting += new DevExpress.XtraScheduler.RangeControlAdjustEventHandler(this.schedulerControl1_RangeControlAutoAdjusting);
            // 
            // rangeControl1
            // 
            this.rangeControl1.Client = this.schedulerControl;
            this.rangeControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rangeControl1.Location = new System.Drawing.Point(0, 0);
            this.rangeControl1.Name = "rangeControl1";
            this.rangeControl1.Size = new System.Drawing.Size(817, 151);
            this.rangeControl1.TabIndex = 1;
            this.rangeControl1.Text = "rangeControl1";
            this.rangeControl1.VisibleRangeMaximumScaleFactor = double.PositiveInfinity;
            this.rangeControl1.VisibleRangeScaleFactor = 4.8421052631578947D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 486);
            this.Controls.Add(this.schedulerControl);
            this.Controls.Add(this.rangeControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraEditors.RangeControl rangeControl1;
    }
}

