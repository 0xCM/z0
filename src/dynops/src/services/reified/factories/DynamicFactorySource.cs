//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 

    using K = Kinds;

    readonly struct DynamicFactorySource : IService
    {
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public static DynamicFactorySource Create(IInnerContext context)
            => new DynamicFactorySource(context);

        [MethodImpl(Inline)]
        DynamicFactorySource(IInnerContext context)
        {
            this.Context = context;
        }    

        [MethodImpl(Inline)]
        public IEmitterOpFactory<T> Factory<T>(K.EmitterOpClass<T> op)        
            where T :  unmanaged
                => new EmitterOpFactory<T>(Context);

        [MethodImpl(Inline)]
        public IUnaryOpFactory<T> Factory<T>(K.UnaryOpClass<T> op)        
            where T :  unmanaged
            => new UnaryOpFactory<T>(Context);

        [MethodImpl(Inline)]
        public IBinaryOpFactory<T> Factory<T>(K.BinaryOpClass<T> op)        
            where T :  unmanaged
            => new BinaryOpFactory<T>(Context);

        [MethodImpl(Inline)]
        public ITernaryOpFactory<T> Factory<T>(K.TernaryOpClass<T> op)        
            where T :  unmanaged
                => new TernaryOpFactory<T>(Context);
    }
}