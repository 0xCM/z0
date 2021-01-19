//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Attaches a literal value to a target or identifies a literal field
    /// </summary>
    public class StringLiteralAttribute : Attribute
    {
        public string Text {get;}

        public object Value {get;}

        public int Length {get;}

        public StringLiteralAttribute(string value)
        {
            Text = value ?? "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute()
        {
            Text = "";
            Value = "";
            Length = Text.Length;
        }

        public StringLiteralAttribute(byte value)
        {
            Text = value.ToString();
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(sbyte value)
        {
            Text = value.ToString();
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(short value)
        {
            Text = value.ToString();
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(ushort value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(int value)
        {
            Text = value.ToString();
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(uint value)
        {
            Text = value.ToString();
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(long value)
        {
            Text = value.ToString();
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(ulong value)
        {
            Text = value.ToString();
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(float value)
        {
            Text = value.ToString();
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(double value)
        {
            Text = value.ToString();
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(decimal value)
        {
            Text = value.ToString();
            Value = value;
            Length = Text.Length;
        }
    }
}