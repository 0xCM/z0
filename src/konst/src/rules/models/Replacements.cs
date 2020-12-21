//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Replacements<T> : IIndex<Replacement<T>>
    {
        readonly Index<Replacement<T>> Data;

        public Replacements(Replacement<T>[] src)
            => Data = src;

        public Replacement<T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator Replacements<T>(Replacement<T>[] src)
            => new Replacements<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Replacement<T>[](Replacements<T> src)
            => src.Storage;
    }
}