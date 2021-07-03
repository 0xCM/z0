//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Encoder
    {
        readonly Index<byte> Buffer;

        [MethodImpl(Inline)]
        public Encoder(byte[] buffer)
        {
            Buffer = buffer;
        }

        public Outcome Encode<S,T>(in Inst<S> src, out InstSpec<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            dst = default;
            return true;
        }

        public Outcome Encode<S,T>(in ReadOnlySpan<Inst<S>> src, Span<InstSpec<T>> dst)
            where S : unmanaged
            where T : unmanaged
        {
            dst = default;
            return true;
        }

    }
}