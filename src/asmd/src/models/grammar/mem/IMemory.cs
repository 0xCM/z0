//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    public interface IMemory : IOperandSpec
    {
        OperandKind IOperandSpec.Kind 
            => OperandKind.M;
    }

    public interface IMemory<T> : IMemory, IOperandValue<T>
        where T : unmanaged
    {

    }

    public interface IMemory<W,T> : IMemory<T>, IOperand<W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }

    public interface IMemory<F,W,T> : IMemory<W,T>, IOperand<F,W,T>
        where F : unmanaged, IMemory<F,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }

    public interface IMemory8<F> : IMemory<F,W8,byte>
        where F : unmanaged, IMemory8<F>
    {

    }

    public interface IMemory16<F> : IMemory<F,W16,ushort>
        where F : unmanaged, IMemory16<F>
    {

    }

    public interface IMemory32<F> : IMemory<F,W32,uint>
        where F : unmanaged, IMemory32<F>
    {

    }

    public interface IMemory64<F> : IMemory<F,W64,ulong>
        where F : unmanaged, IMemory64<F>
    {

    }

    public interface IMemory128<F> : IMemory<F,W128,Vector128<byte>>
        where F : unmanaged, IMemory128<F>
    {

    }

    public interface IMemory256<F> : IMemory<F,W256,Vector256<byte>>
        where F : unmanaged, IMemory256<F>
    {

    }

    public interface IMemory512<F> : IMemory<F,W512,Vector512<byte>>
        where F : unmanaged, IMemory512<F>
    {

    }        
}