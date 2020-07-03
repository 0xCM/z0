//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 
    using static Kinds;

    readonly struct DynamicFactories : IDynamicFactories
    {
        public static IDynamicFactories Service 
            => default(DynamicFactories);

        [MethodImpl(Inline)]
        public IEmitterOpFactory<T> Factory<T>(EmitterOpClass<T> op)        
            where T :  unmanaged
                => EmitterOpFactory<T>.Service;

        [MethodImpl(Inline)]
        public IUnaryOpFactory<T> Factory<T>(UnaryOpClass<T> op)        
            where T :  unmanaged
            => UnaryOpFactory<T>.Service;

        [MethodImpl(Inline)]
        public IBinaryOpFactory<T> Factory<T>(BinaryOpClass<T> op)        
            where T :  unmanaged
            => BinaryOpFactory<T>.Service;

        [MethodImpl(Inline)]
        public ITernaryOpFactory<T> Factory<T>(TernaryOpClass<T> op)        
            where T :  unmanaged
                => TernaryOpFactory<T>.Service;
    }
}