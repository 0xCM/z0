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
        /// Defines a homogenous file system object flow
        /// </summary>
        public readonly struct FileFlow<T> : IDataFlow<T>
            where T : struct, IEntry<T>
        {
            public T Source {get;}

            public T Target {get;}

            [MethodImpl(Inline)]
            public static implicit operator FileFlow<T>((T src, T dst) x)
                => new FileFlow<T>(x.src, x.dst);

            [MethodImpl(Inline)]
            public FileFlow(T src, T dst)
            {
                Source = src;
                Target = dst;
            }
        }
    }
}