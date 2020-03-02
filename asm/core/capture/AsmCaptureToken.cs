//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    /// <summary>
    /// Describes the capture and subsequent emission of single routine, such
    /// as a member function or a delegate
    /// </summary>
    public readonly struct AsmCaptureToken : IEquatable<AsmCaptureToken>, IComparable<AsmCaptureToken>, IFormattable<AsmCaptureToken>
    {
        /// <summary>
        /// Defines a uri relataive to the global asm data root
        /// </summary>
        public readonly OpUri Uri;

        /// <summary>
        /// Specifies the reason for capture termination
        /// </summary>
        public readonly CaptureTermCode TermCode;

        /// <summary>
        /// The memory range from which the defining code was extracted
        /// </summary>
        public readonly MemoryRange AddressRange;

        [MethodImpl(Inline)]
        public static AsmCaptureToken Define(OpUri uri, MemoryRange src, CaptureTermCode term)        
            => new AsmCaptureToken(uri,src,term);

        [MethodImpl(Inline)]
        public static bool operator==(AsmCaptureToken a, AsmCaptureToken b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(AsmCaptureToken a, AsmCaptureToken b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        AsmCaptureToken(OpUri uri, MemoryRange src, CaptureTermCode term)
        {
            this.Uri = uri;
            this.AddressRange = src;
            this.TermCode = term;
        }

        public string Format()
            => text.concat(Uri.ToString(), AddressRange.Format());

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => HashCode.Combine(Uri,AddressRange);

        [MethodImpl(Inline)]
        public bool Equals(AsmCaptureToken src)
            => TermCode == src.TermCode
            && Uri == src.Uri 
            && AddressRange == src.AddressRange;
        
        public override bool Equals(object src)
            => src is AsmCaptureToken d && Equals(d);

        [MethodImpl(Inline)]
        public int CompareTo(AsmCaptureToken rhs)
            => this.Uri.CompareTo(rhs.Uri);
    }
}