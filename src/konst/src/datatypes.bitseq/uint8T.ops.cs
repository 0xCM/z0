//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using U = uint8T;
    using W = W8;

    partial struct BitSeq
    {
        /// <summary>
        /// Reduces the source value to a width-identified integer via modular arithmetic
        /// </summary>
        /// <param name="src">The input value</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline), Op]
        public static U reduce(byte src, W w)
            => new U(src);

        /// <summary>
        /// Converts a source integral value to an enum value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="K">The target enum  type</typeparam>
        [MethodImpl(Inline)]
        public static ref K refine<K>(in U src)
            where K : unmanaged, Enum
                 => ref z.@as<U,K>(src);

        /// <summary>
        /// Converts an enum to a width-identified integer
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static U scalar<K>(in K src, W w)
            where K : unmanaged, Enum
                => new U(z.@as<K,byte>(src));

        /// <summary>
        /// Injects the source value directly into the width-identified target, bypassing bounds-checks
        /// </summary>
        /// <param name="src">The value to inject</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline)]
        public static U inject(byte src, W w)
            => new U(src);

        /// <summary>
        /// Creates a 8-bit unsigned integer, equal to zero or one, according to whether the source is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint8(bool src)
            => new U(z.bitstate(src));

        /// <summary>
        /// Creates a 8-bit unsigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint8(byte src)
            => new U(src);

        /// <summary>
        /// Creates a 8-bit unsigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint8(sbyte src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 8-bit unsigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint8(ushort src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 8-bit unsigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint8(short src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 8-bit unsigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint8(int src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 8-bit unsigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint8(uint src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 8-bit unsigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint8(long src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 8-bit unsigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint8(ulong src)
            => new U((byte)src);

        [MethodImpl(Inline), Op]
        public static BitState test(U src, byte pos)
            => z.test(src,pos);

        [MethodImpl(Inline), Op]
        public static U set(U src, byte pos, BitState state)
        {
            if(pos < U.Width)
                return new U(z.set(src.data, pos, state));
            else
                return src;
        }

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='uint8T'/>, as indicated by the <see cref='W8'/> selector,
        /// and shifts the result <see cref='N2'/> bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static uint8T extend(W8 w, N2 n, uint2 src)
            => (uint8T)src << 2;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='uint8T'/>, as indicated by the <see cref='W8'/> selector,
        /// and shifts the result <see cref='N3'/> bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static uint8T extend(W8 w, N3 n, uint2 src)
            => (uint8T)src << 3;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='uint8T'/> as indicated by the <see cref='W8'/> selector
        /// and shifts the result <see cref='N4'/> bits bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static uint8T extend(W8 w, N4 n, uint2 src)
            => (uint8T)src << 4;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='Z0.uint8T'/>, as indicated by the <see cref='W8'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint8T extend(W8 w, uint2 src)
            => new U(src.data);
    }
}