//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct SymbolStores
    {
        static int SegCount;

        const NumericKind Closure = UnsignedInts;

        [Op, Closures(UInt64k)]
        public static SymStore<T> create<T>(ushort capacity)
            => new SymStore<T>((ushort)inc(ref SegCount), alloc<T>(capacity));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static bit deposit<T>(in T src, ref SymStore<T> dst, out SymRef s)
            => dst.Deposit(src, out s);
    }
}