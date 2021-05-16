//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class SRM
    {
        // #String heap handle
        public readonly partial struct StringHandle : IEquatable<StringHandle>
        {
            // bits:
            //     31: IsVirtual
            // 29..31: type (non-virtual: String, DotTerminatedString; virtual: VirtualString, WinRTPrefixedString)
            //  0..28: Heap offset or Virtual index
            readonly uint _value;

            [MethodImpl(Inline)]
            StringHandle(uint value)
            {
                Debug.Assert((value & StringHandleType.TypeMask) == StringHandleType.String ||
                            (value & StringHandleType.TypeMask) == StringHandleType.VirtualString ||
                            (value & StringHandleType.TypeMask) == StringHandleType.WinRTPrefixedString ||
                            (value & StringHandleType.TypeMask) == StringHandleType.DotTerminatedString);

                _value = value;
            }

            [MethodImpl(Inline)]
            public static StringHandle FromOffset(int heapOffset)
            {
                return new StringHandle(StringHandleType.String | (uint)heapOffset);
            }

            [MethodImpl(Inline)]
            public static StringHandle FromVirtualIndex(VirtualIndex virtualIndex)
            {
                Debug.Assert(virtualIndex < VirtualIndex.Count);
                return new StringHandle(StringHandleType.VirtualString | (uint)virtualIndex);
            }

            [MethodImpl(Inline)]
            public static StringHandle FromWriterVirtualIndex(int virtualIndex)
            {
                return new StringHandle(StringHandleType.VirtualString | (uint)virtualIndex);
            }

            [MethodImpl(Inline)]
            public StringHandle WithWinRTPrefix()
            {
                Debug.Assert(StringKind == StringKind.Plain);
                return new StringHandle(StringHandleType.WinRTPrefixedString | _value);
            }

            [MethodImpl(Inline)]
            public StringHandle WithDotTermination()
            {
                Debug.Assert(StringKind == StringKind.Plain);
                return new StringHandle(StringHandleType.DotTerminatedString | _value);
            }

            [MethodImpl(Inline)]
            public StringHandle SuffixRaw(int prefixByteLength)
            {
                Debug.Assert(StringKind == StringKind.Plain);
                Debug.Assert(prefixByteLength >= 0);
                return new StringHandle(StringHandleType.String | (_value + (uint)prefixByteLength));
            }

            [MethodImpl(Inline)]
            public static implicit operator Handle(StringHandle handle)
            {
                // VTTx xxxx xxxx xxxx  xxxx xxxx xxxx xxxx -> V111 10TT
                return new Handle(
                    (byte)((handle._value & HeapHandleType.VirtualBit) >> 24 | HandleType.String | (handle._value & StringHandleType.NonVirtualTypeMask) >> HeapHandleType.OffsetBitCount),
                    (int)(handle._value & HeapHandleType.OffsetMask));
            }

            [MethodImpl(Inline)]
            public static explicit operator StringHandle(Handle handle)
            {
                if ((handle.VType & ~(HandleType.VirtualBit | HandleType.NonVirtualStringTypeMask)) != HandleType.String)
                    return default;

                // V111 10TT -> VTTx xxxx xxxx xxxx  xxxx xxxx xxxx xxxx
                return new StringHandle(
                    (handle.VType & HandleType.VirtualBit) << 24 |
                    (handle.VType & HandleType.NonVirtualStringTypeMask) << HeapHandleType.OffsetBitCount |
                    (uint)handle.Offset);
            }

            public uint RawValue => _value;

            public bool IsVirtual
            {
                [MethodImpl(Inline)]
                get { return (_value & HeapHandleType.VirtualBit) != 0; }
            }

            public bool IsNil
            {
                [MethodImpl(Inline)]
                get
                {
                    // virtual strings are never nil, so include virtual bit
                    return (_value & (HeapHandleType.VirtualBit | HeapHandleType.OffsetMask)) == 0;
                }
            }

            [MethodImpl(Inline)]
            public int GetHeapOffset()
            {
                // WinRT prefixed strings are virtual, the value is a heap offset
                Debug.Assert(!IsVirtual || StringKind == StringKind.WinRTPrefixed);
                return (int)(_value & HeapHandleType.OffsetMask);
            }

            [MethodImpl(Inline)]
            public VirtualIndex GetVirtualIndex()
            {
                Debug.Assert(IsVirtual && StringKind != StringKind.WinRTPrefixed);
                return (VirtualIndex)(_value & HeapHandleType.OffsetMask);
            }

            [MethodImpl(Inline)]
            public int GetWriterVirtualIndex()
            {
                Debug.Assert(IsNil || IsVirtual && StringKind == StringKind.Virtual);
                return (int)(_value & HeapHandleType.OffsetMask);
            }

            public StringKind StringKind
            {
                [MethodImpl(Inline)]
                get { return (StringKind)(_value >> HeapHandleType.OffsetBitCount); }
            }

            public override bool Equals(object? obj)
            {
                return obj is StringHandle && Equals((StringHandle)obj);
            }

            [MethodImpl(Inline)]
            public bool Equals(StringHandle other)
            {
                return _value == other._value;
            }

            [MethodImpl(Inline)]
            public override int GetHashCode()
            {
                return unchecked((int)_value);
            }

            [MethodImpl(Inline)]
            public static bool operator ==(StringHandle left, StringHandle right)
            {
                return left.Equals(right);
            }

            [MethodImpl(Inline)]
            public static bool operator !=(StringHandle left, StringHandle right)
            {
                return !left.Equals(right);
            }
        }
    }
}