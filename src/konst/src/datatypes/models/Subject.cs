//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Subject : ISubject
    {
        public string Id {get;}

        [MethodImpl(Inline)]
        public Subject(string src)
            => Id = src;

        [MethodImpl(Inline)]
        public string Format()
            => Id;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Subject(string src)
            => new Subject(src);
    }
}