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

    public readonly struct StringIndexSvc
    {
        public void Render(in StringIndex src, ITextBuffer dst)
            => render(src,dst);

        public void Render(in StringIndex src, Name name, ITextBuffer dst)
            => render(src, name, dst);

        public static void render(in StringIndex src, ITextBuffer dst)
        {
            render(src, EmptyString, dst);
        }

        public static void render(in StringIndex src, Name name, ITextBuffer dst)
        {
            var view = src.View;
            var count = view.Length;
            if(name.IsNonEmpty)
                dst.AppendFormat("{0}[{1}]=",name,count);
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

        public static ReadOnlySpan<byte> serialize(in StringIndex src)
        {
            return default;
        }
    }
}