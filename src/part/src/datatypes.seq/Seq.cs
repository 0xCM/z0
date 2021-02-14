//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;
    using static memory;

    [ApiHost(ApiNames.Seq, true)]
    public readonly partial struct Seq
    {
        const NumericKind Closure = UInt64k;

        public static string format<T>(T[] src)
            => delimit(src).Format();
   }
}