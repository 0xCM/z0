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
        [MethodImpl(Inline)]
        public static implicit operator AppResource<TextDoc>(AppResourceDoc src)
            => new AppResource<TextDoc>(src.Name,src.Data);

        [MethodImpl(Inline)]
        public AppResourceDoc(string name, TextDoc doc)
        {
            this.Name = name;
            this.Data = doc;
        }

        public string Name {get;}

        public TextDoc Data {get;}        

        public ReadOnlySpan<string> DataRows
        {
            [MethodImpl(Inline)]
            get => Data.RowData.Map(x => x.Text);
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