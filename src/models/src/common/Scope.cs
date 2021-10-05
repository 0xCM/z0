//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Scope
    {
        public readonly ulong Level;

        public readonly Label Name;

        [MethodImpl(Inline)]
        public Scope(ulong level, Label name)
        {
            Level = level;
            Name = name;
        }


        [MethodImpl(Inline)]

        public bool Equals(Scope src)
            => Level.Equals(src.Level) && Name.Equals(src.Name);

        public string Format()
            => string.Format("{0,-8} {1}", Level, Name);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Scope((ulong level, Label name) src)
            => new Scope(src.level, src.name);
    }
}