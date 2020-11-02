//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using U2 = uint1;
    using U5 = uint5;
    using U3 = uint3;
    using U4 = uint4;

    partial struct Sized
    {
        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='U3'/>, as indicated by the <see cref='W3'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint3 extend(W3 w, uint2 src)
            => src;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='U3'/>, as indicated by the <see cref='W3'/> selector
        /// and shifts the result <see cref='N1'/> bit leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static uint3 extend(W3 w, N1 n, uint2 src)
            => (uint3)src << 1;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='U4'/>, as indicated by the <see cref='W4'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint4 extend(W4 w, uint2 src)
            => src;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='U5'/>, as indicated by the <see cref='W5'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint5 extend(W5 w, uint2 src)
            => src;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='Z0.uint6'/>, as indicated by the <see cref='W6'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint6 extend(W6 w, uint2 src)
            => src;

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