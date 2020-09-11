//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IApiProvider
    {
        ApiSet Api {get;}

        IPart[] Parts
            => Api.Storage;

        PartId[] PartIdentities
            => Api.Identifiers;

        Assembly[] Components
            => Api.Components;
    }
}