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

        MemoryAddress[] IndexedMemory  {get;}

        UriCode[] IndexedCode {get;}

        OpUri[] IncludedOps {get;}

        UriCode CodeAt(MemoryAddress src);

        UriCode[] CodeFor(OpUri uri);

        UriCode this[MemoryAddress address] {get;}

        UriCode[] this[OpUri uri] {get;}        
    }
}