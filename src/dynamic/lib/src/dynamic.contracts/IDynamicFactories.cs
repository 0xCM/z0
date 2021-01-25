//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDynamicFactories
    {
        IEmitterOpFactory<T> Factory<T>(EmitterClass<T> k)
            where T : unmanaged;

        IUnaryOpFactory<T> Factory<T>(UnaryOperatorClass<T> op)
            where T :  unmanaged;

        IBinaryOpFactory<T> Factory<T>(BinaryOperatorClass<T> op)
            where T :  unmanaged;

        ITernaryOpFactory<T> Factory<T>(TernaryOperatorClass<T> op)
            where T :  unmanaged;
    }
}