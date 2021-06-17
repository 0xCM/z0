//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOpTypes;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static RegExpr<r8> regxpr(r8 @base, r8 index, MemoryScale scale, uint dx)
            => new RegExpr<r8>(@base, index, scale, dx);

        [MethodImpl(Inline), Op]
        public static RegExpr<r16> regxpr(r16 @base, r16 index, MemoryScale scale, uint dx)
            => new RegExpr<r16>(@base, index, scale, dx);

        [MethodImpl(Inline), Op]
        public static RegExpr<r32> regxpr(r32 @base, r32 index, MemoryScale scale, uint dx)
            => new RegExpr<r32>(@base, index, scale, dx);

        [MethodImpl(Inline), Op]
        public static RegExpr<r64> regxpr(r64 @base, r64 index, MemoryScale scale, uint dx)
            => new RegExpr<r64>(@base, index, scale, dx);

    }
}