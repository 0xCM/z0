//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial class WfShell
    {
        [Op]
        public static ApiPartSet parts()
            => parts(WfShell.controller(), args());

        [Op]
        public static ApiPartSet parts(Assembly control, string[] args)
        {
            var parts = ApiPartIdParser.parse(args);
            if(parts.Length != 0)
               return new ApiPartSet(control, parts);
            else
                return new ApiPartSet(control);
        }

        [Op]
        public static ApiPartSet parts(Assembly control)
            => parts(control, args());
    }
}