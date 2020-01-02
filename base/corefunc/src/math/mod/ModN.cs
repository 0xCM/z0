//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
        
    using static zfunc;    

    public interface IModN
    {
        uint div(uint a);
        
        uint mod(uint a);

        void divrem(uint a, out uint q, out uint r);

        uint add(uint a, uint b);

        uint mul(uint a, uint b);

        uint N {get;}
    }

    /// <summary>
    /// Implements basic arithmetic operations relative to a fixed modulus
    /// </summary>
    /// <remarks>See https://arxiv.org/pdf/1902.01961.pdf</remarks>
    public readonly struct ModN : IModN
    {
        readonly ulong _N;

        readonly ulong _M;

        [MethodImpl(Inline)]
        public static ModN Ops(uint n)
            => new ModN(n);

        [MethodImpl(Inline)]
        ModN(ulong n)
        {
            this._N = n;
            this._M = (ulong.MaxValue / _N) + 1;
        }

        /// <summary>
        /// Computes a % N
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint mod(uint a)
            => (uint) Math128.mulhi(_M * a, _N);

        /// <summary>
        /// Computes the quotient a / N
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint div(uint a)        
            => (uint) Math128.mulhi(_M, a);

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