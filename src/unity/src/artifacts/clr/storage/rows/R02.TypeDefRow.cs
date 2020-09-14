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

    using static Konst;

    partial struct ClrStorage
    {
        //  0x02
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeDefRow
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