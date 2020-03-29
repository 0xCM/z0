//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static Core;
 
    partial class Data
    {                
        /// <summary>
        /// Loads a 128-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => vgeneric.generic<T>(vgeneric.vload(n, in head(src)));

        /// <summary>
        /// Loads a 256-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => vgeneric.generic<T>(vgeneric.vload(n, in head(src)));

        /// <summary>
        /// Loads a 512-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> vload<T>(N512 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => vgeneric.generic<T>(vgeneric.vload(n, in head(src)));    

        /// <summary>
        /// Loads a 128-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<byte> vload(N128 n, ReadOnlySpan<byte> src)
            => vload<byte>(n,src);

        /// <summary>
        /// Loads a 256-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<byte> vload(N256 n, ReadOnlySpan<byte> src)
            => vload<byte>(n,src);

        /// <summary>
        /// Loads a 256-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<byte> vload(N512 n, ReadOnlySpan<byte> src)
            => vload<byte>(n,src);
    }
}