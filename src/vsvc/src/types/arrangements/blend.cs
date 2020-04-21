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
        [Closures(Integers)]        
        public readonly struct Blend2x64x128<T> : ISVImm8BinaryOp128Api<T>, ISVImm8BinaryResolver128Api<T>
            where T : unmanaged
        {
            public const string Name = "vblend2x64";

            public static Blend2x64x128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            public DynamicDelegate<BinaryOp<Vector128<T>>> @delegate(byte spec)
                => Dynop.EmbedVBinaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),spec);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y, byte spec) 
                => gvec.vblend2x64(x,y,spec);            
        }

        [Closures(Integers)]        
        public readonly struct Blend4x64x256<T> : ISVImm8BinaryOp256Api<T>, ISVImm8BinaryResolver256Api<T>
            where T : unmanaged
        {
            public const string Name = "vblend4x64";

            public Vec256Kind<T> VKind => default;

            public static Blend4x64x256<T> Op => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            public DynamicDelegate<BinaryOp<Vector256<T>>> @delegate(byte spec)
                => Dynop.EmbedImmVBinaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name), spec);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y, byte spec) 
                => gvec.vblend4x64(x,y,spec);
        }

        [Closures(Integers)]        
        public readonly struct Blend4x32x128<T> : ISVImm8BinaryOp128Api<T>, ISVImm8BinaryResolver128Api<T>
            where T : unmanaged
        {
            public const string Name = "vblend4x32";

            public static Blend4x32x128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            public DynamicDelegate<BinaryOp<Vector128<T>>> @delegate(byte spec)
                => Dynop.EmbedVBinaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),spec);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y, byte spec) 
                => gvec.vblend4x32(x,y,spec);            
        }

        [Closures(Integers)]
        public readonly struct Blend8x32x256<T> : ISVImm8BinaryOp256Api<T>, ISVImm8BinaryResolver256Api<T>
            where T : unmanaged
        {
            public const string Name = "vblend8x32";

            public static Blend8x32x256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            public DynamicDelegate<BinaryOp<Vector256<T>>> @delegate(byte spec)
                => Dynop.EmbedImmVBinaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),spec);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y, byte spec) 
                => gvec.vblend8x32(x,y,spec);
        }

        [Closures(Integers)]        
        public readonly struct Blend8x16x128<T> : ISVImm8BinaryOp128Api<T>, ISVImm8BinaryResolver128Api<T>
            where T : unmanaged
        {
            public const string Name = "vblend8x16";

            public static Blend8x16x128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            public DynamicDelegate<BinaryOp<Vector128<T>>> @delegate(byte spec)
                => Dynop.EmbedVBinaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),spec);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y, byte spec) 
                => gvec.vblend8x16(x,y,spec);            
        }

        [Closures(Integers)]        
        public readonly struct Blend8x16x256<T> : ISVImm8BinaryOp256Api<T>, ISVImm8BinaryResolver256Api<T>
            where T : unmanaged
        {
            public const string Name = "vblend8x16";

            public Vec256Kind<T> VKind => default;

            public static Blend8x16x256<T> Op => default;

            public OpIdentity Id => Identities.sfunc(Name,VKind);

            public DynamicDelegate<BinaryOp<Vector256<T>>> @delegate(byte spec)
                => Dynop.EmbedImmVBinaryOpImm<T>(VKind, Id, gApiMethod(VKind,Name),spec);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y, byte spec) 
                =>  gvec.vblend8x16(x,y,spec);
        }
    }
}