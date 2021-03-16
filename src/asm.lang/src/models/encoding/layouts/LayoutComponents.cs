//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct LayoutComponents
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

        public readonly struct Prefix : IPrefix
        {
            public Cell8 Value {get;}

            public Prefix(Cell8 value)
            {
                Value = value;
            }

            public bool IsEmpty
                => Value == 0;
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

        public interface IFourByteDisplacement : IDisplacement<W32>
        {

        }

        public interface IImm : ISegment<N5>
        {
            ReadOnlySpan<byte> Data {get;}
        }

        public interface IImm<W,T> : IImm, ISized<W>, IImmediate<W,T>
            where W : unmanaged, INumericWidth
            where T : unmanaged
        {
            T Value {get;}

            ReadOnlySpan<byte> IImm.Data
                => memory.bytes(Value);
        }


        public interface IOneByteImm : IImm<W8,Cell8>
        {

        }


        public interface ITwoByteImm : IImm<W16,Cell16>
        {

        }

        public interface IFourByteImm : IImm<W32,Cell32>
        {

        }

        public readonly struct Immediate : IImm
        {
            Cell32 Value {get;}

            public DataWidth Width {get;}

            public Immediate(Cell8 value)
            {
                Value = value;
                Width = DataWidth.W8;
            }

            public Immediate(Cell16 value)
            {
                Value = value;
                Width = DataWidth.W16;
            }

            public Immediate(Cell32 value)
            {
                Value = value;
                Width = DataWidth.W32;
            }

            public ReadOnlySpan<byte> Data
                => memory.slice(memory.bytes(Value),0, (byte)Width/8);

            public bool IsEmpty
                => Value == 0;

        }

        public readonly struct Displacement : IDisplacement
        {
            public DataWidth Width {get;}
            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Width == 0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }
        }

        public readonly struct Sib : ISib
        {
            public uint3 Base {get;}

            public uint3 Index {get;}

            public uint2 Scale {get;}

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Base == 0 && Index == 0 && Scale == 0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }

            public static Sib Empty
                => default;
        }

        public readonly struct ModRm : IModRm
        {
            public uint3 Rm {get;}

            public uint3 Reg {get;}

            public uint2 Mod {get;}

            public ModRm(uint3 rm, uint3 reg, uint2 mod)
            {
                Rm = rm;
                Reg = reg;
                Mod = mod;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Rm == 0 && Reg == 0 && Mod ==0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }

            public static ModRm Empty
                => default;
        }

        public readonly struct OneByteImm : IOneByteImm
        {
            public Cell8 Value {get;}

            [MethodImpl(Inline)]
            public OneByteImm(Cell8 value)
            {
                Value = value;
            }
            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Value == 0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }

            public static OneByteImm Empty
                => default;
        }

        public readonly struct TwoByteImm : ITwoByteImm
        {
            public Cell16 Value {get;}

            [MethodImpl(Inline)]
            public TwoByteImm(Cell16 value)
            {
                Value = value;
            }
            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Value == 0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }

            public static TwoByteImm Empty
                => default;
        }

        public readonly struct FourByteImm : IFourByteImm
        {
            public Cell32 Value {get;}

            [MethodImpl(Inline)]
            public FourByteImm(Cell32 value)
            {
                Value = value;
            }
            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Value == 0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }

            public static FourByteImm Empty
                => default;
        }
    }
}