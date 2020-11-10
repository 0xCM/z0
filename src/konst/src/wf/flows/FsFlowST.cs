//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a heterogenous file system object flow
    /// </summary>
    public readonly struct FsFlow<S,T> : IDataFlow<S,T>
        where T : struct, IFsEntry<T>
        where S : struct, IFsEntry<S>
    {
        public S Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public FsFlow(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => string.Format("{0} -> {1}", Source, Target);
        }

        [MethodImpl(Inline)]
        public static implicit operator FsFlow<S,T>((S src, T dst) x)
            => new FsFlow<S,T>(x.src, x.dst);
    }
}