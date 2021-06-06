//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public struct BitfieldSeg<T>
        where T : unmanaged
    {
        public ushort FirstIndex {get;}

        public ushort LastIndex {get;}

        public T State;

        [MethodImpl(Inline)]
        public BitfieldSeg(BitfieldSeg spec, T state)
        {
            State = state;
            FirstIndex = spec.Min;
            LastIndex = spec.Max;
        }

        [MethodImpl(Inline)]
        public BitfieldSeg(ushort i0, ushort i1, T state)
        {
            FirstIndex = i0;
            LastIndex = i1;
            State = state;
        }

        [MethodImpl(Inline)]
        public static implicit operator BitfieldSeg<T>(BitfieldSeg part)
            => new BitfieldSeg<T>(part, default);
    }
}