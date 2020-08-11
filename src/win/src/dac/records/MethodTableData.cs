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
    public readonly struct MethodTableData
    {
        public readonly uint IsFree; // everything else is NULL if this is true.

        public readonly ClrDataAddress Module;

        public readonly ClrDataAddress EEClass;

        public readonly ClrDataAddress ParentMethodTable;

        public readonly ushort NumInterfaces;

        public readonly ushort NumMethods;

        public readonly ushort NumVtableSlots;

        public readonly ushort NumVirtuals;

        public readonly uint BaseSize;

        public readonly uint ComponentSize;

        public readonly uint Token;

        public readonly uint AttrClass;

        public readonly uint Shared; // flags & enum_flag_DomainNeutral

        public readonly uint Dynamic;

        public readonly uint ContainsPointers;
    }
}