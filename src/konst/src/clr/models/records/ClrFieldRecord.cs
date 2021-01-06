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
        public const string TableId = "clr.fields";

        public ClrArtifactRef Key;

        public ClrToken DeclaringType;

        public ClrToken DataType;

        public FieldAttributes Attributes;

        public MemoryAddress Address;

        public bool IsStatic;
    }
}