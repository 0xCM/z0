//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Defines a vector of 32 or 64-bit floating point values where each component has been intialized to the value -0.0
        /// </summary>
        /// <typeparam name="T">The floating point type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> fpsign<T>(N256 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vbroadcast(n256,-0.0f));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vbroadcast(n256,-0.0));
            else 
                return default;
        }
    }
}