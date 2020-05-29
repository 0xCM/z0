//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [ApiHost("api")]
    public class Artifacts : IApiHost<Artifacts>
    {   
        [MethodImpl(Inline), Op]
        public static FieldEntity ConstField(string Declarer, string Name, string Description, string FieldType, object FieldValue)
            => new FieldEntity(
                Declarer: Declarer, 
                Name: Name, 
                Facets: new FieldFacets(AccessFacetKind.Public, ModifierFacetKind.Const), 
                Description: Description,
                FieldType: FieldType, 
                FieldValue: FieldValue);

        [MethodImpl(Inline), Op]
        public static ClassEntity Class(string ns, string name, ClassFacets facets, string Description, MemberEntity[] members)
            => new ClassEntity(ns, name, facets, Description, members);

        [MethodImpl(Inline), Op]
        public static StructEntity Struct(string ns, string name, StructFacets facets, string Description, MemberEntity[] members)
            => new StructEntity(ns, name, facets, Description, members);

        [MethodImpl(Inline), Op]
        public static EnumEntity Enum(string Namespace, string Declarer, string Identifier, EnumFacets Facets, string Description, LiteralEntity[] Members)
            => new EnumEntity(Namespace, Declarer, Identifier,Facets, Description, Members);
        
        [MethodImpl(Inline), Op]
        public static LiteralEntity Literal(string Declarer, string Identifier, int Index, string Description, ulong LiteralValue)
            => new LiteralEntity(Declarer, Identifier, Index, Description, LiteralValue);
    }

    public static partial class XTend
    {
        
    }
}