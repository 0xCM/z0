//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class gvec
    {
        public static string fPerm2x128<T>(Vector512<T> src, Perm2x4 p0, Perm2x4 p1)
            where T : unmanaged
        {
            var sfk = SequenceFormatKind.List;
            var sep = Chars.Comma;
            var pad = 2;
            var sym0 = Permute.symbols(p0).ToString();
            var sym1 = Permute.symbols(p1).ToString();
            var description = $"{src.Format()} |> {sym0}{sym1} = {gvec.vperm2x128(src, p0, p1).Format()}";
            return description;
        }
    }
}