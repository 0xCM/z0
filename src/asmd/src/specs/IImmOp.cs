//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IImmOp : IOperand
    {
        OperandKind IOperand.OpKind => OperandKind.Imm;
    }

    public interface IImmOp<T> : IImmOp, IOperand<T>
        where T : unmanaged
    {
        
    }

    public interface IImmOp<W,T> : IImmOp<T>, IOperand<W,T>
        where T : unmanaged
        where W : unmanaged, IDataWidth
    {
        
    }

    public interface IImmOp<F,W,T> : IImmOp<W,T>, IOperand<F,W,T>
        where F : unmanaged, IImmOp<F,W,T>
        where T : unmanaged
        where W : unmanaged, IDataWidth
    {
        
    }

    public interface IImmOp8<F> : IImmOp<F,W8,byte>
        where F : unmanaged, IImmOp8<F>
    {

    }

    public interface IImmOp16<F> : IImmOp<F,W16,ushort>
        where F : unmanaged, IImmOp16<F>

    {

    }

    public interface IImmOp32<F> : IImmOp<F,W32,uint>
        where F : unmanaged, IImmOp32<F>

    {

    }

    public interface IImmOp64<F> : IImmOp<F,W64,ulong>
        where F : unmanaged, IImmOp64<F>
    {

    }
}