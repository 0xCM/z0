//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public static class ArtifactOps
    {   
        public static CodeFacets Normalize(this MemberFacets facets)
            => (CodeFacets)facets;

        public static CodeFacets Normalize(this FieldFacets facets)
            => (CodeFacets)facets;

        public static CodeFacets Normalize(this ClassFacets facets)
            => (CodeFacets)facets;

        public static CodeFacets Normalize(this TypeFacets facets)
            => (CodeFacets)facets;

        public static bool IsStatic(this CodeFacets facets)
            => (facets & Z0.CodeFacets.Static) != 0;

        public static bool IsPublic(this CodeFacets facets)
            => (facets & Z0.CodeFacets.Public) != 0;

        public static bool IsConst(this CodeFacets facets)
            => (facets & Z0.CodeFacets.Const) != 0;        
        public static bool IsStatic(this IMemberArtifact model)
            => model.Facets.Normalize().IsStatic();

        public static bool IsStatic(this ITypeArtifact model)
            => model.Facets.Normalize().IsPublic();

        public static bool IsPublic(this ITypeArtifact model)
            => model.Facets.Normalize().IsPublic();

        public static bool IsPublic(this IMemberArtifact model)
            => model.Facets.Normalize().IsPublic();

        public static bool IsStruct(this ITypeArtifact model)
            => model is StructArtifact;

        public static bool IsConst(this ITypeArtifact model)
            => model.Facets.Normalize().IsConst();

        public static bool IsConst(this IMemberArtifact model)
            => model.Facets.Normalize().IsConst();

        public static bool IsClass(this ITypeArtifact model)
            => model is ClassArtifact;       

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

        static string Format(this ConstFieldArtifact src)
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

        public static string Format(this IMemberArtifact src)
        {
            return src switch{
                ConstFieldArtifact x => x.Format(),
                _ => string.Empty
            };
        }
        
        public static string Format(this ITypeArtifact src, int offset)
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
                fmt.AppendLine(text.concat(indent + indent, m.Format()));
            
            fmt.AppendLine();
            fmt.Append(indent);
            fmt.Append(text.rbrace());            

            return fmt.ToString();                
        }


        public static string FormatDataProp<T>(this Span<T> src, [Caller] string propname = null)
            where T : unmanaged
                =>  ResourceData.GenAccessor(src.AsBytes(), propname);

        public static string FormatDataProp<T>(this ReadOnlySpan<T> src, [Caller] string propname = null)
            where T : unmanaged
                =>  ResourceData.GenAccessor(src.AsBytes(), propname);            
    }
}