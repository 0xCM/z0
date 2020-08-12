//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;

    public enum DebugDirectoryEntryType
    {
        Unknown = 0,
     
        Coff = 1,
     
        CodeView = 2,
     
        Reproducible = 16,
     
        EmbeddedPortablePdb = 17,
     
        PdbChecksum = 19,
    }
}