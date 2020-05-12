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

    public readonly struct ResFileData
    {
        public static ResFileData Empty => Define();

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
        public static ResFileData Define(params TextRow[] lines)
            => new ResFileData(lines);

        [MethodImpl(Inline)]
        ResFileData(TextRow[] lines)
        {
            Rows = lines;
        }
        
        public ResFileData Zero => Empty;   

    }
}