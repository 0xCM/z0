//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static PartRecords;

    public interface IPartReader : IServiceAllocation
    {        
        ReadOnlySpan<R> Read<R>()
            where R : struct, IPartRecord;
                                
        ReadOnlySpan<StringValueRecord> ReadStrings();

        ReadOnlySpan<StringValueRecord> ReadUserStrings();

        ReadOnlySpan<BlobRecord> ReadBlobs();

        ReadOnlySpan<ConstantRecord> ReadConstants();

        ReadOnlySpan<FieldRecord> ReadFields();
        
    }
}