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
    public struct AsmBranch
    {
        public MemoryAddress Base;

        public MemoryAddress Source;

        public AsmBranchTarget Target;

        public MemoryAddress TargetOffset;

        [MethodImpl(Inline)]
        public AsmBranch(MemoryAddress @base, MemoryAddress src, in AsmBranchTarget target, uint offset)
        {
            Base = @base;
            Source = src;
            Target = target;
            TargetOffset = offset;
        }
    }
}