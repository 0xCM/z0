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
    using static Data;
 
    partial class VPattern
    {
        /// <summary>
        /// Creates a 128-bit vector where each component is of unit value 
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), NatOp, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vunits<T>(N128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(w,Units128x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(w,Units128x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return load<T>(w,Units128x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(w,Units128x64u);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector where each component is of unit value 
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), NatOp, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vunits<T>(N256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(w,Units256x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(w,Units256x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return load<T>(w,Units256x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(w,Units256x64u);
            else
                throw unsupported<T>();
        }
    }
}