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
    public readonly struct SymbolicChoices<T>
        where T : unmanaged
    {
        public Index<T> Items {get;}

        [MethodImpl(Inline)]
        public SymbolicChoices(T[] choices)
            => Items = choices;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Items.Count;
        }

        [MethodImpl(Inline)]
        public static implicit operator SymbolicChoices<T>(T[] src)
            => new SymbolicChoices<T>(src);
    }
}