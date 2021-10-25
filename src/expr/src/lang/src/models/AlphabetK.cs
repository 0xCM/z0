//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a set of symbols over which strings may be formed
    /// </summary>
    /// <typeparam name="K">The symbol value kind</typeparam>
    public class Alphabet<K>
        where K : unmanaged
    {
        /// <summary>
        /// The name of the alphabet
        /// </summary>
        public Label Name {get;}

        readonly Atoms<K> Data;

        [MethodImpl(Inline)]
        internal Alphabet(Label name, Atom<K>[] src)
        {
            Name = name;
            Data = new Atoms<K>(src);
        }

        public Atom<K> this[uint key]
        {
            [MethodImpl(Inline)]
            get => Data[key];
        }

        /// <summary>
        /// The symbols that comprise the alpabet
        /// </summary>
        public ReadOnlySpan<Atom<K>> Symbols
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public uint MemberCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Members.Length;
        }

        internal Atom<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }
    }
}