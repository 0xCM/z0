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

        public StringLiteralAttribute(string value)
            : base(value ?? "")
        {
            Text = value ?? "";
            Value = value;
        }

        public StringLiteralAttribute()
        {
            Text = "";
            Value = "";
        }

        public StringLiteralAttribute(byte value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

        public StringLiteralAttribute(sbyte value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

        public StringLiteralAttribute(short value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

        public StringLiteralAttribute(ushort value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

        public StringLiteralAttribute(int value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

        public StringLiteralAttribute(uint value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

        public StringLiteralAttribute(long value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

        public StringLiteralAttribute(ulong value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

        public StringLiteralAttribute(float value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

        public StringLiteralAttribute(double value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

        public StringLiteralAttribute(decimal value)
            : base(value)
        {
            Text = "";
            Value = value;
        }

    }
}