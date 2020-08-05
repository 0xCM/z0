//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using Z0.Asm;

    public readonly struct MemDirect : INullity
    {        
        public readonly Register Base;

        public readonly MemScale Scale;

        public readonly MemDx Dx;
        
        [MethodImpl(Inline)]
        public static MemDirect From(Instruction src)
            => new MemDirect(src.MemoryBase, src.MemoryIndexScale,
                    asm.memdx(src.MemoryDisplacement, src.MemoryDisplSize));

        [MethodImpl(Inline)]
        public MemDirect(Register register, MemScale scale, MemDx dx)
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

        public static MemDirect Empty 
            => new MemDirect(Register.None, MemScale.Empty, MemDx.Empty);
    }
}