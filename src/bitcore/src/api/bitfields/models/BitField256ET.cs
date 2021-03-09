//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    public struct BitField256<E,T>
        where E : unmanaged
        where T : unmanaged
    {
        public Vector256<T> State;

        public readonly BitFieldSpec256<E> Spec;

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
            get => Read(index);
        }

        [MethodImpl(Inline)]
        public T Mask(E index)
            => BitMasks.lo<T>(Spec[index]);

        [MethodImpl(Inline)]
        public T Read(E index)
            => gmath.and(cpu.vcell(State, @as<E,byte>(index)), Mask(index));

        [MethodImpl(Inline)]
        public void Write(T src, E index)
        {
            var mask = Mask(index);
            var conformed = gmath.and(src,mask);
            var i  = ClrEnums.scalar<E,byte>(index);
            State = gcpu.vset(conformed, i, State);
        }
    }
}