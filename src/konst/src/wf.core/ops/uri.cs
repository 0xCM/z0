//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    partial struct WfCore
    {
        [Op]
        public static ApiHostUri uri(Type src)
        {
            var typename = src.Name;
            var partName = typename.LeftOfFirst('_');
            var part = ApiPartIdParser.single(partName);
            var host = text.ifempty(typename.RightOfFirst('_'), "anonymous");
            return new ApiHostUri(part, host);
        }
    }
}