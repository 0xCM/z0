//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Buffers;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    public class ClrmdPrimitiveType : ClrType
    {
        public ClrmdPrimitiveType(ITypeHelpers helpers, ClrModule module, ClrHeap heap, ClrMdTypeCode type)
        {
            if (helpers is null)
                throw new ArgumentNullException(nameof(helpers));

            ClrObjectHelpers = helpers.ClrObjectHelpers;
            Module = module ?? throw new ArgumentNullException(nameof(module));
            Heap = heap ?? throw new ArgumentNullException(nameof(heap));
            ElementType = type;
        }

        public override bool IsEnum => false;

        public override ClrEnum AsEnum()
            => throw new InvalidOperationException();

        public override ClrModule Module { get; }

        public override IClrObjectHelpers ClrObjectHelpers { get; }

        public override ClrMdTypeCode ElementType { get; }

        public override bool IsShared => false;

        public override int StaticSize => ClrmdField.GetSize(this, ElementType);

        public override ClrType? BaseType => null; // todo;

        public override ClrHeap Heap { get; }

        public override IEnumerable<ClrGenericParameter> EnumerateGenericParameters()
            => Enumerable.Empty<ClrGenericParameter>();

        public override IEnumerable<ClrInterface> EnumerateInterfaces()
            => Enumerable.Empty<ClrInterface>();

        public override bool IsAbstract => false;

        public override bool IsFinalizable => false;

        public override bool IsInterface => false;

        public override bool IsInternal => false;

        public override bool IsPrivate => false;

        public override bool IsProtected => false;

        public override bool IsPublic => false;

        public override bool IsSealed => false;

        public override int MetadataToken => 0;

        public override ulong MethodTable => 0;

        public override string Name => ElementType switch
        {
            ClrMdTypeCode.Bool8 => "System.Boolean",
            ClrMdTypeCode.Char16 => "System.Char",
            ClrMdTypeCode.Int8i => "System.SByte",
            ClrMdTypeCode.Int8u => "System.Byte",
            ClrMdTypeCode.Int16i => "System.Int16",
            ClrMdTypeCode.Int16u => "System.UInt16",
            ClrMdTypeCode.Int32i => "System.Int32",
            ClrMdTypeCode.Int32u => "System.UInt32",
            ClrMdTypeCode.Int64i => "System.Int64",
            ClrMdTypeCode.Int64u => "System.UInt64",
            ClrMdTypeCode.Float32 => "System.Single",
            ClrMdTypeCode.Float64 => "System.Double",
            ClrMdTypeCode.IntI => "System.IntPtr",
            ClrMdTypeCode.IntU => "System.UIntPtr",
            ClrMdTypeCode.Struct => "Sytem.ValueType",
            _ => ElementType.ToString(),
        };

        public override ulong GetArrayElementAddress(ulong objRef, int index) => 0;

        public override object? GetArrayElementValue(ulong objRef, int index) => null;

        public override T[]? GetArrayElementValues<T>(ulong objRef, int count) => null;

        public override ClrInstanceField? GetFieldByName(string name) => null;

        public override ClrStaticField? GetStaticFieldByName(string name) => null;

        public override bool IsFinalizeSuppressed(ulong obj) => false;

        public override ImmutableArray<ClrInstanceField> Fields
            => ImmutableArray<ClrInstanceField>.Empty;

        public override GCDesc GCDesc => default;

        public override ImmutableArray<ClrStaticField> StaticFields
            => ImmutableArray<ClrStaticField>.Empty;

        public override ImmutableArray<ClrMethod> Methods
            => ImmutableArray<ClrMethod>.Empty;

        public override ClrType? ComponentType => null;

        public override bool IsArray => false;

        public override int ComponentSize => 0;
    }
}