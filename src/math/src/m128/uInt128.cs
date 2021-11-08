//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using U = uint128;
    using api = Math128;

    [ApiComplete]
    public struct uint128
    {
        public ulong Lo;

        public ulong Hi;

        [MethodImpl(Inline)]
        public uint128(ulong lo, ulong hi)
        {
            Lo = lo;
            Hi = hi;
        }


        [MethodImpl(Inline)]
        public bool Equals(uint128 src)
            => api.eq(this,src);

        public override bool Equals(object src)
            => src is uint128 x && Equals(x);

        public override int GetHashCode()
            => (int)alg.hash.combine(Lo,Hi);

        [MethodImpl(Inline)]
        public static implicit operator U((ulong lo, ulong hi) src)
            => new U(src.lo, src.hi);

        [MethodImpl(Inline)]
        public static U operator +(U a, U b)
            => api.add(ref a,b);

        [MethodImpl(Inline)]
        public static U operator *(U a, U b)
            => api.mul(ref a,b);

        [MethodImpl(Inline)]
        public static U operator -(U a, U b)
            => api.sub(ref a, b);

        [MethodImpl(Inline)]
        public static bool operator ==(U a, U b)
            => api.eq(a,b);

        [MethodImpl(Inline)]
        public static bool operator !=(U a, U b)
            => !api.eq(a,b);

        [MethodImpl(Inline)]
        public static bool operator >(U a, U b)
            => api.gt(a,b);

        [MethodImpl(Inline)]
        public static bool operator <(U a, U b)
            => api.lt(a,b);

        [MethodImpl(Inline)]
        public static bool operator >=(U a, U b)
            => api.gteq(a,b);

        [MethodImpl(Inline)]
        public static bool operator <=(U a, U b)
            => api.lteq(a,b);

        [MethodImpl(Inline)]
        public static U operator -(U a)
            => api.negate(ref a);

        [MethodImpl(Inline)]
        public static U operator --(U a)
            => api.dec(ref a);

        [MethodImpl(Inline)]
        public static U operator ++(U a)
            => api.inc(ref a);

        [MethodImpl(Inline)]
        public static U operator ~(U a)
            => api.not(a);

        [MethodImpl(Inline)]
        public static U operator &(U a, U b)
            => api.and(a,b);

        [MethodImpl(Inline)]
        public static U operator |(U a, U b)
            => api.or(a,b);

        [MethodImpl(Inline)]
        public static U operator ^(U a, U b)
            => api.xor(a,b);

        [MethodImpl(Inline)]
        public static U operator <<(U a, int shift)
            => api.sll(a,(byte)shift);

        [MethodImpl(Inline)]
        public static U operator >>(U a, int shift)
            => api.srl(a,(byte)shift);

        public static uint128 Zero => default;
    }
}