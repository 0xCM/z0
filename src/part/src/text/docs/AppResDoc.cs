//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AppResDoc : IAppRes<TextGrid>
    {
        public string Name {get;}

        public TextGrid Content {get;}

        [MethodImpl(Inline)]
        public AppResDoc(string name, TextGrid doc)
        {
            Name = name;
            Content = doc;
        }

        public Index<TextRow> Rows
        {
            [MethodImpl(Inline)]
            get => Content.RowData;
        }

        public ref readonly TextRow this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Content.RowData[index];
        }

        public int RowCount
        {
            [MethodImpl(Inline)]
            get => Content.RowCount;
        }

        public int CharCount(char exclude)
        {
            var count = 0;
            for(var i=0; i<RowCount; i++)
            {
                ref readonly var row = ref this[i];
                for(var j = 0; j<row.CellCount; j++)
                {
                    ref readonly var block = ref row[j];
                    var data = block.View;
                    var len = data.Length;

                    for(var k=0u; k<len; k++)
                    {
                        ref readonly var c = ref memory.skip(data,k);
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
            root.iter(Content.RowData, d => dst.AppendLine(d.RowText));
            return dst.ToString();
        }

        public override string ToString()
            => Format();

        public static AppResDoc Empty
            => new AppResDoc(EmptyString, TextGrid.Empty);

        [MethodImpl(Inline)]
        public static implicit operator AppRes<TextGrid>(AppResDoc src)
            => new AppRes<TextGrid>(src.Name,src.Content);
    }
}