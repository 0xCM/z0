//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    using Z0.MS;

    [StructLayout(LayoutKind.Sequential)]
    public struct V45ObjectData : IObjectData
    {
        public ClrDataAddress MethodTable;

        public uint ObjectType;

        public ulong Size;

        public ClrDataAddress ElementTypeHandle;

        public uint ElementType;

        public uint Rank;

        public ulong NumComponents;

        public ulong ComponentSize;

        public ClrDataAddress ArrayDataPointer;

        public ClrDataAddress ArrayBoundsPointer;

        public ClrDataAddress ArrayLowerBoundsPointer;

        public ClrDataAddress RCW;

        public ClrDataAddress CCW;

        ClrMdTypeCode IObjectData.ElementType
            => (ClrMdTypeCode)ElementType;

        ulong IObjectData.ElementTypeHandle
            => ElementTypeHandle;

        ulong IObjectData.RCW
            => RCW;

        ulong IObjectData.CCW
            => CCW;

        ulong IObjectData.DataPointer
            => ArrayDataPointer;
    }
}