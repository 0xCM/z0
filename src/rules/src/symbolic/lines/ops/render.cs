//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using SR = SymbolicRender;
    using static core;

    partial struct Lines
    {
        [Op]
        public static uint render(in UnicodeLine src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            SR.render(format(src.LineNumber), ref i, dst);
            if(src.IsNonEmpty)
                SR.render(src.Content, ref i, dst);
            return i - i0;
        }

        [Op]
        public static uint render(in AsciLine src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            SR.render(format(src.LineNumber), ref i, dst);
            if(src.IsNonEmpty)
                SR.render(src.Codes, ref i, dst);
            return i - i0;
        }

        [Op]
        public static uint render<T>(in AsciLine<T> src, ref uint i, Span<char> dst)
            where T : unmanaged
        {
            var i0 = i;
            SR.render(format(src.LineNumber), ref i, dst);
            if(src.IsNonEmpty)
                SR.render(recover<T,AsciCode>(src.View), ref i, dst);
            return i - i0;
        }

        [Op]
        public static uint render(in TextLine src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            SR.render(format(src.LineNumber), ref i, dst);
            if(src.IsNonEmpty)
                SR.render(src.Content, ref i, dst);
            return i - i0;
        }
    }
}