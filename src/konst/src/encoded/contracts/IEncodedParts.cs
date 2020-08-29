//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEncodedParts
    {
        int EntryCount {get;}

        ApiHostUri[] Hosts {get;}

        PartId[] Parts {get;}

        X86ApiCode Code(MemoryAddress src);

        EncodedMembers CodeSet(ApiHostUri host);

        PartCode CodeSet(PartId part);

        X86ApiCode this[MemoryAddress address] {get;}

        EncodedMembers this[ApiHostUri uri] {get;}

        PartCode this[PartId id] {get;}
    }
}