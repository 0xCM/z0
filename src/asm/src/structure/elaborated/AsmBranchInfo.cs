//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Describes a branching instruction operand
    /// </summary>
    public readonly struct AsmBranchInfo : ITextual
    {
        public static AsmBranchInfo Empty => default(AsmBranchInfo);

        public readonly MemoryAddress Base;

        public readonly MemoryAddress Target;

        public readonly int Size;

        public readonly bool Near;

        public ulong LocalAddress 
        {
            [MethodImpl(Inline)]
            get => Near ? Target - Base : Target;
        }

        [MethodImpl(Inline)]
        public static AsmBranchInfo Define(MemoryAddress @base, MemoryAddress target, int size, bool near)
            => new AsmBranchInfo(@base, target, size, near);

        [MethodImpl(Inline)]
        AsmBranchInfo(MemoryAddress @base, MemoryAddress target, int size, bool near)
        {
            this.Size = size;
            this.Near = near;
            this.Target = target;
            this.Base = @base;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base == 0 && Target == 0 && Size == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public string Format()
            => IsEmpty ? string.Empty : text.concat(Base, " -> ", Target);
    }
}