//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Text;

    using static Konst;
 
    public readonly struct DataPublisher
    {
        public static DataPublisher Service => default;
        
        public Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum
                => LiteralPublisher.Service.PublishLiterals<E>();

        public LiteralRecord[] PublishLiterals<E>(out FilePath dst)
            where E : unmanaged, Enum
                => LiteralPublisher.Service.PublishLiterals<E>(out dst);

        public LiteralRecord[] LiteralRecords<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum
                => LiteralPublisher.Service.LiteralRecords<E>(declarer, descriptor);
        
        public void PublishList<E>(Dictionary<string,E> src, string name)
            where E : unmanaged, Enum
            => ListPublisher.Service.PublishList(src,name);
 
        public void PublishList<E>()        
            where E : unmanaged, Enum
                => ListPublisher.Service.PublishList<E>();
 
        public void PublishRecords<M,F,R>(M model, F rep, R[] src, char delimiter)
            where M : IDataModel
            where R : IRecord
            where F : unmanaged, Enum
                => RecordPublisher.Service.Publish(model,rep,src,delimiter);                 
    }
}