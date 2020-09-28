//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ImageTables
    {
        [Flags]
        public enum ComImageKind
        {
            ILONLY = 0x00000001,

            _32BITREQUIRED = 0x00000002,

            IL_LIBRARY = 0x00000004,

            STRONGNAMESIGNED = 0x00000008,

            NATIVE_ENTRYPOINT = 0x00000010,

            TRACKDEBUGDATA = 0x00010000,

            _32BITPREFERRED = 0x00020000,
        }
    }
}