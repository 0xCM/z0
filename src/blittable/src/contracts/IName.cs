//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    partial struct Blit
    {
        [Free]
        public interface IName : IPrimitive
        {
            BlittableKind IPrimitive.TypeKind
                => BlittableKind.Name;
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

            BitWidth IPrimitive.StorageWidth
                => core.width<F>();

            BitWidth IPrimitive.ContentWidth
                => Length*PointSize;
        }
        [Free]
        public interface IBitVector<T> : IBitVector, IPrimitive<T>
            where T : unmanaged
        {

        }

        [Free]
        public interface IScalarBits<T> : IBitVector<T>
            where T : unmanaged
        {
            bit this[byte i] {get;set;}
        }
        [Free]
        public interface IUnsigned<T> : IUnsigned, IPrimitive<T>
            where T : unmanaged
        {
        }

        [Free]
        public interface IChar<T> : IChar, IPrimitive<T>
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

        [Free]
        public interface ISigned<T> : ISigned, IPrimitive<T>
            where T : unmanaged
        {
        }

        [Free]
        public interface IFloat<T> : IFloat, IPrimitive<T>
            where T : unmanaged
        {

        }


    }
}