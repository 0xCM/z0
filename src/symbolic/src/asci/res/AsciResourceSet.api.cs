//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    [ApiHost]
    public readonly struct AsciResourceSet
    {
        public static AsciResourceSet Service => default;
        
        [MethodImpl(Inline)]
        public static byte EntrySize<A>()
            where A : unmanaged, IAsciSequence
                => (byte)Root.size<A>();

        [MethodImpl(Inline)]
        public static int EntryOffset<A>(int index)
            where A : unmanaged, IAsciSequence
                => index*EntrySize<A>();

        [MethodImpl(Inline)]
        public static int EntryCount<A>(int datasize)
            where A : unmanaged, IAsciSequence
                => datasize/EntrySize<A>();

        [MethodImpl(Inline), Op]
        public AsciResourceSet<asci2> Perm2x4Names()
            => Create<Perm2x4,asci2>();

        [MethodImpl(Inline), Op]
        public AsciResourceSet<asci4> HexKindNames()
            => Create<HexKind,asci4>();

        [MethodImpl(Inline), Op]
        public AsciResourceSet<asci8> Blend8x16Names()
            => Create<Blend8x16,asci8>();

        [MethodImpl(Inline)]
        public AsciResourceSet<A> Load<A>(in asci32 name, ReadOnlySpan<byte> src)
            where A : unmanaged, IAsciSequence
                => new AsciResourceSet<A>(name, src);

        [MethodImpl(Inline)]
        public AsciResourceSet<A> Create<A>(in asci32 name, ReadOnlySpan<string> src)
            where A : unmanaged, IAsciSequence
        {
            var n = (byte)size<A>();
            var resDst = span(alloc<byte>(src.Length*n));
            return Encode<A>(name, src, resDst, n);
        }

        [MethodImpl(Inline)]
        public AsciResourceSet<A> Create<E,A>()
            where E : unmanaged, Enum
            where A : unmanaged, IAsciSequence
        {
            var n = (byte)size<A>();
            asci32 resname = typeof(E).Name;
            var resSrc = @readonly(Enums.names<E>());
            var resDst = span(alloc<byte>(resSrc.Length*n));
            return Encode<A>(resname, resSrc, resDst, n);
        }

        [MethodImpl(Inline)]
        public AsciResourceSet<A> Encode<A>(in asci32 name, ReadOnlySpan<string> src, Span<byte> dst, byte n)
            where A : unmanaged, IAsciSequence
        {
            var width = size<A>();
            for(int i=0, j=0; i<src.Length; i++, j+=width)
                Encode(src, dst,n,i,j);
            return new AsciResourceSet<A>(name, dst);
        }

        [MethodImpl(Inline), Op]
        public void Encode(ReadOnlySpan<string> resSrc, Span<byte> resDst, byte n, int i, int j)
        {
            var chars = span(skip(resSrc,i));
            var count = min(chars.Length, n);
            ref readonly var src = ref head(chars);
            ref var dst = ref seek(resDst, j);
            asci.encode(src, count, ref dst);
        }
    }
}