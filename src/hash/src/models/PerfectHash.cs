//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct PerfectHash<T>
    {
        public T Subject {get;}

        public uint Hash {get;}

        public uint Index {get;}

        [MethodImpl(Inline)]
        public PerfectHash(T src, uint hash, uint index)
        {
            Subject = src;
            Hash = hash;
            Index = index;
        }
    }
}