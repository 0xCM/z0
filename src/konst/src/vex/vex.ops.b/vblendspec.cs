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
    using static z;
    using static KonstBytes;

    partial struct z
    {
        /// <summary>
        /// Defines a blend specification for combining 2 256-bit vectors that selects the odd components from each vector
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="odd">Whether to select odd or even components</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<byte> vblendspec<T>(W256 n, bool odd)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return blend(n, w8, odd);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return blend(n, w16, odd);
            else if(typeof(T) == typeof(uint) ||typeof(T) == typeof(int))
                return blend(n, w32, odd);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return blend(n, w64, odd);
            else
                throw no<T>();
        }

        /// <summary>
        /// Retrieves a blend specification for combining 2 256-bit vectors that selects the even components from each vector
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="odd">Whether to select odd or even components</param>
        /// <typeparam name="N">The component width type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<byte> vblendspec<N>(W256 n, bool odd, N w = default)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N8))
                return blend(n, w8, odd);
            else if(typeof(N) == typeof(N16))
                return blend(n, w16, odd);
            else if(typeof(N) == typeof(N32))
                return blend(n, w32, odd);
            else if(typeof(N) == typeof(N64))
                return blend(n, w64, odd);
            else
                throw no<N>();
        }

        [MethodImpl(Inline)]
        static Vector256<byte> blend(W256 n, W8 width, bool odd)
            => z.vload<byte>(n,odd ? BlendSpec_Odd_256x8 : BlendSpec_Even_256x8);

        [MethodImpl(Inline)]
        static Vector256<byte> blend(W256 n, W16 width, bool odd)
            => z.vload<byte>(n,odd ? BlendSpec_Odd_256x16 : BlendSpec_Even_256x16);

        [MethodImpl(Inline)]
        static Vector256<byte> blend(W256 n, W32 width, bool odd)
            => z.vload<byte>(n,odd ? BlendSpec_Odd_256x32 : BlendSpec_Even_256x32);

        [MethodImpl(Inline)]
        static Vector256<byte> blend(N256 n, N64 width, bool odd)
            => z.vload<byte>(n, odd ? BlendSpec_Odd_256x64 : BlendSpec_Even_256x64);
   }
}