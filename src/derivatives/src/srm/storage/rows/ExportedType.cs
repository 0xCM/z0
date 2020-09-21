//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.InteropServices;

    partial struct MetadataRows
    {
        //  0x27
        [StructLayout(LayoutKind.Sequential)]
        public struct ExportedType
        {
            public TypeDefFlags Flags;

            public uint TypeDefId;

            public uint TypeName;

            public uint TypeNamespace;

            public uint Implementation;

            public bool IsNested
            {
                get
                {
                    return (this.Flags & TypeDefFlags.NestedMask) != 0;
                }
            }
        }
    }
}