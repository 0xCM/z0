//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        [Op]
        public static void render(in CmdScript src, ITextBuffer dst)
        {
            var count = src.Length;
            var parts = src.Content.View;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(parts,i).Format());
        }

        [Op]
        public static void render(in CmdArgs src, ITextBuffer dst)
        {
            var view = src.View;
            var count = view.Length;
            for(var i=0; i<count; i++)
            {
                dst.Append(Space);
                dst.Append(skip(view,i).Format());
            }
        }
    }
}