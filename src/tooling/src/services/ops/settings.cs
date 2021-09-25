//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    using SQ = SymbolicQuery;
    using SR = SymbolicRender;

    partial class Tooling
    {
        public static Settings settings(FS.FilePath src)
        {
            var dst = list<Setting>();
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                var content = line.Codes;
                var length = content.Length;
                if(length != 0)
                {
                    if(SQ.hash(first(content)))
                        continue;

                    var i = SQ.index(content, Chars.Colon);
                    if(i > 0)
                    {
                        var name = SR.format(SQ.left(content,i));
                        var value = SR.format(SQ.right(content,i));
                        dst.Add(new Setting(name,value));
                    }
                }
            }
            return dst.ToArray();
        }
    }
}