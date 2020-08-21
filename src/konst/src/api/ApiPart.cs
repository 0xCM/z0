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

    using A = PartIdAttribute;

    /// <summary>
    /// Defines a collection of resolved assemblies
    /// </summary>
    [ApiHost]
    public readonly struct ApiPart : IResolvedApi,  ITextual
    {
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