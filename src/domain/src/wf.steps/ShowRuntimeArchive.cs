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

    using static Konst;
    using static z;

    [Cmd]
    public struct ShowRuntimeArchiveCmd : ICmdSpec<ShowRuntimeArchiveCmd>
    {

    }

    sealed class ShowRuntimeArchive : CmdReactor<ShowRuntimeArchiveCmd, CmdResult>
    {
        protected override CmdResult Run(ShowRuntimeArchiveCmd cmd)
        {
            var archive = RuntimeArchive.create();
            var resolver = new PathAssemblyResolver(archive.ArchiveFiles().Select(x => x.Name.Text));
            using var context = new MetadataLoadContext(resolver);
            iter(archive.ManagedLibraries, path => context.LoadFromAssemblyPath(path.Name));
            var assemblies = context.GetAssemblies();
            foreach(var a in assemblies)
                Wf.Status(a.GetSimpleName());
            return Cmd.ok(cmd);
        }
    }

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static ShowRuntimeArchiveCmd ShowRuntimeArchive(this ICmdCatalog wf)
            => default;
    }
}
