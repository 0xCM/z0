//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    [Flags]
    public enum PAGE : uint
    {
        NOACCESS = 0x01,

        READONLY = 0x02,

        READWRITE = 0x04,

        WRITECOPY = 0x08,

        EXECUTE = 0x10,

        EXECUTE_READ = 0x20,

        EXECUTE_READWRITE = 0x40,

        EXECUTE_WRITECOPY = 0x80,

        GUARD = 0x100,

        NOCACHE = 0x200,

        WRITECOMBINE = 0x400
    }
}