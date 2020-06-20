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
    using static Root;
    using static SymBits;
    using static Imagine;
    using static VectorKonst;

    partial class SymbolicData
    {
        /// <summary>
        /// Creates a 128-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vincrements<T>(N128 w)
            where T : unmanaged
       {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return vgeneric<T>(vload(w, head(Inc128x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return vgeneric<T>(vload(w, head(Inc128x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int) || typeof(T) == typeof(float))
                return vgeneric<T>(vload(w, head(Inc128x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return vgeneric<T>(vload(w, head(Inc128x64u)));
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vincrements<T>(N256 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return vgeneric<T>(vload(w, head(Inc256x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return vgeneric<T>(vload(w, head(Inc256x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int)  || typeof(T) == typeof(float))
                return vgeneric<T>(vload(w, head(Inc256x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return vgeneric<T>(vload(w, head(Inc256x64u)));
            else
                throw Unsupported.define<T>();
        }
 
        /// <summary>
        /// Creates a 128-bit vector where each component is of unit value 
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vunits<T>(W128 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return vgeneric<T>(vload(w, head(Units128x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return vgeneric<T>(vload(w, head(Units128x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return vgeneric<T>(vload(w,head(Units128x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return vgeneric<T>(vload(w,head(Units128x64u)));
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector where each component is of unit value 
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vunits<T>(W256 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return vgeneric<T>(vload(w, head(Units256x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return vgeneric<T>(vload(w, head(Units256x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return vgeneric<T>(vload(w, head(Units256x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return vgeneric<T>(vload(w, head(Units256x64u)));
            else
                throw Unsupported.define<T>();
        }        
    }
}