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
    public readonly struct AsmOffsetOp
    {
        public RegOp Base {get;}

        public RegOp Index {get;}

        public MemoryScale Scale {get;}

        public Disp Disp {get;}

        [MethodImpl(Inline)]
        public AsmOffsetOp(RegOp @base, RegOp index, Disp disp, MemoryScale scale)
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

        // public static AsmOffsetOp Empty
        // {
        //     get => new AsmOffsetOp(RegKind.None,RegKind.None,Disp.Empty,0);
        // }
    }
}