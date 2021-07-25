//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents an operand expression of the form BaseReg + IndexReg*Scale + Displacement
    /// </summary>
    public readonly struct AsmOffsetOp<D>
        where D : unmanaged, IDisplacement
    {
        public RegOp Base {get;}

        public RegOp Index {get;}

        public MemoryScale Scale {get;}

        public D Disp {get;}

        [MethodImpl(Inline)]
        public AsmOffsetOp(RegOp @base, RegOp index, MemoryScale scale, D disp)
        {
            Base = @base;
            Index = index;
            Scale = scale;
            Disp = disp;
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();
    }
}