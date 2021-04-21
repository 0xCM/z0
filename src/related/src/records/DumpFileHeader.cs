//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using W = Windows;

    partial struct Images
    {
        [Record(TableId)]
        public unsafe struct DumpFileHeader : IRecord<DumpFileHeader>
        {
            public const string TableId = "minidump.header";

            public CharBlock4 Signature;

            public ushort Version;

            ushort _Filler1;

            /// <summary>
            /// The number of streams in the minidump directory.
            /// </summary>
            public Count StreamCount;

            /// <summary>
            /// The base RVA of the minidump directory
            /// </summary>
            public Address32 Streams;

            public ulong Timestamp;

            public Flags64<W.MinidumpType> Properties;
        }

    }
}