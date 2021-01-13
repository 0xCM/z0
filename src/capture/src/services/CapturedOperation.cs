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

    readonly struct CapturedOperation
    {
        public OpIdentity Id {get;}

        public CaptureOutcome Outcome {get;}

        public CapturedCodeBlock Encoded {get;}

        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Output;
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
        public CapturedOperation(OpIdentity id, CaptureOutcome outcome, CapturedCodeBlock code)
        {
            Id = id;
            Outcome = outcome;
            Encoded = code;
        }
    }
}