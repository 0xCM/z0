//     Copyright (c) Microsoft Corporation.  All rights reserved.
// Adapted from https://github.com/microsoft/perfview
namespace Windows
{
    using System;

    public struct MemoryRangeInfo
    {
        public ulong BaseAddress;

        public ulong EndAddress;

        public ulong Size;

        public MemType Type;

        public PageProtection Protection;

        public MemState State;

        public string Owner;
    }
}