//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    public interface IMetadataRecordSpec : ITextual
    {
        MetadataRecordKind RecordType {get;}   

        byte FieldCount => 0;

        ReadOnlySpan<string> HeaderFields => new string[0]{};    

        ReadOnlySpan<byte> FieldWidths => new byte[0]{};

        string HeaderText => string.Empty;     

        string ITextual.Format() => RecordType.ToString();
    }

    public interface IMetadataRecordSpec<R> : IMetadataRecordSpec
        where R : unmanaged, IMetadataRecordSpec<R>
    {
        
    }
}