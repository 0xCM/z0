//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IKnownCode<F,C> : ICapturedCode<F,C>
        where F : struct, IEncoded<F,C>
    {
        
    }
}