//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    public struct Bitfield256<E,T>
        where E : unmanaged
        where T : unmanaged
    {
        public Vector256<T> State;

        readonly Vector256<byte> Widths;

        [MethodImpl(Inline)]
        public Bitfield256(Vector256<byte> widths, Vector256<T> state)
        {
            State = state;
            Widths = default;
        }

        public T this[E index]
        {
            [MethodImpl(Inline)]
            get => Read(index);
        }

        [MethodImpl(Inline)]
        public byte SegWidth(E index)
            => cpu.vcell(Widths, bw8(index));

        [MethodImpl(Inline)]
        public T Mask(E index)
            => BitMasks.lo<T>(SegWidth(index));

        [MethodImpl(Inline)]
        public T Read(E index)
            => gmath.and(cpu.vcell(State, bw8(index)), Mask(index));

        [MethodImpl(Inline)]
        public void Write(T src, E index)
        {
            var mask = Mask(index);
            var conformed = gmath.and(src,mask);
            State = cpu.vcell(State, bw8(index), conformed);
        }
    }
}