//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Var
    {
        public readonly Label Name;

        public readonly dynamic Value;

        [MethodImpl(Inline)]
        public Var(Label name, dynamic value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public Var Assign<T>(T src)
            => new Var(Name,src);
    }
}