//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
            
    using static Part;

    using O = OpacityKind;

    partial struct sys
    {        
        [MethodImpl(NotInline), Opaque(O.GetFieldConstant), Closures(AllNumeric)]
        public static T constant<T>(FieldInfo f)
            => (T)f.GetRawConstantValue();                


        [MethodImpl(NotInline), Opaque(O.GetFieldConstant)]
        public static object constant(FieldInfo src)
            => src.GetRawConstantValue();
    }
}