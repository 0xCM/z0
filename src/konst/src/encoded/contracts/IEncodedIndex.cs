//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEncodedIndex
    {
        int EntryCount {get;}

        ApiHostUri[] Hosts {get;}

        PartId[] Parts {get;}

        MemberCode Code(MemoryAddress src);

        MemberCodeIndex CodeSet(ApiHostUri host);

        PartCodeIndex CodeSet(PartId part);

        MemberCode this[MemoryAddress address] {get;}

        MemberCodeIndex this[ApiHostUri uri] {get;}

        PartCodeIndex this[PartId id] {get;}
    }
}