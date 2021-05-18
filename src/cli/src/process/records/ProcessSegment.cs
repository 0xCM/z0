//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Windows;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct ProcessSegment : IComparableRecord<ProcessSegment>
    {
        public const string TableId = "process.segments";

        public uint Index;

        public Address16 Selector;

        public ushort SelectorIndex;

        public Address32 Base;

        public ByteSize Size;

        public uint PageCount;

        public MemoryAddress Target;

        public MemType Type;

        public PageProtection Protection;

        public utf8 Label;

        public int CompareTo(ProcessSegment src)
            => Target.CompareTo(src.Target);
    }
}