//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    [ApiDataType]
    public struct X86ApiCapture : ICapturedCode<X86ApiCapture,X86Code>
    {
        readonly X86Code Extracted;

        public X86Code Parsed;

        public OpUri OpUri;

        public MethodInfo Method;

        public ExtractTermCode TermCode;

        public CilCode Cil;

        [MethodImpl(Inline)]
        public X86ApiCapture(OpIdentity id, MethodInfo method, X86Code extracted, X86Code parsed, ExtractTermCode term)
        {
            Extracted = extracted;
            Parsed = parsed;
            Method = method;
            z.insist(extracted.Address, parsed.Address);
            OpUri = OpUri.hex(ApiQuery.uri(method.DeclaringType), method.Name, id);
            TermCode = term;
            Cil = FunctionDynamic.cil(method);
        }

        public ReadOnlySpan<byte> InputData
        {
            [MethodImpl(Inline)]
            get => Extracted.Encoded;
        }

        public ReadOnlySpan<byte> OutputData
        {
            [MethodImpl(Inline)]
            get => Parsed.Encoded;
        }

        public ByteSize InputSize
        {
            [MethodImpl(Inline)]
            get => Extracted.Length;
        }

        public ByteSize OutputSize
        {
            [MethodImpl(Inline)]
            get => Parsed.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Parsed.Length;
        }

        public ref readonly byte this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Parsed[index];
        }

        public ref readonly byte this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Parsed[index];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Parsed.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Parsed.IsNonEmpty;
        }

        public X86ApiCode HostedBits
        {
             [MethodImpl(Inline)]
             get => new X86ApiCode(OpUri, Parsed);
        }

        public OpIdentity MemberId
        {
            [MethodImpl(Inline)]
            get => OpUri.OpId;
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Extracted.Address;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => BaseAddress.Hash;
        }

        public ulong Hash64
        {
            [MethodImpl(Inline)]
            get => BaseAddress;
        }

        [MethodImpl(Inline)]
        public bool Identical(in X86ApiCapture src)
            => Parsed.Equals(src.Parsed);

        [MethodImpl(Inline)]
        public int Compare(in X86ApiCapture src)
            => BaseAddress.CompareTo(src.BaseAddress);

        [MethodImpl(Inline)]
        public string Format()
            => Parsed.Format();

        [Ignore]
        bool INullity.IsEmpty
        {
            [MethodImpl(Inline)]
            get => Parsed.IsEmpty;
        }

        [Ignore]
        bool INullity.IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Parsed.IsNonEmpty;
        }

        [Ignore]
        bool IEquatable<X86ApiCapture>.Equals(X86ApiCapture src)
            => Identical(src);

        [Ignore]
        int IComparable<X86ApiCapture>.CompareTo(X86ApiCapture src)
            => Compare(src);

        [Ignore]
        string ITextual.Format()
            => Format();

        [Ignore]
        public X86Code Encoded
            => Parsed;

        [Ignore]
        BinaryCode IEncoded.Encoded
            => Encoded;

        [Ignore]
        int IMeasured.Length
            => Parsed.Length;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is X86ApiCapture x && Identical(x);

        public static X86ApiCapture Empty
            => default;
    }
}