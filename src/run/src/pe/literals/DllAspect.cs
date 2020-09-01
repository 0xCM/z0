//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ImageTables
    {
        //
        // Summary:
        //     Describes the characteristics of a dynamic link library.
        [Flags]
        public enum DllAspect : ushort
        {
            //
            // Summary:
            //     Reserved.
            ProcessInit = 0x1,
            //
            // Summary:
            //     Reserved.
            ProcessTerm = 0x2,
            //
            // Summary:
            //     Reserved.
            ThreadInit = 0x4,
            //
            // Summary:
            //     Reserved.
            ThreadTerm = 0x8,
            //
            // Summary:
            //     The image can handle a high entropy 64-bit virtual address space.
            HighEntropyVirtualAddressSpace = 0x20,
            //
            // Summary:
            //     The DLL can be relocated.
            DynamicBase = 0x40,
            //
            // Summary:
            //     The image is NX compatible.
            NxCompatible = 0x100,
            //
            // Summary:
            //     The image understands isolation and doesn't want it.
            NoIsolation = 0x200,
            //
            // Summary:
            //     The image does not use SEH. No SE handler may reside in this image.
            NoSeh = 0x400,
            //
            // Summary:
            //     Do not bind this image.
            NoBind = 0x800,
            //
            // Summary:
            //     The image must run inside an AppContainer.
            AppContainer = 0x1000,
            //
            // Summary:
            //     The driver uses the WDM model.
            WdmDriver = 0x2000,
            //
            // Summary:
            //     The image is Terminal Server aware.
            TerminalServerAware = 0x8000
        }
    }
}