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

    /// <summary>
    /// Defines a container over the data found in an instruction resource file
    /// for a single instruction
    /// </summary>
    public readonly struct ResInstruction
    {
        public static ResInstruction Empty => new ResInstruction();
        
        public readonly TextRow[] Rows {get;}

        public int RowCount => Rows.Length;

        public ref readonly TextRow this[int i] { [MethodImpl(Inline)] get => ref Rows[i];}

        [MethodImpl(Inline)]
        public ResInstruction(params TextRow[] rows)
        {
            Rows = rows;
        }

        public bool IsEmpty { [MethodImpl(Inline)] get => (Rows?.Length ?? 0) == 0;}

        public bool IsNonEmpty{ [MethodImpl(Inline)] get => !IsEmpty;}           
    }
}