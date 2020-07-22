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

    [ApiHost]
    public readonly struct AsciResourceSet
    {        
        [MethodImpl(Inline)]
        public static ByteSize size<A>()
            where A : unmanaged, IAsciSequence
                => (ByteSize)size<A>();

        [MethodImpl(Inline)]
        public static int offset<A>(int index)
            where A : unmanaged, IAsciSequence
                => index*size<A>();

        [MethodImpl(Inline)]
        public static int count<A>(int datasize)
            where A : unmanaged, IAsciSequence
                => datasize/size<A>();

        [MethodImpl(Inline)]
        public static AsciResourceSet<A> load<A>(in asci32 name, ReadOnlySpan<byte> src)
            where A : unmanaged, IAsciSequence
                => new AsciResourceSet<A>(name, src);

        [MethodImpl(Inline)]
        public static AsciResourceSet<A> create<A>(in asci32 name, ReadOnlySpan<string> src)
            where A : unmanaged, IAsciSequence
        {
            var n = (byte)z.size<A>();
            var resDst = span(sys.alloc<byte>(src.Length*n));
            return encode<A>(name, src, resDst, n);
        }

        [MethodImpl(Inline)]
        public static AsciResourceSet<A> create<E,A>()
            where E : unmanaged, Enum
            where A : unmanaged, IAsciSequence
        {
            var n = (byte)z.size<A>();
            asci32 resname = typeof(E).Name;
            var resSrc = @readonly(Enums.names<E>());
            var resDst = span(sys.alloc<byte>(resSrc.Length*n));
            return encode<A>(resname, resSrc, resDst, n);
        }

        [MethodImpl(Inline)]
        public static AsciResourceSet<A> encode<A>(in asci32 name, ReadOnlySpan<string> src, Span<byte> dst, byte n)
            where A : unmanaged, IAsciSequence
        {
            var width = size<A>();
            for(int i=0, j=0; i<src.Length; i++, j+=width)
                encode(src, dst,n,i,j);
            return new AsciResourceSet<A>(name, dst);
        }

        [MethodImpl(Inline), Op]
        public static void encode(ReadOnlySpan<string> resSrc, Span<byte> resDst, byte n, int i, int j)
        {
            var chars = span(skip(resSrc,(uint)i));
            var count = min(chars.Length, n);
            ref readonly var src = ref first(chars);
            ref var dst = ref seek(resDst, (uint)j);
            asci.encode(src, count, ref dst);
        }
    }
}