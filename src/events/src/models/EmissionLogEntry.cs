//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct EmissionLogEntry : IRecord<EmissionLogEntry>
    {
        public const string TableId = "emissions";

        public ExecToken Token;

        [RenderWidth(24)]
        public FS.FileExt TargetExt;

        public EmissionPhase Phase;

        [RenderWidth(10)]
        public ulong Metric;

        public FS.FileUri Target;
    }

    [RenderWidth(12)]
    public enum EmissionPhase : byte
    {
        None = 0,

        Emitting = 1,

        Emitted = 2
    }
}