//     Copyright (c) Microsoft Corporation.  All rights reserved.
// Adapted from https://github.com/microsoft/perfview
namespace Windows
{
    using System;

    public struct MemorySegInfo
    {
        public const string HeaderRow = "StartAddress | EndAddress | Size | Type | Protection | State | Owner";

        public const string DataPattern = "{0,-16:x}h | {1,-16:x}h | {2,-8:x}h | {3,-16} | {4,-24} | {5,-16} | {6}";

        public ulong StartAddress;

        public ulong EndAddress;

        public ulong Size;

        public MemType Type;

        public PageProtection Protection;

        public MemState State;

        public string Owner;

        public string Format()
            => string.Format(DataPattern, StartAddress, EndAddress, Size, Type, Protection, State, Owner);
    }
}