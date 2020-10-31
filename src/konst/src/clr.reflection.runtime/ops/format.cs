//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ClrQuery
    {
        [Op]
        public static string format(in MethodSig src)
        {
            var dst = Buffers.text();
            render(src, dst);
            return dst.Emit();
        }

        [Op]
        public static void render(in MethodSig src, ITextBuffer dst)
        {
            dst.Append(src.ReturnType.Format());
            dst.Append(Chars.Space);
            dst.Append(src.MethodName);
            dst.Append(src.ValueParams.Format());
        }
    }
}