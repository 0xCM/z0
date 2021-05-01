//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static System.StringSplitOptions;

    partial class text
    {
        [Op]
        public static Index<string> split(string src, char sep, bool clean = true)
            => src.Split(sep,  clean ? RemoveEmptyEntries : None);

        [Op]
        public static Index<string> split(string src, string sep, bool clean = true)
            => src.Split(sep, clean ? RemoveEmptyEntries : None);
    }
}