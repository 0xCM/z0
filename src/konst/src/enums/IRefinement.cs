//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IRefinement<V> : ITextual
        where V : unmanaged, Enum
    {
        EnumScalarKind Kind => Enums.kind<V>();
    }
    
    public interface IRefinement<V,T> : IRefinement<V>
        where V : unmanaged, Enum
        where T : unmanaged
    {

    }

    public interface IRefinement<F,E,T> : IRefinement<E,T>, INullary<F>, IEquatable<F>
        where F : unmanaged, IRefinement<F,E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        F INullary<F>.Zero => default(F);
    }
}