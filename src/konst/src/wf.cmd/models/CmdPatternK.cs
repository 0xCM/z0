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

    public readonly struct CmdPattern<K> : IIdentified<K>
        where K : unmanaged
    {
        public K Id {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public CmdPattern(string content)
        {
            Id = default;
            Content = content;
        }

        [MethodImpl(Inline)]
        public CmdPattern(K id, string content)
        {
            Id = id;
            Content = content;
        }

        public override string ToString()
            => Content ?? EmptyString;

        public override int GetHashCode()
            => Content?.GetHashCode() ?? 0;

        public bool Equals(CmdPattern<K> src)
            => text.equals(Content, src.Content);

        [MethodImpl(Inline)]
        public static implicit operator CmdPattern<K>(string src)
            => new CmdPattern<K>(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdPattern<K> src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator CmdPattern(CmdPattern<K> src)
            => new CmdPattern(src.Id.ToString(), src.Content);

        [MethodImpl(Inline)]
        public static implicit operator CmdPattern<K>(Paired<K,string> src)
            => new CmdPattern<K>(src.Left, src.Right);
    }
}