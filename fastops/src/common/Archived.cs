//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface IArchived
    {
        int Sequence {get;}

        object Content {get;}

    }

    public interface IArchived<T> : IArchived
    {
        new T Content {get;}

        object IArchived.Content
            => Content;
    }

    public readonly struct Archived : IArchived<string>
    {
        [MethodImpl(Inline)]
        public static Archived Define(int seq, string content)
            => new Archived(seq,content);

        [MethodImpl(Inline)]
        public static Archived<T> Define<T>(int seq, T content)
            => new Archived<T>(seq,content);

        [MethodImpl(Inline)]
        Archived(int seq, string content)
        {
            this.Sequence = seq;
            this.Content = content;
        }

        public int Sequence {get;}

        public string Content {get;}
    }

    public readonly struct Archived<T> : IArchived<T>
    {
        [MethodImpl(Inline)]
        internal Archived(int seq, T content)
        {
            this.Sequence = seq;
            this.Content = content;
        }

        public int Sequence {get;}

        public T Content {get;}
    }
}
