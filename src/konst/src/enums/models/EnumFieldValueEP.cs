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
    /// Captures an <typeparamname name='E'/> parametric enum value and the integral <typeparamref name='P'/> value along with the <see cref='FieldInfo'/>
    /// that defines the corresponding enum literal
    /// </summary>
    [Datatype]
    public readonly struct EnumFieldValue<E,P>
        where E : unmanaged, Enum
    {
        public FieldInfo Field {get;}

        public E EnumValue {get;}

        public P NumericValue {get;}

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
            =>$"{EnumValue}:{NumericValue}";

        public override string ToString()
            => Format();
    }
}