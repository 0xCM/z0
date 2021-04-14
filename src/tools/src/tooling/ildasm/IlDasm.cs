//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;

    using P2 = Pow2x16;

    public readonly struct IlDasm
    {
        [Flags]
        public enum FlagKind : ushort
        {
            None,
            NOBAR = P2.P2ᐞ00,

            BYTES = P2.P2ᐞ01,

            TOKENS = P2.P2ᐞ02,

            RAWEH = P2.P2ᐞ03,

            LINENUM = P2.P2ᐞ04,

            TYPELIST = P2.P2ᐞ05,

            HEADERS = P2.P2ᐞ06,

            STATS = P2.P2ᐞ07,

            CLASSLIST = P2.P2ᐞ08,

            METADATA = P2.P2ᐞ09,
        }

        [Flags]
        public enum MetadataKind : byte
        {
            MDHEADER,

            HEX,

            HEAPS,

            RAW,

            UNREX
        }

        public enum OptionKind : byte
        {
            Metadata,

            Out
        }
    }
}