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

    partial struct asm
    {
        /// <summary>
        /// Creates a register operand
        /// </summary>
        /// <param name="src">The defining source value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static reg<T> reg<T>(T src)
            where T : unmanaged, IRegister
                => new reg<T>(src);

        [MethodImpl(Inline)]
        public static r8 reg<R>(R r, byte data = default)
            where R : unmanaged, IRegister
                => new r8(data, r.RegKind);

        [MethodImpl(Inline)]
        public static r16 reg<R>(R r, ushort data = default)
            where R : unmanaged, IRegister
                => new r16(data, r.RegKind);

        [MethodImpl(Inline)]
        public static r32 reg<R>(R r, uint data = default)
            where R : unmanaged, IRegister
                => new r32(data, r.RegKind);

        [MethodImpl(Inline)]
        public static r64 reg<R>(R r, ulong data = default)
            where R : unmanaged, IRegister
                => new r64(data, r.RegKind);

        [MethodImpl(Inline)]
        public static Xmm<R> reg<R>(R r, Cell128 data = default)
            where R : unmanaged, IRegister
                => new Xmm<R>(data);

        [MethodImpl(Inline)]
        public static Ymm<R> reg<R>(R r, Cell256 data = default)
            where R : unmanaged, IRegister
                => new Ymm<R>(data);

        [MethodImpl(Inline)]
        public static Zmm<R> reg<R>(R r, Cell512 data = default)
            where R : unmanaged, IRegister
                => new Zmm<R>(data);
    }
}