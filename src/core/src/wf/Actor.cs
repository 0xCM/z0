//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Actor : IActor
    {
        public readonly StringAddress Name;

        [MethodImpl(Inline)]
        public Actor(string name)
        {
            Name = name;
        }

        [MethodImpl(Inline)]
        public Actor(StringAddress name)
        {
            Name = name;
        }

        string IActor.Name
            => Name.Format();

        [MethodImpl(Inline)]
        public string Format()
            => Name.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Actor(string name)
            => new Actor(name);
    }
}