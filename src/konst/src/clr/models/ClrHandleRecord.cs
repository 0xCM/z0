//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct ClrHandleRecord : IRecord<ClrHandleRecord>
    {
        public const string TableId = "clr.handles";

        public ClrArtifactKind Kind;

        public CliToken Key;

        public MemoryAddress Address;
    }
}