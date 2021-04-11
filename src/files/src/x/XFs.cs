//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public static partial class XFs
    {
        [Op]
        public static string Format(this FileKind src)
            => SymCache<FileKind>.get()[src].Expr.Format();
    }
}