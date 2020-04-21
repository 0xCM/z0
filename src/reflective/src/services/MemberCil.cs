//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IMemberCil : IStateless<MemberCil,IMemberCil>
    {
        [MethodImpl(Inline)]
        CilBody cil(DynamicMethod src)
            => DynamicOps.cil(src);

        [MethodImpl(Inline)]
        CilBody cil(MethodInfo src)
            => DynamicOps.cil(src);

        [MethodImpl(Inline)]
        CilBody cil(DynamicDelegate src)
            => DynamicOps.cil(src);

        [MethodImpl(Inline)]
        CilBody cil<D>(DynamicDelegate<D> src)
            where D : Delegate
                => DynamicOps.cil(src);        
    }

    public readonly struct MemberCil : IMemberCil
    {

    }
}