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
    public readonly struct Addresses
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static AddressBox<T> box<T>(T @base, ByteSize size)
            where T : unmanaged, IAddress<T>
                => new AddressBox<T>(@base, size);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool contains<T>(AddressBox<T> src, T address)
            where T : unmanaged, IAddress<T>
        {
            var a = uint64(address.Location);
            var @base = uint64(src.Base);
            if(a < @base)
                return false;
            var max = @base + src.Size;
            return a <= max;
        }
    }
}