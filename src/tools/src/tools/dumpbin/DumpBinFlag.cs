//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    using static Konst;
    using static Pow2x32;

    [Flags]
    public enum DumpBinFlag : ulong
    {
        ArchiveMembers = P2ᐞ00,
        
        ClrHeader = P2ᐞ01,
        
        Dependents = P2ᐞ02,
        
        Directives = P2ᐞ03,
        
        Disasm = P2ᐞ04,
        
        Exports = P2ᐞ05,
        
        Fpo = P2ᐞ06,
        
        Headers = P2ᐞ07,
        
        Imports = P2ᐞ08,
        
        LineNumbers = P2ᐞ09,
        
        LinkerMember = P2ᐞ10,
        
        LoadConfig = P2ᐞ11,
        
        RawData = P2ᐞ12,
        
        Relocations = P2ᐞ13,
        
        Summary = P2ᐞ14,
        
        Symbols = P2ᐞ15,
        
        Tls = P2ᐞ16,
    }

}