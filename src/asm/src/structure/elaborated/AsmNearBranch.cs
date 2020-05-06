//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
    using static Seed;

    public readonly struct AsmNearBranch : IAsmBranch
    {
        public static AsmBranchInfo Empty => default(AsmBranchInfo);

        public MemoryAddress Base {get;}

        public MemoryAddress IP {get;}

        readonly MemoryAddress UnmodifiedTarget;
        
        public MemoryAddress Target {get;}
        
        public int Size {get;}

        public bool IsNear => true;

        [MethodImpl(Inline)]
        public static AsmNearBranch Define(MemoryAddress @base, MemoryAddress ip, MemoryAddress target, int size)
            => new AsmNearBranch(@base, ip, target, size);

        [MethodImpl(Inline)]
        internal AsmNearBranch(MemoryAddress @base, MemoryAddress ip, MemoryAddress target, int size)
        {
            Base = @base;
            IP = ip;
            UnmodifiedTarget = target;
            Target = target - @base;
            Size = size;
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