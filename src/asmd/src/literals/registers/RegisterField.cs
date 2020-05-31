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
        public static RegisterSpec join(RegisterCode c, RegisterClass k, RegisterWidth w)
            => (RegisterSpec)((uint)c | (uint)k << FK | (uint)w << FW);

        [MethodImpl(Inline)]
        public static void split(RegisterSpec src, out RegisterCode c, out RegisterClass k, out RegisterWidth w)
        {
            c = (RegisterCode)src;
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
        public const RegisterCode CodeFW = RegisterCode.FieldWidth;

        /// <summary>
        /// The width of the RegisterClass segment
        /// </summary>
        public const RegisterClass ClassFW = RegisterClass.FieldWidth;

        /// <summary>
        /// The width of the RegisterWidth segment
        /// </summary>
        public const RegisterWidth WidthFW = RegisterWidth.FieldWidth;

        public readonly RegisterCode Code;

        public readonly RegisterClass Class;

        public readonly RegisterWidth Width;

        [MethodImpl(Inline)]
        public static implicit operator RegisterField(RegisterSpec src)
            => new RegisterField(src);    

        [MethodImpl(Inline)]
        public RegisterField(RegisterCode c, RegisterClass k, RegisterWidth w)
        {
            Code = c;
            Class = k;
            Width = w;
        }

        [MethodImpl(Inline)]
        public RegisterField(RegisterSpec src)
            => split(src, out Code, out Class, out Width);

        public RegisterSpec Bits 
        {
            [MethodImpl(Inline)]
            get => join(Code,Class,Width);
        }

        public string Format()
        {
            var formatter = BitFormatter.create<RegisterField>();
            var f = formatter.Format(this);
            var c = f.Substring(FC,(int)CodeFW);
            var k = f.Substring(FK,(int)ClassFW);
            var w = f.Substring(FW, (int)WidthFW);
            var sep = " | ";
            return text.bracket(text.concat(c, sep, k, sep, w));
        }
    }
}