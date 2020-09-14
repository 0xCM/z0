//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using R = System.Reflection;

    partial struct ClrArtifacts
    {
        public struct FieldTable : IClrTable<FieldTable>
        {
            public ClrArtifactRef Key;

            public ArtifactIdentifier DeclaringType;

            public ArtifactIdentifier DataType;

            public R.FieldAttributes Attributes;

            public MemoryAddress Address;

            public bool IsStatic;
        }
    }
}