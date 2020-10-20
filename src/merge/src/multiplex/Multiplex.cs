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

        TableSpan<ClrAssembly> Assemblies;

        IBuildArchive Build;

        ICaptureArchive Capture;

        IModuleArchive Modules;

        public static Multiplex create(MultiplexSettings settings)
        {
            var mpx = new Multiplex();
            mpx.Settings = settings;
            mpx.Host = WfSelfHost.create(typeof(Multiplex));
            mpx.Build = BuildArchive.create(mpx.Settings.BuildArchive);
            mpx.Capture = ApiFiles.capture(mpx.Settings.CaptureArchive);
            mpx.Modules = mpx.Build.Modules;
            return mpx;
        }

        void LoadAssemblies()
        {

        }

        void Receive(in ManagedDll src)
        {

        }

    }
}