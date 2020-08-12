//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.MS;
    
    /// <summary>
    /// Describes the DAC dll.
    /// </summary>
    [Table]
    public readonly struct DacLibInfo
    {
        public readonly ProcessModuleInfo ModuleInfo;

        /// <summary>
        /// Gets the platform-agnostic file name of the DAC dll.
        /// </summary>
        public readonly string PlatformAgnosticFileName;

        /// <summary>
        /// Gets the architecture (x86 or amd64) being targeted.
        /// </summary>
        public readonly Architecture TargetArchitecture;

        /// <summary>
        /// Constructs a DacInfo object with the appropriate properties initialized.
        /// </summary>
        public DacLibInfo(string agnosticName, Architecture targetArch, ProcessModuleInfo module)
        {
            ModuleInfo = module;
            PlatformAgnosticFileName = agnosticName;
            TargetArchitecture = targetArch;
        }

        /// <summary>
        /// Constructs a DacInfo object with the appropriate properties initialized.
        /// </summary>
        public DacLibInfo(string agnosticName, Architecture targetArch, ulong @base, uint size, uint timestamp, string filename, VersionInfo version)
        {
            ModuleInfo = new ProcessModuleInfo(@base, size, timestamp, filename, version);
            PlatformAgnosticFileName = agnosticName;
            TargetArchitecture = targetArch;
        }
    }
}