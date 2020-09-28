//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System;

    partial struct ClrMetadata
    {
        [Flags]
        public enum MethodImplFlags : ushort
        {
            ILCodeType = 0x0000,

            NativeCodeType = 0x0001,

            OPTILCodeType = 0x0002,

            RuntimeCodeType = 0x0003,

            CodeTypeMask = 0x0003,

            Unmanaged = 0x0004,

            NoInlining = 0x0008,

            ForwardRefInterop = 0x0010,

            Synchronized = 0x0020,

            NoOptimization = 0x0040,

            PreserveSigInterop = 0x0080,

            AggressiveInlining = 0x0100,

            InternalCall = 0x1000,
        }
    }
}