//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

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

        public ListItemRecord ToRecord(string list)
        {
            const string Pattern = "{0,-42} | {1:D6} | {2}";
            var dst = new ListItemRecord();
            dst.ListName = list;
            dst.Index = Index;
            dst.Value =  string.Format("{0}",Content);
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator ListItem<T>((uint index, T content) src)
            => new ListItem<T>(src.index, src.content);
    }
}