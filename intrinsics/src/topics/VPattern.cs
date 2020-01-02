//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
 
    public static partial class VPattern
    {
        /// <summary>
        /// Loads a 128-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        static Vector128<T> load<T>(N128 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => vgeneric<T>(CpuVector.vload(n, in head(src)));

        /// <summary>
        /// Loads a 256-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        static Vector256<T> load<T>(N256 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => vgeneric<T>(CpuVector.vload(n, in head(src)));

        /// <summary>
        /// Loads a 512-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        static Vector512<T> load<T>(N512 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => vgeneric<T>(CpuVector.vload(n, in head(src)));
    }

}
