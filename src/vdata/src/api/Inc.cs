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
    using static As;
    using static HexConst;
    using static VectorKonst;
    using static Root;

    public static partial class VData
    {
        /// <summary>
        /// Creates a 128-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vincrements<T>(W128 w)
            where T : unmanaged
       {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return vgeneric<T>(Vectors.vload(w, head(Inc128x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return vgeneric<T>(Vectors.vload(w, head(Inc128x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int) || typeof(T) == typeof(float))
                return vgeneric<T>(Vectors.vload(w, head(Inc128x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return vgeneric<T>(Vectors.vload(w, head(Inc128x64u)));
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vincrements<T>(W256 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return vgeneric<T>(Vectors.vload(w, head(Inc256x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return vgeneric<T>(Vectors.vload(w, head(Inc256x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int)  || typeof(T) == typeof(float))
                return vgeneric<T>(Vectors.vload(w, head(Inc256x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return vgeneric<T>(Vectors.vload(w, head(Inc256x64u)));
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Creates a 512-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector512<T> vincrements<T>(W512 w)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return vload<T>(w,Inc512x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return vload<T>(w,Inc512x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int) || typeof(T) == typeof(float))
                return vload<T>(w,Inc512x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return vload<T>(w,Inc512x64u);
            else
                throw Unsupported.define<T>();
        }

        // public static ReadOnlySpan<byte> Inc128x8u  
        //     => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,B,12,13,14,F};

        // public static ReadOnlySpan<byte> Inc128x16u  
        //     => new byte[16]{0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0};

        // public static ReadOnlySpan<byte> Inc128x32u  
        //     => new byte[16]{0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0};

        // public static ReadOnlySpan<byte> Inc128x64u  
        //     => new byte[16]{0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0};

        // public static ReadOnlySpan<byte> Inc256x8u  
        //     => new byte[32]{
        //         0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
        //         16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31
        //         };

        // public static ReadOnlySpan<byte> Inc256x16u  
        //     => new byte[32]{
        //         0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0,
        //         8,0,9,0,10,0,11,0,12,0,13,0,14,0,15,0
        //         };

        // public static ReadOnlySpan<byte> Inc256x32u  
        //     => new byte[32]{
        //         0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0,
        //         4,0,0,0,5,0,0,0,6,0,0,0,7,0,0,0
        //         };

        // public static ReadOnlySpan<byte> Inc256x64u  
        //     => new byte[32]{
        //         0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
        //         2,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0
        //         };

        public static ReadOnlySpan<byte> Inc512x8u  
            => new byte[64]{
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
                16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,
                32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,
                48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63
                };

        public static ReadOnlySpan<byte> Inc512x16u  
            => new byte[64]{
                0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0,
                8,0,9,0,10,0,11,0,12,0,13,0,14,0,15,0,
                16,0,17,0,18,0,19,0,20,0,21,0,22,0,23,0,
                24,0,25,0,26,0,27,0,28,0,29,0,30,0,31,0
                };

        public static ReadOnlySpan<byte> Inc512x32u  
            => new byte[64]{
                0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0,
                4,0,0,0,5,0,0,0,6,0,0,0,7,0,0,0,
                8,0,0,0,9,0,0,0,A,0,0,0,B,0,0,0,
                C,0,0,0,D,0,0,0,E,0,0,0,F,0,0,0
                };

        public static ReadOnlySpan<byte> Inc512x64u  
            => new byte[64]{
                0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                2,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,
                4,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,
                6,0,0,0,0,0,0,0,7,0,0,0,0,0,0,0,
                };
    }
}