//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.Clr;
    using static MemberModels;


    using static Konst;
    using static z;

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static FieldInfo field(Type t, string name)
        {
            var src =  fields(t);
            var view = src.View;
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var candidate = ref skip(view,i);
                if(candidate.Name == name)
                    return candidate;                    
            }
            return EmptyVessels.EmptyField;
        }   

        [MethodImpl(Inline), Op]
        public static ClrField field(FieldInfo src)
            => new ClrField(src);    
    }
}