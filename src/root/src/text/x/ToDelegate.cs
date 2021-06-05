//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;

    partial class XText
    {
        [Op]
        public static ParserDelegate ToDelegate(this ITextParser parser)
        {
            Outcome parse(string src, out dynamic dst)
                => parser.Parse(src, out dst);
            return parse;
        }
    }
}