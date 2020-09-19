//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static ProjectModel;

    [ApiHost]
    public readonly partial struct Projects
    {
        const string NetSdk = "Microsoft.NET.Sdk";

        [Op]
        public static Project resbytes()
        {
            var itemBuffer = sys.alloc<ProjectItem>(4);
            var items = span(itemBuffer);
            seek(items,0) = resource("asm/**/*.asm");
            seek(items,1) = resource("docs/**/*.csv");
            seek(items,2) = resource("index/**/*.csv");
            seek(items,3) = resource("metadata/**/*.csv");

            var propBuffer = sys.alloc<ProjectProperty>(4);
            var props = span(propBuffer);
            seek(props,0) = library();
            seek(props,1) = netcoreapp(n3);

            return project("z0.res", netsdk(), default, itemBuffer);
        }

        [MethodImpl(Inline), Op]
        public static FS.FileName filename(in Project src, string type)
            => FS.file(src.Name, type);

        [Op]
        public static void save(in Project src, string type, FS.FolderPath dst)
            => (dst + filename(src,type)).Overwrite(src.Render());

        [MethodImpl(Inline), Op]
        public static Sdk sdk(string name)
            => new Sdk(name);

        [MethodImpl(Inline), Op]
        public static Sdk netsdk()
            => new Sdk(NetSdk);

        [MethodImpl(Inline), Op]
        public static Project project(string name, Sdk sdk, PropertyGroup props, ItemGroup items)
            => new Project(name, sdk, array(props), array(items));

        [MethodImpl(Inline), Op]
        public static Project project(string name, Sdk sdk, PropertyGroup[] props, ItemGroup[] items)
            => new Project(name, sdk, props, items);

        [MethodImpl(Inline), Op]
        public static Project project(string name, Sdk sdk, ProjectProperty[] props, ProjectItem[] _items)
            => project(name, sdk, properties(props), items(_items));

        [MethodImpl(Inline), Op]
        public static ProjectProperty<OutputType> library()
            => new OutputType(OutputTypes.Library);

        [MethodImpl(Inline), Op]
        public static ProjectProperty<OutputType> exe()
            => new OutputType(OutputTypes.Exe);

        [MethodImpl(Inline), Op]
        public static ProjectProperty<TargetFramework> netcoreapp(N3 major)
            => TargetFrameworks.netcoreapp3_0;

        [MethodImpl(Inline), Op]
        public static ProjectProperty<TargetFramework> netcoreapp(N3 major, N1 minor)
            => TargetFrameworks.netcoreapp3_1;

        [MethodImpl(Inline), Op]
        public static PropertyGroup properties(ProjectProperty[] src)
            => new PropertyGroup(src);

        [MethodImpl(Inline), Op]
        public static PropertyGroup properties<T>(T[] src)
            where T : IProjectProperty
                => new PropertyGroup(src.Map(x => new ProjectProperty(x)));

        [MethodImpl(Inline), Op]
        public static ItemGroup items<T>(T[] src)
            where T : IProjectItem
                => new ItemGroup(src.Map(x => new ProjectItem(x)));

        [MethodImpl(Inline), Op]
        public static ItemGroup items(ProjectItem[] src)
            => new ItemGroup(src);

        [MethodImpl(Inline), Op]
        public static ProjectItem<EmbeddedResource> resource(string include)
            => new EmbeddedResource(include);

        [MethodImpl(Inline), Op]
        public static TargetFramework framework(string value)
            => new TargetFramework(value);


        [MethodImpl(Inline), Op]
        public static string render(in EmbeddedResource src)
            => format(src);

        [MethodImpl(Inline), Op]
        public static string render(in TargetFramework src)
            => format(src);
    }
}