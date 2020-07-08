//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class math
    {
        
        [MethodImpl(Inline), Op]
        public static ModN modn(uint n)
            => new ModN(n);

        /// <summary>
        /// Computes a % N
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline), Op]
        public static uint mod(in ModN n, uint a)
            => n.mod(a);

        /// <summary>
        /// Computes the quotient a / N
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline), Op]
        public static uint div(in ModN n, uint a)        
            => n.div(a);

        /// <summary>
        /// Computes whether a % n == 0
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline), Op]
        public static bool divisible(in ModN n, uint a)
            => n.divisible(a);

        [MethodImpl(Inline), Op]
        public static ConstPair<uint> divrem(in ModN n, uint a)
            => n.divrem(n,a, out var dst);

        [MethodImpl(Inline), Op]
        public static uint add(in ModN n, uint a, uint b)
            => n.add(a,b);

        [MethodImpl(Inline), Op]
        public static uint mul(in ModN n, uint a, uint b)
            => n.mod(a * b);
    }

    /// <summary>
    /// Implements basic arithmetic operations relative to a fixed modulus
    /// </summary>
    /// <remarks>See https://arxiv.org/pdf/1902.01961.pdf</remarks>
    public readonly struct ModN
    {
        readonly ulong _N;

        readonly ulong _M;

        [MethodImpl(Inline)]
        internal ModN(ulong n)
        {
            _N = n;
            _M = (ulong.MaxValue / _N) + 1;
        }

        /// <summary>
        /// Computes a % N
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint mod(uint a)
            => (uint) math.mulhi(_M * a, _N);

        /// <summary>
        /// Computes the quotient a / N
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint div(uint a)        
            => (uint) math.mulhi(_M, a);

        /// <summary>
        /// Computes whether a % n == 0
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public bool divisible(uint a)
            => a * _M <= _M - 1; 

        /// <summary>
        /// Computes both the quotient and remainder
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public void divrem(uint a, out uint q, out uint r)
        {
            q = div(a);
            r = mod(a);
        }

        [MethodImpl(Inline), Op]
        public ref readonly ConstPair<uint> divrem(in ModN n, uint a, out ConstPair<uint> dst)
        {
            dst = new ConstPair<uint>(div(a),mod(a));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public uint add(uint a, uint b)
            => mod(a + b);

        [MethodImpl(Inline)]
        public uint mul(uint a, uint b)
            => mod(a * b);

        public uint N
        {
            [MethodImpl(Inline)]
            get => (uint)_N;
        } 
    }    
}