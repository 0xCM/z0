//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface ITensor : IPrimitive
    {
        byte Arity {get;}

        TypeKind IPrimitive.TypeKind
            => TypeKind.Tensor;
    }

    [Free]
    public interface ITensor<T> : ITensor, IPrimitive<T>
        where T : unmanaged
    {
    }

    [Free]
    public interface ITensor<N,T> : ITensor<T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        byte ITensor.Arity
            => Typed.nat8u<N>();

        BitWidth IPrimitive.StorageWidth
            => Arity*core.width<T>();
    }
}