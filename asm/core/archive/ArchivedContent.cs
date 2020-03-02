//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ArchivedContent : IArchivedContent<string>
    {
        [MethodImpl(Inline)]
        public static ArchivedContent Define(int seq, string content)
            => new ArchivedContent(seq,content);

        [MethodImpl(Inline)]
        public static ArchivedContent<T> Define<T>(int seq, T content)
            => new ArchivedContent<T>(seq,content);

        [MethodImpl(Inline)]
        ArchivedContent(int seq, string content)
        {
            this.Sequence = seq;
            this.Content = content;
        }

        public int Sequence {get;}

        public string Content {get;}
    }

    public readonly struct ArchivedContent<T> : IArchivedContent<T>
    {
        [MethodImpl(Inline)]
        internal ArchivedContent(int seq, T content)
        {
            this.Sequence = seq;
            this.Content = content;
        }

        public int Sequence {get;}

        public T Content {get;}
    }
}