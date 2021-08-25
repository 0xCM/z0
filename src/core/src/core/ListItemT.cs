//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct ListItem<T>
    {
        public uint Index {get;}

        public T Content {get;}

        [MethodImpl(Inline)]
        public ListItem(uint index, T content)
        {
            Index = index;
            Content = content;
        }

        public string Format()
            => string.Format("{0:D6}:{1}", Index, Content);

        public override string ToString()
            => Format();

        public ListItem ToRecord(string type)
            => ListItems.record(this,type);

        [MethodImpl(Inline)]
        public static implicit operator ListItem<T>((uint index, T content) src)
            => new ListItem<T>(src.index, src.content);
    }
}