//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Publications
    {
        public static Publishers Publishers => default;                

        public static IPublicationArchive Archive 
            => PublicationArchive.Default;

        [MethodImpl(Inline)]
        public static Publication<R> Flow<R>(R[] src, FilePath dst)
            where R : ITabular
                => new Publication<R>(src,dst);

        public static ListPublisher ListPubliser
        {
            [MethodImpl(Inline)]
            get => Z0.ListPublisher.Service;
        }

        public static LiteralPublisher LiteralPublisher
        {
            [MethodImpl(Inline)]
            get => Z0.LiteralPublisher.Service;
        }

        public static RecordPublisher RecordPubliser
        {
            [MethodImpl(Inline)]
            get => Z0.RecordPublisher.Service;
        }
    }   
}