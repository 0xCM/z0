//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    [ApiComplete]
    public struct ApiCaptureBlock
    {
        readonly CodeBlock Extracted;

        public CodeBlock Parsed;

        public OpUri OpUri;

        public MethodInfo Method;

        public ExtractTermCode TermCode;

        public CilMethod Cil;

        public CliSig CliSig;

        public ApiArtifactKey ArtifactKey
            => Method;

        public ApiCaptureBlock(OpIdentity id, MethodInfo method, CodeBlock extracted, CodeBlock parsed, ExtractTermCode term)
        {
            Extracted = extracted;
            Parsed = parsed;
            Method = method;
            root.require(extracted.BaseAddress == parsed.BaseAddress, () => $"Parsed address {parsed.BaseAddress} does not match the extracted base address {extracted.BaseAddress}");
            OpUri = OpUri.hex(method.DeclaringType.HostUri(), method.Name, id);
            TermCode = term;
            Cil = ClrDynamic.cil(parsed.BaseAddress, OpUri, method);
            CliSig = CliSigs.resolve(method);
        }

        public ReadOnlySpan<byte> InputData
        {
            [MethodImpl(Inline)]
            get => Extracted.Code;
        }

        public ReadOnlySpan<byte> OutputData
        {
            [MethodImpl(Inline)]
            get => Parsed.Code;
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

        public ApiCodeBlock CodeBlock
        {
             [MethodImpl(Inline)]
             get => new ApiCodeBlock(BaseAddress, OpUri, Parsed);
        }

        public OpIdentity MemberId
        {
            [MethodImpl(Inline)]
            get => OpUri.OpId;
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Extracted.BaseAddress;
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
        public bool Identical(in ApiCaptureBlock src)
            => Parsed.Equals(src.Parsed);

        [MethodImpl(Inline)]
        public int Compare(in ApiCaptureBlock src)
            => BaseAddress.CompareTo(src.BaseAddress);

        [MethodImpl(Inline)]
        public string Format()
            => Parsed.Format();


        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is ApiCaptureBlock x && Identical(x);

        public static ApiCaptureBlock Empty
            => default;
    }
}