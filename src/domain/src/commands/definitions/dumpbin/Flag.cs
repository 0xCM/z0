//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    using static Pow2x32;

    public partial struct DumpBin
    {
        [Flags]
        public enum Flag : ulong
        {
            ARCHIVEMEMBERS = P2ᐞ00,

            CLRHEADER = P2ᐞ01,

            DEPENDENTS = P2ᐞ02,

            DIRECTIVES = P2ᐞ03,

            DISASM = P2ᐞ04,

            EXPORTS = P2ᐞ05,

            FPO = P2ᐞ06,

            HEADERS = P2ᐞ07,

            Imports = P2ᐞ08,

            LineNumbers = P2ᐞ09,

            LinkerMember = P2ᐞ10,

            LOADCONFIG = P2ᐞ11,

            RAWDATA = P2ᐞ12,

            RELOCATIONS = P2ᐞ13,

            SUMMARY = P2ᐞ14,

            SYMBOLS = P2ᐞ15,

            TLS = P2ᐞ16,

            OUTPUT = P2ᐞ17,
        }
    }
}