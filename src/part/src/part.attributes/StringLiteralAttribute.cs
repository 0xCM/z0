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
    public class StringLiteralAttribute : LiteralAttachmentAttribute
    {
        public string Text {get;}

        public object Value {get;}

        public int Length {get;}

        public StringLiteralAttribute(string value)
            : base(value ?? "")
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
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(sbyte value)
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(short value)
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(ushort value)
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(int value)
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(uint value)
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(long value)
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(ulong value)
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(float value)
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(double value)
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }

        public StringLiteralAttribute(decimal value)
            : base(value)
        {
            Text = "";
            Value = value;
            Length = Text.Length;
        }


        public StringLiteralAttribute(string value, uint length)
        {
            Text = value ?? "";
            Value = Text;
            Length = (int)length;
        }
    }
}