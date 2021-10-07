//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Identifies a context-relative scope
    /// </summary>
    public readonly struct Scope
    {
        public readonly uint Depth;

        public readonly Label Name;

        [MethodImpl(Inline)]
        public Scope(uint level, Label name)
        {
            Depth = level;
            Name = name;
        }

        [MethodImpl(Inline)]

        public bool Equals(Scope src)
            => Depth.Equals(src.Depth) && Name.Equals(src.Name);

        public string Format()
            => string.Format("{0,-8} {1}", Depth, Name);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Scope((uint level, Label name) src)
            => new Scope(src.level, src.name);
    }
}