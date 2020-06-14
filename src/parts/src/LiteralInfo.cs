//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Covers a value that can be interpreted as a compile-time literal constant
    /// </summary>
    public readonly struct LiteralInfo : ILiteral<LiteralInfo> 
    {
        public static LiteralInfo Empty 
            => new LiteralInfo(string.Empty, string.Empty, string.Empty, 0, false, false);

        public string Name {get;}        

        public object Data {get;}

        public string Text {get;}

        public TypeCode TypeCode {get;}
        
        public bool IsEnum {get;}

        public bool MultiLiteral {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == null || (Data is string s && string.IsNullOrWhiteSpace(s));
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public LiteralInfo Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public bool IsAnonymous
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Name);
        }

        public Type SystemType 
        {
            [MethodImpl(Inline)]
            get => Data?.GetType() ?? typeof(void);
        }
 
        [MethodImpl(Inline)]
        public static LiteralInfo Define(string Name, object Data, string Text, TypeCode TypeCode, bool IsEnum, bool MultiLiteral)
            => new LiteralInfo(Name,Data, Text, TypeCode, IsEnum, MultiLiteral);
        
        [MethodImpl(Inline)]
        LiteralInfo(string Name, object Data, string Text, TypeCode TypeCode, bool IsEnum, bool MultiLiteral)
        {
            this.Name = Name;
            this.Data = Data;
            this.Text = Text;
            this.TypeCode = TypeCode;
            this.IsEnum = IsEnum;
            this.MultiLiteral = MultiLiteral;
        }

        [MethodImpl(Inline)]
        LiteralInfo(string name, byte data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.Byte;
            IsEnum = false;
            MultiLiteral = false;
        }        

        [MethodImpl(Inline)]
        LiteralInfo(string name, sbyte data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.SByte;
            IsEnum = false;
            MultiLiteral = false;
        }                

        [MethodImpl(Inline)]
        LiteralInfo(string name, short data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.Int16;
            IsEnum = false;
            MultiLiteral = false;
        }                

        [MethodImpl(Inline)]
        LiteralInfo(string name, ushort data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.UInt16;
            IsEnum = false;
            MultiLiteral = false;
        }                        

        [MethodImpl(Inline)]
        LiteralInfo(string name, int data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.Int32;
            IsEnum = false;
            MultiLiteral = false;
        }                        

        [MethodImpl(Inline)]
        LiteralInfo(string name, uint data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.UInt32;
            IsEnum = false;
            MultiLiteral = false;
        }                        

        [MethodImpl(Inline)]
        LiteralInfo(string name, long data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.Int64;
            IsEnum = false;
            MultiLiteral = false;
        }                        

        [MethodImpl(Inline)]
        LiteralInfo(string name, ulong data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.UInt64;
            IsEnum = false;
            MultiLiteral = false;
        }                        

        [MethodImpl(Inline)]
        LiteralInfo(string name, float data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.Single;
            IsEnum = false;
            MultiLiteral = false;
        }                        

        [MethodImpl(Inline)]
        LiteralInfo(string name, double data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.Double;
            IsEnum = false;
            MultiLiteral = false;
        }                        

        [MethodImpl(Inline)]
        LiteralInfo(string name, decimal data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.Decimal;
            IsEnum = false;
            MultiLiteral = false;
        }                        

        [MethodImpl(Inline)]
        LiteralInfo(string name, char data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.Char;
            IsEnum = false;
            MultiLiteral = false;
        }                        

        [MethodImpl(Inline)]
        LiteralInfo(string name, string data)
        {
            Name = name;
            Data = data?.Trim() ?? string.Empty;
            Text = data?.Trim() ?? string.Empty;
            TypeCode = TypeCode.String;
            IsEnum = false;
            MultiLiteral = false;
        }

        [MethodImpl(Inline)]
        LiteralInfo(string name, bool data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = TypeCode.Boolean;
            IsEnum = false;
            MultiLiteral = false;
        }        

        [MethodImpl(Inline)]
        LiteralInfo(string name, Enum data)
        {
            Name = name;
            Data = data;
            Text = data.ToString();
            TypeCode = data.GetTypeCode();
            IsEnum = true;
            MultiLiteral = false;
        }        

        [MethodImpl(Inline)]
        public bool Equals(LiteralInfo src)
            => object.Equals(Data,src.Data);
        
        [MethodImpl(Inline)]
        public string Format()
            => Data?.ToString() ?? string.Empty;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Data?.GetHashCode() ?? 0;
        
        public override bool Equals(object src)
            => src is LiteralInfo v && Equals(v);
    }
}