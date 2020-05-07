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
    public readonly struct AsmBranchInfo
    {
        public readonly MemoryAddress Base;

        public readonly MemoryAddress IP;

        public readonly MemoryAddress Local;

        public readonly LocalAddress Relative;

        public readonly int Size;

        public readonly bool Near;

        [MethodImpl(Inline)]
        public static AsmBranchInfo Define(MemoryAddress @base, MemoryAddress target, MemoryAddress local, int size, bool near)
            => new AsmBranchInfo(@base, target, local, size, near);

        [MethodImpl(Inline)]
        AsmBranchInfo(MemoryAddress @base, MemoryAddress target, MemoryAddress local,  int size, bool near)
        {
            Base = @base;
            IP = target;
            Local = local;
            Relative = near ? LocalAddress.From((ushort)(local - @base)) : LocalAddress.Empty;
            Size = size;
            Near = near;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base == 0 && IP == 0 && Size == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }
}