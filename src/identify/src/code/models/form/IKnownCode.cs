//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IKnownCode<F,C> : 
        IUriCode<F,C>, 
        ICapturedCode<F,C>,
        IReflectedCode<F,C>
            where F : struct, IEncoded<F,C>
    {
        
    }
}