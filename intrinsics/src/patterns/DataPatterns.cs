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

    public static class DataPatterns
    {
        [MethodImpl(Inline)]
        public static Vector128<T> increments<T>(N128 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return ginx.vload<T>(n,Inc128x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return ginx.vload<T>(n,Inc128x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return ginx.vload<T>(n,Inc128x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return ginx.vload<T>(n,Inc128x64u);
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vector256<T> increments<T>(N256 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return ginx.vload<T>(n,Inc256x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return ginx.vload<T>(n,Inc256x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return ginx.vload<T>(n,Inc256x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return ginx.vload<T>(n,Inc256x64u);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> decrements<T>(N128 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return ginx.vload<T>(n,Dec128x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return ginx.vload<T>(n,Dec128x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return ginx.vload<T>(n,Dec128x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return ginx.vload<T>(n,Dec128x64u);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> decrements<T>(N256 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return ginx.vload<T>(n,Dec256x8u);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return ginx.vload<T>(n,Dec256x16u);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return ginx.vload<T>(n,Dec256x32u);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return ginx.vload<T>(n,Dec256x64u);
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vector128<byte> bswap<T>(N128 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ushort))
                return ginx.vload(n, BSwap_128x16u);
            else if(typeof(T) == typeof(uint))
                return ginx.vload(n, BSwap_128x32u);
            else if(typeof(T) == typeof(ulong))
                return ginx.vload(n, BSwap_128x64u);
            else
                throw unsupported<T>();            
        }

        [MethodImpl(Inline)]
        public static Vector256<byte> blendspec<T>(N256 n, bit odd)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))   
                return blendspec(n, n8, odd);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return blendspec(n, n16, odd);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return blendspec(n, n32, odd);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return blendspec(n, n64, odd);
            else
                throw unsupported<T>();            
        }

        [MethodImpl(Inline)]
        public static Vector256<byte> blendspec(N256 n, N8 width, bit odd)
            => ginx.vload(n,odd ? BlendSpec_Odd_256x8 : BlendSpec_Even_256x8);

        [MethodImpl(Inline)]
        public static Vector256<byte> blendspec(N256 n, N16 width, bit odd)
            => ginx.vload(n,odd ? BlendSpec_Odd_256x16 : BlendSpec_Even_256x16);

        [MethodImpl(Inline)]
        public static Vector256<byte> blendspec(N256 n, N32 width, bit odd)
            => ginx.vload(n,odd ? BlendSpec_Odd_256x32 : BlendSpec_Even_256x32);

        [MethodImpl(Inline)]
        public static Vector256<byte> blendspec(N256 n, N64 width, bit odd)
            => ginx.vload(n,odd ? BlendSpec_Odd_256x64 : BlendSpec_Even_256x64);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N8 offset)
            => ginx.vload(n, RotL8_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N16 offset)
            => ginx.vload(n,RotL16_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N24 offset)
            => ginx.vload(n,RotL24_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N32 offset)
            => ginx.vload(n,RotL32_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N40 offset)
            => ginx.vload(n,RotL40_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotl(N128 n, N48 offset)
            => ginx.vload(n,RotL48_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotr(N128 n, N8 offset)
            => ginx.vload(n,RotR8_128x8u);

        [MethodImpl(Inline)]
        public static Vector128<byte> rotr(N128 n, N16 offset)
            => ginx.vload(n,RotR16_128x8u);

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
            => new byte[32]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
                    16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31};
        static ReadOnlySpan<byte> Inc256x16u  
            => new byte[32]{0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0,
                16,0,17,0,18,0,19,0,20,0,21,0,22,0,23,0};

        static ReadOnlySpan<byte> Inc256x32u  
            => new byte[32]{0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0,
                20,0,0,0,21,0,0,0,22,0,0,0,23,0,0,0};

        static ReadOnlySpan<byte> Inc256x64u  
            => new byte[32]{0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                18,0,0,0,0,0,0,0,19,0,0,0,0,0,0,0};

        static ReadOnlySpan<byte> Dec128x8u 
            => new byte[16]{F,E,D,C,B,A,9,8,7,6,5,4,3,2,1,0};

        static ReadOnlySpan<byte> Dec128x16u  
            => new byte[16]{7,0,6,0,5,0,4,0,3,0,2,0,1,0,0,0};

        static ReadOnlySpan<byte> Dec128x32u  
            => new byte[16]{3,0,0,0,2,0,0,0,1,0,0,0,0,0,0,0};

        static ReadOnlySpan<byte> Dec128x64u  
            => new byte[16]{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

        static ReadOnlySpan<byte> Dec256x8u  
            => new byte[32]{31,30,29,28,27,26,25,24,23,22,21,20,19,18,17,16,
                15,14,13,12,11,10,9,8,7,6,5,4,3,2,1,0};

        static ReadOnlySpan<byte> Dec256x16u  
            => new byte[32]{23,0,22,0,21,0,20,0,19,0,18,0,17,0,16,0,
                7,0,6,0,5,0,4,0,3,0,2,0,1,0,0,0};

        static ReadOnlySpan<byte> Dec256x32u  
            => new byte[32]{23,0,0,0,22,0,0,0,21,0,0,0,20,0,0,0,
                3,0,0,0,2,0,0,0,1,0,0,0,0,0,0,0};

        static ReadOnlySpan<byte> Dec256x64u  
            => new byte[32]{19,0,0,0,0,0,0,0,18,0,0,0,0,0,0,0,
                1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

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

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 48 bits
        /// </summary>
        static ReadOnlySpan<byte> RotR48_128x8u 
            => new byte[16]{6,7,8,9,A,B,C,E,E,F,0,1,2,4,5,6};

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 16-bit unsigned integers
        /// </summary>
        static ReadOnlySpan<byte> BSwap_128x16u
            => new byte[16]{1,0,3,2,5,4,7,6,9,8,B,A,D,C,F,E};


        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 32-bit unsigned integers
        /// </summary>
        static ReadOnlySpan<byte> BSwap_128x32u
            => new byte[16]{3,2,1,0,7,6,5,4,B,A,9,8,F,E,D,C};

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 64-bit unsigned integers
        /// </summary>
        static ReadOnlySpan<byte> BSwap_128x64u
            => new byte[16]{7,6,5,4,3,2,1,0,F,E,D,C,B,A,9,8};

        /// <summary>
        /// Defines a mask for an even 256x8-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Even_256x8
            => new byte[32]{
                0, FF, 0, FF, 0, FF, 0, FF,
                0, FF, 0, FF, 0, FF, 0, FF,
                0, FF, 0, FF, 0, FF, 0, FF,
                0, FF, 0, FF, 0, FF, 0, FF,
            };

        /// <summary>
        /// Defines a mask for an even 256x8-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Odd_256x8
            => new byte[32]{
                FF, 0, FF, 0, FF, 0, FF, 0,
                FF, 0, FF, 0, FF, 0, FF, 0,
                FF, 0, FF, 0, FF, 0, FF, 0,
                FF, 0, FF, 0, FF, 0, FF, 0,
            };

        /// <summary>
        /// Defines a mask for an even 256x8-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Even_256x16
            => new byte[32]{
                0,0, FF,FF, 0,0, FF,FF,
                0,0, FF,FF, 0,0, FF,FF,
                0,0, FF,FF, 0,0, FF,FF,
                0,0, FF,FF, 0,0, FF,FF,
            };

        /// <summary>
        /// Defines a mask for an odd 256x32-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Odd_256x16
            => new byte[32]{
                FF,FF, 0,0, FF,FF, 0,0,
                FF,FF, 0,0, FF,FF, 0,0,
                FF,FF, 0,0, FF,FF, 0,0,
                FF,FF, 0,0, FF,FF, 0,0,
            };

        /// <summary>
        /// Defines a mask for an even 256x32-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Even_256x32
            => new byte[32]{
                0,0,0,0, FF,FF,FF,FF,
                0,0,0,0, FF,FF,FF,FF,
                0,0,0,0, FF,FF,FF,FF,
                0,0,0,0, FF,FF,FF,FF,
            };

        /// <summary>
        /// Defines a mask for an odd 256x32-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Odd_256x32
            => new byte[32]{
                FF,FF,FF,FF, 0,0,0,0, 
                FF,FF,FF,FF, 0,0,0,0, 
                FF,FF,FF,FF, 0,0,0,0, 
                FF,FF,FF,FF, 0,0,0,0, 
            };

        /// <summary>
        /// Defines a mask for an even 256x64-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Even_256x64
            => new byte[32]{
                0,0,0,0,0,0,0,0,
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,0,0,0,0,0,0,0,
                FF,FF,FF,FF,FF,FF,FF,FF,
            };

        /// <summary>
        /// Defines a mask for an odd 256x64-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Odd_256x64
            =>new byte[32]{
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,0,0,0,0,0,0,0,
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,0,0,0,0,0,0,0,  
            };
    }
}