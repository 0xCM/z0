//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct SourceFileData
    {
        public static SourceFileData Empty => Define(FilePath.Empty, Control.array<TextRow>());

        public FilePath Source {get;}
        
        public TextRow[] Rows {get;}
            
        public int RowCount
        {
            [MethodImpl(Inline)]
            get => Rows.Length;
        }

        public ref readonly TextRow this[int index] {[MethodImpl(Inline)] get => ref Rows[index];}

        public bool IsEmpty => (Rows?.Length ?? 0) == 0;

        public bool IsNonEmpty => !IsEmpty;

        [MethodImpl(Inline)]
        public static SourceFileData Define(FilePath src, params TextRow[] lines)
            => new SourceFileData(src,lines);

        [MethodImpl(Inline)]
        SourceFileData(FilePath src, TextRow[] lines)
        {
            Source = src;
            Rows = lines;
        }
        
        public SourceFileData Zero => Empty;   
    }
}