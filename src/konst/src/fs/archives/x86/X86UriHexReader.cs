//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct X86UriHexReader : IX86UriHexReader<X86UriHexReader,X86UriHex>
    {
        public static IX86UriHexReader Service => default(X86UriHexReader);

        public X86UriHex[] Read(FilePath src)
            => read(src);

        public static X86UriHex[] read(FilePath src)
            => from line in src.ReadLines().Select(X86UriParser.row)
                where line.IsSome()
                select line.Value;
    }
}