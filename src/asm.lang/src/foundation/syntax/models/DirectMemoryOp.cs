//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct DirectMemoryOp
    {
        public Register Base {get;}

        public MemoryScale Scale {get;}

        public AsmDisplacement Dx {get;}

        [MethodImpl(Inline)]
        public DirectMemoryOp(Register register, MemoryScale scale, AsmDisplacement dx)
        {
            Base = register;
            Dx = dx;
            Scale = scale;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base.IsEmpty && Scale.IsEmpty && Dx.IsEmpty;
        }

        public static DirectMemoryOp Empty
            => new DirectMemoryOp(Register.Empty, MemoryScale.Empty, AsmDisplacement.Empty);
    }
}