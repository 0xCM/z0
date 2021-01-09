//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static Part;

    partial struct FS
    {
        public static PartId part(FileName src)
        {
            var i = src.Name.Text.IndexOf(Chars.Dot);
            if(i == NotFound)
                return default;
            else
                return ApiPartIdParser.single(Z0.text.segment(src.Name.Text,0, i - 1));
        }
    }
}