//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct X86UriHexReader : IApiHexReader
    {
        public static IApiHexReader Service => default(X86UriHexReader);

        public ApiHex[] Read(FilePath src)
            => read(src);

        public static ApiHex[] read(FilePath src)
            => from line in src.ReadLines().Select(X86UriParser.row)
                where line.IsSome()
                select line.Value;
    }
}