//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct BasedApiMemberCatalog
    {
        readonly BasedApiMembers Members {get;}

        readonly Index<ApiCatalogRecord> Addresses {get;}

        readonly FS.FilePath Location {get;}

        internal BasedApiMemberCatalog(FS.FilePath location, BasedApiMembers members, Index<ApiCatalogRecord> addresses)
        {
            Members = members;
            Addresses = addresses;
            Location = location;
        }

    }
}