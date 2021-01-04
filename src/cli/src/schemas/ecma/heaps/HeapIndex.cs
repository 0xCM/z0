//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct HeapIndexKind<T>
        where T : unmanaged, IHeapIndexKind<T>
    {
        /// <summary>
        /// Classifies the index
        /// </summary>
        public HeapIndexKind Classifier
            => default(T).Classifier;

        /// <summary>
        /// Projects a closed index onto a parametrix index
        /// </summary>
        [MethodImpl(Inline)]
        public static implicit operator HeapIndexKind<T>(T src)
            => default;

        /// <summary>
        /// Projects a parametric index onto the corresponding closure
        /// </summary>
        /// <param name="src">The source index</param>
        [MethodImpl(Inline)]
        public static implicit operator T(HeapIndexKind<T> src)
            => default;

        /// <summary>
        /// Projects a parametric index onto its classifier
        /// </summary>
        /// <param name="src">The source index</param>
        [MethodImpl(Inline)]
        public static implicit operator HeapIndexKind(HeapIndexKind<T> src)
            => src.Classifier;
    }
}