//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    [StructLayout(LayoutKind.Sequential), Record]
    public struct ProcessState : IRecord<ProcessState>
    {
        /// <summary>
        /// The process identifier
        /// </summary>
        public uint ProcessId;

        /// <summary>
        /// The process name
        /// </summary>
        public string ProcessName;

        /// <summary>
        /// The path of the process image
        /// </summary>
        public FS.FilePath ImagePath;

        /// <summary>
        /// The process image version
        /// </summary>
        public VersionId ImageVersion;

        /// <summary>
        /// The base address of the process
        /// </summary>
        public MemoryAddress BaseAddress;

        /// <summary>
        /// The address of the entry point
        /// </summary>
        public MemoryAddress EntryAddress;

        /// <summary>
        /// The number of bytes occupied by the main process module
        /// </summary>
        public ByteSize MemorySize;

        /// <summary>
        /// Captures the min/max working set size
        /// </summary>
        public ClosedInterval<ulong> Capacity;

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

        /// <summary>
        /// The process main module
        /// </summary>
        public ProcessModuleRow Main;
    }
}