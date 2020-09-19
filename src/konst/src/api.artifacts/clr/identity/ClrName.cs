//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ClrName : ITextual
    {
        readonly StringRef Ref;

        [MethodImpl(Inline)]
        public static implicit operator ClrName(string src)
            => new ClrName(src);

        [MethodImpl(Inline)]
        public ClrName(string src)
            => Ref = src;


        [MethodImpl(Inline)]
        public string Format()
            => Ref.Format();
    }
}