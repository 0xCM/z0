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

    public interface IRegOpSpec : IOperandSpec
    {
        OperandKind IOperandSpec.Kind 
            => OperandKind.R;

        RegisterKind RegisterKind {get;}

    }

    public interface IRegOpSpec<T> : IRegOpSpec, IOperandValue<T>
        where T : unmanaged
    {
    }

    public interface IRegOpSpec<W,T> : IRegOpSpec<T>, IOperand<W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }

    public interface IRegOpSpec<F,W,T> : IRegOpSpec<W,T>, IOperand<F,W,T>
        where F : unmanaged, IRegOpSpec<F,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }

    public interface IRegOpSpec8<F> : IRegOpSpec<F,W8,byte>
        where F : unmanaged, IRegOpSpec8<F>
    {

    }

    public interface IRegOpSpec16<F> : IRegOpSpec<F,W16,ushort>
        where F : unmanaged, IRegOpSpec16<F>
    {

    }

    public interface IRegOpSpec32<F> : IRegOpSpec<F,W32,uint>
        where F : unmanaged, IRegOpSpec32<F>
    {

    }

    public interface IRegOpSpec64<F> : IRegOpSpec<F,W64,ulong>
        where F : unmanaged, IRegOpSpec64<F>
    {

    }

    public interface IRegOpSpec128<F> : IRegOpSpec<F,W128,Vector128<byte>>
        where F : unmanaged, IRegOpSpec128<F>
    {

    }

    public interface IRegOpSpec256<F> : IRegOpSpec<F,W256,Vector256<byte>>
        where F : unmanaged, IRegOpSpec256<F>
    {

    }

    public interface IRegOpSpec512<F> : IRegOpSpec<F,W512,Vector512<byte>>
        where F : unmanaged, IRegOpSpec512<F>
    {

    }
}