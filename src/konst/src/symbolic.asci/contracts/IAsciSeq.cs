//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAsciSeq : IByteSeq
    {

    }

    public interface IAsciSeq<F> : IAsciSeq, IBytes<F>, IDataTypeComparable<F>
        where F : struct, IAsciSeq<F>
    {

    }

    public interface IAsciSeq<F,N> : IAsciSeq<F>, IBytes<F,N>
        where N : unmanaged, ITypeNat
        where F : struct, IAsciSeq<F,N>
    {

    }
}