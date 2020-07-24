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
        public static AsmMemDirect Empty => new AsmMemDirect(Register.None, AsmMemScale.Empty, AsmMemDx.Empty);
        
        public Register Base {get;}

        public AsmMemScale Scale {get;}        

        public AsmMemDx Dx {get;}               

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base == 0 && Scale.IsEmpty && Dx.IsEmpty;
        }

        [MethodImpl(Inline)]
        public static AsmMemDirect From(Instruction src)
            => new AsmMemDirect(src.MemoryBase, src.MemoryIndexScale,
                    AsmMemDx.From(src.MemoryDisplacement, src.MemoryDisplSize));

        [MethodImpl(Inline)]
        AsmMemDirect(Register register, AsmMemScale scale, AsmMemDx dx)
        {
            this.Base = register;
            this.Dx = dx;
            this.Scale = scale;
        }       
    }
}