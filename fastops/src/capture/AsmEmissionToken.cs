//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Describes the capture and subsequent emission of single routine, such
    /// as a member function or a delegate
    /// </summary>
    public readonly struct AsmEmissionToken : IAsmEmissionToken
    {
        /// <summary>
        /// Specifies the reason for capture termination
        /// </summary>
        public readonly CaptureTermCode TermCode;

        /// <summary>
        /// Defines a uri relataive to the global asm data root
        /// </summary>
        public readonly OpUri Uri;

        /// <summary>
        /// The memory range from which the defining code was extracted
        /// </summary>
        public readonly MemoryRange Origin;

        [MethodImpl(Inline)]
        public static AsmEmissionToken Define(CaptureOutcome cc, OpUri uri)        
            => new AsmEmissionToken(cc, uri);

        [MethodImpl(Inline)]
        public static bool operator==(AsmEmissionToken a, AsmEmissionToken b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(AsmEmissionToken a, AsmEmissionToken b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        AsmEmissionToken(CaptureOutcome cc, OpUri uri)
        {
            this.TermCode = cc.TermCode;
            this.Uri = uri;
            this.Origin = cc.Range;
        }

        public string Format()
            => concat(Uri.ToString(), Origin.Format());

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => HashCode.Combine(Uri,Origin);

        [MethodImpl(Inline)]
        public bool Equals(AsmEmissionToken src)
            => TermCode == src.TermCode
            && Uri == src.Uri 
            && Origin == src.Origin;
        
        public override bool Equals(object src)
            => src is AsmEmissionToken d && Equals(d);

        [MethodImpl(Inline)]
        public int CompareTo(AsmEmissionToken rhs)
            => this.Uri.CompareTo(rhs.Uri);
    }
}