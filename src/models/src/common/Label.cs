//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Label
    {
        public readonly ulong Value;

        [MethodImpl(Inline)]
        public Label(ulong value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Label(ulong value)
            => new Label(value);
    }
}