//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AppResDoc : IAppRes<TextDoc>
    {
        public string Name {get;}

        public TextDoc Content {get;}

        [MethodImpl(Inline)]
        public AppResDoc(string name, TextDoc doc)
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
                for(var j = 0; j< row.CellCount; j++)
                {
                    ref readonly var cell = ref row[j];
                    ReadOnlySpan<char> data = cell.Content;

                    for(var k=0u; k<data.Length; k++)
                    {
                        ref readonly var c = ref z.skip(data,k);
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
            z.iter(Content.RowData, d => dst.AppendLine(d.Text));
            return dst.ToString();
        }

        public override string ToString()
            => Format();

        public static AppResDoc Empty
            => new AppResDoc(EmptyString, TextDoc.Empty);

        [MethodImpl(Inline)]
        public static implicit operator AppRes<TextDoc>(AppResDoc src)
            => new AppRes<TextDoc>(src.Name,src.Content);
    }
}