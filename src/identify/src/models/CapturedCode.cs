//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;

    /// <summary>
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    public readonly struct CapturedCode : 
        IUriCode<CapturedCode, LocatedCode>, 
        ICapturedCode<CapturedCode,LocatedCode>,
        IMemberCode<CapturedCode,LocatedCode>
    {        
        public static CapturedCode Empty => default;

        public static MemberParseRecord CreateParseRecord(CapturedCode src)
            => MemberParseRecord.Define
                (
                    Sequence: 0,
                    SourceSequence: 0,
                    Address: src.Address,
                    Length: src.Length,
                    TermCode: src.TermCode,
                    Uri: src.Uri,
                    OpSig : src.Method.Signature().Format(),
                    Data : src.Encoded
                );

        readonly LocatedCode Extracted;

        public LocatedCode Encoded {get;}

        public OpUri Uri {get;}

        public MethodInfo Method {get;}

        public ExtractTermCode TermCode {get;}

        public OpIdentity Id => Uri.OpId;
        
        public HostedBits HostedBits  { [MethodImpl(Inline)] get => new HostedBits(Uri, Encoded); }

        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        public ref readonly byte Head { [MethodImpl(Inline)] get => ref Encoded.Head;}

        public ref readonly byte this[int index] { [MethodImpl(Inline)] get => ref Encoded[index]; }

        public MemoryAddress Address { [MethodImpl(Inline)] get => Encoded.Address; }

        public MemoryRange MemorySegment { [MethodImpl(Inline)] get => Encoded.MemorySegment; }

        [MethodImpl(Inline)]
        public static CapturedCode Define(OpIdentity id, Delegate src, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
            => new CapturedCode(id, src, method, extracted, parsed, term);

        [MethodImpl(Inline)]
        internal CapturedCode(OpIdentity id, Delegate src, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
        {
            Extracted = extracted; 
            Encoded = parsed;
            Method = method;
            Uri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
        }

        public bool Equals(CapturedCode src)
            => Encoded.Equals(src.Encoded);        
    }
}