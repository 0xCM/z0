//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Z0.MS;

    /// <summary>
    /// An interface for reading data out of the target process.
    /// </summary>
    /// <remarks>
    /// Replica of <see cref='IDataReader'/> that enumerates <see cref='ProcessModuleInfo'/> data in lieu of <see cref='ModuleInfo'/>
    /// </remarks>
    public interface IProcessDataReader : IDisposable, IMemoryReader
    {
        /// <summary>
        /// Gets a value indicating whether this data reader is safe to use in parallel from multiple threads.
        /// </summary>
        bool IsThreadSafe { get; }

        /// <summary>
        /// Gets the architecture of the target.
        /// </summary>
        /// <returns>The architecture of the target.</returns>
        Architecture Architecture { get; }

        /// <summary>
        /// Gets the process ID of the DataTarget.
        /// </summary>
        uint ProcessId { get; }

        /// <summary>
        /// Gets a value indicating whether the data target contains full heap data.
        /// </summary>
        bool IsFullMemoryAvailable { get; }

        /// <summary>
        /// Enumerates the OS thread ID of all threads in the process.
        /// </summary>
        /// <returns>An enumeration of all threads in the target process.</returns>
        IEnumerable<uint> EnumerateAllThreads();

        /// <summary>
        /// Enumerates modules in the target process.
        /// </summary>
        /// <returns>An enumerable of the modules in the target process.</returns>
        IEnumerable<ProcessModuleInfo> EnumerateModules();

        /// <summary>
        /// Gets the version information for a given module (given by the base address of the module).
        /// </summary>
        /// <param name="baseAddress">The base address of the module to look up.</param>
        /// <param name="version">The version info for the given module.</param>
        void GetVersionInfo(ulong baseAddress, out VersionInfo version);

        /// <summary>
        /// Gets information about the given memory range.
        /// </summary>
        /// <param name="address">An arbitrary address in the target process.</param>
        /// <param name="info">The base address and size of the allocation.</param>
        /// <returns>True if the address was found and vq was filled, false if the address is not valid memory.</returns>
        bool QueryMemory(ulong address, out MemoryRegionInfo info);

        /// <summary>
        /// Gets the thread context for the given thread.
        /// </summary>
        /// <param name="threadID">The OS thread ID to read the context from.</param>
        /// <param name="contextFlags">The requested context flags, or 0 for default flags.</param>
        /// <param name="context">A span to write the context to.</param>
        bool GetThreadContext(uint threadID, uint contextFlags, Span<byte> context);

        /// <summary>
        /// Informs the data reader that the user has requested all data be flushed.
        /// </summary>
        void FlushCachedData();
    }
}