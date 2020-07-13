//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    


    public interface IPartRecordSpec : ITextual
    {
        PartRecordKind RecordType {get;}   

        byte FieldCount
            => 0;

        ReadOnlySpan<string> HeaderFields 
            => Array.Empty<string>();

        ReadOnlySpan<byte> FieldWidths 
            => Array.Empty<byte>();

        string HeaderText 
            => string.Empty;     

        string ITextual.Format() 
            => RecordType.ToString();
    }

    public interface IPartRecordSpec<R> : IPartRecordSpec
        where R : unmanaged, IPartRecordSpec<R>
    {
        
    }
}