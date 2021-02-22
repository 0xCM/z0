//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static Msg;

    public class ToolCatalog : WfService<ToolCatalog>
    {
        public FS.FolderPath Root => Wf.Db().ToolCatalogRoot();

        public ToolCatalog()
        {

        }

        public FS.Files Help()
            => HelpDir.Files(FS.ext("help"));

        [MethodImpl(Inline), Op]
        public static Toolset toolset(string id, FS.FolderPath location)
            => new Toolset(id, location);

        public FS.FilePath Help(ToolId tool)
        {
            var match = FS.file(tool.Format());
            var path = HelpDir.Files(FS.ext("help")).Where(f => f.FileName.WithoutExtension.Equals(match)).FirstOrDefault();
            return path;
        }

        public void ListToolHelpFiles()
        {
            root.iter(Help(), file => term.print(file));
        }

        public void ShowHelp(ToolId tool)
        {
            var help = Help(tool);
            if(help.IsEmpty)
                Wf.Warn(ToolHelpNotFound.Format(tool));
            else
                Wf.Row(help);
        }

        public void ListCommands()
        {
            foreach(var a in Wf.Components)
                root.iter(Cmd.search(a), spec => term.print(spec.CmdId));
        }

        public void Emit(CmdScript script)
        {
            var dst = Cmd.enqueue(Cmd.job(script.Id, script), Wf.Db());
            var flow = Wf.EmittingFile(dst);
            Wf.EmittedFile(flow, script.Length);
        }

        FS.FolderPath HelpDir
            => Root + FS.folder("help");
    }
}