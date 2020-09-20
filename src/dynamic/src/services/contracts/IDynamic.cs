//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDynamic
    {
        IDynexus Dynexus => new Dynexus(Identities.Services.Diviner);
    }
}