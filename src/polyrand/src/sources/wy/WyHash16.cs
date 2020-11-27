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
    /// Implements a 16-bit random number generator
    /// </summary>
    /// <remarks>Algorithms take from https://lemire.me/blog/2019/07/03/a-fast-16-bit-random-number-generator/</remarks>
    public class WyHash16 : IRngDomainValues<ushort>
    {
        /// <summary>
        /// Creates a wyhash 16-bit rng
        /// </summary>
        /// <param name="state">The initial state</param>
        /// <param name="index">The stream index</param>
        [MethodImpl(Inline)]
        public static WyHash16 Define(ushort state, ushort? index = null)
            => new WyHash16(state,index);

        [MethodImpl(Inline)]
        internal WyHash16(ushort state, ushort? index = null)
        {
            State = state;
            Index = index ?? 0xfc15;
        }

        ushort State;

        readonly ushort Index;

        public RngKind RngKind
            => RngKind.WyHash16;

        [MethodImpl(Inline)]
        public ushort Next()
            => Hash16(State += Index, 0x2ab);

        public ushort Next(ushort max)
        {
            var x = Next();
            var m = (uint)x * (uint)max;
            var l = (ushort)m;
            if (l < max)
            {
                var t = mod(negate(max), max);
                while (l < t)
                {
                    x = Next();
                    m = (uint)x * (uint)max;
                    l = (ushort)m;
                }
            }
            return (ushort) (m >> 16);
        }

        [MethodImpl(Inline)]
        public ushort Next(ushort min, ushort max)
            => add(min, Next((ushort)(max - min)));

        [MethodImpl(Inline)]
        ushort Hash16(uint input, uint key)
        {
            var hash = input * key;
            return (ushort) (((hash >> 16) ^ hash) & 0xFFFF);
        }


        [MethodImpl(Inline)]
        static ushort mod(ushort a, ushort m)
            => (ushort)(a % m);

        [MethodImpl(Inline)]
        static ushort negate(ushort src)
            => (ushort)(~src + 1);

        [MethodImpl(Inline)]
        static ushort add(ushort a, ushort b)
            => (ushort)(a + b);

    }
}