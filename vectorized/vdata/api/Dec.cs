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
    
    using static root;
    using static Nats;
    using static HexConst;
 
    partial class Data
    {
        /// <summary>
        /// Creates a 128-bit vector with component values k - 1, ..., 1, 0  where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
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
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
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

        public static ReadOnlySpan<byte> Dec128x8u 
            => new byte[16]{F,E,D,C,B,A,9,8,7,6,5,4,3,2,1,0};

        public static ReadOnlySpan<byte> Dec128x16u  
            => new byte[16]{7,0,6,0,5,0,4,0,3,0,2,0,1,0,0,0};

        public static ReadOnlySpan<byte> Dec128x32u  
            => new byte[16]{3,0,0,0,2,0,0,0,1,0,0,0,0,0,0,0};

        public static ReadOnlySpan<byte> Dec128x64u  
            => new byte[16]{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

        public static ReadOnlySpan<byte> Dec256x8u  
            => new byte[32]{
                31,30,29,28,27,26,25,24,23,22,21,20,19,18,17,16,
                15,14,13,12,11,10,9,8,7,6,5,4,3,2,1,0
                };

        public static ReadOnlySpan<byte> Dec256x16u  
            => new byte[32]{
                15,0,14,0,13,0,12,0,11,0,10,0,9,0,8,0,
                7,0,6,0,5,0,4,0,3,0,2,0,1,0,0,0
                };

        public static ReadOnlySpan<byte> Dec256x32u  
            => new byte[32]{
                7,0,0,0,6,0,0,0,5,0,0,0,4,0,0,0,
                3,0,0,0,2,0,0,0,1,0,0,0,0,0,0,0
                };

        public static ReadOnlySpan<byte> Dec256x64u  
            => new byte[32]{
                3,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,
                1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
                };

        [ResourceProvider]
        static void RegisterDec()
        {
            const string basename = "Dec";
            var w = default(ITypeNat);
            var index = DecIndex;

            w = n128;
            Register(index++, NaturalIdentity.resource(basename, w, NumericKind.U8), Dec128x8u);
            Register(index++, NaturalIdentity.resource(basename, w, NumericKind.U16), Dec128x16u);
            Register(index++, NaturalIdentity.resource(basename, w, NumericKind.U32), Dec128x32u);
            Register(index++, NaturalIdentity.resource(basename, w, NumericKind.U64), Dec128x64u);
            
            w = n256;
            Register(index++, NaturalIdentity.resource(basename, w, NumericKind.U8), Dec256x8u);
            Register(index++, NaturalIdentity.resource(basename, w, NumericKind.U16), Dec256x16u);
            Register(index++, NaturalIdentity.resource(basename, w, NumericKind.U32), Dec256x32u);
            Register(index++, NaturalIdentity.resource(basename, w, NumericKind.U64), Dec256x64u);
        }
    }
}