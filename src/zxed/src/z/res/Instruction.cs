//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;
    using static InstructionMarkers;

    partial class Res
    {    
        /// <summary>
        /// Defines a container over the data found in an instruction resource file for a single instruction
        /// </summary>
        public readonly struct Instruction
        {
            public static Instruction Empty => new Instruction(Control.array<TextRow>());
            
            public readonly TextRow[] Rows {get;}

            public int RowCount => Rows.Length;

            public ref readonly TextRow this[int i] { [MethodImpl(Inline)] get => ref Rows[i];}

            [MethodImpl(Inline)]
            public Instruction(params TextRow[] rows)
            {
                Rows = rows;
            }

            public bool IsEmpty { [MethodImpl(Inline)] get => (Rows?.Length ?? 0) == 0;}

            public bool IsNonEmpty{ [MethodImpl(Inline)] get => !IsEmpty;}   

            public string Class 
                => this.ExtractProp(ICLASS);

            public string Category
                => this.ExtractProp(CATEGORY);

            public string Extension
                => this.ExtractProp(EXTENSION);

            public string IsaSet
                => this.ExtractProp(ISA_SET);

            public string AttributeText
                => this.ExtractProp(ATTRIBUTES);

            public string RealOpCode
                => this.ExtractProp(REAL_OPCODE);

            public InstructionPattern[] Patterns
                => this.ExtractPatterns();
    
            [MethodImpl(Inline)]
            internal bool IsProp(int index, string Name)            
                => this[index].Text.StartsWith(Name);

            [MethodImpl(Inline)]
            internal string ExtractProp(TextRow src)
                => src.Text.RightOf(PROP_DELIMITER).Trim(); 

            [MethodImpl(Inline)]
            internal string ExtractProp(int index)
                => ExtractProp(this[index]);
        }
    }
}