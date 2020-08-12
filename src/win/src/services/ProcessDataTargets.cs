//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Buffers;
    using System.IO;
    using System.Linq;

    using Z0.MS;
    
    public readonly struct ProcessDataTargets
    {
        public static ProcessDataTarget from(IProcessDataReader reader)
        {
            var dst = new ProcessDataTarget();
            runtimes(reader, ref dst);
            return dst;
        }

        static ClrDescription[] runtimes(IProcessDataReader src, ref ProcessDataTarget target)
        {
            var arch = src.Architecture;
            var versions = z.list<ClrDescription>();

            foreach (ProcessModuleInfo module in modules(src, ref target).Modules)
            {
                if (!ClrInfoOps.IsSupportedRuntime(module, out var flavor, out var platform))
                    continue;

                string dacFileName = ClrInfoOps.GetDacFileName(flavor, platform);
                string dacLocation = Path.Combine(Path.GetDirectoryName(module.FileName)!, dacFileName);

                var version = module.Version;
                string dacAgnosticName = ClrInfoOps.GetDacRequestFileName(flavor, arch, arch, version, platform);
                string dacRegularName = ClrInfoOps.GetDacRequestFileName(flavor, IntPtr.Size == 4 ? Architecture.X86 : Architecture.Amd64, arch, version, platform);

                var dacInfo = new DacLibInfo(dacAgnosticName, arch, 0, module.FileSize, module.TimeStamp, dacRegularName, module.Version);
                versions.Add(new ClrDescription(target, flavor, module, dacInfo, dacLocation));
            }

            return versions.ToArray();            
        }

        /// <summary>
        /// Enumerates information about the loaded modules in the process (both managed and unmanaged).
        /// </summary>
        static ref ProcessDataTarget modules(IProcessDataReader src, ref ProcessDataTarget dst)
        {
            char[] invalid = Path.GetInvalidPathChars();
            var modules = src.EnumerateModules().Where(m => m.FileName != null && m.FileName.IndexOfAny(invalid) < 0).ToArray();
            Array.Sort(modules, (a, b) => a.ImageBase.CompareTo(b.ImageBase));
            dst.Data.Modules = modules;
            return ref dst;
        }
    }
}