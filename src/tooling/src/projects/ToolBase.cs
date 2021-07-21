//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    public sealed partial class ToolBase : Service<ToolBase>, IFileArchive
    {
        const string config = nameof(config);

        const string docs = nameof(docs);

        const string logs = nameof(logs);

        const string scripts = nameof(scripts);

        const string samples = nameof(samples);

        public FS.FolderPath Root {get; private set;}

        Dictionary<ToolId,ToolConfig> ConfigLookup;

        IRecordFormatter<ToolConfig> ConfigFormatter;

        public ToolBase()
        {
            ConfigLookup = dict<ToolId,ToolConfig>();
            ConfigFormatter = Tables.formatter<ToolConfig>();
        }

        [MethodImpl(Inline)]
        internal ToolBase WithRoot(FS.FolderPath root)
        {
            Root = root;
            return this;
        }

        public FS.FolderPath Home(ToolId id)
            => Root + FS.folder(id.Format());

        public FS.FolderPath Docs(ToolId id)
            => Home(id) + FS.folder(docs);

        public FS.FolderPath Logs(ToolId id)
            => Home(id) + FS.folder(logs);

        public FS.FolderPath Scripts(ToolId id)
            => Home(id) + FS.folder(scripts);

        public FS.FolderPath Samples(ToolId id)
            => Home(id) + FS.folder(samples);

        public FS.FilePath Script(ToolId tool, string id)
            => Scripts(tool) + FS.file(id,FS.Cmd);

        public FS.FilePath ConfigScript(ToolId id)
            => Home(id) + FS.file(config, FS.Cmd);

        public FS.FilePath ConfigLog(ToolId id)
            => Logs(id) + FS.file(config, FS.Log);

        public bool Settings(ToolId id, out ToolConfig dst)
            => ConfigLookup.TryGetValue(id, out dst);

        public void Configure(ToolId id, in ToolConfig src)
            => ConfigLookup[id] = src;

        [Op]
        public string FormatSettings(ToolId id)
        {
            if(Settings(id, out var config))
                return ConfigFormatter.Format(config, RecordFormatKind.KeyValuePairs);
            else
                return EmptyString;
        }

        [Op]
        public static Outcome parse(string src, out ToolConfig dst)
        {
            dst = default;
            var result = Outcome.Success;
            var lines = Lines.read(src);
            if(lines.Length < ToolConfig.FieldCount)
                return (false, Tables.FieldCountMismatch.Format(ToolConfig.FieldCount, lines.Length));

            var i=0;
            DataParser.block(skip(lines, i++).Content, out dst.ToolGroup);
            DataParser.parse(skip(lines, i++).Content, out dst.ToolId);
            DataParser.parse(skip(lines, i++).Content, out dst.ToolExe);
            DataParser.parse(skip(lines, i++).Content, out dst.InstallBase);

            DataParser.parse(skip(lines, i++).Content, out dst.ToolPath);
            DataParser.parse(skip(lines, i++).Content, out dst.ToolHome);
            DataParser.parse(skip(lines, i++).Content, out dst.ToolLogs);
            DataParser.parse(skip(lines, i++).Content, out dst.ToolDocs);

            DataParser.parse(skip(lines, i++).Content, out dst.ToolScripts);
            DataParser.parse(skip(lines, i++).Content, out dst.ToolConfigLog);
            DataParser.parse(skip(lines, i++).Content, out dst.ToolCmdLog);
            DataParser.parse(skip(lines, i++).Content, out dst.ToolRunLog);

            return result;
        }
    }
}