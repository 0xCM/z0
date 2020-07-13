//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Concatentates two arrays
        /// </summary>
        /// <param name="left">The first array</param>
        /// <param name="right">The second array</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static T[] concat<T>(T[] left, T[] right)
            => Arrays.concat(left,right);

        /// <summary>
        /// Concatentates two byte arrays
        /// </summary>
        /// <param name="left">The first array</param>
        /// <param name="right">The second array</param>
        [MethodImpl(Inline)]
        public static byte[] concat(byte[] left, byte[] right)
            => Arrays.concat(left,right);

        /// <summary>
        /// Concatenates a sequence of parameter arrays
        /// </summary>
        /// <param name="src">The source arrays</param>
        public static T[] concat<T>(params T[][] src)
            => Arrays.concat(src);

        /// <summary>
        /// Concatentates a parameter array of byte arrays
        /// </summary>
        /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
        [Op]
        public static byte[] concat(params byte[][] src)
             => Arrays.concat(src);
    }
}