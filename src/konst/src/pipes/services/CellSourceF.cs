//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static CellSource;

    public struct CellSource<F> : ICellValues<F>
        where F : struct, IDataCell
    {
        readonly ISource Values;

        [MethodImpl(Inline)]
        public CellSource(ISource source)
            => Values = source;

        [MethodImpl(Inline)]
        public F Next()
            => select(w8);

        [MethodImpl(Inline)]
        F select(W8 w)
        {
            if(typeof(F) == typeof(Cell8))
                return pull(w8);
            else if(typeof(F) == typeof(Cell16))
                return pull(w16);
            else if(typeof(F) == typeof(Cell32))
                return pull(w32);
            else if(typeof(F) == typeof(Cell64))
                return pull(w64);
            else
                return select(w128);
        }

        [MethodImpl(Inline)]
        F select(W128 w)
        {
            if(typeof(F) == typeof(Cell128))
                return pull(w128);
            else if(typeof(F) == typeof(Cell256))
                return pull(w256);
            else if(typeof(F) == typeof(Cell512))
                return pull(w512);
            else
                throw no<F>();
        }

        [MethodImpl(Inline)]
        F pull(W8 w) => cell(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W16 w) => cell(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W32 w) => cell(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W64 w) => cell(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W128 w) => cell(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W256 w) => cell(next(Values, w));

        [MethodImpl(Inline)]
        F pull(W512 w) => cell(next(Values, w));

        [MethodImpl(Inline)]
        static F cell<K>(in K x)
            where K : struct
                => @as<K,F>(x);
    }
}