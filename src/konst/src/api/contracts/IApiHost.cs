//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IApiHost
    {
        Type HostType {get;}

        string Name
            => Uri.Name;

        ApiHostUri Uri
            => ApiQuery.uri(HostType);

        PartId PartId
            => HostType.Assembly.Id();

        MethodInfo[] HostedMethods
            => HostType.DeclaredMethods();
    }
}