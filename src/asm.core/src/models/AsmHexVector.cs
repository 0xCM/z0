//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;
    using static memory;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct AsmHexVector
    {
        readonly Index<AsmByte> Data;

        readonly LocalOffsetVector _Offsets;

        [MethodImpl(Inline)]
        public AsmHexVector(Index<AsmByte> data, Index<Address16> offsets)
        {
            Data = data;
            _Offsets = offsets;
        }

        public ushort HexSize
        {
            [MethodImpl(Inline)]
            get => (ushort)Data.Count;
        }

        public ReadOnlySpan<Address16> Offsets
        {
            [MethodImpl(Inline)]
            get => _Offsets.Components;
        }

        public uint StorageSize
        {
            [MethodImpl(Inline)]
            get => 2 + (uint)HexSize * 2*(uint)_Offsets.Length;
        }

        public ReadOnlySpan<AsmByte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ReadOnlySpan<AsmByte> Segment(ushort index)
        {
            if(index >= _Offsets.Length)
                return ReadOnlySpan<AsmByte>.Empty;

            var start = _Offsets[index];
            if(index < _Offsets.Length - 1)
            {
                var size = _Offsets[(ushort)(index + 1)] - start;
                return slice(Bytes,start, size);
            }
            else
                return slice(Bytes,start);
        }
    }
}