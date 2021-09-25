//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct HexScalarParser
    {
        public static HexScalarParser Service
            => default(HexScalarParser);

        public ParseResult<ulong> Parse(string src)
            => HexNumericParser.parse64u(src);
    }
}