//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    public interface TApiReflected
    {
        IPartCatalog Catalog(IPart src)
            => ApiHosts.catalog(src);

        ApiDataType[] DataTypeHosts(Assembly src)
            => ApiHosts.DataTypeHosts(src);

        ApiHost[] OperationHosts(Assembly src)
            => ApiHosts.OperationHosts(src); 
    }
}