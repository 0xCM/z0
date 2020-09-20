//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    partial struct ClrStorage
    {
        [Flags]
        public enum DllCharacteristics : ushort
        {
            ProcessInit = 0x0001, // Reserved.

            ProcessTerm = 0x0002, // Reserved.

            ThreadInit = 0x0004, // Reserved.

            ThreadTerm = 0x0008, // Reserved.

            DynamicBase = 0x0040, //

            NxCompatible = 0x0100, //

            NoIsolation = 0x0200, // Image understands isolation and doesn't want it

            NoSEH = 0x0400, // Image does not use SEH.  No SE handler may reside in this image

            NoBind = 0x0800, // Do not bind this image.

            AppContainer = 0x1000, // The image must run inside an AppContainer

            WDM_Driver = 0x2000, // Driver uses WDM model

            //                      0x4000     // Reserved.
            TerminalServerAware = 0x8000,
        }
    }
}