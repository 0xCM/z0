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
        readonly struct ImmBinaryV256 : IImmOpProvider
        {
            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => DynopImm.OpBuilder(HK.vk256(), HK.opk(n2), src)(imm);               
        }

        readonly struct ImmBinaryV256<T> : IImmOpProvider<BinaryOp<Vector256<T>>>
            where T : unmanaged
        { 
            [MethodImpl(Inline)]            
            public DynamicDelegate<BinaryOp<Vector256<T>>> CreateOp(MethodInfo src, byte imm)
                => DynopImm.BinaryOpProvider(HK.vk256<T>(), src.Identity(), src)(imm);
        }
    }
}