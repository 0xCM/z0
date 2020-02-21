//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static nfunc;

    public static class ComplexNumber
    {
        /// <summary>
        /// Defines a generic comple number
        /// </summary>
        /// <param name="re">The real part</param>
        /// <param name="im">The imaginary part</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        public static Complex<T> Define<T>(T re, T im = default)   
            where T : unmanaged
                => (re,im);

        
        public static NatSpan<N,Complex<T>> FromPaired<N,T>(NatSpan<N,T> re, NatSpan<N,T> im)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<Complex<T>> dst = new Complex<T>[nati<N>()];
            for(var i=0; i< dst.Length; i++)
                dst[i] = (re[i], im[i]);
            return dst;
        }
    }

}