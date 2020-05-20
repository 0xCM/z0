//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;

    public interface IDataPublisher
    {
        void PublishList<E>()
            where E : unmanaged, Enum;

        void Save<M,F,R>(M model, F rep, R[] src, char delimiter)
            where M : IAsmDataModel
            where R : IRecord
            where F : unmanaged, Enum;

        LiteralRecord[] PublishLiterals<E>(out FilePath dst)
            where E : unmanaged, Enum;
            
        Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum;            

        LiteralRecord[] LiteralRecords<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum;            
    }    
}