//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.IO;
    using Microsoft.CodeAnalysis.Emit;

    [ApiHost]
    public readonly struct CsTools
    {
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


        public static CSharpCompilation compilation(ToolShimSpec config)
        {
            root.require(config.Source.Exists, () => $"The file {config.Source}, it must exist");

            var refs = CsTools.pe(typeof(object), typeof(Enumerable), typeof(ProcessStartInfo));
            var dst = FS.create(config.OutDir) + FS.file(config.Name, FS.Extensions.Exe);
            var code = new ToolShimCode(dst);
            return CsTools.compilation(config.Name, refs, CsTools.parse(code.Generate()));
        }

        public static EmitResult shim(ToolShimSpec config)
        {
            var compile = CsTools.compilation(config);
            var dst = config.TargetPath.EnsureParentExists();

            using (var exe = new FileStream(dst.Name, FileMode.Create))
            using (var resources = compile.CreateDefaultWin32Resources(true, true, null, null))
                return compile.Emit(exe, win32Resources: resources);
        }

        public static bool shim(ToolShimSpec spec, out EmitResult dst, out string[] errors)
        {
            errors = sys.empty<string>();
            dst = shim(spec);
            if(!dst.Success)
                errors = dst.Diagnostics.Map(x => x.ToString()).Array();
            return dst.Success;
        }
    }
}