//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmMemDirect : INullity
    {        
        public readonly Register Base;

        public readonly AsmMemScale Scale;

        public readonly AsmMemDx Dx;
        
        [MethodImpl(Inline)]
        public static AsmMemDirect From(Instruction src)
            => new AsmMemDirect(src.MemoryBase, src.MemoryIndexScale,
                    AsmMemDx.From(src.MemoryDisplacement, src.MemoryDisplSize));

        [MethodImpl(Inline)]
        public AsmMemDirect(Register register, AsmMemScale scale, AsmMemDx dx)
        {
            Base = register;
            Dx = dx;
            Scale = scale;
        }       

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base == 0 && Scale.IsEmpty && Dx.IsEmpty;
        }

        public static AsmMemDirect Empty 
            => new AsmMemDirect(Register.None, AsmMemScale.Empty, AsmMemDx.Empty);
    }
}