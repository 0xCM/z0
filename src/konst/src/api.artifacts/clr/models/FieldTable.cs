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

    partial struct ClrArtifacts
    {
        [StructLayout(DefaultLayout)]
        public struct FieldTable
        {
            public ClrArtifactRef Key;

            public ApiArtifactKey DeclaringType;

            public ApiArtifactKey DataType;

            public FieldAttributes Attributes;

            public MemoryAddress Address;

            public bool IsStatic;
        }
    }
}