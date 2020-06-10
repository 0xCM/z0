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
        IReflectedCode<CapturedCode,LocatedCode>
    {        
        readonly LocatedCode Extracted;

        public LocatedCode Encoded {get;}

        public OpUri OpUri {get;}

        public MethodInfo Method {get;}

        public ExtractTermCode TermCode {get;}

        public static CapturedCode Empty 
            => Define(
                id: OpIdentity.Empty,
                src: new Func<int>(() => 0), 
                method: typeof(object).GetMethod(nameof(object.GetHashCode)), 
                extracted: LocatedCode.Empty, 
                parsed: LocatedCode.Empty, 
                term: ExtractTermCode.None);

        [MethodImpl(Inline)]
        public static CapturedCode Define(OpIdentity id, Delegate src, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
            => new CapturedCode(id, src, method, extracted, parsed, term);

        [MethodImpl(Inline)]
        internal CapturedCode(OpIdentity id, Delegate src, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
        {
            Extracted = extracted; 
            Encoded = parsed;
            Method = method;
            OpUri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
        }

        public OpIdentity Id
            => OpUri.OpId;

        public UriCode HostedBits  
        {
             [MethodImpl(Inline)] 
             get => new UriCode(OpUri, Encoded); 
        }

        /// <summary>
        /// The encoded content presented as a span
        /// </summary>
        public ReadOnlySpan<byte> Bytes 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Bytes; 
        }

        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Length; 
        }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.IsEmpty; 
        }

        public bool IsNonEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.IsNonEmpty; 
        }

        public CapturedCode Zero 
            => Empty;

        public ref readonly byte Head 
        { 
            [MethodImpl(Inline)]
            get => ref Encoded.Head;
        }
        
        public ref readonly byte this[int index] 
        { 
            [MethodImpl(Inline)] 
            get => ref Encoded[index]; 
        }

        public MemoryAddress Address 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Address; 
        }

        public MemoryRange MemorySegment 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.MemorySegment; 
        }

        [MethodImpl(Inline)] 
        public bool Equals(CapturedCode src)
            => Encoded.Equals(src.Encoded);        
        
        public string Format()
            => Encoded.Format();
        
        public override string ToString()
            => Format();
    }
}