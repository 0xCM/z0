//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct TextFileRows
    {
        public readonly FilePath Source;
        
        public readonly TextRow[] Rows;

        [MethodImpl(Inline)]
        public static TextFileRows define(FilePath src, TextRow[] lines)
            => new TextFileRows(src,lines);

        [MethodImpl(Inline)]
        public TextFileRows(FilePath src, TextRow[] lines)
        {
            Source = src;
            Rows = lines;
        }

        public ref readonly TextRow this[int i] 
        { 
            [MethodImpl(Inline)]
            get => ref Rows[i];
        }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline)]
            get => (Rows?.Length ?? 0) == 0;
        }

        public bool IsNonEmpty
        { 
            [MethodImpl(Inline), Op]
            get => !IsEmpty;
        }   

        public int RowCount 
            => Rows.Length;

        public static TextFileRows Empty 
        {
            [MethodImpl(Inline)]
            get => new TextFileRows(FilePath.Empty, sys.empty<TextRow>());
        }
    }
}