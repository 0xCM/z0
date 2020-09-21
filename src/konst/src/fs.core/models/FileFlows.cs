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
        /// Defines a 1-many FSO flow
        /// </summary>
        public readonly struct FileFlows<S,T>
            where T : struct, IEntry<T>
            where S : struct, IEntry<S>
        {
            public S Source {get;}

            public T[] Targets {get;}


            [MethodImpl(Inline)]
            public FileFlows(S src, T[] dst)
            {
                Source = src;
                Targets = dst;
            }
        }
    }
}