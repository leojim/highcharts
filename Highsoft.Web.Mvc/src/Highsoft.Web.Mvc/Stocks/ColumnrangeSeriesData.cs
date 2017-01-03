﻿// Type: Highsoft.Web.Mvc.Stocks.ColumnrangeSeriesData


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class ColumnrangeSeriesData : BaseObject
    {
        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public object DataLabels { get; set; }

        private object DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public ColumnrangeSeriesDataEvents Events { get; set; }

        private ColumnrangeSeriesDataEvents Events_DefaultValue { get; set; }

        public double? High { get; set; }

        private double? High_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public double? Labelrank { get; set; }

        private double? Labelrank_DefaultValue { get; set; }

        public double? Low { get; set; }

        private double? Low_DefaultValue { get; set; }

        public string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public ColumnrangeSeriesData()
        {
            this.Color = this.Color_DefaultValue = "undefined";
            this.DataLabels = this.DataLabels_DefaultValue = (object) null;
            this.Description = this.Description_DefaultValue = "undefined";
            this.Events = this.Events_DefaultValue = new ColumnrangeSeriesDataEvents();
            double? nullable1 = new double?();
            this.High_DefaultValue = nullable1;
            this.High = nullable1;
            this.Id = this.Id_DefaultValue = "null";
            double? nullable2 = new double?();
            this.Labelrank_DefaultValue = nullable2;
            this.Labelrank = nullable2;
            double? nullable3 = new double?();
            this.Low_DefaultValue = nullable3;
            this.Low = nullable3;
            this.Name = this.Name_DefaultValue = (string) null;
            bool? nullable4 = new bool?(false);
            this.Selected_DefaultValue = nullable4;
            this.Selected = nullable4;
            nullable3 = new double?(double.MinValue);
            this.X_DefaultValue = nullable3;
            this.X = nullable3;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            if (this.DataLabels != this.DataLabels_DefaultValue)
                hashtable.Add((object) "dataLabels", this.DataLabels);
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            double? high = this.High;
            double? nullable1 = this.High_DefaultValue;
            if ((high.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (high.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "high", (object) this.High);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            nullable1 = this.Labelrank;
            double? nullable2 = this.Labelrank_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "labelrank", (object) this.Labelrank);
            nullable2 = this.Low;
            nullable1 = this.Low_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "low", (object) this.Low);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            bool? selected = this.Selected;
            bool? selectedDefaultValue = this.Selected_DefaultValue;
            if ((selected.GetValueOrDefault() == selectedDefaultValue.GetValueOrDefault()
                    ? (selected.HasValue != selectedDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "selected", (object) this.Selected);
            nullable1 = this.X;
            nullable2 = this.X_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "x", (object) this.X);
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