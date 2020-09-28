//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System;

    using static Part;

    partial struct ClrMetadata
    {

        [Flags]
        public enum MethodFlags : ushort
        {
            CompilerControlledAccess = 0x0000,

            PrivateAccess = 0x0001,

            FamilyAndAssemblyAccess = 0x0002,

            AssemblyAccess = 0x0003,

            FamilyAccess = 0x0004,

            FamilyOrAssemblyAccess = 0x0005,

            PublicAccess = 0x0006,

            AccessMask = 0x0007,

            StaticContract = 0x0010,

            FinalContract = 0x0020,

            VirtualContract = 0x0040,

            HideBySignatureContract = 0x0080,

            ReuseSlotVTable = 0x0000,

            NewSlotVTable = 0x0100,

            CheckAccessOnOverrideImpl = 0x0200,

            AbstractImpl = 0x0400,

            SpecialNameImpl = 0x0800,

            PInvokeInterop = 0x2000,

            UnmanagedExportInterop = 0x0008,

            RTSpecialNameReserved = 0x1000,

            HasSecurityReserved = 0x4000,

            RequiresSecurityObjectReserved = 0x8000,
        }
    }
}