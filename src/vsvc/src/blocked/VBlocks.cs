
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

    [ApiHost("api")]
    public partial class VBlocks : IApiHost<VBlocks>
    {

    }

    public partial class VBlockHosts
    {

        [NumericClosures(AllNumeric)]
        public readonly struct Negate128<T> : IBlockedUnaryOp128<T>
            where T : unmanaged
        {
            public OpIdentity Id => Identify.sfunc(nameof(VBlocks.negate),VKind);

            public Vec128Kind<T> VKind => default;

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> c)            
                => ref VBlocks.negate(a,c);
        }

        [NumericClosures(AllNumeric)]
        public readonly struct Negate256<T> : IBlockedUnaryOp256<T>
            where T : unmanaged
        {
            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc(nameof(VBlocks.negate),VKind);


            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> c)            
                => ref VBlocks.negate(a,c);
        }
    }
}