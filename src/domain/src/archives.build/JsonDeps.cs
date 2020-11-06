//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.Extensions.DependencyModel;
    using System.Reflection;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.JsonDeps, true)]
    public readonly partial struct JsonDeps
    {
        public static FS.FileExt Ext => FS.ext("deps", "json");

        [Op]
        internal static ref Library map(in CompilationLibrary src, ref Library dst)
        {
            dst.Name = src.Name;
            dst.Path = FS.path(src.Path);
            dst.Version = src.Version;
            dst.Hash = src.Hash;
            dst.Serviceable = src.Serviceable;
            dst.HashPath = src.HashPath;
            dst.RuntimeStoreManifestName = src.RuntimeStoreManifestName;
            return ref dst;
        }

        [Op]
        internal static ref Options map(in CompilationOptions src, ref Options dst)
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

        [MethodImpl(Inline), Op]
        public static ProjectDependency dependency(string assembly, string version)
        {
            var dst = new ProjectDependency();
            dst.AssemblyName = assembly;
            dst.AssemblyVersion = version;
            return dst;
        }

        static Encoding s_utf8NoPreamble =>
            new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        static DependencyContext context(JsonText text)
        {
            using(var stream = new MemoryStream(Encoding.UTF8.GetMaxByteCount(text.Length)))
            using(var writer = new StreamWriter(stream, s_utf8NoPreamble))
            {
                writer.Write(text.Content);
                writer.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                return new DependencyContextJsonReader().Read(stream);
            }
        }

        [Op]
        public static ProjectDependencies dependencies(FS.FilePath src)
            => new ProjectDependencies(context(src.ReadText()));

        [Op]
        public static JsonText json(Assembly src)
        {
            var path = FS.path(src.Location).ChangeExtension(JsonDeps.Ext);
            insist(path);
            return path.ReadText();
        }

        [Op]
        public static ProjectDependencies dependencies(Assembly src)
            => new ProjectDependencies(context(json(src)));
    }
}