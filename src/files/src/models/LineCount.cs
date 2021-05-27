//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct LineCount : IComparable<LineCount>
    {
        public FS.FilePath Source {get;}

        public Count Lines {get;}

        [MethodImpl(Inline)]
        public LineCount(FS.FilePath src, Count lines)
        {
            Source = src;
            Lines = lines;
        }

        [MethodImpl(Inline)]
        public static implicit operator LineCount((FS.FilePath path, Count lines) src)
            => new LineCount(src.path, src.lines);

        public string Format()
            => string.Format("{0:D6}:{1}", (uint)Lines, Source.ToUri());

        public override string ToString()
            => Format();

        public int CompareTo(LineCount src)
            =>  Source.CompareTo(src.Source);
    }
}