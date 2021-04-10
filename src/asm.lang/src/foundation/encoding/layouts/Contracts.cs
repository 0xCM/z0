//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct LayoutComponents
    {
        public interface ISegment : INullity
        {
            uint3 Component {get;}

            DataWidth Width {get;}
        }

        public interface ISized<W> : ISegment
            where W : unmanaged, IDataWidth
        {
            DataWidth ISegment.Width
                => Widths.data<W>();
        }

        public interface ISequenced<N> : ISegment
            where N : unmanaged, ITypeNat
        {
            uint3 ISegment.Component
                => memory.nat8u<N>();
        }

        public interface IRegister : ISegment
        {

        }

        public interface IRegister<N> : IRegister, ISequenced<N>
            where N : unmanaged, ITypeNat
        {

        }

        public interface ISegment<N> : ISequenced<N>
            where N : unmanaged, ITypeNat
        {

        }

        public interface ISegment<N,W> : ISequenced<N>, ISized<W>
            where N : unmanaged, ITypeNat
            where W : unmanaged, IDataWidth
        {

        }

        public interface IPrefix : ISegment<N0,W8>
        {
            Cell8 Value {get;}
        }

        public interface IOpCode : ISegment<N1>
        {

        }

        public interface IOpCode<W> : IOpCode, ISized<W>
            where W : unmanaged, IDataWidth
        {

        }

        public interface IOneByteOpCode : IOpCode<W8>
        {

        }

        public interface ITwoByteOpCode : IOpCode<W16>
        {

        }

        public interface IThreeByteOpCode : IOpCode<W24>
        {

        }

        public interface IModRm : ISegment<N2,W8>
        {
            uint3 Rm {get;}

            uint3 Reg {get;}

            uint2 Mod {get;}
        }

        public interface ISib : ISegment<N3,W8>
        {
            uint3 Base {get;}

            uint3 Index {get;}

            uint2 Scale {get;}
        }

        public interface IDisplacement : ISegment<N4>
        {

        }


        public interface IDisplacement<W> : IDisplacement, ISized<W>
            where W : unmanaged, IDataWidth
        {

        }

        public interface IOneByteDisplacement : IDisplacement<W8>
        {

        }

        public interface ITwoByteDisplacement : IDisplacement<W16>
        {

        }


    }
}