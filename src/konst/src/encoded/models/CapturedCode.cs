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
    public readonly struct CapturedCode : ICapturedCode<CapturedCode,LocatedCode>
    {        
        readonly LocatedCode Extracted;

        public LocatedCode Encoded {get;}

        public OpUri OpUri {get;}

        public MethodInfo Method {get;}

        public ExtractTermCode TermCode {get;}

        public byte[] Data 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Data;
        }
        
        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Length; 
        }

        public ref readonly byte this[int index] 
        { 
            [MethodImpl(Inline)] 
            get => ref Encoded[index]; 
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

        [MethodImpl(Inline)]
        public CapturedCode(OpIdentity id, Delegate src, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
        {
            Extracted = extracted; 
            Encoded = parsed;
            Method = method;
            OpUri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
        }

        public MemberCode HostedBits  
        {
             [MethodImpl(Inline)] 
             get => new MemberCode(OpUri, Encoded); 
        }

        public OpIdentity Id
            => OpUri.OpId;

        public CapturedCode Zero 
            => Empty;

        public MemoryAddress Address 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Address; 
        }


        [MethodImpl(Inline)] 
        public bool Equals(CapturedCode src)
            => Encoded.Equals(src.Encoded);        
        
        public string Format()
            => Encoded.Format();
        
        public override string ToString()
            => Format();

        public static CapturedCode Empty 
            => new CapturedCode(
                id: OpIdentity.Empty,
                src: new Func<int>(() => 0), 
                method: typeof(object).GetMethod(nameof(object.GetHashCode)), 
                extracted: LocatedCode.Empty, 
                parsed: LocatedCode.Empty, 
                term: ExtractTermCode.None);
    }
}