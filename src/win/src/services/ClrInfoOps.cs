//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.IO;
    using System.Diagnostics.CodeAnalysis;
        
    /// <summary>
    /// Infers clr info from module names, provides corresponding DAC details.
    /// </summary>
    public readonly struct ClrInfoOps
    {
        public const string c_desktopModuleName1 = "clr";
        
        public const string c_desktopModuleName2 = "mscorwks";
        
        public const string c_coreModuleName = "coreclr";
        
        public const string c_linuxCoreModuleName = "libcoreclr";

        public const string c_desktopDacFileNameBase = "mscordacwks";

        public const string c_coreDacFileNameBase = "mscordaccore";

        public const string c_desktopDacFileName = c_desktopDacFileNameBase + ".dll";

        public const string c_coreDacFileName = c_coreDacFileNameBase + ".dll";

        public const string c_linuxCoreDacFileName = "libmscordaccore.so";

        public static bool TryGetModuleName(ProcessModuleInfo moduleInfo, [NotNullWhen(true)] out string moduleName)
        {
            moduleName = Path.GetFileNameWithoutExtension(moduleInfo.FileName);
            if (moduleName is null)
                return false;

            moduleName = moduleName.ToLower();
            return true;
        }

        /// <summary>
        /// Checks if the provided module corresponds to a supported runtime, gets clr details inferred from the module name.
        /// </summary>
        /// <param name="moduleInfo">Module info.</param>
        /// <param name="flavor">CLR flavor.</param>
        /// <param name="platform">Platform.</param>
        /// <returns>true if module corresponds to a supported runtime.</returns>
        public static bool IsSupportedRuntime(ProcessModuleInfo moduleInfo, out ClrFlavor flavor, out Platform platform)
        {
            flavor = default;
            platform = default;

            if (!TryGetModuleName(moduleInfo, out var moduleName))
                return false;

            switch (moduleName)
            {
                case c_desktopModuleName1:
                case c_desktopModuleName2:
                    flavor = ClrFlavor.Desktop;
                    platform = Platform.Windows;
                    return true;

                case c_coreModuleName:
                    flavor = ClrFlavor.Core;
                    platform = Platform.Windows;
                    return true;

                case c_linuxCoreModuleName:
                    flavor = ClrFlavor.Core;
                    platform = Platform.Linux;
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Returns the file name of the DAC dll according to the specified parameters.
        /// </summary>
        public static string GetDacFileName(ClrFlavor flavor, Platform platform)
        {
            if (platform == Platform.Linux)
                return c_linuxCoreDacFileName;

            return flavor == ClrFlavor.Core ? c_coreDacFileName : c_desktopDacFileName;
        }

        /// <summary>
        /// Returns the file name of the DAC dll for the requests to the symbol server.
        /// </summary>
        public static string GetDacRequestFileName(ClrFlavor flavor, Architecture currentArchitecture, Architecture targetArchitecture, VersionInfo version, Platform platform)
        {
            // Linux never has a "long" named DAC
            if (platform == Platform.Linux)
                return c_linuxCoreDacFileName;

            var dacNameBase = flavor == ClrFlavor.Core ? c_coreDacFileNameBase : c_desktopDacFileNameBase;
            return $"{dacNameBase}_{currentArchitecture}_{targetArchitecture}_{version.Major}.{version.Minor}.{version.Revision}.{version.Patch:D2}.dll";
        }
    }        
}