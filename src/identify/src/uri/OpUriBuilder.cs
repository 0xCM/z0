//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static UriDelimiters;

    public readonly struct OpUriBuilder
    {        
        public static string PathText(string scheme, PartId catalog, string host)
            => $"{scheme}{EOS}{FS2}{catalog.Format()}{FS}{host}";

        public static string QueryText(OpUriScheme scheme, PartId catalog, string host, string group)
            => $"{scheme.Format()}{EOS}{FS2}{catalog.Format()}{FS}{host}{Q}{group}";

        public static string FullUriText(OpUriScheme scheme, PartId catalog, string host, string group, OpIdentity opid)
            => $"{scheme.Format()}{EOS}{FS2}{catalog.Format()}{FS}{host}?{group}#{opid.Identifier}";

        public static string GroupUriText(OpUriScheme scheme, ApiHostUri host, string group)
            => QueryText(scheme, host.Owner, host.Name, group); 
    }
}