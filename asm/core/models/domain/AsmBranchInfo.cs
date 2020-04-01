//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    /// <summary>
    /// Describes a branching instruction operand
    /// </summary>
    public readonly struct AsmBranchInfo
    {
        public readonly ulong BaseAddress;

        public readonly ulong TargetAddress;

        public readonly int Size;

        public readonly bool Near;

        public ulong LocalAddress 
        {
            [MethodImpl(Inline)]
            get => Near ? TargetAddress - BaseAddress : TargetAddress;
        }

        [MethodImpl(Inline)]
        public static AsmBranchInfo Define(ulong @base, ulong target, int size, bool near)
            => new AsmBranchInfo(size, target,near, @base);

        [MethodImpl(Inline)]
        AsmBranchInfo(int size, ulong target, bool near, ulong @base)
        {
            this.Size = size;
            this.Near = near;
            this.TargetAddress = target;
            this.BaseAddress = @base;
        }

    }
}