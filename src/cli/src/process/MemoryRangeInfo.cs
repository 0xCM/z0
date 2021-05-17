//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/microsoft/perfview
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Windows;

    [Record]
    public struct MemoryRangeInfo : IRecord<MemoryRangeInfo>
    {
        public const string TableId = "memory.range";

        public MemoryAddress StartAddress;

        public MemoryAddress EndAddress;

        public ByteSize Size;

        public MemType Type;

        public PageProtection Protection;

        public MemState State;

        public string Owner;
    }
}