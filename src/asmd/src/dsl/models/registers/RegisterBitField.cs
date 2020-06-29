//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using static RegisterBitFields;

    /// <summary>
    /// The register bitfield
    /// </summary>
    public readonly struct RegisterBitField : ITextual
    {
        /// <summary>
        /// The register code data (1 byte)
        /// </summary>
        public readonly RegisterCode Code;

        /// <summary>
        /// The register class data (1 byte)
        /// </summary>
        public readonly RegisterClass Class;

        /// <summary>
        /// The register width (2 bytes)
        /// </summary>
        public readonly RegisterWidth Width;

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static RegisterCode code(RegisterKind src)
            => (RegisterCode)((byte)src >> CodeIndex);

        /// <summary>
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static RegisterClass @class(RegisterKind src)
            => (RegisterClass)((uint)src >> ClassIndex);

        /// <summary>
        /// Determines the register width from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static RegisterWidth width(RegisterKind src)
            => (RegisterWidth)((uint)src >> WidthIndex);

        [MethodImpl(Inline)]
        public static RegisterKind join(RegisterCode c, RegisterClass k, RegisterWidth w)
            => (RegisterKind)((uint)c  << CodeIndex | (uint)k << ClassIndex | (uint)w << WidthIndex);

        [MethodImpl(Inline)]
        public static void split(RegisterKind src, out RegisterCode c, out RegisterClass k, out RegisterWidth w)
        {
            c = code(src);
            k = @class(src);
            w = width(src);
        }

        [MethodImpl(Inline)]
        public static implicit operator RegisterBitField(RegisterKind src)
            => new RegisterBitField(src);    

        [MethodImpl(Inline)]
        public RegisterBitField(RegisterCode c, RegisterClass k, RegisterWidth w)
        {
            Code = c;
            Class = k;
            Width = w;
        }

        [MethodImpl(Inline)]
        public RegisterBitField(RegisterKind src)
            => split(src, out Code, out Class, out Width);

        public RegisterKind Joined
        {
            [MethodImpl(Inline)]
            get => join(Code,Class,Width);
        }

        public string Format()
        {            
            const string Sep = " | ";
            
            var seg0 = BitFieldSegmentFormatter.format<RegisterCode,byte>(Code);
            var seg1 = BitFieldSegmentFormatter.format<RegisterClass,byte>(Class);
            var seg2 = BitFieldSegmentFormatter.format<RegisterWidth,ushort>(Width);
            var dst = text.bracket(text.concat(seg2, Sep, seg1, Sep, seg0));

            return dst;
        }
    }
}