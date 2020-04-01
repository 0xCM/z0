//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    

    public interface IAsmEmissionToken :  IEquatable<AsmEmissionToken>, IComparable<AsmEmissionToken>, IFormattable<AsmEmissionToken>
    {
        
    }

    /// <summary>
    /// Upon success, provides evidence that an operation was extracted, decoded and emitted; upon failure, communicates in the
    /// termination code the basic reason why the capture processes failed
    /// </summary>
    public readonly struct AsmEmissionToken : IAsmEmissionToken
    {
        /// <summary>
        /// Defines a uri relataive to the global asm data root
        /// </summary>
        public readonly OpUri Uri;

        /// <summary>
        /// Specifies the reason for capture termination
        /// </summary>
        public readonly ExtractTermCode TermCode;

        /// <summary>
        /// The memory range from which the defining code was extracted
        /// </summary>
        public readonly MemoryRange AddressRange;

        [MethodImpl(Inline)]
        public static AsmEmissionToken Define(OpUri uri, MemoryRange src, ExtractTermCode term)        
            => new AsmEmissionToken(uri,src,term);

        [MethodImpl(Inline)]
        public static bool operator==(AsmEmissionToken a, AsmEmissionToken b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(AsmEmissionToken a, AsmEmissionToken b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        AsmEmissionToken(OpUri uri, MemoryRange src, ExtractTermCode term)
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
        public bool Equals(AsmEmissionToken src)
            => TermCode == src.TermCode
            && Uri == src.Uri 
            && AddressRange == src.AddressRange;
        
        public override bool Equals(object src)
            => src is AsmEmissionToken d && Equals(d);

        [MethodImpl(Inline)]
        public int CompareTo(AsmEmissionToken rhs)
            => this.Uri.CompareTo(rhs.Uri);
    }
}