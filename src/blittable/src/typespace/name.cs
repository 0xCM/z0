//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types
{
    using System.Runtime.CompilerServices;

    using Z0;
    using static Z0.Root;

    public struct name
    {
        public StringAddress<N64> Value;

        [MethodImpl(Inline)]
        public name(StringAddress<N64> src)
        {
            Value = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator name(StringAddress<N64> src)
            => new name(src);

        public string Format()
            => Value.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator name(string src)
            => new name(src);
    }
}