//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang.Cs
{
    using System;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;

    using static Konst;
    using static z;

    public readonly partial struct CsLang
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

        public static CSharpCompilation compilation(string name, MetadataReference[] refs)
            => compilation(name).AddReferences(refs);

        public static CSharpCompilation compilation(string name, MetadataReference[] refs, params SyntaxTree[] syntax)
            => compilation(name,refs).AddSyntaxTrees(syntax);
    }
}