//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using Z0.MS;
    using Z0.Dac;
    
    /// <summary>
    /// Represents information about a single CLR in a process.
    /// </summary>
    public readonly struct ClrDescription
    {
        public readonly ProcessDataTarget DataTarget;

        /// <summary>
        /// Gets module information about the ClrInstance.
        /// </summary>
        public readonly ModuleDescription Module;

        /// <summary>
        /// Gets the type of CLR this module represents.
        /// </summary>
        public readonly ClrFlavor Flavor;

        /// <summary>
        /// Gets module information about the DAC needed create a <see cref="ClrRuntime"/> instance for this runtime.
        /// </summary>
        public readonly DacLibInfo DacInfo;

        /// <summary>
        /// Gets module information about the ClrInstance.
        /// </summary>
        public readonly ModuleDescription ModuleInfo;

        /// <summary>
        /// Gets the location of the local DAC on your machine which matches this version of Clr, or <see langword="null"/>
        /// if one could not be found.
        /// </summary>
        public readonly string LocalMatchingDac;

        public ClrDescription(object dt, ClrFlavor flavor, ModuleDescription module, DacLibInfo dacInfo, string dacLocation)
        {
            Module = module;
            ModuleInfo = module;
            DacInfo = dacInfo;
            DataTarget = default;
            Flavor = flavor;
            LocalMatchingDac = dacLocation;
        }

        public ClrDescription(ProcessDataTarget dt, ClrFlavor flavor, ModuleDescription module, DacLibInfo dacInfo, string dacLocation)
        {
            Module = module;
            ModuleInfo = module;
            DacInfo = dacInfo;
            DataTarget = dt;
            Flavor = flavor;
            LocalMatchingDac = dacLocation;
        }

        /// <summary>
        /// Gets the version number of this runtime.
        /// </summary>
        public VersionInfo Version 
            => ModuleInfo.Version;

        /// <summary>
        /// To string.
        /// </summary>
        /// <returns>A version string for this CLR.</returns>
        public override string ToString() 
            => Version.ToString();
     }
}