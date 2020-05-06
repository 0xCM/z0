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

    public readonly struct AsmFarBranch : IAsmBranch
    {
        public static AsmFarBranch Empty => default(AsmFarBranch);

        public MemoryAddress Base {get;}

        public MemoryAddress IP {get;}

        public MemoryAddress Target {get;}

        public int Size {get;}

        public bool IsNear => false;

        [MethodImpl(Inline)]
        public static AsmFarBranch Define(MemoryAddress @base, MemoryAddress ip, MemoryAddress target, int size)
            => new AsmFarBranch(@base, ip, target, size);

        [MethodImpl(Inline)]
        internal AsmFarBranch(MemoryAddress @base, MemoryAddress ip, MemoryAddress target, int size)
        {
            Base = @base;
            IP = ip;
            Target = target;
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