//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using Z0.Asm;

    using static Seed;

    public interface IRegister : IOperand
    {
        OperandKind IOperand.ArgKind 
            => OperandKind.Register;

        RegisterKind RegisterKind {get;}

        RegisterSymbol Symbol { get => (RegisterSymbol)RegisterKind; }
    }

    public interface IRegister<T> : IRegister, IOperand<T>
        where T : unmanaged
    {
    }

    public interface IRegister<W,T> : IRegister<T>, IOperand<W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }

    public interface IRegister<F,W,T> : IRegister<W,T>, IOperand<F,W,T>
        where F : unmanaged, IRegister<F,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }

    public interface IRegister8<F> : IRegister<F,W8,byte>
        where F : unmanaged, IRegister8<F>
    {

    }

    public interface IRegister16<F> : IRegister<F,W16,ushort>
        where F : unmanaged, IRegister16<F>
    {

    }

    public interface IRegister32<F> : IRegister<F,W32,uint>
        where F : unmanaged, IRegister32<F>
    {

    }

    public interface IRegister64<F> : IRegister<F,W64,ulong>
        where F : unmanaged, IRegister64<F>
    {

    }

    public interface IRegister128<F> : IRegister<F,W128,Vector128<byte>>
        where F : unmanaged, IRegister128<F>
    {

    }

    public interface IRegister256<F> : IRegister<F,W256,Vector256<byte>>
        where F : unmanaged, IRegister256<F>
    {

    }

    public interface IRegister512<F> : IRegister<F,W512,Vector512<byte>>
        where F : unmanaged, IRegister512<F>
    {

    }
}