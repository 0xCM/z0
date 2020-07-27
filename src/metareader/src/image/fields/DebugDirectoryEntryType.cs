//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
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