//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Diagnostics;

    [Record]
    public struct ProcessState : IRecord<ProcessState>
    {
        /// <summary>
        /// The base address of the process
        /// </summary>
        public MemoryAddress BaseAddress;

        /// <summary>
        /// The number of bytes occupied by the module
        /// </summary>
        public ByteSize MemorySize;

        /// <summary>
        /// The process name
        /// </summary>
        public Name ImageName;

        /// <summary>
        /// The minimum working set size
        /// </summary>
        public ByteSize MinWorkingSet;

        /// <summary>
        /// The maximum working set size
        /// </summary>
        public ByteSize MaxWorkingSet;

        /// <summary>
        /// The process identifier
        /// </summary>
        public uint ProcessId;

        /// <summary>
        /// The path of the process image
        /// </summary>
        public FS.FilePath ImagePath;

        /// <summary>
        /// The process image version
        /// </summary>
        public VersionInfo ImageVersion;

        /// <summary>
        /// The address of the entry point
        /// </summary>
        public MemoryAddress EntryAddress;

        /// <summary>
        /// The minimum working set size
        /// </summary>
        public ByteSize VirtualSize;

        /// <summary>
        /// The maximum working set size
        /// </summary>
        public ByteSize MaxVirtualSize;

        /// <summary>
        /// The cpu affinity provided by <see cref='Process.ProcessorAffinity'/>
        /// </summary>
        public ushort Affinity;

        /// <summary>
        /// Captures the process start time
        /// </summary>
        public Timestamp StartTime;

        /// <summary>
        /// Captures the value provided by <see cref='Process.TotalProcessorTime'/>
        /// </summary>
        public Duration TotalRuntime;

        /// <summary>
        /// Captures the value provided by <see cref='Process.UserProcessorTime'/>
        /// </summary>
        public Duration UserRuntime;
    }
}