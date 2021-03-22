//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using G = WyHash64;

    /// <summary>
    /// Implements a 64-bit random number generator
    /// </summary>
    /// <remarks>Core algorithm taken from https://github.com/lemire/testingRNG/blob/master/source/wyhash.h</remarks>
    [ApiHost]
    public struct WyHash64 : IRngDomainSource<ulong>
    {
        ulong State;

        [MethodImpl(Inline)]
        public WyHash64(ulong state)
            => State = state;

        public RngKind RngKind
            => RngKind.WyHash64;

        [MethodImpl(Inline), Op]
        public static uint Fill(ref G g, Span<ulong> dst)
        {
            var count = (uint)dst.Length;
            if(count != 0)
            {
                ref var point = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(point,i) = next(ref g);
            }
            return count;
        }

        [MethodImpl(Inline), Op]
        public uint Fill(Span<ulong> dst, ulong max)
        {
            var count = (uint)dst.Length;
            if(count != 0)
            {
                ref var point = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(point,i) = next(ref this, max);
            }
            return count;
        }

        [MethodImpl(Inline), Op]
        public uint Fill(Span<ulong> dst, ulong min, ulong max)
        {
            var count = (uint)dst.Length;
            if(count != 0)
            {
                ref var point = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(point,i) = next(ref this, min, max);
            }
            return count;
        }

        [MethodImpl(Inline)]
        public ulong Next()
            => next(ref this);

        [MethodImpl(Inline)]
        public static bool Next(ref G g, out ulong dst)
        {
            dst = next(ref g);
            return true;
        }

        [MethodImpl(Inline)]
        public ulong Next(ulong max)
            => next(ref this, max);

        [MethodImpl(Inline)]
        public ulong Next(ulong min, ulong max)
            => next(ref this, min, max);

        [MethodImpl(Inline), Op]
        static ulong next(ref G g)
        {
            g.State += X1;
            Math128.mul(g.State, X2, out Pair<ulong> Y1);
            var m1 = Y1.Left ^ Y1.Right;
            Math128.mul(m1, X3, out Pair<ulong> Y2);
            var m2 = Y2.Left ^ Y2.Right;
            return m2;
        }

        [MethodImpl(Inline), Op]
        static ulong next(ref G g, ulong max)
            => RngMath.contract(g.Next(), max);

        [MethodImpl(Inline), Op]
        static ulong next(ref G g, ulong min, ulong max)
            => min + next(ref g, max - min);

        const ulong X1 = 0x60bee2bee120fc15;

        const ulong X2 = 0xa3b195354a39b70d;

        const ulong X3 = 0x1b03738712fad5c9;
    }
}