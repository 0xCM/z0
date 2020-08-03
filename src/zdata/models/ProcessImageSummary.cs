//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    [Record]
    public struct ProcessImageSummary
    {
        public StringRef ImageId;

        public PartId PartId;

        public MemoryAddress EntryAddress;

        public MemoryAddress BaseAddress;

        public MemoryAddress EndAddress;

        public ByteSize Size;

        public ByteSize Gap;
    }
}