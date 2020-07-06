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
        public string Name {get;}        

        public object Data {get;}

        public string Text {get;}

        public TypeCode TypeCode {get;}
        
        public bool IsEnum {get;}

        public bool MultiLiteral {get;}

        public static LiteralInfo from(FieldInfo target)
        {
            var tagged = target.Tagged<LiteralAttribute>();
            if(tagged)
            {
                var attrib = (LiteralAttribute)target.GetCustomAttribute(typeof(LiteralAttribute));
                var data = attrib.Description;
                if(!string.IsNullOrWhiteSpace(data))
                    return LiteralInfo.Define(target.Name, 
                    target.GetRawConstantValue(), data, 
                    Type.GetTypeCode(target.FieldType), 
                    target.FieldType.IsEnum, 
                    false);
            }
            return LiteralInfo.Empty;
        }
        
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
        public LiteralInfo(string Name, object Data, string Text, TypeCode TypeCode, bool IsEnum, bool MultiLiteral)
        {
            this.Name = Name;
            this.Data = Data;
            this.Text = Text;
            this.TypeCode = TypeCode;
            this.IsEnum = IsEnum;
            this.MultiLiteral = MultiLiteral;
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

        public static LiteralInfo Empty 
            => new LiteralInfo(string.Empty, string.Empty, string.Empty, 0, false, false);
    }
}