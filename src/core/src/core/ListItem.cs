//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ListItem
    {

    }

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

        public ListItemRecord ToRecord(string type)
        {
            var dst = new ListItemRecord();
            dst.Id = Index;
            dst.Type = type;
            dst.Value = Content?.ToString() ?? RP.Empty;
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator ListItem<T>((uint index, T content) src)
            => new ListItem<T>(src.index, src.content);
    }
}