//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Attaches a binary literal value to a target or identifies a literal field
    /// </summary>
    public class IndicatorAttribute : LiteralAttachmentAttribute
    {
        public object Min {get;}

        public object Max {get;}

        public string Indicator {get;}

        public IndicatorAttribute(AsciChar c)
            : base(c)
        {
            Indicator = $"{c}";
            Min = c;
            Max = c;
        }

        public IndicatorAttribute(string indicator, byte min, byte max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }

        public IndicatorAttribute(string indicator, sbyte min, sbyte max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }

        public IndicatorAttribute(string indicator, ushort min, ushort max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }

        public IndicatorAttribute(string indicator, short min, short max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }

        public IndicatorAttribute(string indicator, uint min, uint max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }

        public IndicatorAttribute(string indicator, int min, int max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }

        public IndicatorAttribute(string indicator, long min, long max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }

        public IndicatorAttribute(string indicator, ulong min, ulong max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }

        public IndicatorAttribute(string indicator, float min, float max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }

        public IndicatorAttribute(string indicator, double min, double max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }

        public IndicatorAttribute(string indicator, decimal min, decimal max)
            : base(indicator,min,max)
        {
            Min = min;
            Max = max;
        }
    }
}