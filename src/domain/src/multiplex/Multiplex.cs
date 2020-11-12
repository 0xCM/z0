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

        readonly WfHost Host;

        readonly IWfShell Wf;

        public IBuildArchive BuildArchive {get;}

        [MethodImpl(Inline), Op]
        public static MultiplexSettings configure(FS.FolderPath root)
        {
            var settings = new MultiplexSettings();
            settings.DbRoot = root;
            settings.BuildRoot = FS.path(Assembly.GetEntryAssembly().Location).FolderPath;
            return settings;
        }

        [Op]
        public static Multiplex create(IWfShell wf, MultiplexSettings? settings = null)
        {
            var config = settings ?? configure(EnvVars.Common.DbRoot);
            var mpx = new Multiplex(wf, config);
            return mpx;
        }

        internal Multiplex(IWfShell wf, MultiplexSettings settings)
        {

            Host = WfSelfHost.create(typeof(Multiplex));
            Wf = wf.WithHost(Host);
            BuildArchive = BuildArchives.create(wf, settings.BuildRoot);
        }
    }
}