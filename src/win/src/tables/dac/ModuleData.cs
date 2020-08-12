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
    public struct ModuleData
    {
        public ClrDataAddress Address;

        public ClrDataAddress PEFile;

        public ClrDataAddress ILBase;

        public ClrDataAddress MetadataStart;

        public ulong MetadataSize;

        public ClrDataAddress Assembly;

        public uint IsReflection;

        public uint IsPEFile;

        public ulong BaseClassIndex;

        public ulong ModuleID;

        public uint TransientFlags;

        public ClrDataAddress TypeDefToMethodTableMap;

        public ClrDataAddress TypeRefToMethodTableMap;

        public ClrDataAddress MethodDefToDescMap;

        public ClrDataAddress FieldDefToDescMap;

        public ClrDataAddress MemberRefToDescMap;

        public ClrDataAddress FileReferencesMap;

        public ClrDataAddress ManifestModuleReferencesMap;

        public ClrDataAddress LookupTableHeap;

        public ClrDataAddress ThunkHeap;

        public ulong ModuleIndex;

    }
}