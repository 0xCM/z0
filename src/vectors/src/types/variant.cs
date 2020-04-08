//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;
    
    using static Seed;
    using static Vectors;

    using NK = NumericKind;
    
    public interface IVariant
    {
        /// <summary>
        /// The number of bits that are used to store the enclosed data
        /// </summary>
        int DataWidth {get;}

        /// <summary>
        /// The numeric data type if unsegmented or, if segmented, the numeric cell kind
        /// </summary>
        NK CellKind {get;}

        /// <summary>
        /// If covering scalar data, the cell count will always be 1; when blocked or vector data 
        /// is enclosed the cell count will vary based on the specific type
        /// </summary>
        int CellCount 
            => 1;

        /// <summary>
        /// If covering scalar data, will specify the width of the scalar type; otherwise,
        /// it will specify the width of a vector or block cell
        /// </summary>
        int CellWidth
            => DataWidth;

        /// <summary>
        /// For scalar data this bit will always be off; otherwise, it will be on
        /// </summary>
        bit Segmented 
            => CellWidth < DataWidth;        
    }

    public interface IVariant<V>  : IVariant, IEquatable<V>, IFormattable<V>
        where V : unmanaged, IVariant<V>
    {

    }

    public interface IScalarVariant<V> : IVariant<V>
        where V : unmanaged, IScalarVariant<V>
    {

    }

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public readonly struct variant : IScalarVariant<variant>
    {
        public static variant Zero => FromScalar(0);

        readonly Vector128<ulong> data;
        
        [MethodImpl(Inline)]
        public static variant FromGeneric<T>(T src)
            where T : unmanaged
                => new variant(Store((ulong)Cast.to<T,ulong>(src), NumericKinds.kind<T>(), (uint)BitSize.measure<T>()));

        [MethodImpl(Inline)]
        public static variant FromScalar(sbyte src)
            => new variant(src);

        [MethodImpl(Inline)]
        public static variant FromScalar(byte src)
            => new variant(src);

        [MethodImpl(Inline)]
        public static variant FromScalar(short src)
            => new variant(src);

        [MethodImpl(Inline)]
        public static variant FromScalar(ushort src)
            => new variant(src);

        [MethodImpl(Inline)]
        public static variant FromScalar(int src)
            => new variant(src);

        [MethodImpl(Inline)]
        public static variant FromScalar(uint src)
            => new variant(src);        

        [MethodImpl(Inline)]
        public static variant FromScalar(long src)
            => new variant(src);

        [MethodImpl(Inline)]
        public static variant FromScalar(ulong src)
            => new variant(src);

        [MethodImpl(Inline)]
        public static variant FromScalar(float src)
            => new variant(src);

        [MethodImpl(Inline)]
        public static variant FromScalar(double src)
            => new variant(src);

        [MethodImpl(Inline)]
        public T Extract<T>()
            where T : unmanaged
                => cell<T>(0);

        // [MethodImpl(Inline)]
        // public BoxedNumber Extract()
        //     => BoxedNumber.Define(Low64, CellKind);

        // [MethodImpl(Inline)]
        // public BoxedNumber Extract(NumericKind dst)
        //     => BoxedNumber.Define(Low64, dst);

        public variant Convert(NumericKind dst)
        {
            return dst switch
            {                        
                NK.I8 => FromScalar(Extract<sbyte>()),
                NK.U8 => FromScalar(Extract<byte>()),
                NK.I16 => FromScalar(Extract<short>()),
                NK.U16 => FromScalar(Extract<ushort>()),
                NK.I32 => FromScalar(Extract<int>()),
                NK.U32 => FromScalar(Extract<uint>()),
                NK.I64 => FromScalar(Extract<long>()),
                NK.U64 => FromScalar(Extract<ulong>()),
                NK.F32 => FromScalar(Extract<float>()),
                NK.F64 => FromScalar(Extract<double>()),
                _ => this,
            };
        }
        public NK CellKind
        {
            [MethodImpl(Inline)]
            get => (NK)cell<int>(2);
        }

        public int CellWidth
        {
            [MethodImpl(Inline)]
            get => cell<int>(3);
        }

        public int DataWidth
        {
            [MethodImpl(Inline)]
            get => CellWidth;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(variant x, variant y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(variant x, variant y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        variant(Vector128<ulong> src)
            => data = src;
        
        [MethodImpl(Inline)]
        public variant(sbyte value)
            => data = Store(value, NK.I8, 8);

        [MethodImpl(Inline)]
        public variant(byte value)
            => data = Store(value, NK.U8, 8);

        [MethodImpl(Inline)]
        public variant(short value)
            => data = Store(value, NK.I16, 16);

        [MethodImpl(Inline)]
        public variant(ushort value)
            => data = Store(value, NK.U16, 16);

        [MethodImpl(Inline)]
        public variant(int value)
            => data = Store(value, NK.I32, 32);

        [MethodImpl(Inline)]
        public variant(uint value)
            => data = Store(value, NK.U32, 32);

        [MethodImpl(Inline)]
        public variant(long value)
            => data = Store(value, NK.I64, 64);

        [MethodImpl(Inline)]
        public variant(ulong value)
            => data = Store(value, NK.U64, 64);

        [MethodImpl(Inline)]
        public variant(float value)
            => data = Store(value, NK.F32, 32);

        [MethodImpl(Inline)]
        public variant(double value)
            => data = Store(value, NK.F64, 64);

        public override int GetHashCode()
            => Low64.GetHashCode();

        [MethodImpl(Inline)]
        public bool Equals(variant src)
            => data.Equals(src.data);

        public override bool Equals(object src)
            => src is variant v && Equals(v);
 
        public string Format()
        {
            if(CellKind.IsUnsigned())
                return Low64.ToString();
            else if(CellKind.IsSigned())
                return cell<long>(0).ToString();
            else if(CellKind == NK.F32)
                return cell<float>(0).ToString();
            else   
                return cell<double>(0).ToString();
        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        Vector128<T> to<T>()
            where T : unmanaged
                => generic<T>(data);

        [MethodImpl(Inline)]
        T cell<T>(int index)
            where T : unmanaged
                => vcell(to<T>(), index);

        ulong Low64
        {
            [MethodImpl(Inline)]
            get => vcell(data,0);
        }

        ulong Hi64
        {
            [MethodImpl(Inline)]
            get => vcell(data,1);
        }

        [MethodImpl(Inline)]
        static Vector128<ulong> Store(ulong value, NK kind, uint bitwidth)
            => SetWidth(Vector128.Create(value, (ulong)kind), (uint)bitwidth);

        [MethodImpl(Inline)]
        static Vector128<ulong> Store(long value, NK kind, uint bitwidth)
            => SetWidth(Vector128.Create((ulong)value, (ulong)kind), (uint)bitwidth);

        [MethodImpl(Inline)]
        static Vector128<ulong> Store(double value, NK kind, uint bitwidth)
            => SetWidth(Vector128.Create((ulong)value, (ulong)kind), (uint)bitwidth);

        [MethodImpl(Inline)]
        static Vector128<ulong> SetWidth(Vector128<ulong> src, uint width)
            => v64u(vcell(v32u(src), 3, width));
    }
}