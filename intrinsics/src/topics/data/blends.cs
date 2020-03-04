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
    
    using static Root;
    using static Nats;
    using static HexConst;

    partial class VectorData
    {        
        /// <summary>
        /// Defines a blend specification for combining 2 256-bit vectors that selects the odd components from each vector
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="odd">Whether to select odd or even components</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<byte> blendspec<T>(N256 n, bit odd)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))   
                return blend(n, n8, odd);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return blend(n, n16, odd);
            else if(typeof(T) == typeof(uint) ||typeof(T) == typeof(int))
                return blend(n, n32, odd);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return blend(n, n64, odd);
            else
                throw unsupported<T>();            
        }

        /// <summary>
        /// Retrieves a blend specification for combining 2 256-bit vectors that selects the even components from each vector
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="odd">Whether to select odd or even components</param>
        /// <typeparam name="N">The component width type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<byte> blendspec<N>(N256 n, bit odd, N w = default)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N8))   
                return blend(n, n8, odd);
            else if(typeof(N) == typeof(N16))   
                return blend(n, n16, odd);
            else if(typeof(N) == typeof(N32))   
                return blend(n, n32, odd);
            else if(typeof(N) == typeof(N64))   
                return blend(n, n64, odd);
            else
                throw unsupported<N>();            
        }

        [MethodImpl(Inline)]
        static Vector256<byte> blend(N256 n, N8 width, bit odd)
            => load<byte>(n,odd ? BlendSpec_Odd_256x8 : BlendSpec_Even_256x8);

        [MethodImpl(Inline)]
        static Vector256<byte> blend(N256 n, N16 width, bit odd)
            => load<byte>(n,odd ? BlendSpec_Odd_256x16 : BlendSpec_Even_256x16);

        [MethodImpl(Inline)]
        static Vector256<byte> blend(N256 n, N32 width, bit odd)
            => load<byte>(n,odd ? BlendSpec_Odd_256x32 : BlendSpec_Even_256x32);

        [MethodImpl(Inline)]
        static Vector256<byte> blend(N256 n, N64 width, bit odd)
            => load<byte>(n,odd ? BlendSpec_Odd_256x64 : BlendSpec_Even_256x64);

        /// <summary>
        /// Defines a mask for an even 256x8-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Even_256x8
            => new byte[32]{
                0,FF,0,FF,0,FF,0,FF,
                0,FF,0,FF,0,FF,0,FF,
                0,FF,0,FF,0,FF,0,FF,
                0,FF,0,FF,0,FF,0,FF,
            };

        /// <summary>
        /// Defines a mask for an even 256x8-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Odd_256x8
            => new byte[32]{
                FF,0,FF,0,FF,0,FF,0,
                FF,0,FF,0,FF,0,FF,0,
                FF,0,FF,0,FF,0,FF,0,
                FF,0,FF,0,FF,0,FF,0,
            };

        /// <summary>
        /// Defines a mask for an even 256x8-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Even_256x16
            => new byte[32]{
                0,0,FF,FF,0,0,FF,FF,
                0,0,FF,FF,0,0,FF,FF,
                0,0,FF,FF,0,0,FF,FF,
                0,0,FF,FF,0,0,FF,FF,
            };

        /// <summary>
        /// Defines a mask for an odd 256x32-bit blend
        /// </summary>
        static ReadOnlySpan<byte> BlendSpec_Odd_256x16
            => new byte[32]{
                FF,FF,0,0,FF,FF,0,0,
                FF,FF,0,0,FF,FF,0,0,
                FF,FF,0,0,FF,FF,0,0,
                FF,FF,0,0,FF,FF,0,0,
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
                FF,FF,FF,FF,0,0,0,0, 
                FF,FF,FF,FF,0,0,0,0, 
                FF,FF,FF,FF,0,0,0,0, 
                FF,FF,FF,FF,0,0,0,0, 
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