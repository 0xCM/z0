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
    using System.Text;
    using System.Globalization;

    [Flags]
    public enum MetadataVisualizerOptions
    {
        None = 0,
        ShortenBlobs = 1,
        NoHeapReferences = 1 << 1
    }

    public class MetadataVisualizer
    {
        readonly TextWriter _writer;

        readonly IReadOnlyList<MetadataReader> _readers;

        readonly MetadataAggregator Aggregator;

        // enc map for each delta reader
        readonly ImmutableArray<ImmutableArray<EntityHandle>> EncMaps;

        private MetadataReader _reader;

        readonly MetadataVisualizerOptions _options;

        readonly SignatureVisualizer _signatureVisualizer;

        readonly List<string[]> PendingRows = new List<string[]>();

        readonly Dictionary<BlobHandle, BlobKind> _blobKinds = new Dictionary<BlobHandle, BlobKind>();

        MetadataVisualizer(TextWriter writer, IReadOnlyList<MetadataReader> readers, MetadataVisualizerOptions options = MetadataVisualizerOptions.None)
        {
            _writer = writer;
            _readers = readers;
            _options = options;
            _signatureVisualizer = new SignatureVisualizer(this);

            if (readers.Count > 1)
            {
                var deltaReaders = new List<MetadataReader>(readers.Skip(1));
                Aggregator = new MetadataAggregator(readers[0], deltaReaders);
                EncMaps = ImmutableArray.CreateRange(deltaReaders.Select(reader => ImmutableArray.CreateRange(reader.GetEditAndContinueMapEntries())));
            }
        }

        public MetadataVisualizer(MetadataReader reader, TextWriter writer, MetadataVisualizerOptions options = MetadataVisualizerOptions.None)
            : this(writer, new[] {reader}, options)
        {
            _reader = reader;
        }

        public MetadataVisualizer(IReadOnlyList<MetadataReader> readers, TextWriter writer, MetadataVisualizerOptions options = MetadataVisualizerOptions.None)
            : this(writer, readers, options)
        {
        }

        public void WriteLine(string line)
        {
            _writer.WriteLine(line);
        }

        public void VisualizeAllGenerations()
        {
            for (int i = 0; i<_readers.Count; i++)
            {
                _writer.WriteLine(">>>");
                _writer.WriteLine(string.Format(">>> Generation {0}:", i));
                _writer.WriteLine(">>>");
                _writer.WriteLine();

                Visualize(i);
            }
        }

        public void Visualize(int generation = -1)
        {
            _reader = (generation >= 0) ? _readers[generation] : _readers.Last();

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

            WriteDocument();
            WriteMethodDebugInformation();
            WriteLocalScope();
            WriteLocalVariable();
            WriteLocalConstant();
            WriteImportScope();
            WriteCustomDebugInformation();


            WriteUserStrings();
            WriteStrings();
            WriteBlobs();
            WriteGuids();
        }

        bool IsDelta
            => _reader.GetTableRowCount(TableIndex.EncLog) > 0;


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

            _writer.Write(title);
            _writer.WriteLine();

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
                    _writer.WriteLine(horizontalSeparator);
                    _writer.Write(new string(' ', rowNumberWidth + 2));
                }
                else
                {
                    string rowNumber = r.ToString("x");
                    _writer.Write(new string(' ', rowNumberWidth - rowNumber.Length));
                    _writer.Write(rowNumber);
                    _writer.Write(": ");
                }

                for (int c = 0; c < row.Length; c++)
                {
                    var field = row[c];

                    _writer.Write(field);
                    _writer.Write(new string(' ', columnWidths[c] - field.Length));
                }

                _writer.WriteLine();

                // header
                if (r == 0)
                {
                    _writer.WriteLine(horizontalSeparator);
                }
            }

            _writer.WriteLine();
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
                return getter(_readers[generation], generationHandle);
            }
            else
            {
                return getter(this._reader, handle);
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

                var generationReader = _readers[generation];
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
                return string.Format("#{0:x}", _reader.GetHeapOffset(handle));
            }

            return string.Format("{1:x} (#{0:x})", _reader.GetHeapOffset(handle), getValue(_reader, handle));
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
                return string.Format("0x{0:x8} ({1})", _reader.GetToken(handle), table);
            }
            else
            {
                return string.Format("0x{0:x8}", _reader.GetToken(handle));
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

        public void VisualizeMethodBody(MethodBodyBlock body, MethodDefinitionHandle generationHandle, int generation)
        {
            var handle = (MethodDefinitionHandle)GetAggregateHandle(generationHandle, generation);
            var method = GetMethod(handle);
            VisualizeMethodBody(body, method, handle);
        }

        public void VisualizeMethodBody(MethodDefinitionHandle methodHandle, Func<int, MethodBodyBlock> bodyProvider)
        {
            var method = GetMethod(methodHandle);

            if ((method.ImplAttributes & MethodImplAttributes.CodeTypeMask) != MethodImplAttributes.Managed)
            {
                _writer.WriteLine("native code");
                return;
            }

            var rva = method.RelativeVirtualAddress;
            if (rva == 0)
            {
                return;
            }

            var body = bodyProvider(rva);
            VisualizeMethodBody(body, method, methodHandle);
        }

        MethodDefinition GetMethod(MethodDefinitionHandle handle)
        {
            return Get(handle, (reader, h) => reader.GetMethodDefinition((MethodDefinitionHandle)h));
        }

        BlobHandle GetLocalSignature(StandaloneSignatureHandle handle)
        {
            return Get(handle, (reader, h) => reader.GetStandaloneSignature((StandaloneSignatureHandle)h).Signature);
        }

        void VisualizeMethodBody(MethodBodyBlock body, MethodDefinition method, MethodDefinitionHandle methodHandle)
        {
            StringBuilder builder = new StringBuilder();

            // TODO: Inspect EncLog to find a containing type and display qualified name.
            builder.AppendFormat("Method {0} (0x{1:X8})", Literal(() => method.Name), MetadataTokens.GetToken(methodHandle));
            builder.AppendLine();

            if (!body.LocalSignature.IsNil)
            {
                builder.AppendFormat("  Locals: {0}", StandaloneSignature(() => GetLocalSignature(body.LocalSignature)));
                builder.AppendLine();
            }

            ILVisualizer.service().DumpMethod(
                builder,
                body.MaxStack,
                body.GetILContent(),
                ImmutableArray.Create<ILVisualizer.LocalInfo>(),
                ImmutableArray.Create<ILVisualizer.HandlerSpan>());

            builder.AppendLine();

            _writer.Write(builder.ToString());
        }

        public void VisualizeHeaders()
        {
            _reader = _readers[0];

            _writer.WriteLine($"MetadataVersion: {_reader.MetadataVersion}");

            if (_reader.DebugMetadataHeader != null)
            {
                _writer.WriteLine("Id: " + BitConverter.ToString(_reader.DebugMetadataHeader.Id.ToArray()));

                if (!_reader.DebugMetadataHeader.EntryPoint.IsNil)
                {
                    _writer.WriteLine($"EntryPoint: {Token(() => _reader.DebugMetadataHeader.EntryPoint)}");
                }
            }

            _writer.WriteLine();
        }

        void WriteModule()
        {
            if (_reader.DebugMetadataHeader != null)
            {
                return;
            }

            var def = _reader.GetModuleDefinition();

            var table = new TableBuilder(
                "Module (0x00):",
                "Gen",
                "Name",
                "Mvid",
                "EncId",
                "EncBaseId"
            );

            table.AddRow(
                ToString(() => def.Generation),
                Literal(() => def.Name),
                Literal(() => def.Mvid),
                Literal(() => def.GenerationId),
                Literal(() => def.BaseGenerationId));

            WriteTable(table);
        }

        void WriteTypeRef()
        {
            var table = new TableBuilder(
                "TypeRef (0x01):",
                "Scope",
                "Name",
                "Namespace"
            );

            foreach (var handle in _reader.TypeReferences)
            {
                var entry = _reader.GetTypeReference(handle);

                table.AddRow(
                    Token(() => entry.ResolutionScope),
                    Literal(() => entry.Name),
                    Literal(() => entry.Namespace)
                );
            }

            WriteTable(table);
        }

        public string TokenList(IReadOnlyCollection<EntityHandle> handles, bool displayTable = false)
        {
            if (handles.Count == 0)
            {
                return "nil";
            }

            return string.Join(", ", handles.Select(h => Token(() => h, displayTable)));
        }

        void WriteTypeDef()
        {
            var table = new TableBuilder(
                "TypeDef (0x02):",
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

            foreach (var handle in _reader.TypeDefinitions)
            {
                var entry = _reader.GetTypeDefinition(handle);

                var layout = entry.GetLayout();

                // TODO: Visualize InterfaceImplementations
                var implementedInterfaces = entry.GetInterfaceImplementations().Select(h => _reader.GetInterfaceImplementation(h).Interface).ToArray();

                table.AddRow(
                    Literal(() => entry.Name),
                    Literal(() => entry.Namespace),
                    Token(() => entry.GetDeclaringType()),
                    Token(() => entry.BaseType),
                    TokenList(implementedInterfaces),
                    TokenRange(entry.GetFields(), h => h),
                    TokenRange(entry.GetMethods(), h => h),
                    EnumValue<int>(() => entry.Attributes),
                    !layout.IsDefault ? layout.Size.ToString() : "n/a",
                    !layout.IsDefault ? layout.PackingSize.ToString() : "n/a"
                );
            }

            WriteTable(table);
        }

        void WriteField()
        {
            var table = new TableBuilder(
                "Field (0x04):",
                "Name",
                "Signature",
                "Attributes",
                "Marshalling",
                "Offset",
                "RVA"
            );

            foreach (var handle in _reader.FieldDefinitions)
            {
                var entry = _reader.GetFieldDefinition(handle);

                table.AddRow(
                    Literal(() => entry.Name),
                    FieldSignature(() => entry.Signature),
                    EnumValue<int>(() => entry.Attributes),
                    Literal(() => entry.GetMarshallingDescriptor(), BlobKind.Marshalling),
                    ToString(() =>
                    {
                        int offset = entry.GetOffset();
                        return offset >= 0 ? offset.ToString() : "n/a";
                    }),
                    ToString(() => entry.GetRelativeVirtualAddress())
                );
            }

            WriteTable(table);
        }

        void WriteMethod()
        {
            var table = new TableBuilder(
                "Method (0x06, 0x1C):",
                "Name",
                "Signature",
                "RVA",
                "Parameters",
                "GenericParameters",
                "Attributes",
                "ImplAttributes",
                "ImportAttributes",
                "ImportName",
                "ImportModule"
            );

            foreach (var handle in _reader.MethodDefinitions)
            {
                var entry = _reader.GetMethodDefinition(handle);
                var import = entry.GetImport();

                table.AddRow(
                    Literal(() => entry.Name),
                    MethodSignature(() => entry.Signature),
                    Int32Hex(() => entry.RelativeVirtualAddress),
                    TokenRange(entry.GetParameters(), h => h),
                    TokenRange(entry.GetGenericParameters(), h => h),
                    EnumValue<int>(() => entry.Attributes),    // TODO: we need better visualizer than the default enum
                    EnumValue<int>(() => entry.ImplAttributes),
                    EnumValue<short>(() => import.Attributes),
                    Literal(() => import.Name),
                    Token(() => import.Module)
                );
            }

            WriteTable(table);
        }

        void WriteParam()
        {
            var table = new TableBuilder(
                "Param (0x08):",
                "Name",
                "Seq#",
                "Attributes",
                "Marshalling"
            );

            for (int i = 1, count = _reader.GetTableRowCount(TableIndex.Param); i <= count; i++)
            {
                var entry = _reader.GetParameter(MetadataTokens.ParameterHandle(i));

                table.AddRow(
                    Literal(() => entry.Name),
                    ToString(() => entry.SequenceNumber),
                    EnumValue<int>(() => entry.Attributes),
                    Literal(() => entry.GetMarshallingDescriptor(), BlobKind.Marshalling)
                );
            }

            WriteTable(table);
        }

        void WriteMemberRef()
        {
            var table = new TableBuilder(
                "MemberRef (0x0a):",
                "Parent",
                "Name",
                "Signature"
            );

            foreach (var handle in _reader.MemberReferences)
            {
                var entry = _reader.GetMemberReference(handle);

                table.AddRow(
                    Token(() => entry.Parent),
                    Literal(() => entry.Name),
                    MemberReferenceSignature(() => entry.Signature)
                );
            }

            WriteTable(table);
        }

        void WriteConstant()
        {
            var table = new TableBuilder(
                "Constant (0x0b):",
                "Parent",
                "Type",
                "Value"
            );

            for (int i = 1, count = _reader.GetTableRowCount(TableIndex.Constant); i <= count; i++)
            {
                var entry = _reader.GetConstant(MetadataTokens.ConstantHandle(i));

                table.AddRow(
                    Token(() => entry.Parent),
                    EnumValue<byte>(() => entry.TypeCode),
                    Literal(() => entry.Value, BlobKind.ConstantValue)
                );
            }

            WriteTable(table);
        }

        void WriteCustomAttribute()
        {
            var table = new TableBuilder(
                "CustomAttribute (0x0c):",
                "Parent",
                "Constructor",
                "Value"
            );

            foreach (var handle in _reader.CustomAttributes)
            {
                var entry = _reader.GetCustomAttribute(handle);

                table.AddRow(
                    Token(() => entry.Parent),
                    Token(() => entry.Constructor),
                    Literal(() => entry.Value, BlobKind.CustomAttribute)
                );
            }

            WriteTable(table);
        }

        void WriteDeclSecurity()
        {
            var table = new TableBuilder(
                "DeclSecurity (0x0e):",
                "Parent",
                "PermissionSet",
                "Action"
            );

            foreach (var handle in _reader.DeclarativeSecurityAttributes)
            {
                var entry = _reader.GetDeclarativeSecurityAttribute(handle);

                table.AddRow(
                    Token(() => entry.Parent),
                    Literal(() => entry.PermissionSet, BlobKind.PermissionSet),
                    EnumValue<short>(() => entry.Action)
                );
            }

            WriteTable(table);
        }

        void WriteStandAloneSig()
        {
            var table = new TableBuilder(
                "StandAloneSig (0x11):",
                "Signature"
            );

            for (int i = 1, count = _reader.GetTableRowCount(TableIndex.StandAloneSig); i <= count; i++)
            {
                var entry = _reader.GetStandaloneSignature(MetadataTokens.StandaloneSignatureHandle(i));
                table.AddRow(StandaloneSignature(() => entry.Signature));
            }

            WriteTable(table);
        }

        void WriteEvent()
        {
            var table = new TableBuilder(
                "Event (0x12, 0x14, 0x18):",
                "Name",
                "Add",
                "Remove",
                "Fire",
                "Attributes"
            );

            foreach (var handle in _reader.EventDefinitions)
            {
                var entry = _reader.GetEventDefinition(handle);
                var accessors = entry.GetAccessors();

                table.AddRow(
                    Literal(() => entry.Name),
                    Token(() => accessors.Adder),
                    Token(() => accessors.Remover),
                    Token(() => accessors.Raiser),
                    EnumValue<int>(() => entry.Attributes)
                );
            }

            WriteTable(table);
        }

        void WriteProperty()
        {
            var table = new TableBuilder(
                "Property (0x15, 0x17, 0x18):",
                "Name",
                "Get",
                "Set",
                "Attributes"
            );

            foreach (var handle in _reader.PropertyDefinitions)
            {
                var entry = _reader.GetPropertyDefinition(handle);
                var accessors = entry.GetAccessors();

                table.AddRow(
                    Literal(() => entry.Name),
                    Token(() => accessors.Getter),
                    Token(() => accessors.Setter),
                    EnumValue<int>(() => entry.Attributes)
                );
            }

            WriteTable(table);
        }

        void WriteMethodImpl()
        {
            var table = new TableBuilder(
                "MethodImpl (0x19):",
                "Type",
                "Body",
                "Declaration"
            );

            for (int i = 1, count = _reader.GetTableRowCount(TableIndex.MethodImpl); i <= count; i++)
            {
                var entry = _reader.GetMethodImplementation(MetadataTokens.MethodImplementationHandle(i));

                table.AddRow(
                    Token(() => entry.Type),
                    Token(() => entry.MethodBody),
                    Token(() => entry.MethodDeclaration)
                );
            }

            WriteTable(table);
        }

        void WriteModuleRef()
        {
            var table = new TableBuilder(
                "ModuleRef (0x1a):",
                "Name"
            );

            for (int i = 1, count = _reader.GetTableRowCount(TableIndex.ModuleRef); i <= count; i++)
            {
                var entry = _reader.GetModuleReference(MetadataTokens.ModuleReferenceHandle(i));
                table.AddRow(Literal(() => entry.Name));
            }

            WriteTable(table);
        }

        void WriteTypeSpec()
        {
            var table = new TableBuilder(
                "TypeSpec (0x1b):",
                "Name");

            for (int i = 1, count = _reader.GetTableRowCount(TableIndex.TypeSpec); i <= count; i++)
            {
                var entry = _reader.GetTypeSpecification(MetadataTokens.TypeSpecificationHandle(i));
                table.AddRow(TypeSpecificationSignature(() => entry.Signature));
            }

            WriteTable(table);
        }

        void WriteEnCLog()
        {
            AddHeader(
                "Entity",
                "Operation");

            foreach (var entry in _reader.GetEditAndContinueLogEntries())
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


            foreach (var entry in _reader.GetEditAndContinueMapEntries())
            {
                if (Aggregator != null)
                {
                    int generation;
                    Handle primary = Aggregator.GetGenerationHandle(entry, out generation);
                    bool isUpdate = _readers[generation] != _reader;

                    var primaryModule = _readers[generation].GetModuleDefinition();

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
            if (_reader.IsAssembly)
            {
                AddHeader(
                    "Name",
                    "Version",
                    "Culture",
                    "PublicKey",
                    "Flags",
                    "HashAlgorithm"
                );

                var entry = _reader.GetAssemblyDefinition();

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

            foreach (var handle in _reader.AssemblyReferences)
            {
                var entry = _reader.GetAssemblyReference(handle);

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

            foreach (var handle in _reader.AssemblyFiles)
            {
                var entry = _reader.GetAssemblyFile(handle);

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

            foreach (var handle in _reader.ExportedTypes)
            {
                var entry = _reader.GetExportedType(handle);
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

            foreach (var handle in _reader.ManifestResources)
            {
                var entry = _reader.GetManifestResource(handle);

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

            var count = _reader.GetTableRowCount(TableIndex.GenericParam);
            for (int i = 1; i<=count; i++)
            {
                var entry = _reader.GetGenericParameter(MetadataTokens.GenericParameterHandle(i));
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

            var count = _reader.GetTableRowCount(TableIndex.MethodSpec);
            for (int i = 1; i<=count; i++)
            {
                var entry = _reader.GetMethodSpecification(MetadataTokens.MethodSpecificationHandle(i));
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

            var count = _reader.GetTableRowCount(TableIndex.GenericParamConstraint);
            for (int i = 1; i <= count; i++)
            {
                var entry = _reader.GetGenericParameterConstraint(MetadataTokens.GenericParameterConstraintHandle(i));

                AddRow(
                    Token(entry.Parameter),
                    Token(entry.Type)
                );
            }

            WriteRows("GenericParamConstraint (0x2c):");
        }

        void WriteUserStrings()
        {
            int size = _reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return;

            _writer.WriteLine(string.Format("#US (size = {0}):", size));
            var handle = MetadataTokens.UserStringHandle(0);
            do
            {
                string value = _reader.GetUserString(handle);
                _writer.WriteLine("  {0:x}: '{1}'", _reader.GetHeapOffset(handle), value);
                handle = _reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            _writer.WriteLine();
        }

        void WriteStrings()
        {
            int size = _reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return;

            _writer.WriteLine(string.Format("#String (size = {0}):", size));
            var handle = MetadataTokens.StringHandle(0);
            do
            {
                string value = _reader.GetString(handle);
                _writer.WriteLine("  {0:x}: '{1}'", _reader.GetHeapOffset(handle), value);
                handle = _reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            _writer.WriteLine();
        }

        void WriteBlobs()
        {
            int size = _reader.GetHeapSize(HeapIndex.Blob);
            if (size == 0)
            {
                return;
            }

            _writer.WriteLine(string.Format("#Blob (size = {0}):", size));
            var handle = MetadataTokens.BlobHandle(0);
            do
            {
                byte[] value = _reader.GetBlobBytes(handle);
                _writer.WriteLine("  {0:x}: {1}", _reader.GetHeapOffset(handle), BitConverter.ToString(value));
                handle = _reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            _writer.WriteLine();
        }

        void WriteGuids()
        {
            int size = _reader.GetHeapSize(HeapIndex.Guid);
            if (size == 0)
            {
                return;
            }

            _writer.WriteLine(string.Format("#Guid (size = {0}):", size));
            int i = 1;
            while (i <= size / 16)
            {
                string value = _reader.GetGuid(MetadataTokens.GuidHandle(i)).ToString();
                _writer.WriteLine("  {0:x}: {{{1}}}", i, value);
                i++;
            }

            _writer.WriteLine();
        }

        public void WriteDocument()
        {
            var table = new TableBuilder(
                MakeTableName(TableIndex.Document),
                "Name",
                "Language",
                "HashAlgorithm",
                "Hash"
            );

            foreach (var handle in _reader.Documents)
            {
                var entry = _reader.GetDocument(handle);

                table.AddRow(
                    DocumentName(() => entry.Name),
                    Language(() => entry.Language),
                    HashAlgorithm(() => entry.HashAlgorithm),
                    Literal(() => entry.Hash, BlobKind.DocumentHash)
               );
            }

            WriteTable(table);
        }

        string Literal(Func<BlobHandle> getHandle, BlobKind kind) =>
            Literal(getHandle, kind, (r, h) => BitConverter.ToString(r.GetBlobBytes(h)));

        string DocumentName(Func<DocumentNameBlobHandle> getHandle) =>
            Literal(() => getHandle(), BlobKind.DocumentName, (r, h) => "'" + StringUtilities.EscapeNonPrintableCharacters(r.GetString((DocumentNameBlobHandle)h)) + "'");

        public void WriteMethodDebugInformation()
        {
            if (_reader.MethodDebugInformation.Count == 0)
            {
                return;
            }

            var table = new TableBuilder(
                MakeTableName(TableIndex.MethodDebugInformation),
                "IL"
            );

            var detailsBuilder = new StringBuilder();

            foreach (var handle in _reader.MethodDebugInformation)
            {
                if (handle.IsNil)
                {
                    continue;
                }

                var entry = _reader.GetMethodDebugInformation(handle);

                bool hasSingleDocument = false;
                bool hasSequencePoints = false;
                try
                {
                    hasSingleDocument = !entry.Document.IsNil;
                    hasSequencePoints = !entry.SequencePointsBlob.IsNil;
                }
                catch (BadImageFormatException)
                {
                    hasSingleDocument = hasSequencePoints = false;
                }

                string details;

                if (hasSequencePoints)
                {
                    _blobKinds[entry.SequencePointsBlob] = BlobKind.SequencePoints;

                    detailsBuilder.Clear();
                    detailsBuilder.AppendLine("{");

                    bool addLineBreak = false;

                    if (!TryGetValue(() => entry.GetStateMachineKickoffMethod(), out var kickoffMethod) || !kickoffMethod.IsNil)
                    {
                        detailsBuilder.AppendLine($"  Kickoff Method: {(kickoffMethod.IsNil ? BadMetadataStr : Token(kickoffMethod))}");
                        addLineBreak = true;
                    }

                    if (!TryGetValue(() => entry.LocalSignature, out var localSignature) || !localSignature.IsNil)
                    {
                        detailsBuilder.AppendLine($"  Locals: {(localSignature.IsNil ? BadMetadataStr : Token(localSignature))}");
                        addLineBreak = true;
                    }

                    if (hasSingleDocument)
                    {
                        detailsBuilder.AppendLine($"  Document: {RowId(() => entry.Document)}");
                        addLineBreak = true;
                    }

                    if (addLineBreak)
                    {
                        detailsBuilder.AppendLine();
                    }

                    try
                    {
                        foreach (var sequencePoint in entry.GetSequencePoints())
                        {
                            detailsBuilder.Append("  ");
                            detailsBuilder.AppendLine(SequencePoint(sequencePoint, includeDocument: !hasSingleDocument));
                        }
                    }
                    catch (BadImageFormatException)
                    {
                        detailsBuilder.AppendLine("  " + BadMetadataStr);
                    }

                    detailsBuilder.AppendLine("}");
                    details = detailsBuilder.ToString();
                }
                else
                {
                    details = null;
                }

                table.AddRowWithDetails(new[] { HeapOffset(() => entry.SequencePointsBlob) }, details);
            }

            WriteTable(table);
        }

        string GetCustomDebugInformationKind(Guid guid)
        {
            if (guid == PortableCustomDebugInfoKinds.AsyncMethodSteppingInformationBlob) return "Async Method Stepping Information";
            if (guid == PortableCustomDebugInfoKinds.StateMachineHoistedLocalScopes) return "State Machine Hoisted Local Scopes";
            if (guid == PortableCustomDebugInfoKinds.DynamicLocalVariables) return "Dynamic Local Variables";
            if (guid == PortableCustomDebugInfoKinds.TupleElementNames) return "Tuple Element Names";
            if (guid == PortableCustomDebugInfoKinds.DefaultNamespace) return "Default Namespace";
            if (guid == PortableCustomDebugInfoKinds.EncLocalSlotMap) return "EnC Local Slot Map";
            if (guid == PortableCustomDebugInfoKinds.EncLambdaAndClosureMap) return "EnC Lambda and Closure Map";
            if (guid == PortableCustomDebugInfoKinds.EmbeddedSource) return "Embedded Source";
            if (guid == PortableCustomDebugInfoKinds.SourceLink) return "Source Link";
            if (guid == CompilationMetadataReferences) return "Compilation Metadata References";
            if (guid == CompilationOptions) return "Compilation Options";

            return "{" + guid + "}";
        }

        public void WriteLocalScope()
        {
            var table = new TableBuilder(
                MakeTableName(TableIndex.LocalScope),
                "Method",
                "ImportScope",
                "Variables",
                "Constants",
                "StartOffset",
                "Length"
            );

            foreach (var handle in _reader.LocalScopes)
            {
                var entry = _reader.GetLocalScope(handle);

                table.AddRow(
                    Token(() => entry.Method),
                    Token(() => entry.ImportScope),
                    TokenRange(entry.GetLocalVariables(), h => h),
                    TokenRange(entry.GetLocalConstants(), h => h),
                    Int32Hex(() => entry.StartOffset, digits: 4),
                    Int32(() => entry.Length)
               );
            }

            WriteTable(table);
        }

        public void WriteLocalVariable()
        {
            var table = new TableBuilder(
                MakeTableName(TableIndex.LocalVariable),
                "Name",
                "Index",
                "Attributes"
            );

            foreach (var handle in _reader.LocalVariables)
            {
                var entry = _reader.GetLocalVariable(handle);

                table.AddRow(
                    Literal(() => entry.Name),
                    Int32(() => entry.Index),
                    EnumValue<int>(() => entry.Attributes)
               );
            }

            WriteTable(table);
        }

        static string EnumValue<TIntegral>(Func<object> getValue)
            where TIntegral : IEquatable<TIntegral>
        {
            object value;

            try
            {
                value = getValue();
            }
            catch (BadImageFormatException)
            {
                return BadMetadataStr;
            }

            TIntegral integralValue = (TIntegral)value;
            if (integralValue.Equals(default))
            {
                return "0";
            }

            return $"0x{integralValue:x8} ({value})";
        }


        public void WriteLocalConstant()
        {
            var table = new TableBuilder(
                MakeTableName(TableIndex.LocalConstant),
                "Name",
                "Signature"
            );

            foreach (var handle in _reader.LocalConstants)
            {
                var entry = _reader.GetLocalConstant(handle);

                table.AddRow(
                    Literal(() => entry.Name),
                    Literal(() => entry.Signature, BlobKind.LocalConstantSignature, (r, h) => FormatLocalConstant(r, (BlobHandle)h))
               );
            }

            WriteTable(table);
        }

        private string Literal(Func<BlobHandle> getHandle, BlobKind kind, Func<MetadataReader, BlobHandle, string> getValue)
        {
            BlobHandle handle;
            try
            {
                handle = getHandle();
            }
            catch (BadImageFormatException)
            {
                return BadMetadataStr;
            }

            if (!handle.IsNil && kind != BlobKind.None)
            {
                _blobKinds[handle] = kind;
            }

            return Literal(handle, (r, h) => getValue(r, (BlobHandle)h));

        }

        static bool IsPrimitiveType(SignatureTypeCode typeCode)
        {
            switch (typeCode)
            {
                case SignatureTypeCode.Boolean:
                case SignatureTypeCode.Char:
                case SignatureTypeCode.SByte:
                case SignatureTypeCode.Byte:
                case SignatureTypeCode.Int16:
                case SignatureTypeCode.UInt16:
                case SignatureTypeCode.Int32:
                case SignatureTypeCode.UInt32:
                case SignatureTypeCode.Int64:
                case SignatureTypeCode.UInt64:
                case SignatureTypeCode.Single:
                case SignatureTypeCode.Double:
                case SignatureTypeCode.String:
                    return true;

                default:
                    return false;
            }
        }

        SignatureTypeCode ReadConstantTypeCode(ref BlobReader sigReader, List<string> modifiers)
        {
            while (true)
            {
                var s = sigReader.ReadSignatureTypeCode();
                if (s == SignatureTypeCode.OptionalModifier || s == SignatureTypeCode.RequiredModifier)
                {
                    var type = sigReader.ReadTypeHandle();
                    modifiers.Add((s == SignatureTypeCode.RequiredModifier ? "modreq" : "modopt") + "(" + Token(() => type) + ")");
                }
                else
                {
                    return s;
                }
            }
        }

        string FormatLocalConstant(MetadataReader reader, BlobHandle signature)
        {
            var sigReader = reader.GetBlobReader(signature);

            var modifiers = new List<string>();

            SignatureTypeCode typeCode = ReadConstantTypeCode(ref sigReader, modifiers);

            Handle typeHandle = default;
            object value;
            if (IsPrimitiveType(typeCode))
            {
                if (typeCode == SignatureTypeCode.String)
                {
                    if (sigReader.RemainingBytes == 1)
                    {
                        value = (sigReader.ReadByte() == 0xff) ? "null" : BadMetadataStr;
                    }
                    else if (sigReader.RemainingBytes % 2 != 0)
                    {
                        value = BadMetadataStr;
                    }
                    else
                    {
                        value = "'" + StringUtilities.EscapeNonPrintableCharacters(sigReader.ReadUTF16(sigReader.RemainingBytes)) + "'";
                    }
                }
                else
                {
                    object rawValue = sigReader.ReadConstant((ConstantTypeCode)typeCode);
                    if (rawValue is char c)
                    {
                        value = "'" + StringUtilities.EscapeNonPrintableCharacters(c.ToString()) + "'";
                    }
                    else
                    {
                        value = string.Format(CultureInfo.InvariantCulture, "{0}", rawValue);
                    }
                }

                if (sigReader.RemainingBytes > 0)
                {
                    typeHandle = sigReader.ReadTypeHandle();
                }
            }
            else if (typeCode == SignatureTypeCode.TypeHandle)
            {
                typeHandle = sigReader.ReadTypeHandle();
                value = (sigReader.RemainingBytes > 0) ? BitConverter.ToString(sigReader.ReadBytes(sigReader.RemainingBytes)) : "default";
            }
            else
            {
                value = (typeCode == SignatureTypeCode.Object) ? "null" : $"<bad type code: {typeCode}>";
            }

            return string.Format("{0} [{1}{2}]",
                value,
                 string.Join(" ", modifiers),
                typeHandle.IsNil ? typeCode.ToString() : Token(() => typeHandle));
        }


        private string Int32(Func<int> getValue)
            => ToString(getValue, value => value.ToString());

        private string Int32Hex(Func<int> getValue, int digits = 8)
            => ToString(getValue, value => "0x" + value.ToString("X" + digits));

        public string Token(Func<Handle> getHandle, bool displayTable = true)
            => ToString(getHandle, displayTable, Token);

        string Language(Func<GuidHandle> getHandle) =>
            Literal(() => getHandle(), (r, h) => GetLanguage(r.GetGuid((GuidHandle)h)));

        string HashAlgorithm(Func<GuidHandle> getHandle) =>
            Literal(() => getHandle(), (r, h) => GetHashAlgorithm(r.GetGuid((GuidHandle)h)));

        string CustomDebugInformationKind(Func<GuidHandle> getHandle) =>
            Literal(() => getHandle(), (r, h) => GetCustomDebugInformationKind(r.GetGuid((GuidHandle)h)));

        void WriteTable(TableBuilder table)
        {
            if (table.RowCount > 0)
            {
                table.WriteTo(_writer);
                _writer.WriteLine();
            }
        }

        string SequencePoint(SequencePoint sequencePoint, bool includeDocument = true)
        {
            string range = sequencePoint.IsHidden ?
                "<hidden>" :
                $"({sequencePoint.StartLine}, {sequencePoint.StartColumn}) - ({sequencePoint.EndLine}, {sequencePoint.EndColumn})" +
                    (includeDocument ? $" [{RowId(() => sequencePoint.Document)}]" : "");

            return $"IL_{sequencePoint.Offset:X4}: " + range;
        }

        bool NoHeapReferences
            => (_options & MetadataVisualizerOptions.NoHeapReferences) != 0;

        string HeapOffset(Func<Handle> getHandle)
            => ToString(getHandle, HeapOffset);

        string HeapOffset(Handle handle)
            => handle.IsNil ? "nil" : NoHeapReferences ? "" : $"#{_reader.GetHeapOffset(handle):x}";

        public string RowId(Func<EntityHandle> getHandle)
            => ToString(getHandle, RowId);

        public string RowId(EntityHandle handle)
            => handle.IsNil ? "nil" : $"#{_reader.GetRowNumber(handle):x}";

        static readonly Guid s_CSharpGuid = new Guid("3f5162f8-07c6-11d3-9053-00c04fa302a1");

        static readonly Guid s_visualBasicGuid = new Guid("3a12d0b8-c26c-11d0-b442-00a0244a1dd2");

        static readonly Guid s_FSharpGuid = new Guid("ab4f38c9-b6e6-43ba-be3b-58080b2ccce3");

        static string GetLanguage(Guid guid)
        {
            if (guid == s_CSharpGuid) return "C#";
            if (guid == s_visualBasicGuid) return "Visual Basic";
            if (guid == s_FSharpGuid) return "F#";

            return "{" + guid + "}";
        }

        string ToString<TValue>(Func<TValue> getValue)
        {
            try
            {
                return getValue().ToString();
            }
            catch (BadImageFormatException)
            {
                return BadMetadataStr;
            }
        }

        static string GetHashAlgorithm(Guid guid)
        {
            if (guid == s_sha1Guid) return "SHA-1";
            if (guid == s_sha256Guid) return "SHA-256";
            return "{" + guid + "}";
        }

        string Literal(Func<Handle> getHandle, Func<MetadataReader, Handle, string> getValue)
        {
            Handle handle;
            try
            {
                handle = getHandle();
            }
            catch (BadImageFormatException)
            {
                return BadMetadataStr;
            }

            return Literal(handle, getValue);
        }


        public void WriteImportScope()
        {
            var table = new TableBuilder(
                MakeTableName(TableIndex.ImportScope),
                "Parent",
                "Imports"
            );

            foreach (var handle in _reader.ImportScopes)
            {
                var entry = _reader.GetImportScope(handle);

                _blobKinds[entry.ImportsBlob] = BlobKind.Imports;

                table.AddRow(
                    Token(() => entry.Parent),
                    FormatImports(entry)
               );
            }

            WriteTable(table);
        }

        string FormatImports(ImportScope scope)
        {
            if (scope.ImportsBlob.IsNil)
            {
                return "nil";
            }

            var sb = new StringBuilder();

            foreach (var import in scope.GetImports())
            {
                if (sb.Length > 0)
                {
                    sb.Append(", ");
                }

                switch (import.Kind)
                {
                    case ImportDefinitionKind.ImportNamespace:
                        sb.AppendFormat("{0}", LiteralUtf8Blob(() => import.TargetNamespace, BlobKind.ImportNamespace));
                        break;

                    case ImportDefinitionKind.ImportAssemblyNamespace:
                        sb.AppendFormat("{0}::{1}",
                            Token(() => import.TargetAssembly),
                            LiteralUtf8Blob(() => import.TargetNamespace, BlobKind.ImportNamespace));
                        break;

                    case ImportDefinitionKind.ImportType:
                        sb.AppendFormat("{0}", Token(() => import.TargetType));
                        break;

                    case ImportDefinitionKind.ImportXmlNamespace:
                        sb.AppendFormat("<{0} = {1}>",
                            LiteralUtf8Blob(() => import.Alias, BlobKind.ImportAlias),
                            LiteralUtf8Blob(() => import.TargetNamespace, BlobKind.ImportNamespace));
                        break;

                    case ImportDefinitionKind.ImportAssemblyReferenceAlias:
                        sb.AppendFormat("Extern Alias {0}",
                            LiteralUtf8Blob(() => import.Alias, BlobKind.ImportAlias));
                        break;

                    case ImportDefinitionKind.AliasAssemblyReference:
                        sb.AppendFormat("{0} = {1}",
                            LiteralUtf8Blob(() => import.Alias, BlobKind.ImportAlias),
                            Token(() => import.TargetAssembly));
                        break;

                    case ImportDefinitionKind.AliasNamespace:
                        sb.AppendFormat("{0} = {1}",
                            LiteralUtf8Blob(() => import.Alias, BlobKind.ImportAlias),
                            LiteralUtf8Blob(() => import.TargetNamespace, BlobKind.ImportNamespace));
                        break;

                    case ImportDefinitionKind.AliasAssemblyNamespace:
                        sb.AppendFormat("{0} = {1}::{2}",
                            LiteralUtf8Blob(() => import.Alias, BlobKind.ImportAlias),
                            Token(() => import.TargetAssembly),
                            LiteralUtf8Blob(() => import.TargetNamespace, BlobKind.ImportNamespace));
                        break;

                    case ImportDefinitionKind.AliasType:
                        sb.AppendFormat("{0} = {1}",
                            LiteralUtf8Blob(() => import.Alias, BlobKind.ImportAlias),
                            Token(() => import.TargetType));
                        break;
                }
            }

            return sb.ToString();
        }

        string LiteralUtf8Blob(Func<BlobHandle> getHandle, BlobKind kind)
        {
            return Literal(getHandle, kind, (r, h) =>
            {
                var bytes = r.GetBlobBytes(h);
                return "'" + Encoding.UTF8.GetString(bytes, 0, bytes.Length) + "'";
            });
        }

        public void WriteCustomDebugInformation()
        {
            const int BlobSizeLimit = 32;

            var table = new TableBuilder(
                MakeTableName(TableIndex.CustomDebugInformation),
                "Parent",
                "Kind",
                "Value"
            );

            foreach (var handle in _reader.CustomDebugInformation)
            {
                var entry = _reader.GetCustomDebugInformation(handle);

                table.AddRowWithDetails(
                    fields: new[]
                    {
                        Token(() => entry.Parent),
                        CustomDebugInformationKind(() => entry.Kind),
                        Literal(() => entry.Value, BlobKind.CustomDebugInformation, (r, h) =>
                        {
                            var blob = r.GetBlobBytes(h);
                            int length = blob.Length;
                            string suffix = "";

                            if (blob.Length > BlobSizeLimit)
                            {
                                length = BlobSizeLimit;
                                suffix = "-...";
                            }

                            return BitConverter.ToString(blob, 0, length) + suffix;
                        })
                    },
                    details: TryDecodeCustomDebugInformation(entry)
                );
            }

            WriteTable(table);
        }

        public string TryDecodeCustomDebugInformation(CustomDebugInformation entry)
        {
            Guid kind;
            BlobReader blobReader;

            try
            {
                kind = _reader.GetGuid(entry.Kind);
                blobReader = _reader.GetBlobReader(entry.Value);
            }
            catch
            {
                // error is already reported
                return null;
            }

            if (kind == PortableCustomDebugInfoKinds.SourceLink)
            {
                return VisualizeSourceLink(blobReader);
            }

            if (kind == CompilationMetadataReferences)
            {
                return VisualizeCompilationMetadataReferences(blobReader);
            }

            if (kind == CompilationOptions)
            {
                return VisualizeCompilationOptions(blobReader);
            }

            return null;
        }

        [Flags]
        enum MetadataReferenceFlags
        {
            Assembly = 1,
            EmbedInteropTypes = 1 << 1,
        }

        static string VisualizeCompilationMetadataReferences(BlobReader reader)
        {
            var table = new TableBuilder(
                title: null,
                "FileName",
                "Aliases",
                "Flags",
                "TimeStamp",
                "FileSize",
                "MVID")
            {
                HorizontalSeparatorChar = '-',
                Indent = "  ",
                FirstRowNumber = 0,
            };

            while (reader.RemainingBytes > 0)
            {
                var fileName = TryReadUtf8NullTerminated(ref reader);
                var aliases = TryReadUtf8NullTerminated(ref reader);

                string flags = null;
                string timeStamp = null;
                string fileSize = null;
                string mvid = null;

                try { flags = ((MetadataReferenceFlags)reader.ReadByte()).ToString(); } catch { }
                try { timeStamp = $"0x{reader.ReadUInt32():X8}"; } catch { }
                try { fileSize = $"0x{reader.ReadUInt32():X8}"; } catch { }
                try { mvid = reader.ReadGuid().ToString(); } catch { }

                table.AddRow(
                    (fileName != null) ? $"'{fileName}'" : BadMetadataStr,
                    (aliases != null) ? $"'{string.Join("', '", aliases.Split(','))}'" : BadMetadataStr,
                    flags ?? BadMetadataStr,
                    timeStamp ?? BadMetadataStr,
                    fileSize ?? BadMetadataStr,
                    mvid ?? BadMetadataStr
                );
            }

            var builder = new StringBuilder();
            builder.AppendLine("{");
            table.WriteTo(new StringWriter(builder));
            builder.AppendLine("}");
            return builder.ToString();
        }

        static string TryReadUtf8NullTerminated(ref BlobReader reader)
        {
            var terminatorIndex = reader.IndexOf(0);
            if (terminatorIndex == -1)
            {
                return null;
            }

            var value = reader.ReadUTF8(terminatorIndex);
            _ = reader.ReadByte();
            return value;
        }

        static string VisualizeCompilationOptions(BlobReader reader)
        {
            var builder = new StringBuilder();
            builder.AppendLine("{");

            while (reader.RemainingBytes > 0)
            {
                var key = TryReadUtf8NullTerminated(ref reader);
                if (key == null)
                {
                    builder.AppendLine(BadMetadataStr);
                    break;
                }

                builder.Append($"  {key}: ");

                var value = TryReadUtf8NullTerminated(ref reader);
                if (value == null)
                {
                    builder.AppendLine(BadMetadataStr);
                    break;
                }

                builder.AppendLine(value);
            }

            builder.AppendLine("}");
            return builder.ToString();
        }

        private static string VisualizeSourceLink(BlobReader reader)
            => reader.ReadUTF8(reader.RemainingBytes);

        string Literal(Func<StringHandle> getHandle) =>
            Literal(() => getHandle(), (r, h) => "'" + StringUtilities.EscapeNonPrintableCharacters(r.GetString((StringHandle)h)) + "'");

        string Literal(Func<NamespaceDefinitionHandle> getHandle) =>
            Literal(() => getHandle(), (r, h) => "'" + StringUtilities.EscapeNonPrintableCharacters(r.GetString((NamespaceDefinitionHandle)h)) + "'");

        string Literal(Func<GuidHandle> getHandle) =>
            Literal(() => getHandle(), (r, h) => "{" + r.GetGuid((GuidHandle)h) + "}");

        static readonly Guid s_sha1Guid = new Guid("ff1816ec-aa5e-4d10-87f7-6f4963833460");

        static readonly Guid s_sha256Guid = new Guid("8829d00f-11b8-4213-878b-770e8597ac16");

        public static readonly Guid CompilationMetadataReferences = new Guid("7E4D4708-096E-4C5C-AEDA-CB10BA6A740D");

        public static readonly Guid CompilationOptions = new Guid("B5FEEC05-8CD0-4A83-96DA-466284BB4BD8");


        static string ToString<TValue>(Func<TValue> getValue, Func<TValue, string> valueToString)
        {
            try
            {
                return valueToString(getValue());
            }
            catch (BadImageFormatException)
            {
                return BadMetadataStr;
            }
        }

        static string ToString<TValue, TArg>(Func<TValue> getValue, TArg arg, Func<TValue, TArg, string> valueToString)
        {
            try
            {
                return valueToString(getValue(), arg);
            }
            catch (BadImageFormatException)
            {
                return BadMetadataStr;
            }
        }

        const string BadMetadataStr = "<bad metadata>";

        static bool TryGetValue<T>(Func<T> getValue, out T result)
        {
            try
            {
                result = getValue();
                return true;
            }
            catch (BadImageFormatException)
            {
                result = default;
                return false;
            }
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

        string MakeTableName(TableIndex index)
            => $"{index} (index: 0x{(byte)index:X2}, size: {_reader.GetTableRowCount(index) * _reader.GetTableRowSize(index)}): ";

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

        private string FieldSignature(Func<BlobHandle> getHandle) =>
            Literal(getHandle, BlobKind.FieldSignature, (r, h) => Signature(r, h, BlobKind.FieldSignature));

        private string MethodSignature(Func<BlobHandle> getHandle) =>
            Literal(getHandle, BlobKind.MethodSignature, (r, h) => Signature(r, h, BlobKind.MethodSignature));

        private string StandaloneSignature(Func<BlobHandle> getHandle) =>
            Literal(getHandle, BlobKind.StandAloneSignature, (r, h) => Signature(r, h, BlobKind.StandAloneSignature));

        private string MemberReferenceSignature(Func<BlobHandle> getHandle) =>
            Literal(getHandle, BlobKind.MemberRefSignature, (r, h) => Signature(r, h, BlobKind.MemberRefSignature));

        private string MethodSpecificationSignature(Func<BlobHandle> getHandle) =>
            Literal(getHandle, BlobKind.MethodSpec, (r, h) => Signature(r, h, BlobKind.MethodSpec));

        private string TypeSpecificationSignature(Func<BlobHandle> getHandle) =>
            Literal(getHandle, BlobKind.TypeSpec, (r, h) => Signature(r, h, BlobKind.TypeSpec));

        public string MethodSignature(BlobHandle signatureHandle) =>
            Literal(signatureHandle, (r, h) => Signature(r, (BlobHandle)h, BlobKind.MethodSignature));

        public string StandaloneSignature(BlobHandle signatureHandle) =>
            Literal(signatureHandle, (r, h) => Signature(r, (BlobHandle)h, BlobKind.StandAloneSignature));

        public string MemberReferenceSignature(BlobHandle signatureHandle) =>
            Literal(signatureHandle, (r, h) => Signature(r, (BlobHandle)h, BlobKind.MemberRefSignature));

        public string MethodSpecificationSignature(BlobHandle signatureHandle) =>
            Literal(signatureHandle, (r, h) => Signature(r, (BlobHandle)h, BlobKind.MethodSpec));

        public string TypeSpecificationSignature(BlobHandle signatureHandle) =>
            Literal(signatureHandle, (r, h) => Signature(r, (BlobHandle)h, BlobKind.TypeSpec));

        private string Signature(MetadataReader reader, BlobHandle signatureHandle, BlobKind kind)
        {
            try
            {
                var sigReader = reader.GetBlobReader(signatureHandle);
                var decoder = new SignatureDecoder<string, object>(_signatureVisualizer, reader, genericContext: null);
                switch (kind)
                {
                    case BlobKind.FieldSignature:
                        return decoder.DecodeFieldSignature(ref sigReader);

                    case BlobKind.MethodSignature:
                        return MethodSignature(decoder.DecodeMethodSignature(ref sigReader));

                    case BlobKind.StandAloneSignature:
                        return string.Join(", ", decoder.DecodeLocalSignature(ref sigReader));

                    case BlobKind.MemberRefSignature:
                        var header = sigReader.ReadSignatureHeader();
                        sigReader.Offset = 0;
                        switch (header.Kind)
                        {
                            case SignatureKind.Field:
                                return decoder.DecodeFieldSignature(ref sigReader);

                            case SignatureKind.Method:
                                return MethodSignature(decoder.DecodeMethodSignature(ref sigReader));
                        }

                        throw new BadImageFormatException();

                    case BlobKind.MethodSpec:
                        return string.Join(", ", decoder.DecodeMethodSpecificationSignature(ref sigReader));

                    case BlobKind.TypeSpec:
                        return decoder.DecodeType(ref sigReader, allowTypeSpecifications: false);

                    default:
                        throw ExceptionUtilities.UnexpectedValue(kind);
                }
            }
            catch (BadImageFormatException)
            {
                return $"<bad signature: {BitConverter.ToString(reader.GetBlobBytes(signatureHandle))}>";
            }
        }


        static string MethodSignature(MethodSignature<string> signature)
        {
            var builder = new StringBuilder();
            builder.Append(signature.ReturnType);
            builder.Append(' ');
            builder.Append('(');

            for (int i = 0; i < signature.ParameterTypes.Length; i++)
            {
                if (i > 0)
                {
                    builder.Append(", ");

                    if (i == signature.RequiredParameterCount)
                    {
                        builder.Append("... ");
                    }
                }

                builder.Append(signature.ParameterTypes[i]);
            }

            builder.Append(')');
            return builder.ToString();
        }

        // Test implementation of ISignatureTypeProvider<TType, TGenericContext> that uses strings in ilasm syntax as TType.
        // A real provider in any sort of perf constraints would not want to allocate strings freely like this, but it keeps test code simple.
        internal sealed class SignatureVisualizer : ISignatureTypeProvider<string, object>
        {
            private readonly MetadataVisualizer _visualizer;

            public SignatureVisualizer(MetadataVisualizer visualizer)
            {
                _visualizer = visualizer;
            }

            public string GetPrimitiveType(PrimitiveTypeCode typeCode)
            {
                switch (typeCode)
                {
                    case PrimitiveTypeCode.Boolean: return "bool";
                    case PrimitiveTypeCode.Byte: return "uint8";
                    case PrimitiveTypeCode.Char: return "char";
                    case PrimitiveTypeCode.Double: return "float64";
                    case PrimitiveTypeCode.Int16: return "int16";
                    case PrimitiveTypeCode.Int32: return "int32";
                    case PrimitiveTypeCode.Int64: return "int64";
                    case PrimitiveTypeCode.IntPtr: return "native int";
                    case PrimitiveTypeCode.Object: return "object";
                    case PrimitiveTypeCode.SByte: return "int8";
                    case PrimitiveTypeCode.Single: return "float32";
                    case PrimitiveTypeCode.String: return "string";
                    case PrimitiveTypeCode.TypedReference: return "typedref";
                    case PrimitiveTypeCode.UInt16: return "uint16";
                    case PrimitiveTypeCode.UInt32: return "uint32";
                    case PrimitiveTypeCode.UInt64: return "uint64";
                    case PrimitiveTypeCode.UIntPtr: return "native uint";
                    case PrimitiveTypeCode.Void: return "void";
                    default: return "<bad metadata>";
                }
            }

            private string RowId(EntityHandle handle)
                => _visualizer.RowId(handle);

            public string GetTypeFromDefinition(MetadataReader reader, TypeDefinitionHandle handle, byte rawTypeKind = 0)
                => $"typedef{RowId(handle)}";

            public string GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind = 0) =>
                $"typeref{RowId(handle)}";

            public string GetTypeFromSpecification(MetadataReader reader, object genericContext, TypeSpecificationHandle handle, byte rawTypeKind = 0) =>
                $"typespec{RowId(handle)}";

            public string GetSZArrayType(string elementType)
                => elementType + "[]";

            public string GetPointerType(string elementType)
                => elementType + "*";

            public string GetByReferenceType(string elementType)
                => elementType + "&";

            public string GetGenericMethodParameter(object genericContext, int index)
                => "!!" + index;

            public string GetGenericTypeParameter(object genericContext, int index)
                => "!" + index;

            public string GetPinnedType(string elementType)
                => elementType + " pinned";

            public string GetGenericInstantiation(string genericType, ImmutableArray<string> typeArguments)
                => genericType + "<" + string.Join(",", typeArguments) + ">";

            public string GetModifiedType(string modifierType, string unmodifiedType, bool isRequired) =>
                unmodifiedType + (isRequired ? " modreq(" : " modopt(") + modifierType + ")";

            public string GetArrayType(string elementType, ArrayShape shape)
            {
                var builder = new StringBuilder();

                builder.Append(elementType);
                builder.Append('[');

                for (int i = 0; i < shape.Rank; i++)
                {
                    int lowerBound = 0;

                    if (i < shape.LowerBounds.Length)
                    {
                        lowerBound = shape.LowerBounds[i];
                        builder.Append(lowerBound);
                    }

                    builder.Append("...");

                    if (i < shape.Sizes.Length)
                    {
                        builder.Append(lowerBound + shape.Sizes[i] - 1);
                    }

                    if (i < shape.Rank - 1)
                    {
                        builder.Append(',');
                    }
                }

                builder.Append(']');
                return builder.ToString();
            }

            public string GetFunctionPointerType(MethodSignature<string> signature)
                => $"methodptr({MethodSignature(signature)})";
        }

        public virtual string VisualizeLocalType(object type)
            => string.Format(CultureInfo.InvariantCulture, "0x{0:X8}", type);

        sealed class TokenTypeComparer : IComparer<EntityHandle>
        {
            public static readonly TokenTypeComparer Instance = new TokenTypeComparer();

            public int Compare(EntityHandle x, EntityHandle y)
            {
                return x.Kind.CompareTo(y.Kind);
            }
        }

        enum BlobKind
        {
            None,
            Key,
            FileHash,

            MethodSignature,
            FieldSignature,
            MemberRefSignature,
            StandAloneSignature,

            TypeSpec,
            MethodSpec,

            ConstantValue,
            Marshalling,
            PermissionSet,
            CustomAttribute,

            DocumentName,
            DocumentHash,
            SequencePoints,
            Imports,
            ImportAlias,
            ImportNamespace,
            LocalConstantSignature,
            CustomDebugInformation,

            Count
        }

        sealed class TableBuilder
        {
            readonly string _title;

            readonly string[] _header;

            readonly List<(string[] fields, string details)> _rows;

            public char HorizontalSeparatorChar = '=';

            public string Indent = "";

            public int FirstRowNumber = 1;

            public TableBuilder(string title, params string[] header)
            {
                _rows = new List<(string[] fields, string details)>();
                _title = title;
                _header = header;
            }

            public int RowCount
                => _rows.Count;

            public void AddRow(params string[] fields)
                => AddRowWithDetails(fields, details: null);

            public void AddRowWithDetails(string[] fields, string details)
            {
                Debug.Assert(_header.Length == fields.Length);
                _rows.Add((fields, details));
            }

            public void WriteTo(TextWriter writer)
            {
                if (_rows.Count == 0)
                {
                    return;
                }

                if (_title != null)
                {
                    writer.Write(Indent);
                    writer.WriteLine(_title);
                }

                string columnSeparator = "  ";
                var columnWidths = new int[_rows.First().fields.Length];

                void updateColumnWidths( string[] fields)
                {
                    for (int i = 0; i < fields.Length; i++)
                    {
                        columnWidths[i] = Math.Max(columnWidths[i], fields[i].Length + columnSeparator.Length);
                    }
                }

                updateColumnWidths(_header);

                foreach (var (fields, _) in _rows)
                {
                    updateColumnWidths(fields);
                }

                void writeRow(string[] fields)
                {
                    for (int i = 0; i < fields.Length; i++)
                    {
                        var field = fields[i];

                        writer.Write(field);
                        writer.Write(new string(' ', columnWidths[i] - field.Length));
                    }
                }

                // header:
                int rowNumberWidth = (FirstRowNumber + _rows.Count - 1).ToString("x").Length;
                int tableWidth = Math.Max(_title?.Length ?? 0, columnWidths.Sum() + columnWidths.Length);
                string horizontalSeparator = new string(HorizontalSeparatorChar, tableWidth);

                writer.Write(Indent);
                writer.WriteLine(horizontalSeparator);

                writer.Write(Indent);
                writer.Write(new string(' ', rowNumberWidth + 2));

                writeRow(_header);

                writer.WriteLine();
                writer.Write(Indent);
                writer.WriteLine(horizontalSeparator);

                // rows:
                int rowNumber = FirstRowNumber;
                foreach (var (fields, details) in _rows)
                {
                    string rowNumberStr = rowNumber.ToString("x");
                    writer.Write(Indent);
                    writer.Write(new string(' ', rowNumberWidth - rowNumberStr.Length));
                    writer.Write(rowNumberStr);
                    writer.Write(": ");

                    writeRow(fields);
                    writer.WriteLine();

                    if (details != null)
                    {
                        writer.Write(Indent);
                        writer.Write(details);
                    }

                    rowNumber++;
                }
            }
        }
    }

    internal static class StringUtilities
    {
        internal static string EscapeNonPrintableCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in str)
            {
                bool escape;
                switch (CharUnicodeInfo.GetUnicodeCategory(c))
                {
                    case UnicodeCategory.Control:
                    case UnicodeCategory.OtherNotAssigned:
                    case UnicodeCategory.ParagraphSeparator:
                    case UnicodeCategory.Surrogate:
                        escape = true;
                        break;

                    default:
                        escape = c >= 0xFFFC;
                        break;
                }

                if (escape)
                {
                    sb.AppendFormat("\\u{0:X4}", (int)c);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }

    internal static class ExceptionUtilities
    {
        internal static Exception UnexpectedValue(object o)
        {
            string output = string.Format("Unexpected value '{0}' of type '{1}'", o, (o != null) ? o.GetType().FullName : "<unknown>");
            Debug.Assert(false, output);

            // We do not throw from here because we don't want all Watson reports to be bucketed to this call.
            return new InvalidOperationException(output);
        }

        internal static Exception Unreachable
        {
            get { return new InvalidOperationException("This program location is thought to be unreachable."); }
        }
    }



    public enum HandlerKind
    {
        Try,
        Catch,
        Filter,
        Finally,
        Fault
    }


    // public struct LocalInfo
    // {
    //     public readonly string Name;
    //     public readonly bool IsPinned;
    //     public readonly bool IsByRef;
    //     public readonly object Type; // ITypeReference or ITypeSymbol

    //     public LocalInfo(string name, object type, bool isPinned, bool isByRef)
    //     {
    //         Name = name;
    //         Type = type;
    //         IsPinned = isPinned;
    //         IsByRef = isByRef;
    //     }
    //}

    internal static class PortableCustomDebugInfoKinds
    {
        public static readonly Guid AsyncMethodSteppingInformationBlob = new Guid("54FD2AC5-E925-401A-9C2A-F94F171072F8");

        public static readonly Guid StateMachineHoistedLocalScopes = new Guid("6DA9A61E-F8C7-4874-BE62-68BC5630DF71");

        public static readonly Guid DynamicLocalVariables = new Guid("83C563C4-B4F3-47D5-B824-BA5441477EA8");

        public static readonly Guid TupleElementNames = new Guid("ED9FDF71-8879-4747-8ED3-FE5EDE3CE710");

        public static readonly Guid DefaultNamespace = new Guid("58b2eab6-209f-4e4e-a22c-b2d0f910c782");

        public static readonly Guid EncLocalSlotMap = new Guid("755F52A8-91C5-45BE-B4B8-209571E552BD");

        public static readonly Guid EncLambdaAndClosureMap = new Guid("A643004C-0240-496F-A783-30D64F4979DE");

        public static readonly Guid SourceLink = new Guid("CC110556-A091-4D38-9FEC-25AB9A351A6A");

        public static readonly Guid EmbeddedSource = new Guid("0E8A571B-6926-466E-B4AD-8AB04611F5FE");
    }

    internal static class Hash
    {
        /// <summary>
        /// This is how VB Anonymous Types combine hash values for fields.
        /// </summary>
        internal static int Combine(int newKey, int currentKey)
        {
            return unchecked((currentKey * (int)0xA5555529) + newKey);
        }

        internal static int Combine(bool newKeyPart, int currentKey)
        {
            return Combine(currentKey, newKeyPart ? 1 : 0);
        }

        /// <summary>
        /// This is how VB Anonymous Types combine hash values for fields.
        /// PERF: Do not use with enum types because that involves multiple
        /// unnecessary boxing operations.  Unfortunately, we can't constrain
        /// T to "non-enum", so we'll use a more restrictive constraint.
        /// </summary>
        internal static int Combine<T>(T newKeyPart, int currentKey) where T : class
        {
            int hash = unchecked(currentKey * (int)0xA5555529);

            if (newKeyPart != null)
            {
                return unchecked(hash + newKeyPart.GetHashCode());
            }

            return hash;
        }

        internal static int CombineValues<T>(ImmutableArray<T> values, IEqualityComparer<T> comparer = null, int maxItemsToHash = int.MaxValue)
        {
            if (values.IsDefaultOrEmpty)
            {
                return 0;
            }

            if (comparer == null)
            {
                comparer = EqualityComparer<T>.Default;
            }

            var hashCode = 0;
            var count = 0;
            foreach (var value in values)
            {
                if (count++ >= maxItemsToHash)
                {
                    break;
                }

                // Should end up with a constrained virtual call to object.GetHashCode (i.e. avoid boxing where possible).
                if (value != null)
                {
                    hashCode = Combine(comparer.GetHashCode(value), hashCode);
                }
            }

            return hashCode;
        }

        internal static int CombineValues<T>(IEnumerable<T> values, IEqualityComparer<T> comparer = null, int maxItemsToHash = int.MaxValue)
        {
            if (values == null)
            {
                return 0;
            }

            if (comparer == null)
            {
                comparer = EqualityComparer<T>.Default;
            }

            var hashCode = 0;
            var count = 0;
            foreach (var value in values)
            {
                if (count++ >= maxItemsToHash)
                {
                    break;
                }

                if (value != null)
                {
                    hashCode = Combine(comparer.GetHashCode(value), hashCode);
                }
            }

            return hashCode;
        }

        /// <summary>
        /// The offset bias value used in the FNV-1a algorithm
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        internal const int FnvOffsetBias = unchecked((int)2166136261);

        /// <summary>
        /// The generative factor used in the FNV-1a algorithm
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        internal const int FnvPrime = 16777619;

        /// <summary>
        /// Compute the FNV-1a hash of a sequence of bytes
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="data">The sequence of bytes</param>
        /// <returns>The FNV-1a hash of <paramref name="data"/></returns>
        internal static int GetFNVHashCode(byte[] data)
        {
            int hashCode = Hash.FnvOffsetBias;

            for (int i = 0; i < data.Length; i++)
            {
                hashCode = unchecked((hashCode ^ data[i]) * Hash.FnvPrime);
            }

            return hashCode;
        }

        /// <summary>
        /// Compute the FNV-1a hash of a sequence of bytes and determines if the byte
        /// sequence is valid ASCII and hence the hash code matches a char sequence
        /// encoding the same text.
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="data">The sequence of bytes that are likely to be ASCII text.</param>
        /// <param name="length">The length of the sequence.</param>
        /// <param name="isAscii">True if the sequence contains only characters in the ASCII range.</param>
        /// <returns>The FNV-1a hash of <paramref name="data"/></returns>
        internal static unsafe int GetFNVHashCode(byte* data, int length, out bool isAscii)
        {
            int hashCode = Hash.FnvOffsetBias;

            byte asciiMask = 0;

            for (int i = 0; i < length; i++)
            {
                byte b = data[i];
                asciiMask |= b;
                hashCode = unchecked((hashCode ^ b) * Hash.FnvPrime);
            }

            isAscii = (asciiMask & 0x80) == 0;
            return hashCode;
        }

        /// <summary>
        /// Compute the FNV-1a hash of a sequence of bytes
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="data">The sequence of bytes</param>
        /// <returns>The FNV-1a hash of <paramref name="data"/></returns>
        internal static int GetFNVHashCode(ImmutableArray<byte> data)
        {
            int hashCode = Hash.FnvOffsetBias;

            for (int i = 0; i < data.Length; i++)
            {
                hashCode = unchecked((hashCode ^ data[i]) * Hash.FnvPrime);
            }

            return hashCode;
        }

        /// <summary>
        /// Compute the hashcode of a sub-string using FNV-1a
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// Note: FNV-1a was developed and tuned for 8-bit sequences. We're using it here
        /// for 16-bit Unicode chars on the understanding that the majority of chars will
        /// fit into 8-bits and, therefore, the algorithm will retain its desirable traits
        /// for generating hash codes.
        /// </summary>
        /// <param name="text">The input string</param>
        /// <param name="start">The start index of the first character to hash</param>
        /// <param name="length">The number of characters, beginning with <paramref name="start"/> to hash</param>
        /// <returns>The FNV-1a hash code of the substring beginning at <paramref name="start"/> and ending after <paramref name="length"/> characters.</returns>
        internal static int GetFNVHashCode(string text, int start, int length)
        {
            int hashCode = Hash.FnvOffsetBias;
            int end = start + length;

            for (int i = start; i < end; i++)
            {
                hashCode = unchecked((hashCode ^ text[i]) * Hash.FnvPrime);
            }

            return hashCode;
        }

        /// <summary>
        /// Compute the hashcode of a sub-string using FNV-1a
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="text">The input string</param>
        /// <param name="start">The start index of the first character to hash</param>
        /// <returns>The FNV-1a hash code of the substring beginning at <paramref name="start"/> and ending at the end of the string.</returns>
        internal static int GetFNVHashCode(string text, int start)
        {
            return GetFNVHashCode(text, start, length: text.Length - start);
        }

        /// <summary>
        /// Compute the hashcode of a string using FNV-1a
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="text">The input string</param>
        /// <returns>The FNV-1a hash code of <paramref name="text"/></returns>
        internal static int GetFNVHashCode(string text)
        {
            return CombineFNVHash(Hash.FnvOffsetBias, text);
        }

        /// <summary>
        /// Compute the hashcode of a string using FNV-1a
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="text">The input string</param>
        /// <returns>The FNV-1a hash code of <paramref name="text"/></returns>
        internal static int GetFNVHashCode(System.Text.StringBuilder text)
        {
            int hashCode = Hash.FnvOffsetBias;
            int end = text.Length;

            for (int i = 0; i < end; i++)
            {
                hashCode = unchecked((hashCode ^ text[i]) * Hash.FnvPrime);
            }

            return hashCode;
        }

        /// <summary>
        /// Compute the hashcode of a sub string using FNV-1a
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="text">The input string as a char array</param>
        /// <param name="start">The start index of the first character to hash</param>
        /// <param name="length">The number of characters, beginning with <paramref name="start"/> to hash</param>
        /// <returns>The FNV-1a hash code of the substring beginning at <paramref name="start"/> and ending after <paramref name="length"/> characters.</returns>
        internal static int GetFNVHashCode(char[] text, int start, int length)
        {
            int hashCode = Hash.FnvOffsetBias;
            int end = start + length;

            for (int i = start; i < end; i++)
            {
                hashCode = unchecked((hashCode ^ text[i]) * Hash.FnvPrime);
            }

            return hashCode;
        }

        /// <summary>
        /// Compute the hashcode of a single character using the FNV-1a algorithm
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// Note: In general, this isn't any more useful than "char.GetHashCode". However,
        /// it may be needed if you need to generate the same hash code as a string or
        /// substring with just a single character.
        /// </summary>
        /// <param name="ch">The character to hash</param>
        /// <returns>The FNV-1a hash code of the character.</returns>
        internal static int GetFNVHashCode(char ch)
        {
            return Hash.CombineFNVHash(Hash.FnvOffsetBias, ch);
        }

        /// <summary>
        /// Combine a string with an existing FNV-1a hash code
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="hashCode">The accumulated hash code</param>
        /// <param name="text">The string to combine</param>
        /// <returns>The result of combining <paramref name="hashCode"/> with <paramref name="text"/> using the FNV-1a algorithm</returns>
        internal static int CombineFNVHash(int hashCode, string text)
        {
            foreach (char ch in text)
            {
                hashCode = unchecked((hashCode ^ ch) * Hash.FnvPrime);
            }

            return hashCode;
        }

        /// <summary>
        /// Combine a char with an existing FNV-1a hash code
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="hashCode">The accumulated hash code</param>
        /// <param name="ch">The new character to combine</param>
        /// <returns>The result of combining <paramref name="hashCode"/> with <paramref name="ch"/> using the FNV-1a algorithm</returns>
        internal static int CombineFNVHash(int hashCode, char ch)
        {
            return unchecked((hashCode ^ ch) * Hash.FnvPrime);
        }
    }

}