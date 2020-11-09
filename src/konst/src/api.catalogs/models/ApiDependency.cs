//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    /// <summary>
    /// Defines an homogenous api dependency
    /// </summary>
    public readonly struct ApiDependency<T>
    {
        public static implicit operator Link<T>(ApiDependency<T> src)
            => src.Arrow;

        readonly Pair<T> Data;

        [MethodImpl(Inline)]
        public ApiDependency(T src, T dst)
            => Data = pair(src,dst);

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