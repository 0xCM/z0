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
    using static FixedValues;

    public struct FixedSource<F> : IFixedSource<F>
        where F : struct, IFixed         
    {
        readonly IValueSource Values;

        [MethodImpl(Inline)]
        public FixedSource(IValueSource source)
            => Values = source;

        [MethodImpl(Inline)]
        public F Next()
            => select(w8);
        
        [MethodImpl(Inline)]
        F select(W8 w)
        {
            if(typeof(F) == typeof(Fixed8))
                return pull(w8);
            else if(typeof(F) == typeof(Fixed16))
                return pull(w16);
            else if(typeof(F) == typeof(Fixed32))
                return pull(w32);
            else if(typeof(F) == typeof(Fixed64))
                return pull(w64);
            else
                return select(w128);
        }

        [MethodImpl(Inline)]
        F select(W128 w)
        {
            if(typeof(F) == typeof(Fixed128))
                return pull(w128);
            else if(typeof(F) == typeof(Fixed256))
                return pull(w256);
            else if(typeof(F) == typeof(Fixed512))
                return pull(w512);
            else
                throw Unsupported.define<F>();
        }

        [MethodImpl(Inline)]
        F pull(W8 w) 
            => Fixed(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W16 w) 
            => Fixed(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W32 w) 
            => Fixed(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W64 w) 
            => Fixed(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W128 w) 
            => Fixed(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W256 w) 
            => Fixed(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W512 w) 
            => Fixed(next(Values, w));

        [MethodImpl(Inline)]
        static F Fixed<K>(in K x)        
            where K : struct
                => As.@as<K,F>(ref As.edit(x));        
    }    
}