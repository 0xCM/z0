//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class root
    {                
        /// <summary>
        /// Computes the bit-width of a type
        /// </summary>
        /// <param name="t">A type representative</param>
        /// <typeparam name="T">The type</typeparam>    
        [MethodImpl(Inline)]
        public static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// Computes the bit-width of a type
        /// </summary>
        /// <param name="t">A type representative</param>
        /// <typeparam name="T">The type</typeparam>    
        [MethodImpl(Inline)]
        public static int bitsize<T>(T t)
            => Unsafe.SizeOf<T>()*8;
    }
}
