//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;

    public class ClrmdConstructedType : ClrType
    {
        private readonly int _ranks;

        public override ClrHeap Heap 
            => ComponentType.Heap;

        public override ClrModule Module 
            => Heap.Runtime.BaseClassLibrary;

        public override ClrType ComponentType { get; }

        public override string Name
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ComponentType.Name);
                if (IsPointer)
                {
                    for (int i = 0; i < _ranks; i++)
                        sb.Append('*');
                }
                else
                {
                    sb.Append('[');
                    for (int i = 0; i < _ranks - 1; i++)
                        sb.Append(',');
                    sb.Append(']');
                }

                return sb.ToString();
            }
        }

        public ClrmdConstructedType(ClrType componentType, int ranks, bool pointer)
        {
            ComponentType = componentType ?? throw new ArgumentNullException(nameof(componentType));
            ElementType = pointer ? ClrElementType.Pointer : ClrElementType.SZArray;
            _ranks = ranks;

            if (ranks <= 0)
                throw new ArgumentException($"{nameof(ranks)} must be 1 or greater.");
        }

        public override IClrObjectHelpers ClrObjectHelpers => ComponentType.ClrObjectHelpers;

        public override bool IsEnum => false;
        public override ClrEnum AsEnum() => throw new InvalidOperationException();

        // We have no good way of finding this value, unfortunately
        public override ClrElementType ElementType { get; }
     
        public override ulong MethodTable => 0;
     
        public override bool IsFinalizeSuppressed(ulong obj) => false;
     
        public override bool IsPointer => true;
     
        public override ImmutableArray<ClrInstanceField> Fields => ImmutableArray<ClrInstanceField>.Empty;
     
        public override ImmutableArray<ClrStaticField> StaticFields => ImmutableArray<ClrStaticField>.Empty;
     
        public override ImmutableArray<ClrMethod> Methods => ImmutableArray<ClrMethod>.Empty;
     
        public override IEnumerable<ClrGenericParameter> EnumerateGenericParameters() => Enumerable.Empty<ClrGenericParameter>();
          
        public override IEnumerable<ClrInterface> EnumerateInterfaces() => Enumerable.Empty<ClrInterface>();
         
        public override bool IsFinalizable => false;
     
        public override bool IsPublic => true;
     
        public override bool IsPrivate => false;
     
        public override bool IsInternal => false;
     
        public override bool IsProtected => false;
    
        public override bool IsAbstract => false;
    
        public override bool IsSealed => false;
    
        public override bool IsShared => false;
    
        public override bool IsInterface => false;
    
        public override ClrInstanceField? GetFieldByName(string name) => null;
    
        public override ClrStaticField? GetStaticFieldByName(string name) => null;
    
        public override ClrType? BaseType => null;
    
        public override ulong GetArrayElementAddress(ulong objRef, int index) => 0;
    
        public override object? GetArrayElementValue(ulong objRef, int index) => null;
    
        public override T[]? GetArrayElementValues<T>(ulong objRef, int count) => null;
    
        public override int StaticSize => IntPtr.Size;
    
        public override GCDesc GCDesc => default;
    
        public override int MetadataToken => 0;
    
        public override bool IsArray => !IsPointer;
    
        public override int ComponentSize => IntPtr.Size;    
    }
}