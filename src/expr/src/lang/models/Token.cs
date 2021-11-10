//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Token : IExpr
    {
        public uint Key {get;}

        readonly Index<Atom> Data;

        [MethodImpl(Inline)]
        public Token(uint key, Atom[] src)
        {
            Key = key;
            Data = src;
        }


        public Index<Atom> Value
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        public ref Atom this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref Atom this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public string Format()
            => lang.format(this);

        public override string ToString()
            => Format();
    }
}