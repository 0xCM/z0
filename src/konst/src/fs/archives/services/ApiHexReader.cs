//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct ApiHexReader : IApiHexReader<ApiHexReader,ApiHex>
    {
        public static IApiHexReader Service => default(ApiHexReader);

        public ApiHex[] Read(FilePath src)
            => read(src);

        public static ApiHex[] read(FilePath src)
            => from line in src.ReadLines().Select(ApiHexParser.row)
                where line.IsSome()
                select line.Value;
    }
}