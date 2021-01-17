//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct DynamicFactories : IDynamicFactories
    {
        public static DynamicFactories Service
            => default(DynamicFactories);

        [MethodImpl(Inline)]
        public IEmitterOpFactory<T> Factory<T>(EmitterClass<T> op)
            where T :  unmanaged
                => EmitterFactory<T>.Service;

        [MethodImpl(Inline)]
        public IUnaryOpFactory<T> Factory<T>(UnaryClass<T> op)
            where T :  unmanaged
            => UnaryOpFactory<T>.Service;

        [MethodImpl(Inline)]
        public IBinaryOpFactory<T> Factory<T>(BinaryClass<T> op)
            where T :  unmanaged
            => BinaryOpFactory<T>.Service;

        [MethodImpl(Inline)]
        public ITernaryOpFactory<T> Factory<T>(TernaryClass<T> op)
            where T :  unmanaged
                => TernaryOpFactory<T>.Service;
    }
}