//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
   public interface reg512 : reg<W512>
    {

    }

    public interface zmm<F> : reg512, reg<F,W512>
        where F : struct, zmm<F>
    {

    }

    public interface zmm<F,N> : zmm<F>
        where F : struct, zmm<F,N>
        where N : unmanaged, ITypeNat
    {

    }
}