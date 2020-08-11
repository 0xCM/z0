//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    /// <summary>
    /// Describes a module
    /// </summary>
    public readonly struct ModuleDescription
    {
        public ModuleDescription(ulong @base, int size, int timestamp, string filename, VersionInfo version)
        {
            ImageBase = @base;
            FileSize = (uint)size;
            TimeStamp = (uint)timestamp;
            FileName = filename;
            Version = version;
        }

        public ModuleDescription(ulong @base, uint size, uint timestamp, string filename, VersionInfo version)
        {
            ImageBase = @base;
            FileSize = size;
            TimeStamp = timestamp;
            FileName = filename;
            Version = version;
        }

        /// <summary>
        /// Gets the base address of the object.
        /// </summary>
        public readonly MemoryAddress ImageBase;

        /// <summary>
        /// Gets the file size of the image.
        /// </summary>
        public readonly uint FileSize;

        /// <summary>
        /// Gets the build timestamp of the image.
        /// </summary>
        public readonly uint TimeStamp;

        /// <summary>
        /// Gets the file name of the module on disk.
        /// </summary>
        public readonly string FileName;

        public readonly VersionInfo Version;
    }
}