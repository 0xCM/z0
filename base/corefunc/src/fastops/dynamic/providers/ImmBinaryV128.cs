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
        readonly struct ImmBinaryV128 : IImmOpProvider
        {

            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => DynopImm.OpBuilder(HK.vk128(), HK.opk(n2), src)(imm);
        }

        readonly struct ImmBinaryV128<T> : IImmOpProvider<BinaryOp<Vector128<T>>>
            where T : unmanaged
        {

            [MethodImpl(Inline)]            
            public DynamicDelegate<BinaryOp<Vector128<T>>> CreateOp(MethodInfo src, byte imm)
                => DynopImm.BinaryOpProvider(HK.vk128<T>(), src.Identify(), src)(imm);

        }
    }
}