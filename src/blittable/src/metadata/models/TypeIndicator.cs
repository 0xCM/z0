//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        public readonly struct TypeIndicator
        {
            public text7 Name {get;}

            [MethodImpl(Inline)]
            public TypeIndicator(text7 name)
            {
                Name = name;
            }

            public string Format()
                => format(Name);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator TypeIndicator(text7 name)
                => new TypeIndicator(name);
        }
    }
}