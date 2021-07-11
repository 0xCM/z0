//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct Flags<N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        T _State;

        [MethodImpl(Inline)]
        public Flags(T state)
        {
            _State = state;
        }

        Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(_State);
        }

        [MethodImpl(Inline)]
        public ref byte Isolate(W8 w, uint offset)
            => ref seek(Bytes,offset);
    }
}