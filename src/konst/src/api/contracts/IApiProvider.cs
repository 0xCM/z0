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
        ApiParts Api {get;}

        IPart[] Parts
            => Api.Storage;

        PartId[] PartIdentities
            => Api.Identifiers;

        Assembly[] Components
            => Api.Components;
    }
}