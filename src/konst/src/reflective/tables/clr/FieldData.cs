//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ClrTables
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldData
        {
            public ClrTypeCode ElementType;

            public ClrTypeCode SigType;

            public MemoryAddress TypeMethodTable;

            public MemoryAddress TypeModule;

            public ArtifactIdentifier TypeToken;

            public ArtifactIdentifier FieldToken;

            public MemoryAddress MTOfEnclosingClass;

            public Address32 Offset;

            public Bit32 IsThreadLocal;

            public Bit32 IsContextLocal;

            public Bit32 IsStatic;

            public MemoryAddress NextField;
        }
    }
}