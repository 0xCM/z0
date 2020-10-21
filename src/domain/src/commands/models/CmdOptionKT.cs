//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using api = Cmd;

    public struct CmdOption<K,T>
        where K : unmanaged
    {
        public K Kind;

        public T Value;

        [MethodImpl(Inline)]
        public CmdOption(K kind, T value)
        {
            Kind = kind;
            Value = value;
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => api.name(this);
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdOption<K,T>((K kind, T value) src)
            => new CmdOption<K,T>(src.kind, src.value);


        [MethodImpl(Inline)]
        public static implicit operator CmdOption<K,T>(Paired<K,T> src)
            => new CmdOption<K,T>(src.Left, src.Right);
    }
}