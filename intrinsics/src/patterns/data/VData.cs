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
    using static HexConst;
    using static As;

    public static partial class VData
    {        
        /// <summary>
        /// Loads a 128-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> load<T>(N128 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => vgeneric<T>(ginx.vload(n, in head(src)));

        /// <summary>
        /// Loads a 128-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<byte> load(N128 n, ReadOnlySpan<byte> src)
            => load<byte>(n,src);

        /// <summary>
        /// Loads a 256-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> load<T>(N256 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => vgeneric<T>(ginx.vload(n, in head(src)));

        /// <summary>
        /// Loads a 256-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<byte> load(N256 n, ReadOnlySpan<byte> src)
            => load<byte>(n,src);

        [MethodImpl(Inline)]
        public static Vector128<T> increments<T>(N128 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(n,Inc128x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(n,Inc128x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return load<T>(n,Inc128x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(n,Inc128x64u);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> increments<T>(N256 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(n,Inc256x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(n,Inc256x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return load<T>(n,Inc256x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(n,Inc256x64u);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> decrements<T>(N128 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(n,Dec128x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(n,Dec128x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return load<T>(n,Dec128x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(n,Dec128x64u);
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vector256<T> decrements<T>(N256 n)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return load<T>(n,Dec256x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return load<T>(n,Dec256x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return load<T>(n,Dec256x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return load<T>(n,Dec256x64u);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern P will
        /// describe a permutation that has the following effect: permute(X,P) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lanemerge<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return load<T>(n256,LaneMerge256x8u);
            else if(typeof(T) == typeof(ushort))
                return load<T>(n256,LaneMerge256x16u);
            else 
                return default;
        }

        /// <summary>
        /// Creates a shuffle mask that clears ever-other vector component
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> clearalt<T>(N256 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return load<T>(n,ClearAlt256x8u);
            else if(typeof(T) == typeof(ushort))
                return load<T>(n,ClearAlt256x16u);
            else 
                return default;
        }





        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N8 offset)
            => load<byte>(n, RotL8_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N16 offset)
            => load<byte>(n,RotL16_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N24 offset)
            => load<byte>(n,RotL24_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N32 offset)
            => load<byte>(n,RotL32_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N40 offset)
            => load<byte>(n,RotL40_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N48 offset)
            => load<byte>(n,RotL48_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotr(N128 n, N8 offset)
            => load<byte>(n,RotR8_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotr(N128 n, N16 offset)
            => load<byte>(n,RotR16_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotr(N128 n, N24 offset)
            => ginx.vload(n,RotR24_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotr(N128 n, N32 offset)
            => ginx.vload(n, RotR32_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotr(N128 n, N40 offset)
            => ginx.vload(n,RotR40_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotr(N128 n, N48 offset)
            => ginx.vload(n,RotR48_128x8u);

        static ReadOnlySpan<byte> Inc128x8u  
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,B,12,13,14,F};

        static ReadOnlySpan<byte> Inc128x16u  
            => new byte[16]{0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0};

        static ReadOnlySpan<byte> Inc128x32u  
            => new byte[16]{0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0};

        static ReadOnlySpan<byte> Inc128x64u  
            => new byte[16]{0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0};

        public static ReadOnlySpan<byte> Inc256x8u  
            => new byte[32]{
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
                16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31
                };
        static ReadOnlySpan<byte> Inc256x16u  
            => new byte[32]{
                0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0,
                8,0,9,0,10,0,11,0,12,0,13,0,14,0,15,0
                };

        static ReadOnlySpan<byte> Inc256x32u  
            => new byte[32]{
                0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0,
                4,0,0,0,5,0,0,0,6,0,0,0,7,0,0,0
                };

        static ReadOnlySpan<byte> Inc256x64u  
            => new byte[32]{
                0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                2,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0
                };

        static ReadOnlySpan<byte> Dec128x8u 
            => new byte[16]{F,E,D,C,B,A,9,8,7,6,5,4,3,2,1,0};

        static ReadOnlySpan<byte> Dec128x16u  
            => new byte[16]{7,0,6,0,5,0,4,0,3,0,2,0,1,0,0,0};

        static ReadOnlySpan<byte> Dec128x32u  
            => new byte[16]{3,0,0,0,2,0,0,0,1,0,0,0,0,0,0,0};

        static ReadOnlySpan<byte> Dec128x64u  
            => new byte[16]{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

        static ReadOnlySpan<byte> Dec256x8u  
            => new byte[32]{
                31,30,29,28,27,26,25,24,23,22,21,20,19,18,17,16,
                15,14,13,12,11,10,9,8,7,6,5,4,3,2,1,0
                };

        static ReadOnlySpan<byte> Dec256x16u  
            => new byte[32]{
                15,0,14,0,13,0,12,0,11,0,10,0,9,0,8,0,
                7,0,6,0,5,0,4,0,3,0,2,0,1,0,0,0
                };

        static ReadOnlySpan<byte> Dec256x32u  
            => new byte[32]{
                7,0,0,0,6,0,0,0,5,0,0,0,4,0,0,0,
                3,0,0,0,2,0,0,0,1,0,0,0,0,0,0,0
                };

        static ReadOnlySpan<byte> Dec256x64u  
            => new byte[32]{
                3,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,
                1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
                };

        static ReadOnlySpan<byte> RotL_128x8u
            => new byte[16*7]
            {
                F,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,  //8
                14,F,0,1,2,3,4,5,6,7,8,9,A,B,C,D, //16
                D,E,F,0,1,2,3,4,5,6,7,8,9,A,B,C,  //24
                C,D,E,F,0,1,2,3,4,5,6,7,8,9,A,B,  //32
                B,C,D,E,F,0,1,2,3,4,5,6,7,8,9,A,  //40
                A,B,C,D,E,F,0,1,2,3,4,5,6,7,8,9,  //48
                9,A,B,C,D,E,F,0,1,2,3,4,5,6,7,8,  //56
            };

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 48 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR48_128x8u 
            => new byte[16]{6,7,8,9,A,B,C,E,E,F,0,1,2,4,5,6};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 8 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL8_128x8u  
        {
            [MethodImpl(Inline)]
            get => RotL_128x8u.Slice(0*16, 16);
        }

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 16 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL16_128x8u  
        {
            [MethodImpl(Inline)]
            get => RotL_128x8u.Slice(1*16, 16);
        }

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 24 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL24_128x8u  
        {
            [MethodImpl(Inline)]
            get => RotL_128x8u.Slice(2*16, 16);
        }

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 32 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL32_128x8u  
        {
            [MethodImpl(Inline)]
            get => RotL_128x8u.Slice(3*16, 16);
        }

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 40 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL40_128x8u  
        {
            [MethodImpl(Inline)]
            get => RotL_128x8u.Slice(4*16, 16);
        }

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 40 bits
        /// </summary>
        static ReadOnlySpan<byte> RotL48_128x8u  
        {
            [MethodImpl(Inline)]
            get => RotL_128x8u.Slice(5*16, 16);
        }

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 8 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR8_128x8u  
            => new byte[16]{1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,0};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 16 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR16_128x8u  
            => new byte[16]{2,3,4,5,6,7,8,9,A,B,C,D,E,F,0,1};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 24 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR24_128x8u  
            => new byte[16]{3,4,5,6,7,8,9,A,B,C,D,E,F,0,1,2};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 32 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR32_128x8u 
            => new byte[16]{4,5,6,7,8,9,A,B,C,D,E,F,0,1,2,4};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 40 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR40_128x8u 
            => new byte[16]{5,6,7,8,9,A,B,C,D,E,F,0,1,2,4,5};

 
 
        static ReadOnlySpan<byte> LaneMerge256x8u 
            => new byte[32]{0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31};
        
        static ReadOnlySpan<byte> LaneMerge256x16u 
            => new byte[32]{0x00,0x00,0x02,0x00,0x04,0x00,0x06,0x00,0x08,0x00,0x0A,0x00,0x0C,0x00,0x0E,0x00,0x01,0x00,0x03,0x00,0x05,0x00,0x07,0x00,0x09,0x00,0x0B,0x00,0x0D,0x00,0x0F,0x00 };
        
        static ReadOnlySpan<byte> ClearAlt256x8u 
            => new byte[32]{0x00,0xff,0x02,0xff,0x04,0xff,0x06,0xff,0x08,0xff,0x0a,0xff,0x0c,0xff,0x0e,0xff,0x00,0xff,0x02,0xff,0x04,0xff,0x06,0xff,0x08,0xff,0x0a,0xff,0x0c,0xff,0x0e,0xff};        
        
        static ReadOnlySpan<byte> ClearAlt256x16u 
            => new byte[32]{0x00,0x00,0xff,0xff,0x02,0x00,0xff,0xff,0x04,0x00,0xff,0xff,0x06,0x00,0xff,0xff,0x00,0x00,0xff,0xff,0x02,0x00,0xff,0xff,0x04,0x00,0xff,0xff,0x06,0x00,0xff,0xff};

    }
}