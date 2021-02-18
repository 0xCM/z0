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

    partial struct ApiSigs
    {
        [Op]
        public static string format(OperationSig src)
        {
            var dst = buffer();
            render(src,dst);
            return dst.Emit();
        }

        [Op]
        public static string format(TypeSig src)
        {
            var dst = buffer();
            render(src,dst);
            return dst.Emit();
        }
    }
}