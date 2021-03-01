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
    using static memory;

    public class ToolCatalog : WfService<ToolCatalog>
    {
        FS.FolderPath Root;

        protected override void OnInit()
        {
            Root = Wf.Db().ToolCatalogRoot();
        }

        public Index<ToolHelpEntry> UpdateHelpIndex()
        {
            var path = Root + FS.file("help", FS.Extensions.Csv);
            var files = HelpFiles();
            var flow = Wf.EmittingFile(path);
            var count = files.Count;
            var buffer = sys.alloc<ToolHelpEntry>(count);
            var entries = span(buffer);
            var formatter = Records.formatter<ToolHelpEntry>(46);
            using var index = path.Writer();
            index.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count;  i++)
            {
                var file = files[i];
                var components = file.FileName.Format().Split(Chars.Dot);
                ref var entry = ref seek(entries,i);
                entry.Tool = components[0];
                entry.HelpPath = file.ToUri();

                index.WriteLine(formatter.Format(entry));
            }
            Wf.EmittedFile(flow, files.Count);
            return buffer;
        }

        public FS.Files HelpFiles()
            => HelpDir.Files(FS.ext("help"), true);

        [MethodImpl(Inline), Op]
        Toolset Toolset(ToolId id, FS.FolderPath location)
            => new Toolset(id, location);

        public FS.FilePath HelpFile(ToolId tool)
        {
            var match = FS.file(tool.Format());
            return HelpDir.Files(FS.ext("help")).Where(f => f.FileName.WithoutExtension.Equals(match)).FirstOrDefault();
        }

        public bool HasHelp(ToolId tool)
            => HelpFile(tool).Exists;

        public Index<TextLine> HelpText(ToolId tool)
            => HelpFile(tool).ReadTextLines();

        public void Emit(CmdScript script)
        {
            var dst = ToolCmd.enqueue(ToolCmd.job(script.Id, script), Wf.Db());
            var flow = Wf.EmittingFile(dst);
            Wf.EmittedFile(flow, script.Length);
        }

        FS.FolderPath HelpDir
            => Root + FS.folder("help");
    }
}