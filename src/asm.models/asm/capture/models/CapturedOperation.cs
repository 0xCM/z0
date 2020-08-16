//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public readonly struct CapturedOperation : IIdentified<OpIdentity>
    {        
        public OpIdentity Id {get;}

        public readonly CaptureOutcome Outcome;

        public readonly ParsedEncoding Encoded;

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
        public CapturedOperation(OpIdentity id,  CaptureOutcome outcome, ParsedEncoding code)
        {            
            Id = id;
            Outcome = outcome;
            Encoded = code;
        }        
    }
}