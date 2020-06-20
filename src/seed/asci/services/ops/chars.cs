//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    partial struct asci
    {    
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> chars<A>(in A src)
            where A : unmanaged, IAsciSequence
                => chars(n2, src);
        
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars<A>(N2 n, in A src)
            where A : unmanaged, IAsciSequence
        {
            if(typeof(A) == typeof(asci2))
                return decode(cast(n2,src));
            else if(typeof(A) == typeof(asci4))
                return decode(cast(n4,src));
            else if(typeof(A) == typeof(asci8))
                return decode(cast(n8,src));
            else if(typeof(A) == typeof(asci16))
                return decode(cast(n16,src));
            else                
                return chars(n32, src);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars<A>(N32 n, in A src)
            where A : unmanaged, IAsciSequence
        {
            if(typeof(A) == typeof(asci32))
                return decode(cast(n32,src));
            else if(typeof(A) == typeof(asci64))
                return decode(cast(n64,src));
            else
                return ReadOnlySpan<char>.Empty;
        }
    }
}