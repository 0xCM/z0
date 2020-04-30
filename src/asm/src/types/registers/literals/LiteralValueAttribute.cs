//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Attaches a literal value to the target
    /// </summary>
    public class LiteralValueAttribute : Attribute
    {        
        public LiteralValueAttribute(Enum value)
            => Value = value;

        public LiteralValueAttribute(byte value)
            => Value = value;

        public LiteralValueAttribute(sbyte value)
            => Value = value;

        public LiteralValueAttribute(short value)
            => Value = value;

        public LiteralValueAttribute(ushort value)
            => Value = value;

        public LiteralValueAttribute(int value)
            => Value = value;

        public LiteralValueAttribute(uint value)
            => Value = value;

        public LiteralValueAttribute(long value)
            => Value = value;

        public LiteralValueAttribute(ulong value)
            => Value = value;

        public LiteralValueAttribute(float value)
            => Value = value;

        public LiteralValueAttribute(double value)
            => Value = value;

        public LiteralValueAttribute(decimal value)
            => Value = value;

        public LiteralValueAttribute(char value)
            => Value = value;

        public LiteralValueAttribute(string value)
            => Value = value;

        public LiteralValueAttribute(bool value)
            => Value = value;

        public LiteralValue Value {get;}
    }
}