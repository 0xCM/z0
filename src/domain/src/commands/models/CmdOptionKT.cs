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

    public readonly struct CmdOption<K,T> : ITextual
        where K : unmanaged
    {
        public K Kind {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public CmdOption(K kind, T value)
        {
            Kind = kind;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdOption<K,T>((K kind, T value) src)
            => new CmdOption<K,T>(src.kind, src.value);

        public string Format()
            => Render.setting(Kind, Value);
    }
}