//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static z;

    using NK = NumericKind;
    
    public readonly struct variant : IVariant<variant>
    {
        internal readonly Vector128<ulong> data;

        public static variant Zero 
            => default;
        
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
        internal variant(Vector128<ulong> src)
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
        T cell<T>(byte index)
            where T : unmanaged
                => vcell(to<T>(), index);

        ulong Low64
        {
            [MethodImpl(Inline)]
            get => vcell(data,0);
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