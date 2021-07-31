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
        public static Disp8 disp8(sbyte src)
            => new Disp8(src);

        /// <summary>
        /// Defines an 8-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp8 disp8(short src)
            => new Disp8((sbyte)src);

        /// <summary>
        /// Defines an 8-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp8 disp8(int src)
            => new Disp8((sbyte)src);

        /// <summary>
        /// Defines an 8-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp8 disp8(long src)
            => new Disp8((sbyte)src);

        /// <summary>
        /// Computes an 8-bit displacement relative to a specified instruction pointer and target address
        /// </summary>
        /// <param name="ip">The instruction pointer address</param>
        /// <param name="dst">The target address</param>
        [MethodImpl(Inline), Op]
        public static Disp8 disp8(MemoryAddress ip, MemoryAddress dst)
            => disp8((long)dst - (long)ip);

        /// <summary>
        /// Defines a 16-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp16 disp16(short src)
            => new Disp16(src);

        /// <summary>
        /// Defines a 16-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp16 disp16(int src)
            => new Disp16((short)src);

        /// <summary>
        /// Defines a 16-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp16 disp16(long src)
            => new Disp16((short)src);

        /// <summary>
        /// Computes a 16-bit displacement relative to a specified instruction pointer and target address
        /// </summary>
        /// <param name="ip">The instruction pointer address</param>
        /// <param name="dst">The target address</param>
        [MethodImpl(Inline), Op]
        public static Disp16 disp16(MemoryAddress ip, MemoryAddress dst)
            => disp16((long)dst - (long)ip);

        /// <summary>
        /// Defines a 32-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp32 disp32(int src)
            => new Disp32(src);

        /// <summary>
        /// Defines a 32-bit displacement
        /// </summary>
        /// <param name="src">The displacement magnitude</param>
        [MethodImpl(Inline), Op]
        public static Disp32 disp32(long src)
            => new Disp32((int)src);

        /// <summary>
        /// Computes a 32-bit displacement relative to a specified instruction pointer and target address
        /// </summary>
        /// <param name="ip">The instruction pointer address</param>
        /// <param name="dst">The target address</param>
        [MethodImpl(Inline), Op]
        public static Disp32 disp32(MemoryAddress ip, MemoryAddress dst)
            => disp32((long)dst - (long)ip);
    }
}