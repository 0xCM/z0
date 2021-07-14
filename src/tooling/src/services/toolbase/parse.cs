//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class ToolBase
    {
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