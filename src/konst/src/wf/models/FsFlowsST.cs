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
    /// Defines a 1-many FSO flow
    /// </summary>
    public readonly struct FsFlows<S,T>
        where T : struct, IFsEntry<T>
        where S : struct, IFsEntry<S>
    {
        public S Source {get;}

        public T[] Targets {get;}

        [MethodImpl(Inline)]
        public FsFlows(S src, T[] dst)
        {
            Source = src;
            Targets = dst;
        }
    }
}