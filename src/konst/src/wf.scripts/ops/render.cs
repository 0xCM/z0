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
    using static CmdVarTypes;

    partial struct CmdScripts
    {
        [Op]
        public static void render(CmdScript src, ITextBuffer dst)
        {
            var count = src.Length;
            var parts = src.Content.View;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(parts,i).Format());
        }

        [Op]
        public static void render(DirVars src, ITextBuffer dst)
        {
            var members = src.Members().View;
            var count = members.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(CmdVars.format(skip(members,i)));
        }
    }
}