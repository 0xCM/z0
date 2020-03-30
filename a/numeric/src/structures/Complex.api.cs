//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    
    
    public static class ComplexNumber
    {
        /// <summary>
        /// Defines a generic comple number
        /// </summary>
        /// <param name="re">The real part</param>
        /// <param name="im">The imaginary part</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public static Complex<T> Define<T>(T re, T im = default)   
            where T : unmanaged
                => (re,im);        
    }
}