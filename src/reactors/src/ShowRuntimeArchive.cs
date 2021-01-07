//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Part;
    using static z;

    sealed class ShowRuntimeArchive : CmdReactor<ShowRuntimeArchiveCmd, CmdResult>
    {
        protected override CmdResult Run(ShowRuntimeArchiveCmd cmd)
        {
            var archive = Wf.RuntimeArchive();
            iter(archive.DllFiles, f => Wf.Row(f.ToUri()));
            iter(archive.PdbFiles, f => Wf.Row(f.ToUri()));
            iter(archive.XmlFiles, f => Wf.Row(f.ToUri()));
            iter(archive.JsonFiles, f => Wf.Row(f.ToUri()));

            // var archive = RuntimeArchive.create();
            // var resolver = new PathAssemblyResolver(archive.ArchiveFiles().Select(x => x.Name.Text));
            // using var context = new MetadataLoadContext(resolver);
            // iter(archive.ManagedLibraries, path => context.LoadFromAssemblyPath(path.Name));
            // var assemblies = context.GetAssemblies();
            // foreach(var a in assemblies)
            //     Wf.Status(a.GetSimpleName());
            return Cmd.ok(cmd);
        }
    }
}
