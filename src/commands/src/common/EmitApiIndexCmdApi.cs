//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    public static class EmitApiIndexCmdApi
    {
        [Op]
        public static EmitApiIndexCmd EmitApiIndex(this CmdBuilder builder)
        {
            var dst = new EmitApiIndexCmd();

            return dst;
        }

    }
}