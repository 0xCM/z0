//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Immutable;

    /// <summary>
    /// Represents the DAC dll.
    /// </summary>
    public class DacInfo : ModuleInfo
    {
        /// <summary>
        /// Gets the platform-agnostic file name of the DAC dll.
        /// </summary>
        public string PlatformAgnosticFileName { get; }

        /// <summary>
        /// Gets the architecture (x86 or amd64) being targeted.
        /// </summary>
        public Architecture TargetArchitecture { get; }

        /// <summary>
        /// Constructs a DacInfo object with the appropriate properties initialized.
        /// </summary>
        public DacInfo(
            IDataReader reader,
            string agnosticName,
            Architecture targetArch,
            ulong imgBase,
            int filesize,
            int timestamp,
            string fileName,
            VersionInfo version,
            ImmutableArray<byte> buildId = default)
            : base(reader, imgBase, filesize, timestamp, fileName, buildId, version)
        {
            PlatformAgnosticFileName = agnosticName;
            TargetArchitecture = targetArch;
        }
    }

}