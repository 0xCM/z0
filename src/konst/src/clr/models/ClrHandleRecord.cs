//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Record(TableId)]
    public struct ClrHandleRecord : IRecord<ClrHandleRecord>
    {
        public const string TableId = "clr.handles";

        public ClrArtifactKind Kind;

        public CliArtifactKey Key;

        public MemoryAddress Address;
    }
}