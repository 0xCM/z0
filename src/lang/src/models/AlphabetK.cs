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
        readonly SymbolSet<K> Data;

        /// <summary>
        /// The name of the alphabet
        /// </summary>
        public Label Name {get;}

        [MethodImpl(Inline)]
        internal Alphabet(Label name, Symbol<K>[] src)
        {
            Name = name;
            Data = new SymbolSet<K>(src);
        }

        public Symbol<K> this[uint key]
        {
            [MethodImpl(Inline)]
            get => Data[key];
        }

        /// <summary>
        /// The symbols that comprise the alpabet
        /// </summary>
        public ReadOnlySpan<Symbol<K>> Symbols
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public uint MemberCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Members.Length;
        }

        internal Symbol<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }
    }
}