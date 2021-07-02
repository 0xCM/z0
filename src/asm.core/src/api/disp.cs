//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        /// <summary>
        /// Defines an 8-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp8 dis8(byte src)
            => new Disp8(src);

        /// <summary>
        /// Defines a 16-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp16 disp16(ushort src)
            => new Disp16(src);

        /// <summary>
        /// Defines a 32-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp32 disp32(uint src)
            => new Disp32(src);

        /// <summary>
        /// Defines a displacement of specified magnitude and width
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="value">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp disp(W8 w, byte src)
            => new Disp(src, 8);

        /// <summary>
        /// Defines a displacement of specified magnitude and width
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="value">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp disp(W16 w, ushort src)
            => new Disp(src, 16);

        /// <summary>
        /// Defines a displacement of specified magnitude and width
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <param name="value">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp disp(W16 w, uint src)
            => new Disp(src, 32);
    }
}