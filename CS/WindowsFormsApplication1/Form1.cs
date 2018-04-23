using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Native;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void schedulerControl1_RangeControlAutoAdjusting(object sender,
                                                                RangeControlAdjustEventArgs e) {
            schedulerControl.OptionsRangeControl.AutoFormatScaleCaptions = true;
            SchedulerViewType activeViewType = schedulerControl.ActiveViewType;

            if (activeViewType == SchedulerViewType.WorkWeek) {
                schedulerControl.OptionsRangeControl.AutoFormatScaleCaptions = false;
                e.Scales[4].DisplayFormat = "dddd";
                e.Scales[4].Width = 70;
            }

            if (activeViewType == SchedulerViewType.Month) {
                schedulerControl.OptionsRangeControl.AutoFormatScaleCaptions = false;
                
                e.Scales.Clear();
                
                TimeScaleMonth monthScale = new TimeScaleMonth();
                monthScale.DisplayFormat = "MMMM yyyy";
                e.Scales.Add(monthScale);

                TwoWeekTimeScale twoWeekTimeScale = new TwoWeekTimeScale();
                twoWeekTimeScale.Width = 120;
                e.Scales.Add(twoWeekTimeScale);

                e.RangeMinimum = new DateTime(e.RangeMinimum.Year, 1, 1);
                e.RangeMaximum = e.RangeMinimum.AddYears(1);
            }
        }
    }

    public class TwoWeekTimeScale : TimeScaleFixedInterval {
        public TwoWeekTimeScale()
            : base(TimeSpan.FromDays(14)) {
        }
        public override DateTime Floor(DateTime date) {
            DateTime startOfWeeek = DateTimeHelper.GetStartOfWeekUI(date,
                                                                    DateTimeHelper.FirstDayOfWeek);
            if (DateTimeHelper.GetWeekOfYear(date) % 2 == 0)
                return startOfWeeek.AddDays(-7);

            return startOfWeeek;
        }
        public override string FormatCaption(DateTime start, DateTime end) {
            string dateString = "Week {0} - Week {1}";
            return String.Format(dateString, DateTimeHelper.GetWeekOfYear(start),
                                 DateTimeHelper.GetWeekOfYear(end.AddTicks(-1)));
        }
    }
}
