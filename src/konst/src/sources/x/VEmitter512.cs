//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    public readonly struct VEmitter512<T> : IEmitter512<T>
        where T : unmanaged
    {
        public const string Name = "vemitter";

        readonly IDataSource Source;

        static Vec512Kind<T> Kind => default;

        [MethodImpl(Inline)]
        public VEmitter512(IDataSource src)
            => Source = src;

        public OpIdentity Id
            => ApiIdentify.sfunc(Name, Kind);

        [MethodImpl(Inline)]
        public Vector512<T> Invoke()
            => Source.CpuVector<T>(Kind);
    }
}