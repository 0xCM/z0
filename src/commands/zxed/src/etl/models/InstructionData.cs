//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SourceMarkers;

    /// <summary>
    /// Defines a container over the data found in an instruction resource file for a single instruction
    /// </summary>
    public readonly struct InstructionData
    {
        public readonly TextRow[] Rows {get;}

        public static InstructionData Empty 
            => new InstructionData(Array.Empty<TextRow>());
        
        [MethodImpl(Inline)]
        internal InstructionData(params TextRow[] rows)
        {
            Rows = rows;
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