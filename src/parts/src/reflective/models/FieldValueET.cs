//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct FieldValue<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        public readonly FieldInfo Field;

        public readonly E EnumValue;

        public readonly T NumericValue;

        [MethodImpl(Inline)]
        public FieldValue(FieldInfo field,  E eValue, T tValue)
        {
            Field = field;
            EnumValue = eValue;
            NumericValue = tValue;
        }

        [MethodImpl(Inline)]
        public string FormatEnum()
            => EnumValue.ToString();

        [MethodImpl(Inline)]
        public string FormatNumeric()
            => NumericValue.ToString();

        [MethodImpl(Inline)]
        public string Format()
            =>$"{EnumValue} = {NumericValue}";

        public override string ToString()
            => Format();
    }
}