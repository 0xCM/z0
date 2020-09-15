//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IIdentityBuilder
    {

    }

    public interface ILegalIdentityBuilder : IIdentityBuilder
    {
        string Legalize(OpIdentity src);
    }
}