//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmRegMemory
    {
        public RegisterKind Base {get;}

        public AsmDisplacement Dx {get;}

        public MemoryScale Scale {get;}

        [MethodImpl(Inline)]
        public AsmRegMemory(RegisterKind @base, AsmDisplacement dx, MemoryScale scale)
        {
            Base = @base;
            Dx = dx;
            Scale = scale;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base == 0 && Dx.IsEmpty && Scale.IsEmpty;
        }
    }
}