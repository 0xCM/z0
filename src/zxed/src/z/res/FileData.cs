//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    partial class Res
    {
        public readonly struct FileData
        {
            public static FileData Empty => Define(Control.array<TextRow>());

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
            public static FileData Define(params TextRow[] lines)
                => new FileData(lines);

            [MethodImpl(Inline)]
            FileData(TextRow[] lines)
            {
                Rows = lines;
            }
            
            public FileData Zero => Empty;   
        }
    }
}