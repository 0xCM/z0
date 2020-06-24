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

    partial struct asci
    {         
        [MethodImpl(Inline)]
        public static AsciContainer<A> contain<A>(A content)
            where A : unmanaged, IAsciSequence
                => new AsciContainer<A>(content);
    }
}