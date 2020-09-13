//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes a branching instruction operand
    /// </summary>
    public struct AsmBranchInfo
    {
        public Instruction Fx;

        public MemoryAddress Base;

        public MemoryAddress Source;

        public AsmBranchTarget Target;

        public MemoryAddress TargetOffset;

        [MethodImpl(Inline)]
        public AsmBranchInfo(in Instruction fx, MemoryAddress @base, MemoryAddress src, in AsmBranchTarget target, uint offset)
        {
            Fx = fx;
            Base = @base;
            Source = src;
            Target = target;
            TargetOffset = offset;
        }
    }
}