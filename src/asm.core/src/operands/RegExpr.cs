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
    /// Represents an expression of the form BaseReg + IndexReg*Scale + Displacement
    /// </summary>
    public readonly struct RegExpr<T>
        where T : unmanaged, IRegOp
    {
        public T Base {get;}

        public T Index {get;}

        public MemoryScale Scale {get;}

        public uint Dx {get;}

        [MethodImpl(Inline)]
        public RegExpr(T @base, T index, MemoryScale scale, uint dx)
        {
            Base = @base;
            Index = index;
            Scale = scale;
            Dx = dx;
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();
    }
}