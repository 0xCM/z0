//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
        
    /// <summary>
    /// The register bitfield
    /// </summary>
    public readonly struct RegisterField : ITextual
    {
        [MethodImpl(Inline)]
        public static RegisterKind join(RegisterCode32 c, RegisterClass k, RegisterWidth w)
            => (RegisterKind)((uint)c | (uint)k << FK | (uint)w << FW);

        [MethodImpl(Inline)]
        public static void split(RegisterKind src, out RegisterCode32 c, out RegisterClass k, out RegisterWidth w)
        {
            c = (RegisterCode32)src;
            k = (RegisterClass)((uint)src >> FK);
            w = (RegisterWidth)((uint)src >> FW);
        }

        /// <summary>
        /// The RegisterCode segment position
        /// </summary>
        public const byte FC = 0;

        /// <summary>
        /// K: The RegisterClass segment position
        /// </summary>
        public const byte FK = 8;

        /// <summary>
        /// W: The RegisterWidth segment position
        /// </summary>
        public const byte FW = 16;

        /// <summary>
        /// The width of the RegisterCode segment
        /// </summary>
        public const RegisterCode32 CodeFW = RegisterCode32.FieldWidth;

        /// <summary>
        /// The width of the RegisterClass segment
        /// </summary>
        public const RegisterClass ClassFW = RegisterClass.FieldWidth;

        /// <summary>
        /// The width of the RegisterWidth segment
        /// </summary>
        public const RegisterWidth WidthFW = RegisterWidth.FieldWidth;

        public readonly RegisterCode32 Code;

        public readonly RegisterClass Class;

        public readonly RegisterWidth Width;

        [MethodImpl(Inline)]
        public static implicit operator RegisterField(RegisterKind src)
            => new RegisterField(src);    

        [MethodImpl(Inline)]
        public RegisterField(RegisterCode32 c, RegisterClass k, RegisterWidth w)
        {
            Code = c;
            Class = k;
            Width = w;
        }

        [MethodImpl(Inline)]
        public RegisterField(RegisterKind src)
            => split(src, out Code, out Class, out Width);

        public RegisterKind Joined
        {
            [MethodImpl(Inline)]
            get => join(Code,Class,Width);
        }

        public string Format()
        {            
            const string Sep = " | ";
            
            var seg0 = SegmentFormatter.format<RegisterCode32,byte>(Code);
            var seg1 = SegmentFormatter.format<RegisterClass,byte>(Class);
            var seg2 = SegmentFormatter.format<RegisterWidth,ushort>(Width);
            var dst = text.bracket(text.concat(seg2, Sep, seg1, Sep, seg0));

            return dst;
        }
    }
}