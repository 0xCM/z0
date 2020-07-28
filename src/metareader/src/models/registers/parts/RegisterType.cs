//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    [Flags]
    public enum RegisterType : byte
    {
        General             = 0x01,
        Control             = 0x02,
        Segments            = 0x03,
        FloatingPoint       = 0x04,
        Debug               = 0x05,
        TypeMask            = 0x0f,

        ProgramCounter      = 0x10,
        StackPointer        = 0x20,
        FramePointer        = 0x40,
    }        
}