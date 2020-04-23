//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class VSvcHosts
    {
        public readonly struct Sll128<T> : ISVShiftOp128D<T>, IImm8UnaryResolver128<T>
            where T : unmanaged
        {
            public const string Name = "vsll";

            public Vec128Kind<T> VKind => default;

            public static Sll128<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);
            
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => gvec.vsll(x,count);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gmath.sll(a,count);

        }

        public readonly struct Sll256<T> : ISVShiftOp256D<T>, IImm8UnaryResolver256<T>
            where T : unmanaged
        {
            public const string Name = "vsll";            

            public Vec256Kind<T> VKind => default;

            public static Sll256<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => gvec.vsll(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gmath.sll(a,count);
        }
    }
}