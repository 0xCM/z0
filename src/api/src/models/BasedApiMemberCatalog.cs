//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct BasedApiMemberCatalog
    {
        readonly FS.FilePath Location {get;}

        readonly Index<ApiCatalogEntry> Addresses {get;}

        readonly ApiMembers Members {get;}

        internal BasedApiMemberCatalog(FS.FilePath location, ApiMembers members, Index<ApiCatalogEntry> addresses)
        {
            Location = location;
            Members = members;
            Addresses = addresses;
        }
    }
}