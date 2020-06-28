//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
        
    using static Konst;
    using static VectorKonst;
    using static As;
    using static Root;

    partial struct V0p
    {
        /// <summary>
        /// Creates a 128-bit vector where each component is of unit value 
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vunits<T>(N128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return generic<T>(V0.vload(w, head(Units128x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return generic<T>(V0.vload(w, head(Units128x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return generic<T>(V0.vload(w,head(Units128x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return generic<T>(V0.vload(w,head(Units128x64u)));
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector where each component is of unit value 
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vunits<T>(N256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return generic<T>(V0.vload(w, head(Units256x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return generic<T>(V0.vload(w, head(Units256x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return generic<T>(V0.vload(w, head(Units256x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return generic<T>(V0.vload(w, head(Units256x64u)));
            else
                throw Unsupported.define<T>();
        }        

    }
}