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
    using api = ClrArtifactApi;

    partial struct ClrArtifacts
    {
        public struct FieldTable : IClrTable<FieldTable>
        {
            public ArtifactIdentifier Id;

            public ClrName Name;

            public ArtifactIdentifier DeclaringType;

            public ArtifactIdentifier DataType;

            public R.FieldAttributes Attributes;
        }
    }
}