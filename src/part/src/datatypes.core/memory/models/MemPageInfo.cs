//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Windows;
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct MemoryPageInfo : IRecord<MemoryPageInfo>
    {
        public const string TableId = "memory.pages";

        public Name Identity;

        public MemoryAddress BaseAddress;

        public MemoryAddress EndAddress;

        public ByteSize Size;

        public MemType Type;

        public PageProtection Protection;

        public MemState State;

        public string FullIdentity;
    }
}