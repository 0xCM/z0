//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;
    using static core;

    partial struct Tables
    {
        public static Outcome list(FS.FilePath src, out ListItem[] dst)
        {
            dst = array<ListItem>();
            var count = FS.linecount(src);
            using var reader = src.Utf8LineReader();
            if(reader.Next(out var line))
            {
                var content = line.Content;
                if(content.Split(Chars.Pipe).Length < 3)
                    return (false, AppMsg.FieldCountMismatch.Format(0,3));

                var j=0;
                dst = alloc<ListItem>(count.Lines - 1);
                while(reader.Next(out line))
                {
                    var result = ListItems.parse(line.Content, out seek(dst,j++));
                    if(result.Fail)
                        return result;
                }
            }
            return true;
        }
    }
}