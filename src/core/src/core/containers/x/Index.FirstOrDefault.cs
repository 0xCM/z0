//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public static class XIndex
    {
        const NumericKind Closure = UInt64k | UInt8k;

        [MethodImpl(Inline)]
        public static T FirstOrDefault<T>(this Index<T> src, T @default = default)
            => Index.firstOrDefault(src, @default);
    }
}