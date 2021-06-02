//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct asm
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static Vsib vsib(byte src)
            => new Vsib(src);

        [MethodImpl(Inline), Op]
        public static ModRm modrm(byte src)
            => new ModRm(src);

        [MethodImpl(Inline), Op]
        public static ModRm modrm(uint3 rm, uint3 reg, uint2 mod)
            => new ModRm(Bits.join((rm, 0), (reg, 3), (mod, 6)));

        [MethodImpl(Inline), Op]
        public static ModRm modrm(uint3 r1, uint3 r2)
            => modrm(r1, r2, uint2.Max);

        [MethodImpl(Inline), Op]
        public static AsmStatementExpr statement(string src)
            => new AsmStatementExpr(src.Trim());

        [MethodImpl(Inline), Op]
        public static AsmExpr expression(string src)
            => new AsmExpr(src);

        [MethodImpl(Inline), Op]
        public static AsmComment comment(string src)
            => new AsmComment(src);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpr opcode(string src)
            => new AsmOpCodeExpr(src);
    }
}