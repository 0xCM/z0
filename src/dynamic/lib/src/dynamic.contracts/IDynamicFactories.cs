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

        IUnaryOpFactory<T> Factory<T>(UnaryClass<T> op)
            where T :  unmanaged;

        IBinaryOpFactory<T> Factory<T>(BinaryClass<T> op)
            where T :  unmanaged;

        ITernaryOpFactory<T> Factory<T>(TernaryClass<T> op)
            where T :  unmanaged;
    }
}