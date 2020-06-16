//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Seed;
    using static Memories;
    using static VectorKonst;
 
    partial class Data
    {
        /// <summary>
        /// Creates a 128-bit vector with component values k - 1, ..., 1, 0  where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> decrements<T>(N128 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return vload<T>(w, Dec128x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return vload<T>(w, Dec128x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return vload<T>(w, Dec128x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return vload<T>(w, Dec128x64u);
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector with component values k - 1, ..., 1, 0  where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> decrements<T>(N256 w)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return vload<T>(w,Dec256x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return vload<T>(w,Dec256x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return vload<T>(w,Dec256x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return vload<T>(w,Dec256x64u);
            else
                throw Unsupported.define<T>();
        }

        [ResourceProvider]
        static void RegisterDec()
        {
            const string basename = "Dec";
            var w = default(ITypeWidth);
            var index = DecIndex;

            w = w128;
            Register(index++, Identify.resource(basename, w, NumericKind.U8), Dec128x8u);
            Register(index++, Identify.resource(basename, w, NumericKind.U16), Dec128x16u);
            Register(index++, Identify.resource(basename, w, NumericKind.U32), Dec128x32u);
            Register(index++, Identify.resource(basename, w, NumericKind.U64), Dec128x64u);
            
            w = w256;
            Register(index++, Identify.resource(basename, w, NumericKind.U8), Dec256x8u);
            Register(index++, Identify.resource(basename, w, NumericKind.U16), Dec256x16u);
            Register(index++, Identify.resource(basename, w, NumericKind.U32), Dec256x32u);
            Register(index++, Identify.resource(basename, w, NumericKind.U64), Dec256x64u);
        }
    }
}