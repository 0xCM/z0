//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using U = octet;

    partial struct UBits
    {
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
        /// Promotes a <see cref='U2'/> to a <see cref='octet'/>, as indicated by the <see cref='W8'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static octet extend(W8 w, uint2 src)
            => src;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='octet'/>, as indicated by the <see cref='W8'/> selector,
        /// and shifts the result <see cref='N2'/> bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static octet extend(W8 w, N2 n, uint2 src)
            => (octet)src << 2;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='octet'/>, as indicated by the <see cref='W8'/> selector,
        /// and shifts the result <see cref='N3'/> bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static octet extend(W8 w, N3 n, uint2 src)
            => (octet)src << 3;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='octet'/> as indicated by the <see cref='W8'/> selector
        /// and shifts the result <see cref='N4'/> bits bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static octet extend(W8 w, N4 n, uint2 src)
            => (octet)src << 4;
    }
}