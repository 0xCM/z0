//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    
    using static Konst;

    public readonly struct FieldRef : INullity
    {                    
        public MemRef Reference {get;}

        public FieldInfo Metadata {get;}

        [MethodImpl(Inline)]
        public static implicit operator FieldRef((FieldInfo field, MemRef location) src)
            => new FieldRef(src.field, src.location);

        [MethodImpl(Inline)]
        public FieldRef(FieldInfo field, in MemRef location)
        {
            Metadata = field;
            Reference = location;        
        }

        public MemoryRange Segment
        {
            [MethodImpl(Inline)]
            get => Reference.Segment;
        }
        
        public string FieldName
        {
            [MethodImpl(Inline)]
            get => Metadata.Name;
        }

        public object ReflectedValue
        {
            [MethodImpl(Inline)]
            get => Metadata.GetRawConstantValue();
        }
        
        public Type DeclaringType
        {
            [MethodImpl(Inline)]
            get => Metadata.DeclaringType;
        }

        /// <summary>
        /// Specifies the size, in bytes of the fields data
        /// </summary>
        public uint DataSize
        {
            [MethodImpl(Inline)]
            get => Reference.DataSize;
        }

        /// <summary>
        /// Specifies the size, in bits of the fields data
        /// </summary>
        public BitSize Width
        {
            [MethodImpl(Inline)]
            get => Reference.DataSize;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Reference.Address;
        }

        /// <summary>
        /// Presents the leading source cell as an int8 reference
        /// </summary>
        public ref readonly sbyte I8
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<sbyte>();
        }

        /// <summary>
        /// Presents the leading source cell as a uint8 reference
        /// </summary>
        public ref readonly byte U8
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<byte>();
        }

        /// <summary>
        /// Presents the leading source cell as a uint16 reference
        /// </summary>
        public ref readonly ushort U16
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<ushort>();
        }

        /// <summary>
        /// Presents the leading source cell as a uint32 reference
        /// </summary>
        public ref readonly int I32
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<int>();
        }

        /// <summary>
        /// Presents the leading source cell as a uint32 reference
        /// </summary>
        public ref readonly uint U32
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<uint>();
        }

        /// <summary>
        /// Presents the leading source cell as na int64 reference
        /// </summary>
        public ref readonly long I64
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<long>();
        }

        /// <summary>
        /// Presents the leading source cell as a uint64 reference
        /// </summary>
        public ref readonly ulong U64
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<ulong>();
        }

        /// <summary>
        /// Presents the leading source cell as a float32 reference
        /// </summary>
        public ref readonly float F32
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<float>();
        }

        /// <summary>
        /// Presents the leading source cell as a float128 reference
        /// </summary>
        public ref readonly double F64
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<double>();
        }

        /// <summary>
        /// Presents the leading source cell as a float128 reference
        /// </summary>
        public ref readonly decimal F128
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<decimal>();
        }

        /// <summary>
        /// Presents the leading source cell as a bool reference
        /// </summary>
        public ref readonly bool U1
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<bool>();
        }

        /// <summary>
        /// Presents the leading source cell as a character reference
        /// </summary>
        public ref readonly char C16
        {
            [MethodImpl(Inline)]
            get => ref Address.Ref<char>();
        }

        [MethodImpl(Inline)]
        public StringRef ToStringRef()
            => new StringRef(Reference);
            
        /// <summary>
        /// Presents the leading source cell as a reference to an enum value of parametric kind
        /// </summary>
        [MethodImpl(Inline)]
        public ref readonly E Enum<E>()     
            where E : unmanaged, Enum                
                => ref Address.Ref<E>();

        /// <summary>
        /// Presents the leading source cell as a reference to a structural value of pararametric kind
        /// </summary>
        [MethodImpl(Inline)]
        public ref readonly T Struct<T>()     
            where T : struct
                => ref Address.Ref<T>();

        /// <summary>
        /// Specifies the field's primal kind, if applicable; otherwise, none
        /// </summary>
        public PrimalKindId KindId
        {
            [MethodImpl(Inline)]
            get => (PrimalKindId)Type.GetTypeCode(Metadata.FieldType);
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Reference.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Reference.IsEmpty;
        }

        public static FieldRef Empty 
            => new FieldRef(null, MemRef.Empty);
    }
}