//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AppResourceDoc : IAppResource<TextDoc>
    {
        public string Name {get;}

        public TextDoc Data {get;}        

        [MethodImpl(Inline)]
        public static implicit operator AppResource<TextDoc>(AppResourceDoc src)
            => new AppResource<TextDoc>(src.Name,src.Data);

        [MethodImpl(Inline)]
        public AppResourceDoc(string name, TextDoc doc)
        {
            this.Name = name;
            this.Data = doc;
        }

        public TextRow[] Rows
        {
            [MethodImpl(Inline)]
            get => Data.RowData;
        }
        
        public ref readonly TextRow this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data.RowData[index];
        }

        public int RowCount
        {
            [MethodImpl(Inline)]
            get => Data.RowCount;
        }

        public int CharCount(char exclude)        
        {
            var count = 0;
            for(var i=0; i<RowCount; i++)
            {
                ref readonly var row = ref this[i];
                for(var j = 0; j< row.CellCount; j++)
                {
                    ref readonly var cell = ref row[j];
                    ReadOnlySpan<char> data = cell.Content;

                    for(var k=0; k<data.Length; k++)
                    {
                        ref readonly var c = ref Control.skip(data,k);
                        if(!Char.IsWhiteSpace(c))
                            count++;
                    }
                }
            }

            return count;
        }

        public string Format()
        {
            var dst = text.build();
            Control.iter(Data.RowData, d => dst.AppendLine(d.Text));
            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}