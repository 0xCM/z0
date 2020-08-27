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
        public static ReadOnlySpan<AsciCharCode> codes<A>(in A src)
            where A : unmanaged, IAsciSequence
                => codes(n2, src);
        
        [MethodImpl(Inline)]
        static ReadOnlySpan<AsciCharCode> codes<A>(N2 n, in A src)
            where A : unmanaged, IAsciSequence
        {
            if(typeof(A) == typeof(asci2))
                return z.recover<AsciCharCode>(cast(n2,src).View);
            else if(typeof(A) == typeof(asci4))
                return z.recover<AsciCharCode>(cast(n4,src).View);
            else if(typeof(A) == typeof(asci8))
                return z.recover<AsciCharCode>(cast(n8,src).View);
            else if(typeof(A) == typeof(asci16))
                return z.recover<AsciCharCode>(cast(n16,src).View);
            else                
                return codes(n32, src);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<AsciCharCode> codes<A>(N32 n, in A src)
            where A : unmanaged, IAsciSequence
        {
            if(typeof(A) == typeof(asci32))
                return z.recover<AsciCharCode>(cast(n32,src).View);
            else if(typeof(A) == typeof(asci64))
                return z.recover<AsciCharCode>(cast(n64,src).View);
            else
                return ReadOnlySpan<AsciCharCode>.Empty;
        }
    }
}