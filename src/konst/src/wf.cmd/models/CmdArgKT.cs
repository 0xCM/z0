//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Cmd;

    public struct CmdArg<K,T>
        where K : unmanaged
    {
        public K Key {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public CmdArg(K key, T value)
        {
            Key = key;
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdArg<K,T>((K kind, T value) src)
            => new CmdArg<K,T>(src.kind, src.value);

        [MethodImpl(Inline)]
        public static implicit operator CmdArg<K,T>(Paired<K,T> src)
            => new CmdArg<K,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator CmdArg(CmdArg<K,T> src)
            => new CmdArg(src.Key.ToString(), src.Value?.ToString() ?? EmptyString);

        [MethodImpl(Inline)]
        public static implicit operator CmdArg<T>(CmdArg<K,T> src)
            => new CmdArg<T>(src.Key.ToString(), src.Value);
    }
}