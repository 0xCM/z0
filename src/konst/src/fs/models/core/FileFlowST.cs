//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        /// <summary>
        /// Defines a heterogenous file system object flow
        /// </summary>
        public readonly struct FileFlow<S,T> : IDataFlow<S,T>
            where T : struct, IEntry<T>
            where S : struct, IEntry<S>
        {
            public S Source {get;}

            public T Target {get;}

            [MethodImpl(Inline)]
            public static implicit operator FileFlow<S,T>((S src, T dst) x)
                => new FileFlow<S,T>(x.src, x.dst);

            [MethodImpl(Inline)]
            public FileFlow(S src, T dst)
            {
                Source = src;
                Target = dst;
            }
        }
    }
}