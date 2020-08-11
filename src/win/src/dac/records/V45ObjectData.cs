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
    public readonly struct V45ObjectData : IObjectData
    {
        public readonly ClrDataAddress MethodTable;
 
        public readonly uint ObjectType;
 
        public readonly ulong Size;
 
        public readonly ClrDataAddress ElementTypeHandle;
 
        public readonly uint ElementType;
 
        public readonly uint Rank;
 
        public readonly ulong NumComponents;
 
        public readonly ulong ComponentSize;
 
        public readonly ClrDataAddress ArrayDataPointer;
 
        public readonly ClrDataAddress ArrayBoundsPointer;
 
        public readonly ClrDataAddress ArrayLowerBoundsPointer;
 
        public readonly ClrDataAddress RCW;
 
        public readonly ClrDataAddress CCW;

        ClrElementType IObjectData.ElementType 
            => (ClrElementType)ElementType;
 
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