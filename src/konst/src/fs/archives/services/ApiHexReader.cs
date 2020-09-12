//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct ApiHexReader : IApiHexReader<ApiHexReader,X86UriHex>
    {
        public static IApiHexReader Service => default(ApiHexReader);

        public X86UriHex[] Read(FilePath src)
            => read(src);

        public static X86UriHex[] read(FilePath src)
            => from line in src.ReadLines().Select(X86UriParser.row)
                where line.IsSome()
                select line.Value;
    }
}