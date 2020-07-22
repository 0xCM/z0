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
            => new AsciSequence(src, asci.length(src));

        [MethodImpl(Inline)]
        public static AsciSequence<A> contain<A>(A content)
            where A : unmanaged, IAsciSequence
                => new AsciSequence<A>(content);
    }
}