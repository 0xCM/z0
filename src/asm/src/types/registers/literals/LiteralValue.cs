//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Covers a value that can be interpreted as a compile-time literal constant
    /// </summary>
    public readonly struct LiteralValue
    {
        readonly object Data;

        public readonly TypeCode Kind;

        public readonly bool IsEnum;

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(sbyte src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(byte src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(short src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(ushort src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(int src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(uint src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(long src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(ulong src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(float src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(double src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(decimal src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(string src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(char src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(bool src)        
            => new LiteralValue(src);

        [MethodImpl(Inline)]
        public static implicit operator LiteralValue(Enum src)        
            => new LiteralValue(src);
    
        [MethodImpl(Inline)]
        public LiteralValue(byte data)
        {
            Data = data;
            Kind = TypeCode.Byte;
            IsEnum = false;
        }        

        [MethodImpl(Inline)]
        public LiteralValue(sbyte data)
        {
            Data = data;
            Kind = TypeCode.SByte;
            IsEnum = false;
        }                

        [MethodImpl(Inline)]
        public LiteralValue(short data)
        {
            Data = data;
            Kind = TypeCode.Int16;
            IsEnum = false;
        }                

        [MethodImpl(Inline)]
        public LiteralValue(ushort data)
        {
            Data = data;
            Kind = TypeCode.UInt16;
            IsEnum = false;
        }                        

        [MethodImpl(Inline)]
        public LiteralValue(int data)
        {
            Data = data;
            Kind = TypeCode.Int32;
            IsEnum = false;
        }                        

        [MethodImpl(Inline)]
        public LiteralValue(uint data)
        {
            Data = data;
            Kind = TypeCode.UInt32;
            IsEnum = false;
        }                        

        [MethodImpl(Inline)]
        public LiteralValue(long data)
        {
            Data = data;
            Kind = TypeCode.Int64;
            IsEnum = false;
        }                        

        [MethodImpl(Inline)]
        public LiteralValue(ulong data)
        {
            Data = data;
            Kind = TypeCode.UInt64;
            IsEnum = false;
        }                        

        [MethodImpl(Inline)]
        public LiteralValue(float data)
        {
            Data = data;
            Kind = TypeCode.Single;
            IsEnum = false;
        }                        

        [MethodImpl(Inline)]
        public LiteralValue(double data)
        {
            Data = data;
            Kind = TypeCode.Double;
            IsEnum = false;
        }                        

        [MethodImpl(Inline)]
        public LiteralValue(decimal data)
        {
            Data = data;
            Kind = TypeCode.Decimal;
            IsEnum = false;
        }                        

        [MethodImpl(Inline)]
        public LiteralValue(char data)
        {
            Data = data;
            Kind = TypeCode.Char;
            IsEnum = false;
        }                        

        [MethodImpl(Inline)]
        public LiteralValue(string data)
        {
            Data = data;
            Kind = TypeCode.String;
            IsEnum = false;
        }

        [MethodImpl(Inline)]
        public LiteralValue(bool data)
        {
            Data = data;
            Kind = TypeCode.Boolean;
            IsEnum = false;
        }        

        [MethodImpl(Inline)]
        public LiteralValue(Enum data)
        {
            Data = data;
            Kind = data.GetTypeCode();
            IsEnum = true;
        }        
    }
}