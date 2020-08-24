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
    public readonly struct CapturedCode
    {
        readonly LocatedCode Extracted;

        public readonly LocatedCode Parsed;

        public readonly OpUri OpUri;

        public readonly MethodInfo Method;

        public readonly ExtractTermCode TermCode;

        [MethodImpl(Inline)]
        public CapturedCode(OpIdentity id, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
        {
            Extracted = extracted;
            Parsed = parsed;
            Method = method;
            OpUri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
        }

        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Parsed.Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Parsed.Length;
        }

        public ref readonly byte this[int index]
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

        public OpIdentity Id
            => OpUri.OpId;

        public CapturedCode Zero
            => Empty;

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Parsed.Address;
        }


        [MethodImpl(Inline)]
        public bool Equals(CapturedCode src)
            => Parsed.Equals(src.Parsed);

        public string Format()
            => Parsed.Format();

        public override string ToString()
            => Format();

        public static CapturedCode Empty
            => new CapturedCode(
                id: OpIdentity.Empty,
                method: typeof(object).GetMethod(nameof(object.GetHashCode)),
                extracted: LocatedCode.Empty,
                parsed: LocatedCode.Empty,
                term: ExtractTermCode.None);

    }
}