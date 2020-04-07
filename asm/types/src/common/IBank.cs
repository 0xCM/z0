//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    public interface IBank<F,N,W> : ISized<W>
        where F : struct
        where N : unmanaged, ITypeNat
        where W : unmanaged, ITypeWidth
    {

    }

    public interface IBank8<F,N> : IBank<F,N,W8>
        where F : struct, IBank8<F,N>
        where N : unmanaged, ITypeNat
    {

        
    }

    public interface IBank16<F,N> : IBank<F,N,W16>
        where F : struct, IBank16<F,N>
        where N : unmanaged, ITypeNat
    {

        
    }

    public interface IBank32<F,N> : IBank<F,N,W32>
        where F : struct, IBank32<F,N>
        where N : unmanaged, ITypeNat
    {

        
    }

    public interface IBank64<F,N> : IBank<F,N,W64>
        where F : struct, IBank64<F,N>
        where N : unmanaged, ITypeNat
    {


    }

    public interface IBank128<F,N> : IBank<F,N,W128>
        where F : struct, IBank128<F,N>
        where N : unmanaged, ITypeNat
    {


    }

    public interface IBank256<F,N> : IBank<F,N,W256>
        where F : struct, IBank256<F,N>
        where N : unmanaged, ITypeNat
    {

    }

    public interface IBank512<F,N> : IBank<F,N,W512>
        where F : struct, IBank512<F,N>
        where N : unmanaged, ITypeNat
    {

    }
}