//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    public struct BitField256<E,T>
        where E : unmanaged
        where T : unmanaged
    {
        internal Vector256<T> State;

        internal readonly BitFieldSpec256<E> Spec;

        [MethodImpl(Inline)]
        public BitField256(BitFieldSpec256<E> spec, Vector256<T> state)
        {
            Spec = spec;
            State = state;
        }

        [MethodImpl(Inline)]
        public BitField256(BitFieldSpec256<E> spec)
        {
            Spec = spec;
            State = default;
        }

        public T this[E index]
        {
            [MethodImpl(Inline)]
            get => BitFields.read(this, index);
        }
    }
}