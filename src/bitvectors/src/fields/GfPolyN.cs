//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    /// <summary>
    /// Represents a base-2 polynomial of degree N. The represented polynomial is of the form
    /// a_i * x^i + . . . a_1 * x^1 + a_0 * x^0 where  a_i = 0 | 1 and i = 0..N
    /// </summary>
    public readonly struct GfPoly<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        readonly ulong Data;

        public static byte degree => (byte)nat64u<N>();

        public static GfPoly<N,T> Zero => default;

        public static implicit operator T(GfPoly<N,T> src)
            => force<T>(src.Data);

        public GfPoly(params byte[] exponents)
        {
            var result = 0ul;
            var count = exponents.Length;

            for(var i=0; i<count; i++)
                result |= Pow2.pow(exponents[i]);

            Data = result;
        }

        [MethodImpl(Inline)]
        public GfPoly(T src)
        {
            Data = force<T,ulong>(src);;
        }

        /// <summary>
        /// Returns a bit indicating whether the coefficient for x^i is 1 or 0
        /// </summary>
        public Bit32 this[byte i]
        {
            [MethodImpl(Inline)]
            get => gbits.testbit(Data,i);
        }

        /// <summary>
        /// Returns the scalar representation of the polynomial
        /// </summary>
        public T Scalar
        {
            [MethodImpl(Inline)]
            get => force<T>(Data);
        }

        /// <summary>
        /// The degree (N) of the polynomial
        /// </summary>
        public byte Degree
        {
            [MethodImpl(Inline)]
            get => degree;
        }

        /// <summary>
        /// Specfies whether the polynomial is the zero polynomial
        /// </summary>
        public bool Nonzero
        {
            [MethodImpl(Inline)]
            get => Data != 0;
        }

        /// <summary>
        /// Formats the polynomial
        /// </summary>
        public string Format(char? variable = null)
        {
            var bs = BitString.scalar(Data);
            var terms = new List<string>();

            for(var i=0; i<bs.Length; i++)
                if(bs[i])
                    terms.Add($"{variable ?? 'x'}^{i}");

            var sb = text.build();
            terms.Reverse();
            return string.Join($" + ", terms);
        }

        public GfPoly<N,U> As<U>()
            where U: unmanaged
                => @as<GfPoly<N,T>, GfPoly<N,U>>(this);

        public GfPoly<M,U> As<M,U>()
            where M : unmanaged, ITypeNat
            where U: unmanaged
                => @as<GfPoly<N,T>, GfPoly<M,U>>(this);
    }
}