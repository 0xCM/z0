//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ApiQuery
    {
        [Op]
        public static Index<ApiMember> set(Index<ApiMember> src, ApiSetKind kind)
        {
            var dst = root.list<ApiMember>();
            var count = src.Count;
            var view = src.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var member = ref skip(view,i);
                if((member.ApiSet & kind) != 0)
                    dst.Add(member);
            }

            return dst.ToArray();
        }
    }
}