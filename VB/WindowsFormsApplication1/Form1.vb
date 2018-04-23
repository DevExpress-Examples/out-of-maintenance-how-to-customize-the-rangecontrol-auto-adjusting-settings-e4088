Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Native

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub schedulerControl1_RangeControlAutoAdjusting(ByVal sender As Object, _
                                                                ByVal e As RangeControlAdjustEventArgs) _
                                                            Handles schedulerControl.RangeControlAutoAdjusting
            schedulerControl.OptionsRangeControl.AutoFormatScaleCaptions = True
            Dim activeViewType As SchedulerViewType = schedulerControl.ActiveViewType

            If activeViewType = SchedulerViewType.WorkWeek Then
                schedulerControl.OptionsRangeControl.AutoFormatScaleCaptions = False
                e.Scales(4).DisplayFormat = "dddd"
                e.Scales(4).Width = 70
            End If

            If activeViewType = SchedulerViewType.Month Then
                schedulerControl.OptionsRangeControl.AutoFormatScaleCaptions = False

                e.Scales.Clear()

                Dim monthScale As New TimeScaleMonth()
                monthScale.DisplayFormat = "MMMM yyyy"
                e.Scales.Add(monthScale)

                Dim twoWeekTimeScale As New TwoWeekTimeScale()
                twoWeekTimeScale.Width = 120
                e.Scales.Add(twoWeekTimeScale)

                e.RangeMinimum = New DateTime(e.RangeMinimum.Year, 1, 1)
                e.RangeMaximum = e.RangeMinimum.AddYears(1)
            End If
        End Sub
	End Class

	Public Class TwoWeekTimeScale
		Inherits TimeScaleFixedInterval
		Public Sub New()
			MyBase.New(TimeSpan.FromDays(14))
		End Sub
		Public Overrides Overloads Function Floor(ByVal [date] As DateTime) As DateTime
			Dim startOfWeeek As DateTime = DateTimeHelper.GetStartOfWeekUI([date], DateTimeHelper.FirstDayOfWeek)
			If DateTimeHelper.GetWeekOfYear([date]) Mod 2 = 0 Then
				Return startOfWeeek.AddDays(-7)
			End If

			Return startOfWeeek
		End Function
		Public Overrides Function FormatCaption(ByVal start As DateTime, ByVal [end] As DateTime) As String
			Dim dateString As String = "Week {0} - Week {1}"
            Return String.Format(dateString, DateTimeHelper.GetWeekOfYear(start), _
                                 DateTimeHelper.GetWeekOfYear([end].AddTicks(-1)))
		End Function
	End Class
End Namespace
