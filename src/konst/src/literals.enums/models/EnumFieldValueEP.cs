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

    [ApiProviderAttribute(DataStructure)]
    public readonly struct EnumFieldValue<E,P>
        where E : unmanaged, Enum
    {
        public readonly FieldInfo Field;

        public readonly E EnumValue;

        public readonly P NumericValue;

        [MethodImpl(Inline)]
        public EnumFieldValue(FieldInfo field,  E eValue, P tValue)
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