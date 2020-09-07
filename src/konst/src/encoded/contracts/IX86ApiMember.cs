//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IX86ApiMember<F,C> : IEncoded<F,C>
        where F : struct, IEncoded<F,C>
    {
        /// <summary>
        /// The identifying uri
        /// </summary>
        OpUri OpUri {get;}
    }
}