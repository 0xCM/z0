//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Resources
    {
        [MethodImpl(Inline)]
        public static ByteSize size<A>()
            where A : unmanaged, IBytes
                => (ByteSize)size<A>();

        [MethodImpl(Inline)]
        public static int offset<A>(int index)
            where A : unmanaged, IBytes
                => index*size<A>();

        [MethodImpl(Inline)]
        public static int count<A>(int datasize)
            where A : unmanaged, IBytes
                => datasize/size<A>();

        [MethodImpl(Inline)]
        public static ResourceSet<A> load<A>(in asci32 name, ReadOnlySpan<byte> src)
            where A : unmanaged, IBytes
                => new ResourceSet<A>(name, src);

        [MethodImpl(Inline)]
        public static ResourceSet<A> create<A>(in asci32 name, ReadOnlySpan<string> src)
            where A : unmanaged, IBytes
        {
            var n = (byte)z.size<A>();
            var resDst = span(sys.alloc<byte>(src.Length*n));
            return encode<A>(name, src, resDst, n);
        }

        [MethodImpl(Inline)]
        public static ResourceSet<A> create<E,A>()
            where E : unmanaged, Enum
            where A : unmanaged, IBytes
        {
            var n = (byte)z.size<A>();
            asci32 resname = typeof(E).Name;
            var resSrc = @readonly(Enums.names<E>());
            var resDst = span(sys.alloc<byte>(resSrc.Length*n));
            return encode<A>(resname, resSrc, resDst, n);
        }
    }
}