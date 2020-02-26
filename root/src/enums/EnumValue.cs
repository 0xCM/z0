//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public readonly struct EnumValue<E,V>
        where E : unmanaged, Enum
        where V : unmanaged
    {
        public readonly E Enum;

        public readonly V Value;

        [MethodImpl(Inline)]
        public static implicit operator EnumValue<E,V>((E e, V v) src)
            => new EnumValue<E,V>(src.e,src.v);

        [MethodImpl(Inline)]
        internal EnumValue(E e, V v)
        {
            this.Enum = e;
            this.Value = v;    
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out E e, out V v)
        {
            e = Enum;
            v = Value;
        }
    }
}