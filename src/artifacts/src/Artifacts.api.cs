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
        public static FieldArtifact ConstField(string Declarer, string Name, string Description, string FieldType, object FieldValue)
            => new FieldArtifact(
                Declarer: Declarer, 
                Name: Name, 
                Facets: new FieldFacets(AccessFacetKind.Public, ModifierFacetKind.Const), 
                Description: Description,
                FieldType: FieldType, 
                FieldValue: FieldValue);

        [MethodImpl(Inline), Op]
        public static ClassArtifact Class(string ns, string name, ClassFacets facets, string Description, MemberArtifact[] members)
            => new ClassArtifact(ns, name, facets, Description, members);

        [MethodImpl(Inline), Op]
        public static StructArtifact Struct(string ns, string name, StructFacets facets, string Description, MemberArtifact[] members)
            => new StructArtifact(ns, name, facets, Description, members);

        [MethodImpl(Inline), Op]
        public static EnumArtifact Enum(string Namespace, string Declarer, string Identifier, EnumPrimalKind DataType, TypeFacets Facets, string Description, EnumLiteralField[] Members)
            => new EnumArtifact(Namespace, Declarer, Identifier, DataType, Facets, Description, Members);
        
        [MethodImpl(Inline), Op]
        public static EnumLiteralField EnumLiteral(string Declarer, string Identifier, int Index, string Description, EnumPrimalKind DataType, ulong LiteralValue)
            => new EnumLiteralField(Declarer, Identifier, Index, Description, DataType, LiteralValue);
    }

    public static partial class XTend
    {
        
    }
}