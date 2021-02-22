//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Encoded x86 bytes extracted from a memory source with a known (nonzero) location
    /// </summary>
    public readonly struct ExtractBlock
    {
        /// <summary>
        /// The head of the memory location from which the data originated
        /// </summary>
        public MemoryAddress BaseAddress {get;}

        /// <summary>
        /// The encoded content
        /// </summary>
        public BinaryCode Code {get;}

        [MethodImpl(Inline)]
        public ExtractBlock(MemoryAddress src, byte[] data)
        {
            BaseAddress = root.require(src, x => x.IsNonEmpty);
            Code = new BinaryCode(root.require(data));
        }

        [MethodImpl(Inline)]
        public ExtractBlock(MemoryAddress src, BinaryCode code)
        {
            BaseAddress = root.require(src, x => x.IsNonEmpty);
            Code = code;
        }

        [MethodImpl(Inline)]
        ExtractBlock(ulong zero)
        {
            BaseAddress = zero;
            Code = Array.Empty<byte>();
        }

        public MemoryRange MemorySegment
        {
            [MethodImpl(Inline)]
            get => (BaseAddress, BaseAddress + (MemoryAddress)Code.Length);
        }

        public byte[] Storage
        {
            [MethodImpl(Inline)]
            get => Code.Storage;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Code.View;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Code.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Code.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Code.IsNonEmpty;
        }

        public ref readonly byte this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Code[index];
        }

        public ref readonly byte this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Code[index];
        }

        [MethodImpl(Inline)]
        public bool Equals(ExtractBlock src)
            => Code.Equals(src.Code);

        public string Format()
            => Code.Format();


        public override int GetHashCode()
            => Code.GetHashCode();

        public override bool Equals(object src)
            => src is ExtractBlock x && Equals(x);


        [MethodImpl(Inline)]
        public static implicit operator byte[](ExtractBlock src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(ExtractBlock src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(ExtractBlock src)
            => src.View;

        [MethodImpl(Inline)]
        public static bool operator==(ExtractBlock a, ExtractBlock b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ExtractBlock a, ExtractBlock b)
            => !a.Equals(b);

        public static ExtractBlock Empty
            => new ExtractBlock(0);
    }
}