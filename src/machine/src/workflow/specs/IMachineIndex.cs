//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    using static Seed;

    public interface IMachineIndex
    {
        int EntryCount {get;}

        ApiHostUri[] Hosts {get;}

        PartId[] Parts {get;}

        UriCode Code(MemoryAddress src);

        HostCode CodeSet(ApiHostUri host);

        PartCode CodeSet(PartId part);

        UriCode this[MemoryAddress address] {get;}

        HostCode this[ApiHostUri uri] {get;}

        PartCode this[PartId id] {get;}
    }
}