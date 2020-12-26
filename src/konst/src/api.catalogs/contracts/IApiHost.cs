//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiHost
    {
        Type HostType {get;}

        bool IsDataType => false;

        string Name
            => Uri.Name;

        ApiHostUri Uri
            => ApiQuery.uri(HostType);

        PartId PartId
            => HostType.Assembly.Id();

        MethodInfo[] Methods
            => HostType.DeclaredMethods();
    }
}