//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiSection : IApiSection
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public ApiSection(string name)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => Name ?? EmptyString;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ApiSection(string name)
            => new ApiSection(name);
    }
}