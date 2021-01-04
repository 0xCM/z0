//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a heap index
    /// </summary>
    /// <remarks>
    /// Conceptually, this sort of type is analagous to a non-parametric abstract base class that,
    /// when closed over a constraint-satisfying parameter, becomes a distinct concrete type.
    /// The closure itself is analagous to a concrete subtype of an abstract base class
    /// </remarks>
    public readonly struct HeapIndex<T> : IHeapIndex<T,HeapIndex<T>>
        where T : unmanaged, IHeapIndexKind<T>
    {
        public uint Value {get;}

        public HeapIndexKind Classifier
            => default(T).Classifier;

        [MethodImpl(Inline)]
        public HeapIndex(uint offset)
            => Value = offset;
    }
}