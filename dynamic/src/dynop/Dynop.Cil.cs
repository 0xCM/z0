//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Emit;

    using static Root;

    partial class Dynop
    {
        [MethodImpl(Inline)]
        public static CilBody LoadCil(this DynamicMethod src)
            => CilBody.Load(src);

        [MethodImpl(Inline)]
        public static CilBody LoadCil(this MethodInfo src)
            => CilBody.Load(src);

        [MethodImpl(Inline)]
        public static CilBody LoadCil(this DynamicDelegate src)
            => CilBody.Load(src);

        [MethodImpl(Inline)]
        public static CilBody LoadCil<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => CilBody.Load(src); 
    }
}