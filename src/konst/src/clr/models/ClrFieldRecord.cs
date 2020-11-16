//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(DefaultLayout)]
    public struct ClrFieldRecord
    {
        public CliArtifactRef Key;

        public ClrArtifactKey DeclaringType;

        public ClrArtifactKey DataType;

        public FieldAttributes Attributes;

        public MemoryAddress Address;

        public bool IsStatic;
    }
}