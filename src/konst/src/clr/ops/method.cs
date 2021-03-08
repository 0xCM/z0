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

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static ClrMethod method(Delegate src)
            => src.Method;

        // [Op]
        // public static MethodBase method(Module module, ClrToken metadataToken, Type[] gTypeArgs, Type[] gMethodArgs)
        //     => Msil.ModuleExtensions.ResolveMethod(module, (int)metadataToken, gTypeArgs, gMethodArgs);
    }
}