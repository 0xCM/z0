//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    public interface IArchivedContent
    {
        int Sequence {get;}

        object Content {get;}

    }

    public interface IArchivedContent<T> : IArchivedContent
    {
        new T Content {get;}

        object IArchivedContent.Content
            => Content;
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

    public interface IAsmHostArchive : IAsmService
    {
        IEnumerable<ArchivedContent<AsmCode>> ArchivedCode {get;}
    }
}