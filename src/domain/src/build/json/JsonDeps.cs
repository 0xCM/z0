//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyModel;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct JsonDeps
    {
        [MethodImpl(Inline), Op]
        public static ProjectDependency dependency(string assembly, string version)
        {
            var dst = new ProjectDependency();
            dst.AssemblyName = assembly;
            dst.AssemblyVersion = version;
            return dst;
        }

        [Op]
        public static ProjectDependencies dependencies(FS.FilePath src)
        {
            using var reader = new DependencyContextJsonReader();
            using var stream = src.Stream();
            return new ProjectDependencies(reader.Read(stream));
        }

        [Op]
        public static ProjectDependencies dependencies(Assembly src)
        {
            var loader = new DependencyContextLoader();
            var ctx = insist(loader.Load(src));
            return new ProjectDependencies(ctx);
        }

        [Op]
        public static ref Options data(CompilationOptions src, out Options dst)
        {
            dst.AllowUnsafe = src.AllowUnsafe;
            dst.DebugType = src.DebugType;
            dst.Defines = src.Defines.Array();
            dst.DelaySign = src.DelaySign;
            dst.EmitEntryPoint = src.EmitEntryPoint;
            dst.GenerateXmlDocumentation = src.GenerateXmlDocumentation;
            dst.KeyFile = src.KeyFile;
            dst.LanguageVersion = src.LanguageVersion;
            dst.Optimize = src.Optimize;
            dst.Platform = src.Platform;
            dst.PublicSign = src.PublicSign;
            dst.WarningsAsErrors = src.WarningsAsErrors;
            return ref dst;
        }
    }
}