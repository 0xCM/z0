//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RecordFormatter
    {
        /// <summary>
        /// Creates a record formatter predicated on an enum that specifies the record fields
        /// </summary>
        /// <typeparam name="F">The field specification type</typeparam>
        [MethodImpl(Inline)]
        public static RecordFormatter<F> create<F>(char delimiter = FieldDelimiter)
            where F :unmanaged, Enum
                => new RecordFormatter<F>(text.build());        
    }

}