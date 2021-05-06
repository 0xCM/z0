//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct PdbRecords
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct DbiHeaderRow : IRecord<DbiHeaderRow>
        {
            public const string TableId = "dbi.header";

            public Cell32 Signature; // 0..3

            public Cell32 Version; // 4..7

            public Cell32 Age; // 8..11

            public Cell16 gssymStream; // 12..13

            public Cell16 vers; // 14..15

            public Cell16 pssymStream; // 16..17

            public Cell16 pdbver; // 18..19

            public Cell16 symrecStream;               // 20..21

            public Cell16 pdbver2;                    // 22..23

            public Cell32 gpmodiSize;                 // 24..27

            public Cell32 secconSize;                 // 28..31

            public Cell32 secmapSize;                 // 32..35

            public Cell32 filinfSize;                 // 36..39

            public Cell32 tsmapSize;                  // 40..43

            public Cell32 mfcIndex;                   // 44..47

            public Cell32 DebugHeaderSize;                 // 48..51

            public Cell32 ecinfoSize;                 // 52..55

            public Cell16 Flags;                      // 56..57

            public Cell16 Machine;                    // 58..59

            public Cell32 Reserved;                   // 60..63
        }
    }
}