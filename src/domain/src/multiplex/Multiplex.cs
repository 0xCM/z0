//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free,ApiHost]
    public partial class Multiplex
    {
        void OnChange(FsEntry entry, FS.ChangeKind kind)
        {
            Wf.Status(delimit(entry.Name, kind));
        }

        public void monitor(IWfShell wf, params string[] args)
        {
            var path = args.Length != 0 ? FS.dir(args[0]) : wf.Db().Root;
            using var monitor = ArchiveMonitor.create(wf, path, OnChange);
            monitor.Start();
            Console.ReadKey();
        }

        readonly WfHost Host;

        readonly IWfShell Wf;

        public IBuildArchive BuildArchive {get;}

        [MethodImpl(Inline), Op]
        public static MultiplexSettings configure(FS.FolderPath root)
        {
            var settings = new MultiplexSettings();
            settings.DbRoot = root;
            settings.BuildRoot = EnvVars.Common.BuildPubRoot;
            return settings;
        }

        [Op]
        public static Multiplex create(IWfShell wf, MultiplexSettings? settings = null)
        {
            var config = settings ?? configure(EnvVars.Common.DbRoot);
            var mpx = new Multiplex(wf, config);
            return mpx;
        }

        Multiplex(IWfShell wf, MultiplexSettings settings)
        {

            Host = WfSelfHost.create(typeof(Multiplex));
            Wf = wf.WithHost(Host);
            BuildArchive = BuildArchives.create(wf, settings.BuildRoot);
        }
    }
}