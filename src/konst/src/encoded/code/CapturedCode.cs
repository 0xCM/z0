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
    public struct CapturedCode : ICapturedCode<CapturedCode,LocatedCode>
    {
        readonly LocatedCode Extracted;

        public LocatedCode Parsed;

        public OpUri OpUri;

        public MethodInfo Method;

        public ExtractTermCode TermCode;

        public CilCode Cil;

        [MethodImpl(Inline)]
        public CapturedCode(OpIdentity id, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
        {
            Extracted = extracted;
            Parsed = parsed;
            Method = method;
            z.insist(extracted.Address, parsed.Address);
            OpUri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
            Cil = FunctionCil.extract(method);
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

        public MemberCode HostedBits
        {
             [MethodImpl(Inline)]
             get => new MemberCode(OpUri, Parsed);
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
        public bool Identical(in CapturedCode src)
            => Parsed.Equals(src.Parsed);

        [MethodImpl(Inline)]
        public int Compare(in CapturedCode src)
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
        bool IEquatable<CapturedCode>.Equals(CapturedCode src)
            => Identical(src);

        [Ignore]
        int IComparable<CapturedCode>.CompareTo(CapturedCode src)
            => Compare(src);

        [Ignore]
        string ITextual.Format()
            => Format();

        [Ignore]
        public LocatedCode Encoded
            => Parsed;

        [Ignore]
        int IMeasured.Length
            => Parsed.Length;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is CapturedCode x && Identical(x);

        public static CapturedCode Empty
            => default;
    }
}