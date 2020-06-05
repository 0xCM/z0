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
        
        public int RowCount
        {
            [MethodImpl(Inline)]
            get => Data.RowCount;
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