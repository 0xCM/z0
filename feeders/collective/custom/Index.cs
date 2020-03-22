//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Collective;

    /// <summary>
    /// A default index implementation
    /// </summary>
    public readonly struct Index<T> : IIndex<T>
    {
        readonly T[] content;

        [MethodImpl(Inline)]
        public Index(T[] content)
        {
            this.content = content;
        }
        
        public ref T this[int index]        
        {
            [MethodImpl(Inline)]
            get => ref content[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => content.Length;
        }
    }
}