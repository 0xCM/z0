//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/microsoft/perfview
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Windows;

    public struct MemoryRangeInfo : IRecord<MemoryRangeInfo>
    {
        public MemoryAddress BaseAddress;

        public MemoryAddress EndAddress;

        public ByteSize Size;

        public MemType Type;

        public PageProtection Protection;

        public MemState State;

        public string Owner;
    }
}