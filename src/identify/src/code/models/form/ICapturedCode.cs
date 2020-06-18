//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICapturedCode<F,C> : IEncoded<F,C>
        where F : struct, IEncoded<F,C>
    {
        ExtractTermCode TermCode {get;}            
    }
}