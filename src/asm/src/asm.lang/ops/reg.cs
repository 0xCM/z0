//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;

    partial struct AsmLang
    {
        /// <summary>
        /// Creates a register operand
        /// </summary>
        /// <param name="src">The defining source value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RegOp<T> reg<T>(byte pos, T src)
            where T : unmanaged, IRegister
                => new RegOp<T>(pos, src);

        [MethodImpl(Inline)]
        public static r8 reg<R>(R r, byte pos, byte data = default)
            where R : unmanaged, IRegister
                => new r8(pos, data, r.Kind);

        [MethodImpl(Inline)]
        public static r16 reg<R>(R r, byte pos, ushort data = default)
            where R : unmanaged, IRegister
                => new r16(pos, data, r.Kind);

        [MethodImpl(Inline)]
        public static r32 reg<R>(R r, byte pos, uint data = default)
            where R : unmanaged, IRegister
                => new r32(pos, data, r.Kind);

        [MethodImpl(Inline)]
        public static r64 reg<R>(R r, byte pos, ulong data = default)
            where R : unmanaged, IRegister
                => new r64(pos, data, r.Kind);

        [MethodImpl(Inline)]
        public static Xmm<R> reg<R>(R r, byte pos, Cell128 data = default)
            where R : unmanaged, IRegister
                => new Xmm<R>(pos, data);

        [MethodImpl(Inline)]
        public static Ymm<R> reg<R>(R r, byte pos, Cell256 data = default)
            where R : unmanaged, IRegister
                => new Ymm<R>(pos, data);

        [MethodImpl(Inline)]
        public static Zmm<R> reg<R>(R r, byte pos, Cell512 data = default)
            where R : unmanaged, IRegister
                => new Zmm<R>(pos, data);
    }
}