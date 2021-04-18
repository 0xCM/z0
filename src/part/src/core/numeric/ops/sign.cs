//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Numeric
    {

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Sign sign(sbyte src)
            => src < 0 ? new Sign(SignKind.Signed) : new Sign(SignKind.Unsigned);

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static sbyte sign(byte src)
            => (sbyte)src;

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Sign sign(short src)
            => src < 0 ? new Sign(SignKind.Signed) : new Sign(SignKind.Unsigned);

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Sign sign(ushort src)
            => new Sign(SignKind.Unsigned);

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Sign sign(int src)
            => src < 0 ? new Sign(SignKind.Signed) : new Sign(SignKind.Unsigned);

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Sign sign(uint src)
            => new Sign(SignKind.Unsigned);

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Sign sign(long src)
            => src < 0 ? new Sign(SignKind.Signed) : new Sign(SignKind.Unsigned);

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Sign sign(ulong src)
            => new Sign(SignKind.Unsigned);

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Sign sign(float src)
            => src < 0 ? new Sign(SignKind.Signed) : new Sign(SignKind.Unsigned);

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Sign sign(double src)
            => src < 0 ? new Sign(SignKind.Signed) : new Sign(SignKind.Unsigned);

        /// <summary>
        /// Determines the <see cref='Sign'/> of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Sign sign(decimal src)
            => src < 0 ? new Sign(SignKind.Signed) : new Sign(SignKind.Unsigned);
    }
}