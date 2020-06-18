//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IIdentifiedCode<F,C> : IEncoded<F,C>, IIdentified<OpIdentity>
        where F : struct, IEncoded<F,C>

    {

    }
}