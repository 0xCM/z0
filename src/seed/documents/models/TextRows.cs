//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    
    using System.Runtime.CompilerServices;    

    using static Konst;

    public readonly struct TextRows : IConstIndex<TextRow>
    {        
        readonly TextRow[] RowData;        

        [MethodImpl(Inline)]
        public TextRows(TextRow[] data)
        {
            RowData = data;
        }
        
        public int Length
        {
            [MethodImpl(Inline)]
            get => RowData.Length;
        }

        public ReadOnlySpan<TextRow> Rows
        {
            [MethodImpl(Inline)]
            get => RowData;
        }
        public ref readonly TextRow this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Rows[index];
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<TextRow> Slice(int offset)
            => Rows.Slice(offset);
    
        [MethodImpl(Inline)]
        public ReadOnlySpan<TextRow> Slice(int offset, int length)
            => Rows.Slice(offset, length);
    
    }
}