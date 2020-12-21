//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ImageToken : ITextual
    {
        public string Identifier {get;}

        public string Name {get;}

        [MethodImpl(Inline)]
        public ImageToken(string name, string identifier)
        {
            Name = name;
            Identifier = identifier;
        }

        [MethodImpl(Inline)]
        public static implicit operator ImageToken((string name, string id) src)
            => new ImageToken(src.name, src.id);

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}:{1}",Identifier, Name);

        public override string ToString()
            => Format();
    }
}