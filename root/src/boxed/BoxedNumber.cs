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
    [
        IdentityProvider, 
        UserType(TypeCodes.BoxedNumberId), 
        ConversionProvider(typeof(BoxedNumberConverter))
    ]
    public readonly struct BoxedNumber : INumeric, IEquatable<BoxedNumber>, ITypeIdentityProvider<BoxedNumber>
    {
        /// <summary>
        /// In the box
        /// </summary>
        public readonly object Boxed;     

        /// <summary>
        /// Box discriminator for runtime efficiency
        /// </summary>
        public readonly NumericKind Kind;

        [MethodImpl(Inline)]
        public static BoxedNumber Define<T>(T src)
            where T : unmanaged
                => new BoxedNumber(src, Numeric.kind<T>());

        [MethodImpl(Inline)]
        public static BoxedNumber Define(object src, NumericKind kind)
            => new BoxedNumber(src ?? new object(), kind);

        [MethodImpl(Inline)]
        BoxedNumber(object src, NumericKind kind)
        {
            this.Boxed = src;
            this.Kind = kind;
        }

        public bool IsSignedInt
            => Numeric.signed(Boxed);

        public bool IsUnsignedInt
            => Numeric.unsigned(Boxed);

        public bool IsFloat
            => Numeric.floating(Boxed);

        [MethodImpl(Inline)]
        public T Unbox<T>()
            where T : unmanaged
                => (T)Boxed;

        public Biconverter<BoxedNumber> Converter
        {
            [MethodImpl(Inline)]
            get => default(Biconverter<BoxedNumber>);
        }

        public T Convert<T>()
            where T : unmanaged
                => (T)typeof(T).NumericKind().Convert(Boxed);

        public BoxedNumber Convert(NumericKind target)
            => Define(target.Convert(Boxed), target);

        public BoxedNumber Convert(Type target)
            => Convert(target.NumericKind());

        IComparable Comparable
        {
            [MethodImpl(Inline)]
            get => Boxed as IComparable;
        }

        IFormattable Formattable
        {
            [MethodImpl(Inline)]
            get => Boxed as IFormattable;
        }

        IConvertible Convertible
        {
            [MethodImpl(Inline)]
            get => Boxed as IConvertible;
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
            => src.Convert<sbyte>();

        [MethodImpl(Inline)]
        public static explicit operator short(BoxedNumber src)        
            => src.Convert<short>();

        [MethodImpl(Inline)]
        public static explicit operator int(BoxedNumber src)        
            => src.Convert<int>();

        [MethodImpl(Inline)]
        public static explicit operator long(BoxedNumber src)        
            => src.Convert<long>();

        [MethodImpl(Inline)]
        public static explicit operator byte(BoxedNumber src)        
            => src.Convert<byte>();

        [MethodImpl(Inline)]
        public static explicit operator ushort(BoxedNumber src)        
            => src.Convert<ushort>();

        [MethodImpl(Inline)]
        public static explicit operator uint(BoxedNumber src)        
            => src.Convert<uint>();

        [MethodImpl(Inline)]
        public static explicit operator ulong(BoxedNumber src)        
            => src.Convert<ulong>();

        [MethodImpl(Inline)]
        public static explicit operator float(BoxedNumber src)        
            => src.Convert<float>();

        [MethodImpl(Inline)]
        public static explicit operator double(BoxedNumber src)        
            => src.Convert<double>();
       
        [MethodImpl(Inline)]
        public bool Equals(BoxedNumber other)
            => Boxed.Equals(other.Boxed);

        public override string ToString()
            => Boxed.ToString();

        public override int GetHashCode()
            => Boxed.GetHashCode();

        public override bool Equals(object other)
            => other is BoxedNumber n && Equals(n);

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
        public TypeIdentity DefineIdentity()
            => TypeIdentity.Define("nbox");
    }
}