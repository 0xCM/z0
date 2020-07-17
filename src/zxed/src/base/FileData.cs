//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    [ApiHost]
    public readonly struct SourceFileData
    {
        public readonly FilePath Source;
        
        public readonly TextRow[] Rows;

        [MethodImpl(Inline), Op]
        public static SourceFileData Define(FilePath src, params TextRow[] lines)
            => new SourceFileData(src,lines);

        [MethodImpl(Inline), Op]
        internal SourceFileData(FilePath src, TextRow[] lines)
        {
            Source = src;
            Rows = lines;
        }

        public ref readonly TextRow this[int i] 
        { 
            [MethodImpl(Inline), Op]
            get => ref Rows[i];
        }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline), Op]
            get => (Rows?.Length ?? 0) == 0;
        }

        public bool IsNonEmpty
        { 
            [MethodImpl(Inline), Op]
            get => !IsEmpty;
        }   

        public int RowCount 
            => Rows.Length;

        public static SourceFileData Empty 
        {
            [MethodImpl(Inline), Op]
            get => Define(FilePath.Empty, sys.empty<TextRow>());
        }

    }
}