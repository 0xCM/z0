//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines pseudorandom number generator
    /// </summary>
    /// <remarks> Core algorithm taken from http://xoshiro.di.unimi.it/xoshiro256starstar.c</remarks>
    public class XOrShift256 : IRngBoundPointSource<ulong>
    {
        readonly ulong[] State;

        [MethodImpl(Inline)]
        internal XOrShift256(ulong[] seed)
        {
            this.State = seed;
            jump(J128);
        }

        void jump(ulong[] J)
        {
            var s0 = 0UL;
            var s1 = 0UL;
            var s2 = 0UL;
            var s3 = 0UL;
            for(var i = 0; i < J.Length; i++)
                for(var b = 0; b < 64; b++)
                {
                    var j = J[i] & 1UL << b;
                    if (j != 0)
                    {
                        s0 ^= State[0];
                        s1 ^= State[1];
                        s2 ^= State[2];
                        s3 ^= State[3];
                    }
                    Next();
                }

            State[0] = s0;
            State[1] = s1;
            State[2] = s2;
            State[3] = s3;
        }

        [MethodImpl(Inline)]
        public ulong Next()
        {
            var next = rotl(State[1] * 5, 7) * 9;
            var t = State[1] << 17;

            State[2] ^= State[0];
            State[3] ^= State[1];
            State[1] ^= State[2];
            State[0] ^= State[3];

            State[2] ^= t;

            State[3] = rotl(State[3], 45);

            return next;
        }

        public RngKind RngKind
            => RngKind.XOrShift256;

        [MethodImpl(Inline)]
        public ulong Next(ulong max)
            => Rng.contract(Next(), max);

        [MethodImpl(Inline)]
        public ulong Next(ulong min, ulong max)
            => min + Next(max - min);

        /* When supplied to the jump function, it is equivalent
        to 2^128 calls to next(); it can be used to generate 2^128
        non-overlapping subsequences for parallel computations. */
        static readonly ulong[] J128 =
            { 0x180ec6d33cfd0aba, 0xd5a61266f0c9392c,
              0xa9582618e03fc9aa, 0x39abdc4529b1661c };

        /* When supplied ot the jump function, t is equivalent to
        2^192 calls to next(); it can be used to generate 2^64 starting points,
        from each of which jump() will generate 2^64 non-overlapping
        subsequences for parallel distributed computations. */
        static readonly ulong[] J192 =
            { 0x76e15d3efefdcbbf, 0xc5004e441c522fb3,
              0x77710069854ee241, 0x39109bb02acbe635 };

        static ulong rotl(ulong x, int k)
            => (x << k) | (x >> (64 - k));
    }
}