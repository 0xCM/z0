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

        readonly KeyedAtomics<K> Data;

        [MethodImpl(Inline)]
        internal Alphabet(Label name, Atom<K>[] src)
        {
            Name = name;
            Data = new KeyedAtomics<K>(src);
        }

        public Atom<K> this[uint key]
        {
            [MethodImpl(Inline)]
            get => Data[key];
        }

        public Atom<K> this[int key]
        {
            [MethodImpl(Inline)]
            get => Data[(uint)key];
        }

        /// <summary>
        /// The symbols that comprise the alpabet
        /// </summary>
        public ReadOnlySpan<Atom<K>> Members
        {
            [MethodImpl(Inline)]
            get => Data.Members;
        }

        public uint MemberCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Members.Length;
        }

        public string Format()
            => lang.format(this);

        public override string ToString()
            => Format();
    }
}