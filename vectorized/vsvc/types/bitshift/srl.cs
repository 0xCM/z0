//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static root;

    partial class VSvcHosts
    {        
        public readonly struct Srl128<T> : ISVShiftOp128DApi<T>, ISVImm8UnaryResolver128Api<T>
            where T : unmanaged
        {
            public const string Name = "vsrl";

            public Vec128Kind<T> VKind => default;

            public static Srl128<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count)
                => gvec.vsrl(x,count);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gmath.srl(a,count);
        }

        public readonly struct Srl256<T> : ISVShiftOp256DApi<T>, ISVImm8UnaryResolver256Api<T>
            where T : unmanaged
        {
            public const string Name = "vsrl";

            public Vec256Kind<T> VKind => default;

            public static Srl256<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => gvec.vsrl(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte count) 
                => gmath.srl(a,count);
        }
    }
}