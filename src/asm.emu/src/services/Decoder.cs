//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Decoder
    {
        readonly Index<byte> Buffer;

        [MethodImpl(Inline)]
        public Decoder(byte[] buffer)
        {
            Buffer = buffer;
        }

        public Outcome Decode<S,T>(InstSpec<S> src, out Inst<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            dst = default;
            return true;
        }
    }
}