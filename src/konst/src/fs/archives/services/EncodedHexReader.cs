//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public readonly struct EncodedHexReader : IEncodedHexReader<EncodedHexReader,IdentifiedCode>
    {
        public static IEncodedHexReader Service => default(EncodedHexReader);

        public IdentifiedCode[] Read(FilePath src)
            => read(src);

        public static IdentifiedCode[] read(FilePath src)
            => from line in src.ReadLines().Select(IdentifiedCodeParser.row)
                where line.IsSome()
                select line.Value;
    }
}