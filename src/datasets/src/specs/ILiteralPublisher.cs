//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public interface ILiteralPublisher
    {
        LiteralRecord[] PublishLiterals<E>(out FilePath dst)
            where E : unmanaged, Enum;
            
        Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum;            

        LiteralRecord[] LiteralRecords<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum;            

        Report<LiteralTableField,LiteralRecord> LiteralReport<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum;
    }
}