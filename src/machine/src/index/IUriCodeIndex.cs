//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IUriCodeIndex
    {
        int EntryCount {get;}

        MemoryAddress[] Addresses  {get;}

        UriCode[] Code {get;}

        ApiHostUri[] Hosts {get;}

        OpUri[] Operations {get;}

        PartId[] Parts {get;}

        UriCode CodeAt(MemoryAddress src);

        UriCode[] CodeFor(OpUri uri);

        UriCode[] CodeFor(ApiHostUri uri);

        UriCode this[MemoryAddress address] {get;}

        UriCode[] this[OpUri uri] {get;}  

        UriCode[] this[ApiHostUri uri] {get;}
    }
}