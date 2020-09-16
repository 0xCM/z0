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

    [ApiClass(DataStructure)]
    public readonly struct EnumFieldValue<E>
        where E : unmanaged, Enum
    {
        public readonly FieldInfo Field;

        public readonly E EnumValue;

        [MethodImpl(Inline)]
        public EnumFieldValue(FieldInfo field, E value)
        {
            Field = field;
            EnumValue = value;
        }

        public string Format()
        {
            return EnumValue.ToString();
        }

        public override string ToString()
            => Format();
    }
}