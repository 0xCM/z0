//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an enum-predicated numeric refinement
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    public interface IRefinement<E> : ITextual
        where E : unmanaged, Enum, IEquatable<E>
    {
        EnumLiteralKind Kind
            => Literals.kind<E>();
    }

    public interface IRefinement<E,T> : IRefinement<E>
        where E : unmanaged, Enum, IEquatable<E>
        where T : unmanaged
    {

    }

    public interface IRefinement<F,E,T> : IRefinement<E,T>, INullary<F>, IEquatable<F>
        where F : unmanaged, IRefinement<F,E,T>
        where E : unmanaged, Enum, IEquatable<E>
        where T : unmanaged
    {
        F INullary<F>.Zero
            => default(F);
    }
}