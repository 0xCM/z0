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
        public byte FirstIndex {get;}

        public byte LastIndex {get;}

        public T State;

        [MethodImpl(Inline)]
        public BitfieldSeg(BitfieldSegSpec spec, T state)
        {
            State = state;
            FirstIndex = spec.FirstIndex;
            LastIndex = spec.LastIndex;
        }

        [MethodImpl(Inline)]
        public BitfieldSeg(byte i0, byte i1, T state)
        {
            FirstIndex = i0;
            LastIndex = i1;
            State = state;
        }

        [MethodImpl(Inline)]
        public static implicit operator BitfieldSeg<T>(BitfieldSegSpec part)
            => new BitfieldSeg<T>(part, default);
    }
}