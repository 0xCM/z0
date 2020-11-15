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

    public readonly struct ToolArg<K,V> : IToolArg<K,V>
        where K : unmanaged
    {
        /// <summary>
        /// The option name
        /// </summary>
        public ToolOption<K> Option {get;}

        /// <summary>
        /// The option value
        /// </summary>
        public V Value {get;}

        [MethodImpl(Inline)]
        public ToolArg(ToolOption<K> option, V value)
        {
            Option = option;
            Value = value;
        }

        [MethodImpl(Inline)]
        public ToolArg(K kind, V value)
        {
            Option = kind;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolArg<K,V>((ToolOption<K> option, V value) src)
            => new ToolArg<K,V>(src.option, src.value);

        [MethodImpl(Inline)]
        public static implicit operator ToolArg<K,V>((K kind, V value) src)
            => new ToolArg<K,V>(src.kind, src.value);

        [MethodImpl(Inline)]
        public static implicit operator ToolArg<K,V>(Paired<K,V> src)
            => new ToolArg<K,V>(src.Left, src.Right);
    }
}