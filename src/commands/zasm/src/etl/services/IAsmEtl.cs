//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    using static Seed;
    using static AsmDataModels;

    public interface IAsmEtl : IService, IAsmArchiveConfig
    {
         AsmPublication<OpCodeFormRecord> Publish(OpCodes model);

         AsmPublication<InstructionRecord> Publish(Instructions model);

        Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum;        

        void PublishLiterals();

        void PublishLists();

        void PublishOpCodeInfo();
    }

}
