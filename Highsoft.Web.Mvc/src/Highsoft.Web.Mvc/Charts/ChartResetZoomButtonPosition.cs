﻿// Type: Highsoft.Web.Mvc.Charts.ChartResetZoomButtonPosition


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ChartResetZoomButtonPosition : BaseObject
    {
        public string Align { get; set; }

        private string Align_DefaultValue { get; set; }

        public ChartResetZoomButtonPositionVerticalAlign VerticalAlign { get; set; }

        private ChartResetZoomButtonPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public ChartResetZoomButtonPosition()
        {
            this.Align = this.Align_DefaultValue = (string) null;
            this.VerticalAlign = this.VerticalAlign_DefaultValue = ChartResetZoomButtonPositionVerticalAlign.Top;
            double? nullable = new double?(-10.0);
            this.X_DefaultValue = nullable;
            this.X = nullable;
            nullable = new double?(10.0);
            this.Y_DefaultValue = nullable;
            this.Y = nullable;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) this.Align);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highcharts.FirstCharacterToLower(this.VerticalAlign.ToString()));
            double? x = this.X;
            double? nullable = this.X_DefaultValue;
            if ((x.GetValueOrDefault() == nullable.GetValueOrDefault() ? (x.HasValue != nullable.HasValue ? 1 : 0) : 1) !=
                0)
                hashtable.Add((object) "x", (object) this.X);
            nullable = this.Y;
            double? yDefaultValue = this.Y_DefaultValue;
            if ((nullable.GetValueOrDefault() == yDefaultValue.GetValueOrDefault()
                    ? (nullable.HasValue != yDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "y", (object) this.Y);
            return hashtable;
        }

        internal override string ToJSON()
        {
            if (this.ToHashtable().Count > 0)
                return JsonConvert.SerializeObject((object) this.ToHashtable());
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}