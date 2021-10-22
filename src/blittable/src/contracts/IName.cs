//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct BitFlow
    {
        [Free]
        public interface ITensor<T> : ITensor, IBlittable<T>
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

            BitWidth IBlittable.StorageWidth
                => Arity*core.width<T>();
        }
    }
}