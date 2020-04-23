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

    using static Seed;    

    partial class VSvcHosts
    {
        [Closures(Integers), Bsll]
        public readonly struct Bsll128<T> : ISVShiftOp128<T>, IImm8UnaryResolver128<T>
            where T : unmanaged
        {
            public const string Name = "vbsll";

            public static Bsll128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector128<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => gvec.vbsll(x,count);
        }

        [Closures(Integers), Bsll]
        public readonly struct Bsll256<T> : ISVShiftOp256<T>, IImm8UnaryResolver256<T>
            where T : unmanaged
        {
            public const string Name = "vbsll";

            public Vec256Kind<T> VKind => default;

            public static Bsll256<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            public DynamicDelegate<UnaryOp<Vector256<T>>> @delegate(byte count)
                => Dynop.EmbedVUnaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),count);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count)  
                => gvec.vbsll(x,count);
        }    
    }
}