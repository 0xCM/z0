//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;


    /// <summary>
    /// Encapsulates equivalent ways to represent a byte
    /// </summary>
    public readonly struct ByteInfo
    {        
        [MethodImpl(Inline)]
        public ByteInfo(byte Subject, byte[] BitSeq, char[] BitChars, string Text)
        {
            this.Subject = Subject;
            this.BitSeq = BitSeq;
            this.BitChars = BitChars;
            this.BitText = Text;
        }
        
        /// <summary>
        /// The represented byte
        /// </summary>
        public readonly byte Subject;

        /// <summary>
        /// The unpacked byte value where a byte b with digits b7,...,b0 is represented 
        /// with a sequence of 8 corresponding bytes such that b = b7*2^7 + ... + b0*2^0
        /// </summary>
        public readonly byte[] BitSeq;

        /// <summary>
        /// The 8 digits corresponding to the byte value
        /// </summary>
        public readonly char[] BitChars;

        /// <summary>
        /// The string logically equivalent to the concatentation of the characters
        /// in the bitchar sequence
        /// </summary>
        public readonly string BitText;
                 
    }


}