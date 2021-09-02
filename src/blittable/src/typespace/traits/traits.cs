//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types
{
    using Z0;

    using static Z0.core;

    namespace traits
    {
        public interface Type
        {
            ByteSize StorageSize {get;}

            BitWidth DataWidth {get;}
        }

        public interface Type<S> : Type
            where S : unmanaged
        {
            S Storage {get;}

            ByteSize Type.StorageSize
                => size<S>();
        }

        public interface Cellular : Type
        {
            BitWidth CellWidth {get;}

            uint CellCount {get;}

            BitWidth Type.DataWidth
                => CellCount*CellWidth;
        }

        public interface Scalar : Type
        {
            uint N  {get;}

            BitWidth Type.DataWidth
                => N;
        }

        public interface Scalar<S> : Scalar, Type<S>
            where S : unmanaged
        {

        }

        public interface Integral : Scalar
        {

        }

        public interface Integral<S> : Integral, Scalar<S>
            where S : unmanaged
        {

        }

        public interface Float : Scalar
        {

        }

        public interface Float<S> : Float, Scalar<S>
            where S : unmanaged
        {

        }

        public interface U : Integral
        {
        }

        public interface U<S> : U, Integral<S>
            where S : unmanaged
        {

        }

        public interface I : Integral
        {

        }

        public interface I<S> : I, Integral<S>
            where S : unmanaged
        {

        }

        public interface F : Float
        {

        }

        public interface F<S> : F, Float<S>
            where S : unmanaged
        {

        }

        public interface Block : Cellular
        {
            ByteSize Type.StorageSize
                => ((ByteSize)CellWidth)*CellCount;
        }

        public interface Block<T> : Block
            where T : unmanaged
        {
            ref T this[uint cell] {get;}

            BitWidth Cellular.CellWidth
                => width<T>();
        }

        public interface Indexed : Cellular
        {
            uint N {get;}

            uint Cellular.CellCount
                => N;
        }

        public interface Indexed<T> : Indexed
            where T : unmanaged
        {
            BitWidth Cellular.CellWidth
                => width<T>();
        }

        public interface V : Indexed
        {

        }

        public interface V<S> : V, Type<S>
            where S : unmanaged
        {
            BitWidth Type.DataWidth
                => N*CellWidth;
        }

        public interface V<S,T> : V<S>
            where S : unmanaged
            where T : unmanaged
        {
            ref T this[uint cell] {get;}
        }

        public interface Array : Indexed
        {

        }

        public interface Array<T> : Array
            where T : unmanaged
        {
            ref T this[uint cell] {get;}

            BitWidth Type.DataWidth
                => N*width<T>();
        }

        public interface Grid : Type
        {
            uint M {get;}

            uint N {get;}

            BitWidth Type.DataWidth
                => M*N;
        }

        public interface Grid<S> : Grid, Type<S>
            where S : unmanaged
        {
        }

        public interface Grid<S,T> : Grid<S>
            where S : unmanaged
            where T : unmanaged
        {
            ref T this[uint row] {get;}
        }

        public interface Map<S,T> : Type
            where S : unmanaged, Type
            where T : unmanaged, Type
        {
            S Source {get;}

            T Target {get;}

            ByteSize Type.StorageSize
                => size<S>() + size<T>();

            BitWidth Type.DataWidth
                => Source.DataWidth + Target.DataWidth;
        }
    }
}