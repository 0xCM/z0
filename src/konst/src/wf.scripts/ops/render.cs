//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial struct Scripts
    {
        [Op]
        public static void render(Vars src, ITextBuffer dst)
        {
            var members = src.Members().View;
            var count = members.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(format(skip(members,i)));
        }
    }
}