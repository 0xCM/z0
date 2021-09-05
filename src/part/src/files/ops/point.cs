//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static FilePoint point(FS.FilePath path, LineOffset offset)
            => new FilePoint(path,offset);

        [MethodImpl(Inline), Op]
        public static FilePoint point(FS.FilePath path, LineNumber line, uint col)
            => new FilePoint(path, (line,col));

        [Op]
        public static Outcome point(string src, out FilePoint dst)
        {
            var result = Outcome.Failure;
            dst = FilePoint.Empty;
            var parts = text.split(src, Chars.Colon);
            if(parts.Length == 3)
            {
                var _path = path(skip(parts,0));
                result = DataParser.parse(skip(parts,1), out uint line);
                if(result)
                {
                    result = DataParser.parse(skip(parts,2), out uint col);
                    if(result)
                        dst = new FilePoint(_path, (line,col));
                }
            }
            return result;
        }
    }
}
