//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Konst;

    public interface IMemOp : IOperand
    {
        OperandKind IOperand.OpKind 
            => OperandKind.M;
    }

    public interface IMemOp<T> : IMemOp, IOperand<T>
        where T : unmanaged, IFixed
    {

    }

    public interface IMemOp<W,T> : IMemOp<T>, IOperand<W,T>
        where T : unmanaged, IFixed
        where W : unmanaged, ITypeWidth
    {
        DataWidth ISized.Width => Widths.data<W>();
    }

    public interface IMemOp<F,W,T> : IMemOp<W,T>, IOperand<F,W,T>
        where T : unmanaged, IFixed
        where F : unmanaged, IMemOp<F,W,T>
        where W : unmanaged, ITypeWidth
    {

    }

    public interface IMemOp8<F> : IMemOp<F,W8,Fixed8>
        where F : unmanaged, IMemOp8<F>
    {

    }

    public interface IMemOp16<F> : IMemOp<F,W16,Fixed16>
        where F : unmanaged, IMemOp16<F>
    {

    }

    public interface IMemOp32<F> : IMemOp<F,W32,Fixed32>
        where F : unmanaged, IMemOp32<F>
    {

    }

    public interface IMemOp64<F> : IMemOp<F,W64,Fixed64>
        where F : unmanaged, IMemOp64<F>
    {

    }

    public interface IMemOp128<F> : IMemOp<F,W128,Fixed128>
        where F : unmanaged, IMemOp128<F>
    {

    }

    public interface IMemOp256<F> : IMemOp<F,W256,Fixed256>
        where F : unmanaged, IMemOp256<F>
    {

    }

    public interface IMemOp512<F> : IMemOp<F,W512,Fixed512>
        where F : unmanaged, IMemOp512<F>
    {

    }        
}