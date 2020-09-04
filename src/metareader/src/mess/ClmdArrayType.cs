//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    using static ClrDataModel;

    public sealed class ClrmdArrayType : ClrmdType
    {
        private int _baseArrayOffset;

        private ClrType? _componentType;

        public override int ComponentSize { get; }

        public override ClrType? ComponentType => _componentType;

        public ClrmdArrayType(ClrHeap heap, ClrType? baseType, ClrModule? module, ITypeData data)
            : base(heap, baseType, module, data)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            ComponentSize = data.ComponentSize;
            ulong componentMT = data.ComponentMethodTable;
            if (componentMT != 0)
                _componentType = Helpers.Factory.GetOrCreateType(heap, componentMT, 0);
        }

        public void SetComponentType(ClrType? type) => _componentType = type;

        public override ulong GetArrayElementAddress(ulong objRef, int index)
        {
            // todo: remove?
            if (_baseArrayOffset == 0)
            {
                ClrType? componentType = ComponentType;

                IObjectData data = Helpers.GetObjectData(objRef);
                if (data != null)
                {
                    _baseArrayOffset = (int)(data.DataPointer - objRef);
                    DebugOnly.Assert(_baseArrayOffset >= 0);
                }
                else if (componentType != null)
                {
                    if (!componentType.IsObjectReference)
                        _baseArrayOffset = IntPtr.Size * 2;
                }
                else
                {
                    return 0;
                }
            }

            return objRef + (ulong)(_baseArrayOffset + index * ComponentSize);
        }

        public override object? GetArrayElementValue(ulong objRef, int index)
        {
            ulong address = GetArrayElementAddress(objRef, index);
            if (address == 0)
                return null;

            ClrType? componentType = ComponentType;
            ClrTypeCode cet;
            if (componentType != null)
            {
                cet = componentType.ElementType;
            }
            else
            {
                // Slow path, we need to get the element type of the array.
                IObjectData data = Helpers.GetObjectData(objRef);
                if (data is null)
                    return null;

                cet = data.ElementType;
            }

            if (cet == ClrTypeCode.None)
                return null;

            if (cet == ClrTypeCode.String)
                address = DataReader.ReadPointer(address);

            return ValueReader.GetValueAtAddress(Heap, DataReader, cet, address);
        }

        public override T[]? GetArrayElementValues<T>(ulong objRef, int count)
        {
            ulong address = GetArrayElementAddress(objRef, 0);
            ClrType? componentType = ComponentType;
            ClrTypeCode cet;
            if (componentType != null)
            {
                cet = componentType.ElementType;
            }
            else
            {
                // Slow path, we need to get the element type of the array.
                IObjectData data = Helpers.GetObjectData(objRef);
                if (data is null)
                    return null;

                cet = data.ElementType;
            }

            if (cet == ClrTypeCode.None)
                return null;

            if (address == 0)
                return null;

            return ValueReader.GetValuesFromAddress<T>(DataReader, address, count);
        }
    }
}