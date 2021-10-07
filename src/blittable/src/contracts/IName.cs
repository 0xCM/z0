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
        public interface IName : IBlittable
        {
            DataKind IBlittable.TypeKind
                => DataKind.Name;
        }

        [Free]
        public interface IName<T> : IName
            where T : unmanaged
        {

        }

        [Free]
        public interface IName<F,T> : IName<T>
            where T : unmanaged
            where F : unmanaged, IName<F,T>
        {
            uint Length {get;}

            byte PointSize {get;}

            BitWidth IBlittable.StorageWidth
                => core.width<F>();

            BitWidth IBlittable.ContentWidth
                => Length*PointSize;
        }

        [Free]
        public interface IUnsigned<T> : IUnsigned, IBlittable<T>
            where T : unmanaged
        {
        }

        [Free]
        public interface IChar<T> : IChar, IBlittable<T>
            where T : unmanaged
        {


        }

        [Free]
        public interface IChar<F,T> : IChar<T>
            where T : unmanaged
            where F : unmanaged, IChar<F,T>
        {

        }

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

        [Free]
        public interface ISigned<T> : ISigned, IBlittable<T>
            where T : unmanaged
        {
        }

        [Free]
        public interface IFloat<T> : IFloat, IBlittable<T>
            where T : unmanaged
        {

        }
    }
}