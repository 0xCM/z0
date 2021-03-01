//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.IO;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.Emit;

    using Z0.Lang;

    public readonly struct ToolShims
    {
        public static EmitResult create(ToolShimSpec config)
        {
            var compile = compilation(config);
            var dst = config.TargetPath.EnsureParentExists();

            using (var exe = new FileStream(dst.Name, FileMode.Create))
            using (var resources = compile.CreateDefaultWin32Resources(true, true, null, null))
                return compile.Emit(exe, win32Resources: resources);
        }

        public static CSharpCompilation compilation(ToolShimSpec config)
        {
            root.require(config.Source.Exists, () => $"The file {config.Source}, it must exist");

            var refs = CsLang.pe(typeof(object), typeof(Enumerable), typeof(ProcessStartInfo));
            var dst = FS.create(config.OutDir) + FS.file(config.Name, FS.Extensions.Exe);
            var code = new ToolShimCode(dst);
            return CsLang.compilation(config.Name, refs, CsLang.parse(code.Generate()));
        }

        public static bool create(ToolShimSpec spec, out EmitResult dst, out string[] errors)
        {
            errors = sys.empty<string>();
            dst = create(spec);
            if(!dst.Success)
                errors = dst.Diagnostics.Map(x => x.ToString()).Array();
            return dst.Success;
        }
    }
}