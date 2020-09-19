//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using G = Lcg64;
    using api = Lcg;

    [ApiHost]
    public readonly partial struct Lcg
    {
        [MethodImpl(Inline), Op]
        public static G create(N64 n, ulong mul, ulong inc, ulong mod, ulong seed)
            => new G(mul, inc, mod, seed);


        [MethodImpl(Inline), Op]
        public static void capture(ref G g, Span<ulong> dst)
        {
            var count = (uint)dst.Length;
            for(var i=0u; i<count; i++)
            {
                advance(ref g);
                seek(dst,i) = g.State;
            }
        }

        [MethodImpl(Inline), Op]
        public static ref G skip(ref G g, uint n)
        {
            for(var i=0; i<n; i++)
                advance(ref g);
            return ref g;
        }

        [MethodImpl(Inline), Op]
        public static ulong next(in G g)
            => (g.Mul*g.State + g.Inc) % g.Mod;

        [MethodImpl(Inline), Op]
        public static ref G advance(ref G g)
        {
            g.State = api.next(g);
            return ref g;
        }

        [MethodImpl(Inline), Op]
        public static ref G advance(ref G g, uint count)
        {
            for(var i=0; i<count; i++)
                api.advance(ref g);
            return ref g;
        }

        [MethodImpl(Inline), Op]
        public static ulong min(in G g)
            => g.Inc == 0 ? 1 : 0;

        [MethodImpl(Inline), Op]
        public static ulong max(in G g)
            => g.Mod - 1;
    }

    public struct Lcg64
    {
        internal readonly ulong Mul;

        internal readonly ulong Inc;

        internal readonly ulong Mod;

        internal readonly ulong Seed;

        internal readonly ulong Min;

        internal readonly ulong Max;

        internal ulong State;

        [MethodImpl(Inline)]
        internal Lcg64(ulong mul, ulong inc, ulong mod, ulong seed)
            : this()
        {
            Mul = mul;
            Inc = inc;
            Mod = mod;
            Seed = seed;
            State = Seed;
            Min = api.min(this);
            Max = api.max(this);
        }
    }
}