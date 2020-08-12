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

    [StructLayout(LayoutKind.Sequential)]
    public struct MethodTableData
    {
        public uint IsFree; // everything else is NULL if this is true.

        public ClrDataAddress Module;

        public ClrDataAddress EEClass;

        public ClrDataAddress ParentMethodTable;

        public ushort NumInterfaces;

        public ushort NumMethods;

        public ushort NumVtableSlots;

        public ushort NumVirtuals;

        public uint BaseSize;

        public uint ComponentSize;

        public uint Token;

        public uint AttrClass;

        public uint Shared; // flags & enum_flag_DomainNeutral

        public uint Dynamic;

        public uint ContainsPointers;
    }
}