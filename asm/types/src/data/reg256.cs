//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{

    public interface reg256 : reg<W256>
    {

    }

    public interface ymm<F> : reg256
        where F : struct, ymm<F>
    {

    }

    public interface ymm<F,N> : ymm<F>
        where F : struct, ymm<F,N>
        where N : unmanaged, ITypeNat
    {

    }

    public interface reg512 : reg<W512>
    {

    }

    public interface zmm<F> : reg512
        where F : struct, zmm<F>
    {

    }

    public interface zmm<F,N> : zmm<F>
        where F : struct, zmm<F,N>
        where N : unmanaged, ITypeNat
    {

    }

}