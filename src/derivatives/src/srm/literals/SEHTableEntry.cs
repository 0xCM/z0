//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct SEHTableEntry
    {
        public SEHFlags SEHFlags;

        public uint TryOffset;

        public uint TryLength;

        public uint HandlerOffset;

        public uint HandlerLength;

        public uint ClassTokenOrFilterOffset;
    }
}