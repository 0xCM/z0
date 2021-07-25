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
    public readonly struct AsmOffsetOp<T,D>
        where T : unmanaged, IRegOp
        where D : unmanaged, IDisplacement
    {
        public T Base {get;}

        public T Index {get;}

        public MemoryScale Scale {get;}

        public D Disp {get;}

        [MethodImpl(Inline)]
        public AsmOffsetOp(T @base, T index, MemoryScale scale, D disp)
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