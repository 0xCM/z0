//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang.Cs
{
    using System;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static ModelKinds;

    [ApiHost(ApiNames.CsLang, true)]
    public readonly partial struct CsLang
    {
        [MethodImpl(Inline), Op]
        public static SwitchMap<C,T> build<C,T>(SwitchMap k, Identifier name, Tests<C,T> cases)
            => new SwitchMap<C,T>(name,cases);

        public static PortableExecutableReference pe<T>()
            => PortableExecutableReference.CreateFromFile(typeof(T).Assembly.Location);

        [Op]
        public static PortableExecutableReference pe(Type src)
            => PortableExecutableReference.CreateFromFile(src.Assembly.Location);

        [Op]
        public static PortableExecutableReference[] pe(params Type[] src)
            => src.Select(pe);

        [Op]
        public static CSharpCompilation compilation(string name)
            => CSharpCompilation.Create(name);

        [Op]
        public static SyntaxTree parse(string src)
            => CSharpSyntaxTree.ParseText(src);

        [Op]
        public static CSharpCompilation compilation(string name, MetadataReference[] refs)
            => compilation(name).AddReferences(refs);

        [Op]
        public static CSharpCompilation compilation(string name, MetadataReference[] refs, params SyntaxTree[] syntax)
            => compilation(name,refs).AddSyntaxTrees(syntax);
    }
}