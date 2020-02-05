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
    
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public readonly partial struct BoxedNumber : INumeric, IEquatable<BoxedNumber>
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

        public NumericClass Class
        {
            [MethodImpl(Inline)]
            get => 
                  IsUnsignedInt ? NumericClass.Unsigned 
                : IsSignedInt ? NumericClass.Signed 
                : IsFloat ? NumericClass.Float 
                : NumericClass.None;
        }

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
    }
}