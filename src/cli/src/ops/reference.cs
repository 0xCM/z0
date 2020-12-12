//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static z;

    partial struct Cli
    {
        public static CmdResult[] EmitCilTableDocs(IWfShell wf, params FS.FilePath[] paths)
        {
            var count = paths.Length;
            var buffer = sys.alloc<CmdResult>(count);
            ref var dst = ref first(buffer);
            ref readonly var source = ref first(paths);
            for(var i=0; i<count; i++)
                seek(dst,i) = EmitCilTableDoc(wf, skip(source,i));
            return buffer;
        }

        public static CmdResult EmitCilTableDoc(IWfShell wf, FS.FilePath src)
        {
            var cmd = new EmitCliTableDocCmd();
            var dstfile = FS.file($"{src.FileName.WithoutExtension}.metadata.cli");
            var dstdir = wf.Db().Output(new ToolId("ztool"), cmd.Id()).Create();
            cmd.Source = src;
            cmd.Target = dstdir + dstfile;
            return wf.Router.Dispatch(cmd);
        }

        public static CmdResult EmitCilTableDoc(IWfShell wf, Assembly src)
            => EmitCilTableDoc(wf, FS.path(src.Location));

        /// <summary>
        /// Defines an <see cref='CliArtfactRef'/> predicated on an a <see cref='CliArtifactKey'/>
        /// </summary>
        /// <param name="src">The defining type</param>
        [MethodImpl(Inline), Op]
        public static CliArtifactRef reference(CliArtifactKey id, ClrArtifactKind kind, StringRef name)
            => new CliArtifactRef(id,kind,name);
    }
}