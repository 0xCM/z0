//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static zfunc;

    public static class CodeGenX
    {
        static string FormatValue(object src)
        {
            if(src == null)
                return "null";
            
            return src switch{
                string x => text.enquote(x.ToString()),
                char x => text.squote(x.ToString()),
                object x => x.ToString()
            };
        }

        static string Format(this FieldModel src)
        {
            var fmt = string.Empty;
            var value = string.Empty;
            
            if(src.IsPublic())
                fmt += "public ";

            if(src.IsConst())
                fmt += "const ";

            fmt += src.Name;

            if(src.IsConst())                
                fmt += $" = {FormatValue(src.ConstValue.ValueOrDefault())}";

            fmt += text.semicolon();
            
            return fmt;
        }

        public static string Format(this IMemberInfo src)
        {
            return src switch{
                FieldModel x => x.Format(),
                _ => string.Empty
            };
        }
        public static string Format(this ITypeInfo src, int offset)
        {
            var indent = new string(AsciSym.Space, offset);
            var fmt = text.factory.Builder();

            fmt.Append(indent);

            if(src.IsPublic())
                fmt.Append("public ");
            
            if(src.IsStatic())
                fmt.Append("static ");
            
            if(src.IsConst())
                fmt.Append("readonly ");
            
            if(src.IsStruct())
                fmt.Append("struct");
            else if(src.IsClass())
                fmt.Append("class");            
            else 
                fmt.Append("unsupported");
            
            fmt.AppendLine();
            fmt.Append(indent);
            fmt.Append(text.lbrace());
            
            foreach(var m in src.Members)
                fmt.AppendLine(concat(indent + indent, m.Format()));
            
            fmt.AppendLine();
            fmt.Append(indent);
            fmt.Append(text.rbrace());            

            return fmt.ToString();                
        }


        public static string FormatDataProp<T>(this Vector128<T> src, [Caller] string propname = null)
            where T : unmanaged
                =>  InlineData.GenAccessor(src.ToSpan().AsBytes(), propname);

        public static string FormatDataProp<T>(this Vector256<T> src, [Caller] string propname = null)
            where T : unmanaged
                =>  InlineData.GenAccessor(src.ToSpan().AsBytes(), propname);

        public static string FormatDataProp<T>(this Span<T> src, [Caller] string propname = null)
            where T : unmanaged
                =>  InlineData.GenAccessor(src.AsBytes(), propname);

        public static string FormatDataProp<T>(this ReadOnlySpan<T> src, [Caller] string propname = null)
            where T : unmanaged
                =>  InlineData.GenAccessor(src.AsBytes(), propname);
    }

}