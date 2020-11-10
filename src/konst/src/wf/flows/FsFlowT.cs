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
    /// Defines a homogenous file system object flow
    /// </summary>
    public readonly struct FsFlow<T> : IDataFlow<T>
        where T : struct, IFsEntry<T>
    {
        public T Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public FsFlow(T src, T dst)
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
        public static implicit operator FsFlow<T>((T src, T dst) x)
            => new FsFlow<T>(x.src, x.dst);
    }
}