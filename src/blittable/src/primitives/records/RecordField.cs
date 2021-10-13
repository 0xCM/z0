//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct BitFlow
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public readonly struct RecordField
        {
            /// <summary>
            /// The field name
            /// </summary>
            public text15 Name {get;}

            /// <summary>
            /// The 0-based, record-relative field position/index
            /// </summary>
            public byte FieldIndex {get;}

            /// <summary>
            /// The position of the first bit in the field
            /// </summary>
            public uint FieldOffset {get;}

            /// <summary>
            /// The number of physical bits consumed by the field
            /// </summary>
            public byte StorageWidth {get;}

            /// <summary>
            /// The number of semantic bits required by the field
            /// </summary>
            public byte ContentWidth {get;}

            [MethodImpl(Inline)]
            public RecordField(text15 name, byte index, uint offset, byte wStore, byte wContent)
            {
                Name = name;
                FieldIndex = index;
                FieldOffset = offset;
                StorageWidth = wStore;
                ContentWidth = wContent;
            }

            /// <summary>
            /// The position of the last bit in the field
            /// </summary>
            public uint LastBit
            {
                [MethodImpl(Inline)]
                get => FieldOffset + StorageWidth;
            }
        }
    }
}