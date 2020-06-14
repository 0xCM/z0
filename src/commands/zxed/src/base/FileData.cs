//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct SourceFileData
    {
        public FilePath Source {get;}
        
        public readonly TextRow[] Rows {get;}

        public static SourceFileData Empty 
            => Define(FilePath.Empty, Array.Empty<TextRow>());

        [MethodImpl(Inline)]
        public static SourceFileData Define(FilePath src, params TextRow[] lines)
            => new SourceFileData(src,lines);

        [MethodImpl(Inline)]
        internal SourceFileData(FilePath src, TextRow[] lines)
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
            [MethodImpl(Inline)] 
            get => !IsEmpty;
        }   

        public int RowCount 
            => Rows.Length;

        public SourceFileData Zero 
            => Empty;   
    }
}