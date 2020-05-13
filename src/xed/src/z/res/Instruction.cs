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
    using static Props;

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
                => ExtractProp(ICLASS);

            public string Category
                => ExtractProp(CATEGORY);

            public string Extension
                => ExtractProp(EXTENSION);

            public string IsaSet
                => ExtractProp(ISA_SET);

            public string AttributeText
                => ExtractProp(ATTRIBUTES);

            public string RealOpCode
                => ExtractProp(REAL_OPCODE);

            public PatternOps[] Patterns
            {
                get
                {
                    try
                    {
                        var patterns = list<PatternOps>();
                        for(var i=0; i<RowCount; i++)
                        {
                            if(IsProp(i,PATTERN) && i != (RowCount - 1))
                            {
                                if(IsProp(i + 1, OPERANDS))
                                {
                                    var pattern = ExtractProp(i);
                                    var operands = ExtractProp(i + 1);
                                    patterns.Add(PatternOps.Create(Class, Category, Extension, IsaSet, pattern, operands));
                                }
                            }
                        }
                        return patterns.ToArray();
                    }
                    catch(Exception e)
                    {
                        term.error(e);
                        return Control.array<PatternOps>();
                    }

                }
            }                                  
    
            [MethodImpl(Inline)]
            bool IsProp(int index, string Name)
                => this[index].Text.StartsWith(Name);

            [MethodImpl(Inline)]
            string ExtractProp(TextRow src)
                => src.Text.RightOf(PropDelimiter).Trim(); 

            [MethodImpl(Inline)]
            string ExtractProp(int index)
                => ExtractProp(this[index]);

            [MethodImpl(Inline)]
            string ExtractProp(string name)
            {
                var rowtext = Rows.Where(r => r.Text.StartsWith(name)).SingleOrDefault().Text;
                if(text.nonempty(rowtext))
                    return rowtext.RightOf(PropDelimiter).Trim();
                else
                    return string.Empty;
            }
        }
    }
}