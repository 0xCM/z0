//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMemOperand16<T> : IMemOperand<W16,T> 
        where T : unmanaged
    {

    }

    public interface IMemOperand16<F,T> : IMemOperand16<T>, IMemOperand<F,W16,T>
        where F : unmanaged, IMemOperand16<F,T>
        where T : unmanaged
    {

    }
    
    public interface IMemOperand16 : IMemOperand16<ushort>
    {

    }
}