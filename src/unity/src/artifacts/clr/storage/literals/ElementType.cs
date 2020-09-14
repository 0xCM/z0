//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    partial struct ClrStorage
    {
        public enum ElementType : byte
        {
            End = 0x00,

            Void = 0x01,

            Boolean = 0x02,

            Char = 0x03,

            Int8 = 0x04,

            UInt8 = 0x05,

            Int16 = 0x06,

            UInt16 = 0x07,

            Int32 = 0x08,

            UInt32 = 0x09,

            Int64 = 0x0a,

            UInt64 = 0x0b,

            Single = 0x0c,

            Double = 0x0d,

            String = 0x0e,

            Pointer = 0x0f,

            ByReference = 0x10,

            ValueType = 0x11,

            Class = 0x12,

            GenericTypeParameter = 0x13,

            Array = 0x14,

            GenericTypeInstance = 0x15,

            TypedReference = 0x16,

            IntPtr = 0x18,

            UIntPtr = 0x19,

            FunctionPointer = 0x1b,

            Object = 0x1c,

            SzArray = 0x1d,

            GenericMethodParameter = 0x1e,

            RequiredModifier = 0x1f,

            OptionalModifier = 0x20,

            Internal = 0x21,

            Max = 0x22,

            Modifier = 0x40,

            Sentinel = 0x41,

            Pinned = 0x45,

            SingleHFA = 0x54, //  What is this?

            DoubleHFA = 0x55, //  What is this?
        }
    }
}