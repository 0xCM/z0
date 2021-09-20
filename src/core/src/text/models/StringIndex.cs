//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct StringIndex : IIndex<string>
    {
        public void Render(in StringIndex src, ITextBuffer dst)
            => render(src,dst);

        public void Render(in StringIndex src, Name name, ITextBuffer dst)
            => render(src, name, dst);

        public static void render(in StringIndex src, ITextBuffer dst)
            => render(src, EmptyString, dst);

        public static void render(in StringIndex src, Name name, ITextBuffer dst)
        {
            var view = src.View;
            var count = view.Length;
            if(name.IsNonEmpty)
                dst.AppendFormat("{0}[{1}]=", name, count);
            dst.Append(Chars.LBrace);
            for(var i=0; i<count; i++)
            {
                ref readonly var item = ref skip(view,i);
                dst.AppendFormat("'{0}'", skip(view,i));
                if(i != count - 1)
                    dst.Append(Chars.Comma);
            }

            dst.Append(Chars.RBrace);
        }

        readonly Index<string> Data;

        [MethodImpl(Inline)]
        public StringIndex(string[] src)
        {
            Data = src;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref string this[ulong i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref string this[long i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public Span<string> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<string> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public string[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator StringIndex(string[] src)
            => new StringIndex(src);

        [MethodImpl(Inline)]
        public static implicit operator string[](StringIndex src)
            => src.Data.Storage;

        public static StringIndex Empty
        {
            [MethodImpl(Inline)]
            get => new StringIndex(array<string>());
        }
    }
}