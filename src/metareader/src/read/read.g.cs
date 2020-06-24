//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static PartRecords;
    using static Root;
    
    partial class PartReader
    {        
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<R> read<R>(ReaderState State)
            where R : struct, IPartRecord
        {
            if(typeof(R) == typeof(StringValueRecord))
                return As.cast<StringValueRecord,R>(ustrings(State));
            else if(typeof(R) == typeof(BlobRecord))
                return As.cast<BlobRecord,R>(blobs(State));
            else if(typeof(R) == typeof(ConstantRecord))
                return As.cast<ConstantRecord,R>(constants(State));
            else if(typeof(R) == typeof(FieldRecord))
                return As.cast<FieldRecord,R>(fields(State));
            else
                throw Unsupported.define<R>();
        }
    }
}