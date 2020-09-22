//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct ApiHexReader : IApiHexReader
    {
        public static IApiHexReader Service => default(ApiHexReader);

        public ApiCodeBlock[] Read(FilePath src)
            => read(src);

        public static ApiCodeBlock[] read(FilePath src)
            => from line in src.ReadLines().Select(ApiHexParser.row)
                where line.IsSome()
                select line.Value;

        public static ApiCodeBlock[] read(FS.FilePath src)
            => from line in src.ReadLines().Select(ApiHexParser.row)
                where line.IsSome()
                select line.Value;

    }
}