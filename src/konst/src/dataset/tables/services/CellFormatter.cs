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
    using static CellFormatter;

    public readonly struct CellFormatter
    {
        public delegate T RenderFunction<S,T>(in S src);
    }
    
    public readonly struct CellFormatter<S,T> : ICellFormatter<S,T>
    {        
        readonly T[] Buffer;
        
        readonly RenderFunction<S,T> Fx;
        
        [MethodImpl(Inline)]
        public CellFormatter(RenderFunction<S,T> f)
        {
            Fx = f;
            Buffer = sys.alloc<T>(1);
        }
        
        [MethodImpl(Inline)]
        public ref readonly T Format(in S src)
        {
             ref var dst = ref first(span(Buffer));
             dst = Fx(src);
             return ref dst;
        }
    }    
}