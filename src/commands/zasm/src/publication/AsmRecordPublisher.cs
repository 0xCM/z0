//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using F = LiteralTableField;
    using T = LiteralRecord;

    public readonly struct AsmRecordPublisher : IRecordPublisher, IAsmArchiveConfig
    {
        public static AsmRecordPublisher Service => default(AsmRecordPublisher);
        
        static LiteralPublisher LP => Publications.Publishers.LiteralPublisher;

        static RecordPublisher RP => Publications.Publishers.RecordPubliser;

        static ListPublisher ListP => Publications.Publishers.ListPubliser;
        
        public string DescribeLiteral<E>(E literal)
            where E : unmanaged, Enum
        {            
            var info = CommentAttribute.GetDocumentation(typeof(E).Field(literal.ToString()).Require());
            return info ?? string.Empty;
        }

        public Report<F,T> LiteralReport<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum            
                => LP.LiteralReport<E>(declarer,descriptor);

        public Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum
                => LP.PublishLiterals<E>();

        public LiteralRecord[] PublishLiterals<E>(out FilePath dst)
            where E : unmanaged, Enum
                => LP.PublishLiterals<E>(out dst);

        public LiteralRecord[] LiteralRecords<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum
                => LP.LiteralRecords<E>(declarer, descriptor);
        
        public void PublishList<E>(Dictionary<string,E> src, string name)
            where E : unmanaged, Enum
            => ListP.PublishList(src,name);
 
        public void PublishList<E>()        
            where E : unmanaged, Enum
                => ListP.PublishList<E>();
 
        public void Publish<M,F,R>(M model, F rep, R[] src, char delimiter)
            where M : IDataModel
            where R : IRecord
            where F : unmanaged, Enum
                => RP.Publish(model,rep,src,delimiter); 
    }
}