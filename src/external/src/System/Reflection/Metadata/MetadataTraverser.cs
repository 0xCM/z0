// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace System.Reflection.Metadata
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection.Metadata.Ecma335;

    public sealed class MetadataTraverser
    {
        readonly TextWriter Writer;

        readonly IReadOnlyList<MetadataReader> Readers;

        readonly MetadataAggregator Aggregator;

        // enc map for each delta reader
        readonly ImmutableArray<ImmutableArray<EntityHandle>> EncMaps;

        private MetadataReader Reader;

        readonly List<string[]> PendingRows = new List<string[]>();

        MetadataTraverser(TextWriter writer, IReadOnlyList<MetadataReader> readers)
        {
            Writer = writer;
            Readers = readers;

            if (readers.Count > 1)
            {
                var deltaReaders = new List<MetadataReader>(readers.Skip(1));
                Aggregator = new MetadataAggregator(readers[0], deltaReaders);
                EncMaps = ImmutableArray.CreateRange(deltaReaders.Select(reader => ImmutableArray.CreateRange(reader.GetEditAndContinueMapEntries())));
            }
        }

        public MetadataTraverser(MetadataReader reader, TextWriter writer)
            : this(writer, new[] {reader})
        {
            Reader = reader;
        }

        public MetadataTraverser(IReadOnlyList<MetadataReader> readers, TextWriter writer)
            : this(writer, readers)
        {
        }

        public void VisualizeAllGenerations()
        {
            for (int i = 0; i<Readers.Count; i++)
            {
                Writer.WriteLine(">>>");
                Writer.WriteLine(string.Format(">>> Generation {0}:", i));
                Writer.WriteLine(">>>");
                Writer.WriteLine();

                Visualize(i);
            }
        }

        public void Visualize(int generation = -1)
        {
            Reader = (generation >= 0) ? Readers[generation] : Readers.Last();

            WriteModule();
            WriteTypeRef();
            WriteTypeDef();
            WriteField();
            WriteMethod();
            WriteParam();
            WriteMemberRef();
            WriteConstant();
            WriteCustomAttribute();
            WriteDeclSecurity();
            WriteStandAloneSig();
            WriteEvent();
            WriteProperty();
            WriteMethodImpl();
            WriteModuleRef();
            WriteTypeSpec();
            WriteEnCLog();
            WriteEnCMap();
            WriteAssembly();
            WriteAssemblyRef();
            WriteFile();
            WriteExportedType();
            WriteManifestResource();
            WriteGenericParam();
            WriteMethodSpec();
            WriteGenericParamConstraint();
            WriteUserStrings();
            WriteStrings();
            WriteBlobs();
            WriteGuids();
        }

        bool IsDelta
            => Reader.GetTableRowCount(TableIndex.EncLog) > 0;


        void AddHeader(params string[] header)
        {
            Debug.Assert(PendingRows.Count == 0);
            PendingRows.Add(header);
        }

        void AddRow(params string[] fields)
        {
            Debug.Assert(PendingRows.Count > 0 && PendingRows.Last().Length == fields.Length);
            PendingRows.Add(fields);
        }

        void WriteRows(string title)
        {
            Debug.Assert(PendingRows.Count > 0);

            if (PendingRows.Count == 1)
            {
                PendingRows.Clear();
                return;
            }

            Writer.Write(title);
            Writer.WriteLine();

            const string columnSeparator = "  ";

            int rowNumberWidth = PendingRows.Count.ToString("x").Length;

            int[] columnWidths = new int[PendingRows.First().Length];
            foreach (var row in PendingRows)
            {
                for (int c = 0; c < row.Length; c++)
                {
                    columnWidths[c] = Math.Max(columnWidths[c], row[c].Length + columnSeparator.Length);
                }
            }

            int tableWidth = columnWidths.Sum() + columnWidths.Length;
            string horizontalSeparator = new string('=', tableWidth);

            for (int r = 0; r<PendingRows.Count; r++)
            {
                var row = PendingRows[r];

                // header
                if (r == 0)
                {
                    Writer.WriteLine(horizontalSeparator);
                    Writer.Write(new string(' ', rowNumberWidth + 2));
                }
                else
                {
                    string rowNumber = r.ToString("x");
                    Writer.Write(new string(' ', rowNumberWidth - rowNumber.Length));
                    Writer.Write(rowNumber);
                    Writer.Write(": ");
                }

                for (int c = 0; c < row.Length; c++)
                {
                    var field = row[c];

                    Writer.Write(field);
                    Writer.Write(new string(' ', columnWidths[c] - field.Length));
                }

                Writer.WriteLine();

                // header
                if (r == 0)
                {
                    Writer.WriteLine(horizontalSeparator);
                }
            }

            Writer.WriteLine();
            PendingRows.Clear();
        }

        Handle GetAggregateHandle(EntityHandle generationHandle, int generation)
        {
            var encMap = EncMaps[generation - 1];

            int start, count;
            if (!TryGetHandleRange(encMap, generationHandle.Kind, out start, out count))
            {
                throw new BadImageFormatException(string.Format("EncMap is missing record for {0:8X}.", MetadataTokens.GetToken(generationHandle)));
            }

            return encMap[start + MetadataTokens.GetRowNumber(generationHandle) - 1];
        }

        TEntity Get<TEntity>(Handle handle, Func<MetadataReader, Handle, TEntity> getter)
        {
            if (Aggregator != null)
            {
                int generation;
                var generationHandle = Aggregator.GetGenerationHandle(handle, out generation);
                return getter(Readers[generation], generationHandle);
            }
            else
            {
                return getter(this.Reader, handle);
            }
        }

        string Literal(StringHandle handle)
            => Literal(handle, (r, h) => "'" + r.GetString((StringHandle)h) + "'");

        string Literal(NamespaceDefinitionHandle handle)
            => Literal(handle, (r, h) => "'" + r.GetString((NamespaceDefinitionHandle)h) + "'");

        string Literal(GuidHandle handle)
            => Literal(handle, (r, h) => "{" + r.GetGuid((GuidHandle)h) + "}");

        string Literal(BlobHandle handle)
            => Literal(handle, (r, h) => BitConverter.ToString(r.GetBlobBytes((BlobHandle)h)));

        string Literal(Handle handle, Func<MetadataReader, Handle, string> getValue)
        {
            if (handle.IsNil)
                return "nil";

            if (Aggregator != null)
            {
                int generation;
                Handle generationHandle = Aggregator.GetGenerationHandle(handle, out generation);

                var generationReader = Readers[generation];
                string value = getValue(generationReader, generationHandle);
                int offset = generationReader.GetHeapOffset(handle);
                int generationOffset = generationReader.GetHeapOffset(generationHandle);

                if (offset == generationOffset)
                {
                    return string.Format("{0} (#{1:x})", value, offset);
                }
                else
                {
                    return string.Format("{0} (#{1:x}/{2:x})", value, offset, generationOffset);
                }
            }

            if (IsDelta)
            {
                // we can't resolve the literal without aggregate reader
                return string.Format("#{0:x}", Reader.GetHeapOffset(handle));
            }

            return string.Format("{1:x} (#{0:x})", Reader.GetHeapOffset(handle), getValue(Reader, handle));
        }


        public string Token(Handle handle, bool displayTable = true)
        {
            if (handle.IsNil)
            {
                return "nil";
            }

            TableIndex table;
            if (displayTable && MetadataTokens.TryGetTableIndex(handle.Kind, out table))
            {
                return string.Format("0x{0:x8} ({1})", Reader.GetToken(handle), table);
            }
            else
            {
                return string.Format("0x{0:x8}", Reader.GetToken(handle));
            }
        }

        string TokenRange<THandle>(IReadOnlyCollection<THandle> handles, Func<THandle, Handle> conversion)
        {
            var genericHandles = handles.Select(conversion);
            return (handles.Count == 0) ? "nil" : Token(genericHandles.First(), displayTable: false) + "-" + Token(genericHandles.Last(), displayTable: false);
        }

        public string TokenList(InterfaceImplementationHandleCollection handles, bool displayTable = false)
        {
            if (handles.Count == 0)
                return "nil";

            return string.Join(", ", handles.Select(h => Token(h, displayTable)));
        }

        void WriteModule()
        {
            var def = Reader.GetModuleDefinition();

            AddHeader(
                "Gen",
                "Name",
                "Mvid",
                "EncId",
                "EncBaseId"
            );

            AddRow(
                def.Generation.ToString(),
                Literal(def.Name),
                Literal(def.Mvid),
                Literal(def.GenerationId),
                Literal(def.BaseGenerationId));

            WriteRows("Module (0x00):");
        }

        void WriteTypeRef()
        {
            AddHeader(
                "Scope",
                "Name",
                "Namespace"
            );

            foreach (var handle in Reader.TypeReferences)
            {
                var entry = Reader.GetTypeReference(handle);

                AddRow(
                    Token(entry.ResolutionScope),
                    Literal(entry.Name),
                    Literal(entry.Namespace)
                );
            }

            WriteRows("TypeRef (0x01):");
        }

        void WriteTypeDef()
        {
            AddHeader(
                "Name",
                "Namespace",
                "EnclosingType",
                "BaseType",
                "Interfaces",
                "Fields",
                "Methods",
                "Attributes",
                "ClassSize",
                "PackingSize"
            );

            foreach (var handle in Reader.TypeDefinitions)
            {
                var entry = Reader.GetTypeDefinition(handle);

                TypeLayout typeLayout = entry.GetLayout();

                AddRow(
                    Literal(entry.Name),
                    Literal(entry.Namespace),
                    Token(entry.GetDeclaringType()),
                    Token(entry.BaseType),
                    TokenList(entry.GetInterfaceImplementations()),
                    TokenRange(entry.GetFields(), h => h),
                    TokenRange(entry.GetMethods(), h => h),
                    EnumValue<int>(entry.Attributes),
                    typeLayout.IsDefault ? "n/a" : typeLayout.Size.ToString(),
                    typeLayout.IsDefault ? "n/a" : typeLayout.PackingSize.ToString()
                );
            }

            WriteRows("TypeDef (0x02):");
        }

        void WriteField()
        {
            AddHeader(
                "Name",
                "Signature",
                "Attributes",
                "Marshalling",
                "Offset",
                "RVA"
            );

            foreach (var handle in Reader.FieldDefinitions)
            {
                var entry = Reader.GetFieldDefinition(handle);

                int offset = entry.GetOffset();

                AddRow(
                    Literal(entry.Name),
                    Literal(entry.Signature),
                    EnumValue<int>(entry.Attributes),
                    Literal(entry.GetMarshallingDescriptor()),
                    offset >= 0 ? offset.ToString() : "n/a",
                    entry.GetRelativeVirtualAddress().ToString()
                );
            }

            WriteRows("Field (0x04):");
        }

        void WriteMethod()
        {
            AddHeader(
                "Name",
                "Signature",
                "RVA",
                "Parameters",
                "GenericParameters",
                "ImplAttributes",
                "Attributes",
                "ImportAttributes",
                "ImportName",
                "ImportModule"
            );

            foreach (var handle in Reader.MethodDefinitions)
            {
                var entry = Reader.GetMethodDefinition(handle);
                var import = entry.GetImport();

                AddRow(
                    Literal(entry.Name),
                    Literal(entry.Signature),
                    Hex(entry.RelativeVirtualAddress),
                    TokenRange(entry.GetParameters(), h => h),
                    TokenRange(entry.GetGenericParameters(), h => h),
                    EnumValue<int>(entry.Attributes),
                    EnumValue<int>(entry.ImplAttributes),
                    EnumValue<short>(import.Attributes),
                    Literal(import.Name),
                    Token(import.Module)
                );
            }

            WriteRows("Method (0x06, 0x1C):");
        }

        void WriteParam()
        {
            AddHeader(
                "Name",
                "Seq#",
                "Attributes",
                "Marshalling"
            );

            for (int i = 1, count = Reader.GetTableRowCount(TableIndex.Param); i <= count; i++)
            {
                var entry = Reader.GetParameter(MetadataTokens.ParameterHandle(i));

                AddRow(
                    Literal(entry.Name),
                    entry.SequenceNumber.ToString(),
                    EnumValue<int>(entry.Attributes),
                    Literal(entry.GetMarshallingDescriptor())
                );
            }

            WriteRows("Param (0x08):");
        }

        void WriteMemberRef()
        {
            AddHeader(
                "Parent",
                "Name",
                "Signature"
            );

            foreach (var handle in Reader.MemberReferences)
            {
                var entry = Reader.GetMemberReference(handle);

                AddRow(
                    Token(entry.Parent),
                    Literal(entry.Name),
                    Literal(entry.Signature)
                );
            }

            WriteRows("MemberRef (0x0a):");
        }

        void WriteConstant()
        {
            AddHeader(
                "Parent",
                "Type",
                "Value"
            );

            for (int i = 1, count = Reader.GetTableRowCount(TableIndex.Constant); i <= count; i++)
            {
                var entry = Reader.GetConstant(MetadataTokens.ConstantHandle(i));

                AddRow(
                    Token(entry.Parent),
                    EnumValue<byte>(entry.TypeCode),
                    Literal(entry.Value)
                );
            }

            WriteRows("Constant (0x0b):");
        }

        void WriteCustomAttribute()
        {
            AddHeader(
                "Parent",
                "Constructor",
                "Value"
            );

            foreach (var handle in Reader.CustomAttributes)
            {
                var entry = Reader.GetCustomAttribute(handle);

                AddRow(
                    Token(entry.Parent),
                    Token(entry.Constructor),
                    Literal(entry.Value)
                );
            }

            WriteRows("CustomAttribute (0x0c):");
        }

        void WriteDeclSecurity()
        {
            AddHeader(
                "Parent",
                "PermissionSet",
                "Action"
            );

            foreach (var handle in Reader.DeclarativeSecurityAttributes)
            {
                var entry = Reader.GetDeclarativeSecurityAttribute(handle);

                AddRow(
                    Token(entry.Parent),
                    Literal(entry.PermissionSet),
                    EnumValue<short>(entry.Action)
                );
            }

            WriteRows("DeclSecurity (0x0e):");
        }

        void WriteStandAloneSig()
        {
            AddHeader("Signature");

            for (int i = 1, count = Reader.GetTableRowCount(TableIndex.StandAloneSig); i <= count; i++)
            {
                var value = Reader.GetStandaloneSignature(MetadataTokens.StandaloneSignatureHandle(i));

                AddRow(Literal(value.Signature));
            }

            WriteRows("StandAloneSig (0x11):");
        }

        void WriteEvent()
        {
            AddHeader(
                "Name",
                "Add",
                "Remove",
                "Fire",
                "Attributes"
            );

            foreach (var handle in Reader.EventDefinitions)
            {
                var entry = Reader.GetEventDefinition(handle);
                var accessors = entry.GetAccessors();

                AddRow(
                    Literal(entry.Name),
                    Token(accessors.Adder),
                    Token(accessors.Remover),
                    Token(accessors.Raiser),
                    EnumValue<int>(entry.Attributes)
                );
            }

            WriteRows("Event (0x12, 0x14, 0x18):");
        }

        void WriteProperty()
        {
            AddHeader(
                "Name",
                "Get",
                "Set",
                "Attributes"
            );

            foreach (var handle in Reader.PropertyDefinitions)
            {
                var entry = Reader.GetPropertyDefinition(handle);
                var accessors = entry.GetAccessors();

                AddRow(
                    Literal(entry.Name),
                    Token(accessors.Getter),
                    Token(accessors.Setter),
                    EnumValue<int>(entry.Attributes)
                );
            }

            WriteRows("Property (0x15, 0x17, 0x18):");
        }

        void WriteMethodImpl()
        {
            AddHeader(
                "Type",
                "Body",
                "Declaration"
            );

            for (int i = 1, count = Reader.GetTableRowCount(TableIndex.MethodImpl); i <= count; i++)
            {
                var entry = Reader.GetMethodImplementation(MetadataTokens.MethodImplementationHandle(i));

                AddRow(
                    Token(entry.Type),
                    Token(entry.MethodBody),
                    Token(entry.MethodDeclaration)
                );
            }

            WriteRows("MethodImpl (0x19):");
        }

        void WriteModuleRef()
        {
            AddHeader("Name");

            for (int i = 1, count = Reader.GetTableRowCount(TableIndex.ModuleRef); i <= count; i++)
            {
                var value = Reader.GetModuleReference(MetadataTokens.ModuleReferenceHandle(i));
                AddRow(Literal(value.Name));
            }

            WriteRows("ModuleRef (0x1a):");
        }

        void WriteTypeSpec()
        {
            AddHeader("Name");
            var count = Reader.GetTableRowCount(TableIndex.TypeSpec);
            for (int i = 1; i <= count; i++)
            {
                var value = Reader.GetTypeSpecification(MetadataTokens.TypeSpecificationHandle(i));
                AddRow(Literal(value.Signature));
            }

            WriteRows("TypeSpec (0x1b):");
        }

        void WriteEnCLog()
        {
            AddHeader(
                "Entity",
                "Operation");

            foreach (var entry in Reader.GetEditAndContinueLogEntries())
            {
                AddRow(
                    Token(entry.Handle),
                    EnumValue<int>(entry.Operation));
            }

            WriteRows("EnC Log (0x1e):");
        }

        void WriteEnCMap()
        {
            if (Aggregator != null)
            {
                AddHeader("Entity", "Gen", "Row", "Edit");
            }
            else
            {
                AddHeader("Entity");
            }


            foreach (var entry in Reader.GetEditAndContinueMapEntries())
            {
                if (Aggregator != null)
                {
                    int generation;
                    Handle primary = Aggregator.GetGenerationHandle(entry, out generation);
                    bool isUpdate = Readers[generation] != Reader;

                    var primaryModule = Readers[generation].GetModuleDefinition();

                    AddRow(
                        Token(entry),
                        primaryModule.Generation.ToString(),
                        "0x" + MetadataTokens.GetRowNumber((EntityHandle)primary).ToString("x6"),
                        isUpdate ? "update" : "add");
                }
                else
                {
                    AddRow(Token(entry));
                }
            }

            WriteRows("EnC Map (0x1f):");
        }

        void WriteAssembly()
        {
            if (Reader.IsAssembly)
            {
                AddHeader(
                    "Name",
                    "Version",
                    "Culture",
                    "PublicKey",
                    "Flags",
                    "HashAlgorithm"
                );

                var entry = Reader.GetAssemblyDefinition();

                AddRow(
                    Literal(entry.Name),
                    entry.Version.Major + "." + entry.Version.Minor + "." + entry.Version.Revision + "." + entry.Version.Build,
                    Literal(entry.Culture),
                    Literal(entry.PublicKey),
                    EnumValue<int>(entry.Flags),
                    EnumValue<int>(entry.HashAlgorithm)
                );

                WriteRows("Assembly (0x20):");
            }
        }

        void WriteAssemblyRef()
        {
            AddHeader(
                "Name",
                "Version",
                "Culture",
                "PublicKeyOrToken",
                "Flags"
            );

            foreach (var handle in Reader.AssemblyReferences)
            {
                var entry = Reader.GetAssemblyReference(handle);

                AddRow(
                    Literal(entry.Name),
                    entry.Version.Major + "." + entry.Version.Minor + "." + entry.Version.Revision + "." + entry.Version.Build,
                    Literal(entry.Culture),
                    Literal(entry.PublicKeyOrToken),
                    EnumValue<int>(entry.Flags)
                );
            }

            WriteRows("AssemblyRef (0x23):");
        }

        void WriteFile()
        {
            AddHeader(
                "Name",
                "Metadata",
                "HashValue"
            );

            foreach (var handle in Reader.AssemblyFiles)
            {
                var entry = Reader.GetAssemblyFile(handle);

                AddRow(
                    Literal(entry.Name),
                    entry.ContainsMetadata ? "Yes" : "No",
                    Literal(entry.HashValue)
                );
            }

            WriteRows("File (0x26):");
        }

        void WriteExportedType()
        {
            AddHeader(
                "Name",
                "Namespace",
                "Assembly"
            );

            foreach (var handle in Reader.ExportedTypes)
            {
                var entry = Reader.GetExportedType(handle);
                AddRow(
                    Literal(entry.Name),
                    Literal(entry.Namespace),
                    Token(entry.Implementation));
            }

            WriteRows("ExportedType - forwarders (0x27):");
        }

        void WriteManifestResource()
        {
            AddHeader(
                "Name",
                "Attributes",
                "Offset",
                "Implementation"
            );

            foreach (var handle in Reader.ManifestResources)
            {
                var entry = Reader.GetManifestResource(handle);

                AddRow(
                    Literal(entry.Name),
                    entry.Attributes.ToString(),
                    entry.Offset.ToString(),
                    Token(entry.Implementation)
                );
            }

            WriteRows("ManifestResource (0x28):");
        }

        void WriteGenericParam()
        {
            AddHeader(
                "Name",
                "Seq#",
                "Attributes",
                "TypeConstraints"
            );

            var count = Reader.GetTableRowCount(TableIndex.GenericParam);
            for (int i = 1; i<=count; i++)
            {
                var entry = Reader.GetGenericParameter(MetadataTokens.GenericParameterHandle(i));
                AddRow(
                    Literal(entry.Name),
                    entry.Index.ToString(),
                    EnumValue<int>(entry.Attributes),
                    TokenRange(entry.GetConstraints(), h => h)
                );
            }

            WriteRows("GenericParam (0x2a):");
        }

        void WriteMethodSpec()
        {
            AddHeader(
                "Method",
                "Signature"
            );

            var count = Reader.GetTableRowCount(TableIndex.MethodSpec);
            for (int i = 1; i<=count; i++)
            {
                var entry = Reader.GetMethodSpecification(MetadataTokens.MethodSpecificationHandle(i));
                AddRow(
                    Token(entry.Method),
                    Literal(entry.Signature)
                );
            }

            WriteRows("MethodSpec (0x2b):");
        }

        void WriteGenericParamConstraint()
        {
            AddHeader(
                "Parent",
                "Type"
            );

            var count = Reader.GetTableRowCount(TableIndex.GenericParamConstraint);
            for (int i = 1; i <= count; i++)
            {
                var entry = Reader.GetGenericParameterConstraint(MetadataTokens.GenericParameterConstraintHandle(i));

                AddRow(
                    Token(entry.Parameter),
                    Token(entry.Type)
                );
            }

            WriteRows("GenericParamConstraint (0x2c):");
        }

        void WriteUserStrings()
        {
            int size = Reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return;

            Writer.WriteLine(string.Format("#US (size = {0}):", size));
            var handle = MetadataTokens.UserStringHandle(0);
            do
            {
                string value = Reader.GetUserString(handle);
                Writer.WriteLine("  {0:x}: '{1}'", Reader.GetHeapOffset(handle), value);
                handle = Reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            Writer.WriteLine();
        }

        void WriteStrings()
        {
            int size = Reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return;

            Writer.WriteLine(string.Format("#String (size = {0}):", size));
            var handle = MetadataTokens.StringHandle(0);
            do
            {
                string value = Reader.GetString(handle);
                Writer.WriteLine("  {0:x}: '{1}'", Reader.GetHeapOffset(handle), value);
                handle = Reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            Writer.WriteLine();
        }

        void WriteBlobs()
        {
            int size = Reader.GetHeapSize(HeapIndex.Blob);
            if (size == 0)
            {
                return;
            }

            Writer.WriteLine(string.Format("#Blob (size = {0}):", size));
            var handle = MetadataTokens.BlobHandle(0);
            do
            {
                byte[] value = Reader.GetBlobBytes(handle);
                Writer.WriteLine("  {0:x}: {1}", Reader.GetHeapOffset(handle), BitConverter.ToString(value));
                handle = Reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            Writer.WriteLine();
        }

        void WriteGuids()
        {
            int size = Reader.GetHeapSize(HeapIndex.Guid);
            if (size == 0)
            {
                return;
            }

            Writer.WriteLine(string.Format("#Guid (size = {0}):", size));
            int i = 1;
            while (i <= size / 16)
            {
                string value = Reader.GetGuid(MetadataTokens.GuidHandle(i)).ToString();
                Writer.WriteLine("  {0:x}: {{{1}}}", i, value);
                i++;
            }

            Writer.WriteLine();
        }

        static bool TryGetHandleRange(ImmutableArray<EntityHandle> handles, HandleKind handleKind, out int start, out int count)
        {
            TableIndex tableIndex;
            MetadataTokens.TryGetTableIndex(handleKind, out tableIndex);

            int mapIndex = ImmutableArray.BinarySearch<EntityHandle>(handles, MetadataTokens.EntityHandle(tableIndex, 0), TokenTypeComparer.Instance);
            if (mapIndex < 0)
            {
                start = 0;
                count = 0;
                return false;
            }

            int s = mapIndex;
            while (s >= 0 && handles[s].Kind == handleKind)
                s--;

            int e = mapIndex;
            while (e < handles.Length && handles[e].Kind == handleKind)
                e++;

            start = s + 1;
            count = e - start;
            return true;
        }

        static string EnumValue<T>(object value)
            where T : IEquatable<T>
        {
            T integralValue = (T)value;
            if (integralValue.Equals(default(T)))
                return "0";

            return string.Format("0x{0:x8} ({1})", integralValue, value);
        }

        static string Hex(ushort value)
            => "0x" + value.ToString("X4");

        static string Hex(int value)
            => "0x" + value.ToString("X8");

        sealed class TokenTypeComparer : IComparer<EntityHandle>
        {
            public static readonly TokenTypeComparer Instance = new TokenTypeComparer();

            public int Compare(EntityHandle x, EntityHandle y)
            {
                return x.Kind.CompareTo(y.Kind);
            }
        }
    }
}