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
    public readonly struct CaptureToken : ICaptureToken, IFormattable<CaptureToken>
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
        public static CaptureToken Define(OpUri uri, MemoryRange src, CaptureTermCode term)        
            => new CaptureToken(uri,src,term);

        [MethodImpl(Inline)]
        public static bool operator==(CaptureToken a, CaptureToken b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(CaptureToken a, CaptureToken b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        CaptureToken(OpUri uri, MemoryRange src, CaptureTermCode term)
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
        public bool Equals(CaptureToken src)
            => TermCode == src.TermCode
            && Uri == src.Uri 
            && AddressRange == src.AddressRange;
        
        public override bool Equals(object src)
            => src is CaptureToken d && Equals(d);

        [MethodImpl(Inline)]
        public int CompareTo(CaptureToken rhs)
            => this.Uri.CompareTo(rhs.Uri);
    }
}