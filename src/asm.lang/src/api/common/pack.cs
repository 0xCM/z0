//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(AsmBranchTargetKind kind, MemoryAddress dst, AsmBranchTargetWidth size, Address16 selector)
            => new AsmBranchTarget(dst, kind, size, selector);

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(AsmBranchTargetKind kind, MemoryAddress dst, AsmBranchTargetWidth size)
            => new AsmBranchTarget(dst,kind, size);

        [MethodImpl(Inline), Op]
        public static AsmBranchInfo branch(MemoryAddress @base, MemoryAddress ip, byte fxSize, in AsmBranchTarget target)
            => new AsmBranchInfo(@base, ip, target, asm.offset(ip, fxSize, target.Address));

        /// <summary>
        /// Defines an IP offset relative to a specified base address, instruction size and target address
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The size, in bytes, of the call/branch/jmp instruction</param>
        /// <param name="dst">The call/branch/jmp target</param>
        [MethodImpl(Inline), Op]
        public static uint offset(MemoryAddress src, byte fxSize, MemoryAddress dst)
            => (uint)(dst - (src + fxSize));

        [MethodImpl(Inline), Op]
        public static AsmExprSet pack(AsmOpCodeExpr oc, AsmSigExpr sig, AsmStatementExpr statement)
            => new AsmExprSet(new AsmFormExpr(oc, sig), statement);
    }
}