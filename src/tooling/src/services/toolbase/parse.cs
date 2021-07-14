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
            DataParser.parse(skip(lines,i++).Content, out dst.ToolId);
            DataParser.parse(skip(lines,i++).Content, out dst.ToolExe);
            DataParser.parse(skip(lines,i++).Content, out dst.InstallBase);
            DataParser.parse(skip(lines,i++).Content, out dst.ToolPath);
            DataParser.parse(skip(lines,i++).Content, out dst.ToolHome);
            DataParser.parse(skip(lines,i++).Content, out dst.ToolLogs);
            DataParser.parse(skip(lines,i++).Content, out dst.ToolDocs);
            DataParser.parse(skip(lines,i++).Content, out dst.ToolScripts);
            return result;
        }

    }
}