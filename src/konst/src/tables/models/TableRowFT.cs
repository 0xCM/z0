//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableRow<F,T> : ITableRow<F,T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>        
    {    
        public T Data {get;}

        public BinaryCode[] Cells {get;}
        
        public FieldEvaluation<F,T> Values {get;}
        
        [MethodImpl(Inline)]
        public TableRow(T src)
        {
            var fields = Table.fields<F,T>();
            var count = fields.Count;
            var buffer = alloc<BinaryCode>(count);
            Values = Table.evaluate<F,T>(src,fields);
            Data = src;            
            Cells = buffer;
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref Values[i];
            }                       
        }

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Cells.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Cells.Length;
        }

        public ref BinaryCode this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }
    }
}