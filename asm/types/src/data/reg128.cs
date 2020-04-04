//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{

    public interface reg128 : reg<W128>
    {

    }

    public interface xmm<F> : reg128
        where F : struct, xmm<F>
    {

    }

    public interface xmm<F,N> : xmm<F>
        where F : struct, xmm<F,N>
        where N : unmanaged, ITypeNat
    {

    }

    public readonly struct xmm0 : xmm<xmm0, N0>
    {

    }

    public readonly struct xmm1 : xmm<xmm1, N1>
    {
        
    }

    public readonly struct xmm2 : xmm<xmm2, N2>
    {
        
    }

    public readonly struct xmm3 : xmm<xmm3, N3>
    {
        
    }

    public readonly struct xmm4 : xmm<xmm4, N4>
    {
        
    }

}