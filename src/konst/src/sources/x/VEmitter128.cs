//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static SFx;

    public readonly struct VEmitter128<T> : IEmitter128<T>
        where T : unmanaged
    {
        public const string Name = "vemitter";

        static Vec128Kind<T> Kind => default;

        readonly IDataSource Source;

        [MethodImpl(Inline)]
        public VEmitter128(IDataSource source)
            => Source = source;

        public OpIdentity Id
            => ApiIdentify.sfunc(Name, Kind);

        [MethodImpl(Inline)]
        public Vector128<T> Invoke()
            => Source.CpuVector<T>(Kind);
    }
}