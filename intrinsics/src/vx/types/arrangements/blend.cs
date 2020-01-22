//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class VXTypes
    {
        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Blend2x64x128<T> : IVBinOp128Imm8<T>, IVBinaryImm8Resolver128<T>
            where T : unmanaged
        {
            public const string Name = "vblend2x64";

            public static Blend2x64x128<T> Op => default;

            public static HK.Vec128<T> hk => default;

            public Moniker Moniker => moniker(Name,hk);

            public DynamicDelegate<BinaryOp<Vector128<T>>> @delegate(byte spec)
                => Dynop.binary<T>(hk, Moniker, gApiMethod(hk,Name),spec);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y, byte spec) 
                => ginx.vblend2x64(x,y,spec);            
        }

        public readonly struct Blend4x64x256<T> : IVBinOp256Imm8<T>, IVBinaryImm8Resolver256<T>
            where T : unmanaged
        {
            public const string Name = "vblend4x64";

            public static HK.Vec256<T> hk => default;

            public static Blend4x64x256<T> Op => default;

            public Moniker Moniker => moniker(Name,hk);

            public DynamicDelegate<BinaryOp<Vector256<T>>> @delegate(byte spec)
                => Dynop.binary<T>(hk, Moniker, gApiMethod(hk,Name),spec);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y, byte spec) 
                => ginx.vblend4x64(x,y,spec);
        }

        public readonly struct Blend4x32x128<T> : IVBinOp128Imm8<T>, IVBinaryImm8Resolver128<T>
            where T : unmanaged
        {
            public const string Name = "vblend4x32";

            public static Blend4x32x128<T> Op => default;

            public static HK.Vec128<T> hk => default;

            public Moniker Moniker => moniker(Name,hk);

            public DynamicDelegate<BinaryOp<Vector128<T>>> @delegate(byte spec)
                => Dynop.binary<T>(hk, Moniker, gApiMethod(hk,Name),spec);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y, byte spec) 
                => ginx.vblend4x32(x,y,spec);            
        }

        public readonly struct Blend8x32x256<T> : IVBinOp256Imm8<T>, IVBinaryImm8Resolver256<T>
            where T : unmanaged
        {
            public const string Name = "vblend8x32";

            public static Blend8x32x256<T> Op => default;

            public static HK.Vec256<T> hk => default;

            public Moniker Moniker => moniker(Name,hk);

            public DynamicDelegate<BinaryOp<Vector256<T>>> @delegate(byte spec)
                => Dynop.binary<T>(hk, Moniker, gApiMethod(hk,Name),spec);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y, byte spec) 
                =>  ginx.vblend8x32(x,y,spec);

        }

        public readonly struct Blend8x16x128<T> : IVBinOp128Imm8<T>, IVBinaryImm8Resolver128<T>
            where T : unmanaged
        {
            public const string Name = "vblend8x16";

            public static Blend8x16x128<T> Op => default;

            public static HK.Vec128<T> hk => default;

            public Moniker Moniker => moniker(Name,hk);

            public DynamicDelegate<BinaryOp<Vector128<T>>> @delegate(byte spec)
                => Dynop.binary<T>(hk, Moniker, gApiMethod(hk,Name),spec);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y, byte spec) 
                => ginx.vblend8x16(x,y,spec);            
        }

        public readonly struct Blend8x16x256<T> : IVBinOp256Imm8<T>, IVBinaryImm8Resolver256<T>
            where T : unmanaged
        {
            public const string Name = "vblend8x16";

            public static HK.Vec256<T> hk => default;

            public static Blend8x16x256<T> Op => default;

            public Moniker Moniker => moniker(Name,hk);

            public DynamicDelegate<BinaryOp<Vector256<T>>> @delegate(byte spec)
                => Dynop.binary<T>(hk, Moniker, gApiMethod(hk,Name),spec);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y, byte spec) 
                =>  ginx.vblend8x16(x,y,spec);
        }
    }
}