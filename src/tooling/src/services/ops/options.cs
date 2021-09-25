//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;
    using SR = SymbolicRender;

    partial class Tooling
    {
        public static ReadOnlySpan<CmdOptionSpec> options(FS.FilePath src)
        {
            var dst = list<CmdOptionSpec>();
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                var content = line.Codes;
                var i = SQ.index(content, AsciCode.Colon);
                var name = SR.format(SQ.left(content,i)).Trim();
                var desc = SR.format(SQ.right(content,i)).Trim();
                var flag = Cmd.option(name, desc);
                dst.Add(flag);
            }
            return dst.ViewDeposited();
        }
   }
}