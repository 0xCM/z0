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
    /// Defines a sequence of potential choices
    /// </summary>
    public readonly struct Choices<T>
    {
        public Index<T> Terms {get;}

        [MethodImpl(Inline)]
        public Choices(T[] choices)
        {
            Terms = choices;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Terms.Count;
        }

        [MethodImpl(Inline)]
        public static implicit operator Choices<T>(T[] src)
            => new Choices<T>(src);
    }
}