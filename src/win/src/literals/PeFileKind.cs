//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    // This Enum matchs the CorFieldAttr defined in CorHdr.h
    public enum PEFileKind : byte
    {
        Dll = 0x0001,
        
        ConsoleApplication = 0x0002,
        
        WindowApplication = 0x0003,
    }

}