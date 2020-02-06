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
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class ImmOpProviders
    {        
        readonly struct ImmUnaryV256 : IImmOpProvider
        {        
            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => DynopImm.OpBuilder(HK.vk256(), HK.opfk(n1), src)(imm);
        }

        readonly struct ImmUnaryV256<T> : IImmOpProvider<UnaryOp<Vector256<T>>>
            where T : unmanaged
        {            
            [MethodImpl(Inline)]            
            public DynamicDelegate<UnaryOp<Vector256<T>>> CreateOp(MethodInfo src, byte imm)
                => DynopImm.UnaryOpProvider(HK.vk256<T>(), src.Identify(), src)(imm);
        }
    }
}