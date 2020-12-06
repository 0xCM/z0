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

    [StructLayout(DefaultLayout), Table(TableId, FieldCount)]
    public struct ClrFieldRecord
    {
        public const byte FieldCount = 6;

        public const string TableId = "clr.fields";

        public CliArtifactRef Key;

        public CliArtifactKey DeclaringType;

        public CliArtifactKey DataType;

        public FieldAttributes Attributes;

        public MemoryAddress Address;

        public bool IsStatic;
    }
}