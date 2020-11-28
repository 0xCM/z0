//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    using G = WyHash64;

    /// <summary>
    /// Implements a 64-bit random number generator
    /// </summary>
    /// <remarks>Core algorithm taken from https://github.com/lemire/testingRNG/blob/master/source/wyhash.h</remarks>
    [ApiHost]
    public struct WyHash64 : IRngDomainValues<ulong>
    {
        ulong State;

        [MethodImpl(Inline)]
        public WyHash64(ulong state)
        {
            State = state;
        }

        public RngKind RngKind
            => RngKind.WyHash64;

        [MethodImpl(Inline), Op]
        public static ulong next(ref G g)
        {
            g.State += X1;
            math.mul(g.State, X2, out Pair<ulong> Y1);
            var m1 = Y1.Left ^ Y1.Right;
            math.mul(m1, X3, out Pair<ulong> Y2);
            var m2 = Y2.Left ^ Y2.Right;
            return m2;
        }

        [MethodImpl(Inline), Op]
        public static ulong next(ref G g, ulong max)
            => Rng.contract(g.Next(), max);

        [MethodImpl(Inline), Op]
        public static ulong next(ref G g, ulong min, ulong max)
            => min + next(ref g, max - min);

        [MethodImpl(Inline), Op]
        public static void fill(ref G rng, Span<ulong> dst)
        {
            var count = dst.Length;
            if(count != 0)
            {
                ref var point = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(point,i) = next(ref rng);
            }
        }

        [MethodImpl(Inline), Op]
        public static void fill(ref G g, Span<ulong> dst, ulong max)
        {
            var count = dst.Length;
            if(count != 0)
            {
                ref var point = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(point,i) = next(ref g, max);
            }
        }

        [MethodImpl(Inline), Op]
        public static void fill(ref G g, Span<ulong> dst, ulong min, ulong max)
        {
            var count = dst.Length;
            if(count != 0)
            {
                ref var point = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(point,i) = next(ref g, max, max);
            }
        }

        [MethodImpl(Inline)]
        public ulong Next()
            => next(ref this);

        [MethodImpl(Inline)]
        public ulong Next(ulong max)
            => next(ref this, max);

        [MethodImpl(Inline)]
        public ulong Next(ulong min, ulong max)
            => next(ref this, min, max);

        const ulong X1 = 0x60bee2bee120fc15;

        const ulong X2 = 0xa3b195354a39b70d;

        const ulong X3 = 0x1b03738712fad5c9;
    }
}