//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static Konst;
    using static z;

    public struct MultiplexSettings
    {
        public ArchiveConfig BuildArchive;

        public FS.FolderPath SlnRoot;

        public ArchiveConfig CaptureArchive;

        public ArchiveConfig MachineArchive;
    }

    public class Multiplex
    {
        WfHost Host;

        MultiplexSettings Settings;

        // TableSpan<ClrAssembly> Assemblies;

        // TableSpan<NativeDll> Libraries;

        TableSpan<ClrAssembly> Assemblies;

        IBuildArchive Build;

        ICaptureArchive Capture;

        IModuleArchive Modules;

        public static Multiplex create(MultiplexSettings settings)
        {
            var mpx = new Multiplex();
            mpx.Settings = settings;
            mpx.Host = WfSelfHost.create(typeof(Multiplex));
            mpx.Build = Archives.build(mpx.Settings.BuildArchive);
            mpx.Capture = Archives.capture(mpx.Settings.CaptureArchive);
            mpx.Modules = mpx.Build.Modules;
            return mpx;
        }

        void LoadAssemblies()
        {
            Modules.Query((in ManagedDll x) => Receive(x));
        }

        void Receive(in ManagedDll src)
        {

        }

    }
}