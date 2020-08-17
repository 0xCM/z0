//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    
    public readonly struct CodeGen
    {
        public static PortableExecutableReference pe<T>()
            => PortableExecutableReference.CreateFromFile(typeof(T).Assembly.Location);

        public static PortableExecutableReference pe(Type src)
            => PortableExecutableReference.CreateFromFile(src.Assembly.Location);

        public static PortableExecutableReference[] pe(params Type[] src)
            => src.Select(pe);

        public static CSharpCompilation compilation(string name)
            => CSharpCompilation.Create(name);

        public static SyntaxTree parse(string src)
            => CSharpSyntaxTree.ParseText(src);
    }
}