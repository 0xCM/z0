//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class XedConst
    {
        [Op]
        public static string Name(XedExtension src)
            => src.ToString().Remove("XED_EXTENSION_");

        [Op]
        public static string Name(XedCategory src)
            => src.ToString().Remove("XED_CATEGORY_");
    }
}