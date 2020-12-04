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

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static bool type(in ClrTypes src, string name, out Type dst)
        {
            dst = default;
            for(var i=0u; i<src.Count; i++)
            {
                ref readonly var x = ref skip(src.Pairs,i);
                if(x.Value.Name == name)
                {
                    dst = x.Value;
                    return true;
                }
            }
            return false;
        }
    }
}