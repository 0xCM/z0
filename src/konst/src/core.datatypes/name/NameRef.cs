//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct NameRef : INamed<NameRef>
    {
        public StringRef Name {get;}

        [MethodImpl(Inline)]
        public static NameRef From(string src)
            => new NameRef(src);

        [MethodImpl(Inline)]
        public static implicit operator string(NameRef src)
            => src.Name;

        [MethodImpl(Inline)]
        public static implicit operator NameRef(string src)
            => From(src);

        [MethodImpl(Inline)]
        public NameRef(string src)
            => Name = src;

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}