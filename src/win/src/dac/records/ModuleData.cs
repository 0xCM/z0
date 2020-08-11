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
    public readonly struct ModuleData
    {
        public readonly ClrDataAddress Address;

        public readonly ClrDataAddress PEFile;

        public readonly ClrDataAddress ILBase;

        public readonly ClrDataAddress MetadataStart;

        public readonly ulong MetadataSize;

        public readonly ClrDataAddress Assembly;

        public readonly uint IsReflection;

        public readonly uint IsPEFile;

        public readonly ulong BaseClassIndex;

        public readonly ulong ModuleID;

        public readonly uint TransientFlags;

        public readonly ClrDataAddress TypeDefToMethodTableMap;

        public readonly ClrDataAddress TypeRefToMethodTableMap;

        public readonly ClrDataAddress MethodDefToDescMap;

        public readonly ClrDataAddress FieldDefToDescMap;

        public readonly ClrDataAddress MemberRefToDescMap;

        public readonly ClrDataAddress FileReferencesMap;

        public readonly ClrDataAddress ManifestModuleReferencesMap;

        public readonly ClrDataAddress LookupTableHeap;

        public readonly ClrDataAddress ThunkHeap;

        public readonly ulong ModuleIndex;

    }
}