//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    /// <summary>
    /// Captures an <typeparamname name='E'/> parametric enum value along with the <see cref='FieldInfo'/> that defines the corresponding enum literal
    /// </summary>
    [Datatype]
    public readonly struct EnumFieldValue<E>
        where E : unmanaged, Enum
    {
        public FieldInfo Field {get;}

        public E EnumValue {get;}

        [MethodImpl(Inline)]
        public EnumFieldValue(FieldInfo field, E value)
        {
            Field = field;
            EnumValue = value;
        }

        public string Format()
            => EnumValue.ToString();

        public override string ToString()
            => Format();
    }
}