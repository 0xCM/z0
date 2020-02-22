//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    
    /// <summary>
    /// A numbered box
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public readonly struct BoxedNumber : INumeric, IEquatable<BoxedNumber>
    {
        public readonly object Value;     

        [MethodImpl(Inline)]
        BoxedNumber(object src)
            => this.Value = src ?? 0ul;

        public NumericKind Kind
            => Numeric.kind(Value.GetType());

        public bool IsSignedInt
            => Numeric.signed(Value);

        public bool IsUnsignedInt
            => Numeric.unsigned(Value);

        public bool IsFloat
            => Numeric.floating(Value);

        public FixedWidth Width
        {
            [MethodImpl(Inline)]
            get => 
                  IsW8 ? FixedWidth.W8 
                : IsW16 ? FixedWidth.W16 
                : IsW32 ? FixedWidth.W32 
                : IsW64 ? FixedWidth.W64 
                : FixedWidth.None;
        }

        [MethodImpl(Inline)]
        public static BoxedNumber Define<T>(T src)
            where T : unmanaged
                => new BoxedNumber(src);

        [MethodImpl(Inline)]
        public static BoxedNumber From(object src)
            => new BoxedNumber(src);

        [MethodImpl(Inline)]
        public BoxedNumber Convert(NumericKind dst)
            => From(dst.Convert(Value));

        [MethodImpl(Inline)]
        public T Extract<T>()
            where T : unmanaged
        {
            var dst = Convert<T>().Value;
            return Unsafe.As<object,T>(ref dst);
        }

        [MethodImpl(Inline)]
        public BoxedNumber Convert<T>()
            where T : unmanaged
                => Convert(typeof(T));

        [MethodImpl(Inline)]
        public BoxedNumber Convert(Type target)
            => From(target.NumericKind().Convert(Value));

        bool IsW8
        {
            [MethodImpl(Inline)]
            get => Value is byte || Value is sbyte;
        }

        bool IsW16
        {
            [MethodImpl(Inline)]
            get => Value is short || Value is ushort;
        }

        bool IsW32
        {
            [MethodImpl(Inline)]
            get => Value is int || Value is uint || Value is float;
        }

        bool IsW64
        {
            [MethodImpl(Inline)]
            get => Value is long || Value is ulong || Value is double;
        }

        [MethodImpl(Inline)]
        bool LiberalEquals(BoxedNumber rhs)
        {
            if(this.IsSignedInt && rhs.IsSignedInt)
                return Extract<long>() == rhs.Extract<long>();
            else if(this.IsUnsignedInt && rhs.IsUnsignedInt)
                return Extract<ulong>() == rhs.Extract<ulong>();
            else if(this.IsFloat && rhs.IsFloat)
                return Extract<double>() == rhs.Extract<double>();
            else   
                return false;
        }
       
        [MethodImpl(Inline)]
        public bool Equals(BoxedNumber other)
            => Value.Equals(other.Value);

        public override string ToString()
            => Value.ToString();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object other)
            => other is BoxedNumber n && Equals(n);


        IComparable Comparable
        {
            [MethodImpl(Inline)]
            get => Value as IComparable;
        }

        IFormattable Formattable
        {
            [MethodImpl(Inline)]
            get => Value as IFormattable;
        }

        IConvertible Convertible
        {
            [MethodImpl(Inline)]
            get => Value as IConvertible;
        }

        [MethodImpl(Inline)]
        public static bool operator==(BoxedNumber a, BoxedNumber b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(BoxedNumber a, BoxedNumber b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator BoxedNumber(sbyte src)        
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BoxedNumber(byte src)        
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BoxedNumber(short src)        
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BoxedNumber(ushort src)        
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BoxedNumber(int src)        
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BoxedNumber(uint src)        
            => Define(src);
            
        [MethodImpl(Inline)]
        public static implicit operator BoxedNumber(long src)        
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BoxedNumber(ulong src)        
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BoxedNumber(float src)        
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BoxedNumber(double src)        
            => Define(src);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(BoxedNumber src)        
            => src.Extract<sbyte>();

        [MethodImpl(Inline)]
        public static explicit operator short(BoxedNumber src)        
            => src.Extract<short>();

        [MethodImpl(Inline)]
        public static explicit operator int(BoxedNumber src)        
            => src.Extract<int>();

        [MethodImpl(Inline)]
        public static explicit operator long(BoxedNumber src)        
            => src.Extract<long>();

        [MethodImpl(Inline)]
        public static explicit operator byte(BoxedNumber src)        
            => src.Extract<byte>();

        [MethodImpl(Inline)]
        public static explicit operator ushort(BoxedNumber src)        
            => src.Extract<ushort>();

        [MethodImpl(Inline)]
        public static explicit operator uint(BoxedNumber src)        
            => src.Extract<uint>();

        [MethodImpl(Inline)]
        public static explicit operator ulong(BoxedNumber src)        
            => src.Extract<ulong>();

        [MethodImpl(Inline)]
        public static explicit operator float(BoxedNumber src)        
            => src.Extract<float>();

        [MethodImpl(Inline)]
        public static explicit operator double(BoxedNumber src)        
            => src.Extract<double>();

        
        [MethodImpl(Inline)]
        TypeCode IConvertible.GetTypeCode()        
            => Convertible.GetTypeCode();
        
        [MethodImpl(Inline)]
        bool IConvertible.ToBoolean(IFormatProvider provider)    
            => Convertible.ToBoolean(provider);

        [MethodImpl(Inline)]
        byte IConvertible.ToByte(IFormatProvider provider)        
            => Convertible.ToByte(provider);
        
        [MethodImpl(Inline)]
        char IConvertible.ToChar(IFormatProvider provider)        
            => Convertible.ToChar(provider);
        
        [MethodImpl(Inline)]
        DateTime IConvertible.ToDateTime(IFormatProvider provider)        
            => Convertible.ToDateTime(provider);        

        [MethodImpl(Inline)]
        decimal IConvertible.ToDecimal(IFormatProvider provider)        
            => Convertible.ToDecimal(provider);        

        [MethodImpl(Inline)]
        double IConvertible.ToDouble(IFormatProvider provider)        
            => Convertible.ToDouble(provider);        

        [MethodImpl(Inline)]
        short IConvertible.ToInt16(IFormatProvider provider)    
            => Convertible.ToInt16(provider);        

        [MethodImpl(Inline)]
        int IConvertible.ToInt32(IFormatProvider provider)        
            => Convertible.ToInt32(provider);
        
        [MethodImpl(Inline)]
        long IConvertible.ToInt64(IFormatProvider provider)        
            => Convertible.ToInt64(provider);
        
        [MethodImpl(Inline)]
        sbyte IConvertible.ToSByte(IFormatProvider provider)        
            => Convertible.ToSByte(provider);
        
        [MethodImpl(Inline)]
        float IConvertible.ToSingle(IFormatProvider provider)        
            => Convertible.ToSingle(provider);        
        
        [MethodImpl(Inline)]
        string IConvertible.ToString(IFormatProvider provider)        
            => Convertible.ToString(provider);        

        [MethodImpl(Inline)]
        object IConvertible.ToType(Type conversionType, IFormatProvider provider)        
            => Convertible.ToType(conversionType, provider);
        
        [MethodImpl(Inline)]
        ushort IConvertible.ToUInt16(IFormatProvider provider)        
            => Convertible.ToUInt16(provider);
        
        [MethodImpl(Inline)]
        uint IConvertible.ToUInt32(IFormatProvider provider)        
            => Convertible.ToUInt32(provider);

        [MethodImpl(Inline)]
        ulong IConvertible.ToUInt64(IFormatProvider provider)        
            => Convertible.ToUInt64(provider);    

        [MethodImpl(Inline)]
        int IComparable.CompareTo(object obj)        
            => Comparable.CompareTo(obj);

        [MethodImpl(Inline)]
        string IFormattable.ToString(string format, IFormatProvider formatProvider)        
            => Formattable.ToString(format, formatProvider);     
    }
}