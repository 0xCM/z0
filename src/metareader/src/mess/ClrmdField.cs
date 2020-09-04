//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Immutable;
    using System.Diagnostics;
    using System.Reflection;

    public class ClrmdField : ClrInstanceField
    {
        readonly IFieldHelpers _helpers;

        string? _name;

        ClrType? _type;

        FieldAttributes _attributes = FieldAttributes.ReservedMask;

        public override ClrTypeCode ElementType { get; }

        public override bool IsObjectReference
            => ElementType.IsObjectReference();

        public override bool IsValueType
            => ElementType.IsValueType();

        public override bool IsPrimitive
            => ElementType.IsPrimitive();

        public override string? Name
        {
            get
            {
                if (_name != null)
                    return _name;

                return ReadData();
            }
        }

        public override ClrType Type
        {
            get
            {
                if (_type != null)
                    return _type;

                InitData();
                return _type!;
            }
        }

        public override int Size
            => GetSize(Type, ElementType);

        public override int Token { get; }
        public override int Offset { get; }

        public override ClrType Parent { get; }

        public ClrmdField(ClrType parent, IFieldData data)
        {
            if (parent is null)
                throw new ArgumentNullException(nameof(parent));

            if (data is null)
                throw new ArgumentNullException(nameof(data));

            Parent = parent;
            Token = data.Token;
            ElementType = data.ElementType;
            Offset = data.Offset;

            _helpers = data.Helpers;

            // Must be the last use of 'data' in this constructor.
            _type = _helpers.Factory.GetOrCreateType(data.TypeMethodTable, 0);
            if (ElementType == ClrTypeCode.Class && _type != null)
                ElementType = _type.ElementType;

            DebugOnlyLoadLazyValues();
        }

        [Conditional("DEBUG")]
        private void DebugOnlyLoadLazyValues()
        {
            InitData();
        }

        public override bool IsPublic
        {
            get
            {
                InitData();
                return (_attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Public;
            }
        }

        public override bool IsPrivate
        {
            get
            {
                InitData();
                return (_attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Private;
            }
        }

        public override bool IsInternal
        {
            get
            {
                InitData();
                return (_attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Assembly;
            }
        }

        public override bool IsProtected
        {
            get
            {
                InitData();
                return (_attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Family;
            }
        }

        private void InitData()
        {
            if (_attributes != FieldAttributes.ReservedMask)
                return;

            ReadData();
        }

        private string? ReadData()
        {
            if (!_helpers.ReadProperties(Parent, Token, out string? name, out _attributes, out ClrSigParser sigParser))
                return null;

            StringCaching options = Parent.Heap.Runtime.DataTarget?.CacheOptions.CacheFieldNames ?? StringCaching.Cache;
            if (name != null)
            {
                if (options == StringCaching.Intern)
                    name = string.Intern(name);

                if (options != StringCaching.None)
                    _name = name;
            }

            // We may have to try to construct a type from the sigParser if the method table was a bust in the constructor
            if (_type != null)
                return name;

            _type = GetTypeForFieldSig(_helpers.Factory, sigParser, Parent.Heap, Parent.Module);
            return name;
        }

        const int IMAGE_CEE_CS_CALLCONV_FIELD = 0x6;

        internal static ClrType? GetTypeForFieldSig(ITypeFactory factory, ClrSigParser sigParser, ClrHeap heap, ClrModule? module)
        {
            ClrType? result = null;
            bool res;
            int etype = 0;

            if (res = sigParser.GetCallingConvInfo(out int sigType))
                DebugOnly.Assert(sigType == IMAGE_CEE_CS_CALLCONV_FIELD);

            res = res && sigParser.SkipCustomModifiers();
            res = res && sigParser.GetElemType(out etype);

            // Generic instantiation
            if (etype == 0x15)
                res = res && sigParser.GetElemType(out etype);

            if (res)
            {
                ClrTypeCode type = (ClrTypeCode)etype;

                if (type == ClrTypeCode.Array)
                {
                    res = sigParser.PeekElemType(out etype);
                    res = res && sigParser.SkipExactlyOne();

                    int ranks = 0;
                    res = res && sigParser.GetData(out ranks);

                    if (res)
                    {
                        ClrType inner = factory.GetOrCreateBasicType((ClrTypeCode)etype);
                        result = factory.GetOrCreateArrayType(inner, ranks);
                    }
                }
                else if (type == ClrTypeCode.Cells)
                {
                    sigParser.PeekElemType(out etype);
                    type = (ClrTypeCode)etype;

                    if (type.IsObjectReference())
                    {
                        result = factory.GetOrCreateBasicType(ClrTypeCode.Cells);
                    }
                    else
                    {
                        ClrType inner = factory.GetOrCreateBasicType((ClrTypeCode)etype);
                        result = factory.GetOrCreateArrayType(inner, 1);
                    }
                }
                else if (type == ClrTypeCode.Ptr)
                {
                    // Only deal with single pointers for now and types that have already been constructed
                    sigParser.GetElemType(out etype);
                    type = (ClrTypeCode)etype;

                    sigParser.GetToken(out int token);

                    if (module != null)
                    {
                        ClrType? innerType = factory.GetOrCreateTypeFromToken(module, token);
                        if (innerType is null)
                            innerType = factory.GetOrCreateBasicType(type);

                        result = factory.GetOrCreatePointerType(innerType, 1);
                    }
                }
                else if (type == ClrTypeCode.Object || type == ClrTypeCode.Class)
                {
                    result = heap.ObjectType;
                }
                else
                {
                    // struct, then try to get the token
                    int token = 0;
                    if (etype == 0x11 || etype == 0x12)
                        sigParser.GetToken(out token);

                    if (token != 0 && module != null)
                        result = factory.GetOrCreateTypeFromToken(module, token);

                    if (result is null)
                        result = factory.GetOrCreateBasicType((ClrTypeCode)etype);
                }
            }

            if (result is null)
                return result;

            if (result.IsArray && result.ComponentType is null && result is ClrmdArrayType clrmdType)
            {
                etype = 0;

                if (res = sigParser.GetCallingConvInfo(out sigType))
                    DebugOnly.Assert(sigType == IMAGE_CEE_CS_CALLCONV_FIELD);

                res = res && sigParser.SkipCustomModifiers();
                res = res && sigParser.GetElemType(out etype);

                _ = res && sigParser.GetElemType(out etype);

                // Generic instantiation
                if (etype == 0x15)
                    sigParser.GetElemType(out etype);

                // If it's a class or struct, then try to get the token
                int token = 0;
                if (etype == 0x11 || etype == 0x12)
                    sigParser.GetToken(out token);

                if (token != 0 && module != null)
                    clrmdType.SetComponentType(factory.GetOrCreateTypeFromToken(module, token));
                else
                    clrmdType.SetComponentType(factory.GetOrCreateBasicType((ClrTypeCode)etype));
            }

            return result;
        }

        public override T Read<T>(ulong objRef, bool interior)
        {
            ulong address = GetAddress(objRef, interior);
            if (address == 0)
                return default;

            if (!_helpers.DataReader.Read(address, out T value))
                return default;

            return value;
        }

        public override ClrObject ReadObject(ulong objRef, bool interior)
        {
            ulong address = GetAddress(objRef, interior);
            if (address == 0 || !_helpers.DataReader.ReadPointer(address, out ulong obj) || obj == 0)
                return default;

            ulong mt = _helpers.DataReader.ReadPointer(obj);
            ClrType? type = _helpers.Factory.GetOrCreateType(mt, obj);
            if (type is null)
                return default;

            return new ClrObject(obj, type);
        }

        public override ClrValueType ReadStruct(ulong objRef, bool interior)
        {
            ulong address = GetAddress(objRef, interior);
            if (address == 0)
                return default;

            return new ClrValueType(address, Type, interior: true);
        }

        public override string? ReadString(ulong objRef, bool interior)
        {
            ClrObject obj = ReadObject(objRef, interior);
            if (obj.IsNull)
                return null;

            return obj.AsString();
        }

        public override ulong GetAddress(ulong objRef, bool interior = false)
        {
            if (interior)
                return objRef + (ulong)Offset;

            return objRef + (ulong)(Offset + IntPtr.Size);
        }

        internal static int GetSize(ClrType type, ClrTypeCode cet)
        {
            // todo:  What if we have a struct which is not fully constructed (null MT,
            //        null type) and need to get the size of the field?
            switch (cet)
            {
                case ClrTypeCode.Struct:
                    if (type is null)
                        return 1;

                    ClrField? last = null;
                    ImmutableArray<ClrInstanceField> fields = type.Fields;
                    foreach (ClrField field in fields)
                    {
                        if (last is null)
                            last = field;
                        else if (field.Offset > last.Offset)
                            last = field;
                        else if (field.Offset == last.Offset && field.Size > last.Size)
                            last = field;
                    }

                    if (last is null)
                        return 0;

                    return last.Offset + last.Size;

                case ClrTypeCode.Int8i:
                case ClrTypeCode.Int8u:
                case ClrTypeCode.Bool8:
                    return 1;

                case ClrTypeCode.Float32:
                case ClrTypeCode.Int32i:
                case ClrTypeCode.Int32u:
                    return 4;

                case ClrTypeCode.Float64: // double
                case ClrTypeCode.Int64i:
                case ClrTypeCode.Int64u:
                    return 8;

                case ClrTypeCode.String:
                case ClrTypeCode.Class:
                case ClrTypeCode.Array:
                case ClrTypeCode.Cells:
                case ClrTypeCode.Object:
                case ClrTypeCode.IntI: // native int
                case ClrTypeCode.IntU: // native unsigned int
                case ClrTypeCode.Ptr:
                case ClrTypeCode.PtrFx:
                    return IntPtr.Size;

                case ClrTypeCode.Int16u:
                case ClrTypeCode.Int16i:
                case ClrTypeCode.Char16: // u2
                    return 2;
            }

            throw new Exception("Unexpected element type.");
        }
    }
}