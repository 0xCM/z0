namespace Z0
{
    using System.Reflection.Metadata;
    using System.Reflection;
    using System;

    public class MetaTables
    {
        public struct AssemblyRefTableRow
        {
            public Version Version;

            public BlobHandle PublicKeyToken;

            public StringHandle Name;

            public StringHandle Culture;

            public uint Flags;

            public BlobHandle HashValue;
        }

        public struct ModuleRow
        {
            public ushort Generation;

            public StringHandle Name;

            public GuidHandle ModuleVersionId;

            public GuidHandle EncId;

            public GuidHandle EncBaseId;
        }

        public struct AssemblyRow
        {
            public uint HashAlgorithm;

            public Version Version;

            public ushort Flags;

            public BlobHandle AssemblyKey;

            public StringHandle AssemblyName;

            public StringHandle AssemblyCulture;
        }

        public struct ClassLayoutRow
        {
            public ushort PackingSize;

            public uint ClassSize;

            public int Parent;
        }

        public struct ConstantRow
        {
            public byte Type;

            public int Parent;

            public BlobHandle Value;
        }

        public struct CustomAttributeRow
        {
            public int Parent;

            public int Type;

            public BlobHandle Value;
        }

        public struct DeclSecurityRow
        {
            public ushort Action;

            public int Parent;

            public BlobHandle PermissionSet;
        }

        public struct EncLogRow
        {
            public int Token;

            public byte FuncCode;
        }

        public struct EncMapRow
        {
            public int Token;
        }

        public struct EventRow
        {
            public ushort EventFlags;

            public StringHandle Name;

            public int EventType;
        }

        public struct EventMapRow
        {
            public int Parent;

            public int EventList;
        }

        public struct ExportedTypeRow
        {
            public uint Flags;

            public int TypeDefId;

            public StringHandle TypeName;

            public StringHandle TypeNamespace;

            public int Implementation;
        }

        public struct FieldLayoutRow
        {
            public int Offset;

            public int Field;
        }

        public struct FieldMarshalRow
        {
            public int Parent;

            public BlobHandle NativeType;
        }

        public struct FieldRvaRow
        {
            public int Offset;

            public int Field;
        }

        public struct FieldDefRow
        {
            public ushort Flags;

            public StringHandle Name;

            public BlobHandle Signature;
        }

        public struct FileTableRow
        {
            public uint Flags;

            public StringHandle FileName;

            public BlobHandle HashValue;
        }

        public struct GenericParamConstraintRow
        {
            public int Owner;

            public int Constraint;
        }

        public struct GenericParamRow
        {
            public ushort Number;

            public ushort Flags;

            public int Owner;

            public StringHandle Name;
        }

        public struct ImplMapRow
        {
            public ushort MappingFlags;
            public int MemberForwarded;
            public StringHandle ImportName;
            public int ImportScope;
        }

        public struct InterfaceImplRow
        {
            public int Class;
            public int Interface;
        }

        public struct ManifestResourceRow
        {
            public uint Offset;

            public uint Flags;

            public StringHandle Name;

            public int Implementation;
        }

        public struct MemberRefRow
        {
            public int Class;

            public StringHandle Name;

            public BlobHandle Signature;
        }

        public struct MethodImplRow
        {
            public int Class;

            public int MethodBody;

            public int MethodDecl;
        }

        public struct MethodSemanticsRow
        {
            public ushort Semantic;
            public int Method;
            public int Association;
        }

        public struct MethodSpecRow
        {
            public int Method;
            public BlobHandle Instantiation;
        }

        public struct MethodRow
        {
            public int BodyOffset;

            public ushort ImplFlags;

            public ushort Flags;

            public StringHandle Name;

            public BlobHandle Signature;

            public int ParamList;
        }

        public struct ModuleRefRow
        {
            public StringHandle Name;
        }

        public struct NestedClassRow
        {
            public int NestedClass;

            public int EnclosingClass;
        }

        public struct ParamRow
        {
            public ushort Flags;

            public ushort Sequence;

            public StringHandle Name;
        }

        public struct PropertyMapRow
        {
            public int Parent;

            public int PropertyList;
        }

        public struct PropertyRow
        {
            public ushort PropFlags;

            public StringHandle Name;

            public BlobHandle Type;
        }

        public struct TypeDefRow
        {
            public uint Flags;

            public StringHandle Name;

            public StringHandle Namespace;

            public int Extends;

            public int FieldList;

            public int MethodList;
        }

        public struct TypeRefRow
        {
            public int ResolutionScope;

            public StringHandle Name;

            public StringHandle Namespace;
        }

        public struct TypeSpecRow
        {
            public BlobHandle Signature;
        }

        public struct StandaloneSigRow
        {
            public BlobHandle Signature;
        }

        // debug table rows:
        public struct DocumentRow
        {
            public BlobHandle Name;

            public GuidHandle HashAlgorithm;

            public BlobHandle Hash;

            public GuidHandle Language;
        }

        public struct MethodDebugInformationRow
        {
            public int Document;
            public BlobHandle SequencePoints;
        }

        public struct LocalScopeRow
        {
            public int Method;

            public int ImportScope;

            public int VariableList;

            public int ConstantList;

            public int StartOffset;

            public int Length;
        }

        public struct LocalVariableRow
        {
            public ushort Attributes;

            public ushort Index;

            public StringHandle Name;
        }

        public struct LocalConstantRow
        {
            public StringHandle Name;

            public BlobHandle Signature;
        }

        public struct ImportScopeRow
        {
            public int Parent;

            public BlobHandle Imports;
        }

        public struct StateMachineMethodRow
        {
            public int MoveNextMethod;

            public int KickoffMethod;
        }

        public struct CustomDebugInformationRow
        {
            public int Parent;

            public GuidHandle Kind;

            public BlobHandle Value;
        }
    }
}