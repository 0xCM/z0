//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static AsciSequence sequence(byte[] src)
            => new AsciSequence(src);

        [MethodImpl(Inline), Op]
        public static AsciSequence sequence(string src)
        {
            var buffer = z.alloc<byte>(src.Length);
            var seq = new AsciSequence(buffer);
            return encode(src,seq);
        }

        [MethodImpl(Inline), Op]
        public static AsciSequence sequence(string src, byte[] dst)
        {
            encode(src,dst);
            return sequence(dst);
        }

        [MethodImpl(Inline)]
        public static AsciSequence<A> sequence<A>(A content)
            where A : unmanaged, IAsciSequence
                => new AsciSequence<A>(content);
    }
}