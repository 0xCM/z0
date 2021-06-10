//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    using api = IntelDocs;
    public readonly partial struct IntelDocs
    {
        public static Outcome parse(string src, out ChapterPage dst)
        {
            var outcome = Outcome.Success;
            dst = ChapterPage.Empty;
            var i = text.index(src,Chars.Dash);
            if(i == NotFound)
            {
                outcome = (false, string.Format("Chapater/Page separator '{0}' not found", Chars.Dash));
                return outcome;
            }
            var left = src.LeftOfIndex(i);
            outcome += DataParser.parse(left, out dst.Chapter);
            var right = src.RightOfIndex(i);
            outcome += DataParser.parse(left, out dst.Page);
            return outcome;
        }

        public static string format(ChapterPage src)
            => string.Format(ChapterPage.RenderPattern, src.Chapter, src.Page);

        public static string format(VolumePage src)
            => string.Format("Vol. {0} {1}", src.VolName, format(src.Page));

        /// <summary>
        /// Represents content of the form Vol. {VolName} {Chapter}-{Page}
        /// </summary>
        public struct VolumePage
        {
            public string VolName;

            public ChapterPage Page;

            public VolumePage(string vol, ChapterPage page)
            {
                VolName = vol;
                Page = page;
            }
        }

        /// <summary>
        /// Represents content of the form '{Chapter}-{Page}'
        /// </summary>
        public struct ChapterPage
        {
            public const string RenderPattern = "{0}-{1}";

            public byte Chapter;

            public ushort Page;

            [MethodImpl(Inline)]
            public ChapterPage(byte chapter, ushort page)
            {
                Chapter = chapter;
                Page = page;
            }

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();

            public static ChapterPage Empty => new ChapterPage(0,0);
        }
    }

    public readonly struct Subject
    {
        public string Title {get;}

        public ItemNumber Locator {get;}

    }

    public enum ItemKind : byte
    {
        Volume,

        Chapter,

        Topic,

        Section,

        Page,

        Table,

        Figure
    }


    public readonly struct ItemNumber
    {
        readonly WordBlock8 Data;

        [MethodImpl(Inline)]
        public ItemNumber(ItemKind kind, ushort a)
        {
            Data[0] = a;
            seek(Data.Bytes,14) = 1;
            seek(Data.Bytes,15) = (byte)kind;
        }

        [MethodImpl(Inline)]
        public ItemNumber(ItemKind kind, ushort a, ushort b)
        {
            Data[0] = a;
            Data[1] = b;
            seek(Data.Bytes,14) = 2;
            seek(Data.Bytes,15) = (byte)kind;
        }

        [MethodImpl(Inline)]
        public ItemNumber(ItemKind kind, ushort a, ushort b, ushort c)
        {
            Data[0] = a;
            Data[1] = b;
            Data[2] = c;
            seek(Data.Bytes,14) = 3;
            seek(Data.Bytes,15) = (byte)kind;
        }

        [MethodImpl(Inline)]
        public ItemNumber(ItemKind kind, ushort a, ushort b, ushort c, ushort d)
        {
            Data[0] = a;
            Data[1] = b;
            Data[2] = c;
            Data[3] = d;
            seek(Data.Bytes,14) = 4;
            seek(Data.Bytes,15) = (byte)kind;
        }
    }
}