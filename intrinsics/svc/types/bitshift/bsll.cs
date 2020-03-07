//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Root;

    partial class VFTypes
    {
        public readonly struct Bsll128<T> : IVShiftOp128<T>, IImm8V128UnaryResolver<T>, IUnaryBlockedOp128Imm8<T>
            where T : unmanaged
        {
            public const string Name = "vbsll";

            public static Bsll128<T> Op => default;

            public static VKT.Vec128<T> hk => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.ImmVUnaryOP<T>(hk, Id, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => ginx.vbsll(x,count);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, byte count, in Block128<T> c)            
                => ref vblocks.vbsll(a,count,c);            
        }

        public readonly struct Bsll256<T> : IVShiftOp256<T>, IImm8V256UnaryResolver<T>, IUnaryBlockedOp256Imm8<T>
            where T : unmanaged
        {
            public const string Name = "vbsll";

            public static VKT.Vec256<T> hk => default;

            public static Bsll256<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.ImmVUnaryOp<T>(hk, Id, gApiMethod(hk,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count)  
                => ginx.vbsll(x,count);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, byte count, in Block256<T> c)            
                => ref vblocks.vbsll(a,count,c);
        }    
    }
}