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

    using api = Cmd;

    public struct CmdArg<K,T> : ICmdArg<K,T>
        where K : unmanaged
    {
        public K Kind {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public CmdArg(K kind, T value)
        {
            Kind = kind;
            Value = value;
        }

        public string Key
        {
            [MethodImpl(Inline)]
            get => api.name(this);
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        K ICmdArg<K,T>.Key
            => Kind;

        T ICmdArg<T>.Value
            => Value;

        [MethodImpl(Inline)]
        public static implicit operator CmdArg<K,T>((K kind, T value) src)
            => new CmdArg<K,T>(src.kind, src.value);

        [MethodImpl(Inline)]
        public static implicit operator CmdArg<K,T>(Paired<K,T> src)
            => new CmdArg<K,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator CmdArg(CmdArg<K,T> src)
            => new CmdArg(src.Key, src.Value?.ToString() ?? EmptyString);

        [MethodImpl(Inline)]
        public static implicit operator CmdArg<T>(CmdArg<K,T> src)
            => new CmdArg<T>(src.Key, src.Value);
    }
}