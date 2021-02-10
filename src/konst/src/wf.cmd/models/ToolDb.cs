//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;
    using static Msg;

    [ApiHost]
    public class ToolDb : IToolDb
    {
        readonly IWfShell Wf;

        readonly Toolsets _Toolsets;

        readonly ToolCatalog _Catalog;

        public FS.FolderPath Root {get;}

        public ToolDb(IWfShell wf)
        {
            Wf = wf;
            Root = Wf.Db().ToolDbRoot();
            _Toolsets = toolsets();
            _Catalog = catalog(wf);
        }

        [MethodImpl(Inline), Op]
        public static Toolset toolset(string id, FS.FolderPath location)
            => new Toolset(id, location);

        [MethodImpl(Inline), Op]
        public static ToolCatalog catalog(IWfShell wf)
            => new ToolCatalog(wf.Db().ToolDbRoot());

        public void ListToolHelpFiles()
        {
            root.iter(Catalog.Help(), file => term.print(file));
        }

        public void PrintInfo()
        {
            ListToolHelpFiles();
            ListCommands();
            PrintHelp("llvm-ml");
        }

        public void PrintHelp(ToolId tool)
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

        [Op]
        public static Toolsets toolsets()
        {
            var data = array(
                toolset("Llvm", FS.dir("j:/lang/tools/llvm-project/build/Release/bin")),
                toolset("CoreRoot", FS.dir("j:/lang/net/runtime/artifacts/tests/coreclr/Windows_NT.x64.Debug/Tests/Core_Root")),
                toolset("Msys64", FS.dir("j:/tools/msys64/usr/bin"))
            );
            return new Toolsets(data);
        }

        public ToolCatalog Catalog
        {
            get => _Catalog;
        }

        public void Emit(CmdScript script)
        {
            Wf.EmittedFile(script.GetType(), script.Length, Cmd.enqueue(Cmd.job(script.Id, script), Wf.Db()));
        }

        public ToolHelp Help(ToolId tool)
        {
            var path = _Catalog.Help(tool);
            if(path.IsNonEmpty)
                return new ToolHelp(tool, path.ReadText());
            else
                return ToolHelp.Empty;
        }

        [Op]
        public static void emit(IWfShell wf, CmdScript script)
        {
            wf.EmittedFile(script.GetType(),
                script.Length,
                Cmd.enqueue(Cmd.job(script.Id, script), wf.Db()));
        }
    }
}