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

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public readonly void enums(in Indexed<Type> src, in Indexed<Type> dst)
        {
            var view = src.View;
            for(uint i=0, j=0; i<src.Length; i++)
            {
                ref readonly var candidate = ref skip(view,i);
                if(candidate.IsEnum)
                    dst[j++] = candidate;
            }
        }
    }
}