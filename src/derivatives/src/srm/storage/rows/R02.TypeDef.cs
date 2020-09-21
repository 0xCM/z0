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
        //  0x02
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeDef
        {
            public TypeDefFlags Flags;

            public uint Name;

            public uint Namespace;

            public uint Extends;

            public uint FieldList;

            public uint MethodList;

            public bool IsNested
            {
                get  => (this.Flags & TypeDefFlags.NestedMask) != 0;
            }
        }
    }
}