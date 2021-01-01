//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ClrQuery
    {
        [Op]
        public static string format(in MethodMetadata src)
        {
            var dst = Buffers.text();
            format(src, dst);
            return dst.Emit();
        }

        [Op]
        public static void format(in MethodMetadata src, ITextBuffer dst)
        {
            dst.Append(src.ReturnType.Format());
            dst.Append(Chars.Space);
            dst.Append(src.MethodName);
            dst.Append(src.ValueParams.Format());
        }
    }
}