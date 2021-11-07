//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// A terminal atomic
    /// </summary>
    public readonly struct Atom : ISymbol<Atom,char>, ITerminalExpr<char>
    {
        public char Value {get;}

        [MethodImpl(Inline)]
        public Atom(char value)
        {
            Value = value;
        }

        public uint Key
        {
            [MethodImpl(Inline)]
            get => (uint)Value;
        }

        [MethodImpl(Inline)]

        public bool Equals(Atom src)
            => src.Value == Value;

        [MethodImpl(Inline)]
        public int CompareTo(Atom src)
            => Value.CompareTo(src.Value);

        public string Format()
            => Value.ToString();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Key;

        public override bool Equals(object src)
            => src is Atom a && Equals(a);

        [MethodImpl(Inline)]
        public static bool operator ==(Atom a, Atom b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(Atom a, Atom b)
            => !a.Equals(b);

        public static Atom Empty => default;

        [MethodImpl(Inline)]
        public static implicit operator char(Atom src)
            => src.Value;
    }
}