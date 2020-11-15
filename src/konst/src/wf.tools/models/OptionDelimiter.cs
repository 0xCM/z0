//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = Tooling;

    [DataType]
    public readonly struct OptionDelimiter
    {
        internal readonly AsciCharCode C0;

        internal readonly AsciCharCode C1;

        [MethodImpl(Inline)]
        internal OptionDelimiter(AsciCharCode c0)
        {
            C0 = c0;
            C1 = AsciCharCode.Null;
        }

        [MethodImpl(Inline)]
        internal OptionDelimiter(AsciCharCode c0, AsciCharCode c1)
        {
            C0 = c0;
            C1 = c1;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => C0 == AsciCharCode.Null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => C0 != AsciCharCode.Null;
        }

        public byte Length
        {
            [MethodImpl(Inline)]
            get => IsEmpty ? 0 : (C1 == AsciCharCode.Null ? 1 : 2);
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public static OptionDelimiter Empty => default;
    }
}