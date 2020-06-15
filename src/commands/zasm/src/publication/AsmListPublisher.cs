//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static AsmDataModels;
    
    public interface IAsmListPublisher
    {
        void Publish();
    }
        
    public readonly struct AsmListPublisher : IAsmListPublisher, IAsmArchiveConfig
    {
        public static IAsmListPublisher Service => default(AsmListPublisher);

        static IListPublisher LP 
            => Publications.Publishers.ListPubliser;
        
        static RecordPublisher RP 
            => Publications.Publishers.RecordPubliser;
        
        public void Publish()
        {

        }

        public void PublishList<E>(Dictionary<string,E> src, string name)
            where E : unmanaged, Enum
                => LP.PublishList(src,name);

        public void PublishList<E>()
            where E : unmanaged, Enum
                => LP.PublishList<E>();

        public void Publish(OperandCounts model, OperandCountRecord[] src)
            => RP.Publish(model,OperandCountField.Sequence, src, Chars.Pipe);
    }
}