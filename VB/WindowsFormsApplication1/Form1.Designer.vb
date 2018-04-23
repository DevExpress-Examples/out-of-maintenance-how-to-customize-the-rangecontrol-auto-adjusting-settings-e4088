Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler4 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.rangeControl1 = New DevExpress.XtraEditors.RangeControl()
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl
			' 
			Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl.Location = New System.Drawing.Point(0, 151)
			Me.schedulerControl.Name = "schedulerControl"
			Me.schedulerControl.Size = New System.Drawing.Size(817, 335)
			Me.schedulerControl.Start = New System.DateTime(2012, 6, 28, 0, 0, 0, 0)
			Me.schedulerControl.Storage = Me.schedulerStorage1
			Me.schedulerControl.TabIndex = 0
			Me.schedulerControl.Text = "schedulerControl1"
			Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler3)
			Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler4)
'			Me.schedulerControl.RangeControlAutoAdjusting += New DevExpress.XtraScheduler.RangeControlAdjustEventHandler(Me.schedulerControl1_RangeControlAutoAdjusting);
			' 
			' rangeControl1
			' 
			Me.rangeControl1.Client = Me.schedulerControl
			Me.rangeControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.rangeControl1.Location = New System.Drawing.Point(0, 0)
			Me.rangeControl1.Name = "rangeControl1"
			Me.rangeControl1.Size = New System.Drawing.Size(817, 151)
			Me.rangeControl1.TabIndex = 1
			Me.rangeControl1.Text = "rangeControl1"
			Me.rangeControl1.VisibleRangeMaximumScaleFactor = Double.PositiveInfinity
			Me.rangeControl1.VisibleRangeScaleFactor = 4.8421052631578947R
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(817, 486)
			Me.Controls.Add(Me.schedulerControl)
			Me.Controls.Add(Me.rangeControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private rangeControl1 As DevExpress.XtraEditors.RangeControl
	End Class
End Namespace

