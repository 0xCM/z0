//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct BitWriter
    {
        [MethodImpl(Inline)]
        static byte disable(byte pos, byte src)
            => (byte)(src & ~((One8u << pos)));

        [MethodImpl(Inline)]
        static ushort disable(byte pos, ushort src)
            => (ushort)(src & ~((One16u << pos)));

        [MethodImpl(Inline)]
        static uint disable(byte pos, uint src)
            => src & ~((One32u << pos));

        [MethodImpl(Inline)]
        static ulong disable(int pos, ulong src)
            => src & ~((One64u << pos));

        [MethodImpl(Inline)]
        static uint write(uint src, int pos, uint state)
        {
            var c = ~(uint)state + 1u;
            src ^= (c ^ src) & (1u << pos);
            return src;
        }

        [MethodImpl(Inline)]
        static byte write(byte src, int pos, byte state)
        {
            var c = ~state + 1;
            src ^= (byte)((c ^ src) & (1 << pos));
            return src;
        }
    }
}