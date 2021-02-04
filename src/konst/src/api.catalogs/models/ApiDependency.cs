//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an homogenous api dependency
    /// </summary>
    public readonly struct ApiDependency<T>
    {
        readonly Pair<T> Data;

        [MethodImpl(Inline)]
        public ApiDependency(T src, T dst)
            => Data = root.pair(src,dst);

        public T Source
        {
            [MethodImpl(Inline)]
            get => Data.Left;
        }

        public T Target
        {
            [MethodImpl(Inline)]
            get => Data.Right;
        }

        public Link<T> Arrow
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Arrow.Format();

        public override string ToString()
            => Format();
    }
}