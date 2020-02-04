//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static RootShare;
    
    partial struct BoxedNumber
    {
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