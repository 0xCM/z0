//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;

    using A = PartIdAttribute;

    /// <summary>
    /// Defines a collection of resolved assemblies
    /// </summary>
    [ApiHost]
    public readonly struct ApiPart : IResolvedApi,  ITextual
    {
        [MethodImpl(Inline)]
        public static IApiHost<H> host<H>()
            where H : IApiHost<H>, new()
                => new H();

        public static IPartCatalog catalog(IPart part)
            => new PartCatalog(part, dataTypeHosts(part.Owner), opHosts(part.Owner), svcHostTypes(part.Owner));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiDataTypeAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        static ApiDataType[] dataTypeHosts(Assembly src)
        {
            var part = src.Id();
            var types = span(src.GetTypes().Where(t => t.Tagged<ApiDataTypeAttribute>()));
            var count = types.Length;
            var buffer = alloc<ApiDataType>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                var attrib = type.Tag<ApiDataTypeAttribute>();
                var name =  text.ifblank(attrib.MapValueOrDefault(a => a.Name, type.Name),type.Name).ToLower();
                var uri = ApiHostUri.Define(part, name);
                seek(dst,i) = new ApiDataType(type, name, part, uri);
            }
            return buffer;
        }

        static ApiHost[] opHosts(Assembly src)
        {
            var part = src.Id();
            return opHostTypes(src).Select(h => opHost(part, h));
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        static Type[] svcHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        static Type[] opHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<ApiHostAttribute>());

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        static ApiHost opHost(PartId part, Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifblank(attrib.MapValueOrDefault(a => a.HostName, t.Name),t.Name).ToLower();
            var uri = ApiHostUri.Define(part, name);
            return new ApiHost(t, name, part, uri);
        }

        /// <summary>
        /// Retrieves the part identifier, if any, of the entry assembly
        /// </summary>
        public static PartId Executing
            => id(Assembly.GetEntryAssembly());

        [MethodImpl(Inline), Op]
        public static IApiSet apiset(IResolvedApi resolved)
            => new ApiSet(resolved);

        /// <summary>
        /// Retrieves the part identifier, if any, of a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static PartId id(Assembly src)
        {
            if(test(src))
                return ((A)Attribute.GetCustomAttribute(src, typeof(A))).Id;
            else
                return PartId.None;
        }

        [MethodImpl(Inline), Op]
        public static bool isSvc(PartId a)
            => (a & PartId.Svc) != 0;

        [MethodImpl(Inline), Op]
        public static bool isTest(PartId a)
            => (a & PartId.Test) != 0;

        [MethodImpl(Inline), Op]
        public static bool test(Assembly src)
            => Attribute.IsDefined(src, typeof(A));
        public static IPart[] Known
            => ModuleArchives.executing().Known.Where(r => r.Id != 0);

        [MethodImpl(Inline), Op]
        public static ApiPart assemble(params IPart[] parts)
            => new ApiPart(parts);

        [MethodImpl(Inline), Op]
        public static void identities(Assembly[] src)
            => Part.identities(src);

        [MethodImpl(Inline), Op]
        public static Assembly[] parts(in ModuleArchive src)
            => src.Assemblies.Where(a => a.Id() != 0);

        [MethodImpl(Inline), Op]
        public static ApiPart Assemble(in ModuleArchive src)
            => ApiPart.assemble(Known);

        [MethodImpl(Inline), Op]
        public static ApiPart Assemble(IEnumerable<IPart> parts)
            => new ApiPart(parts.ToArray());

        [MethodImpl(Inline)]
        public ApiPart(IPart[] resolved)
            => Resolved = resolved;

        /// <summary>
        /// The members of the compostion
        /// </summary>
        public IPart[] Resolved {get;}

        public bool IsEmpty
            => Resolved.Length == 0;

        public string Format()
        {
            var dst = text.build();
            for(var i=0; i < Resolved.Length; i++)
            {
                dst.Append(Resolved[i].Format());
                if(i != Resolved.Length - 1)
                {
                    dst.Append(Chars.Comma);
                    dst.Append(Chars.Space);
                }
            }
            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}