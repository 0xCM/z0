//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    [Record(TableId)]
    public struct ClrFieldRecord : IRecord<ClrFieldRecord>
    {
        public const byte FieldCount = 6;

        public const string TableId = "clr.fields";

        public CliArtifactRef Key;

        public CliKey DeclaringType;

        public CliKey DataType;

        public FieldAttributes Attributes;

        public MemoryAddress Address;

        public bool IsStatic;
    }
}