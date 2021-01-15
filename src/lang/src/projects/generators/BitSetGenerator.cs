//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Generate
{
    using System;
    using System.Collections.Generic;

    using static Konst;

    public abstract class BitSetGenerator : CodeGenerator
    {
        protected string TypeDigits(byte m, byte n)
            => BitFormatter.format(n, BitFormatter.limited(m,m));

        protected string TypeName(byte m, byte n)
            => text.concat(AsciLetterUp.B, TypeDigits(m,n));

        protected string ValueName(byte m, byte n)
            => text.concat(AsciLetterLo.b, TypeDigits(m,n));

        public string DeclareLiteral(string name, string value)
            => $"public const string {name} = {text.enquote(value)};";

        /// <summary>
        /// Generates public const string TypeName = "B{m}{n}";
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        protected string TypeNameLiteral(byte m, byte n)
            => DeclareLiteral("TypeName", TypeName(m,n));

        /// <summary>
        /// Generates: public const string ValueName = "b{m}{n}";
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        protected string ValueNameLiteral(byte m, byte n)
            => DeclareLiteral("ValueName", TypeName(m,n));

        protected string Interface(byte m, byte n)
        {
            var iName = m switch{
                    1 => "IBit",
                    2 => "IDuet",
                    3 => "ITriad",
                    4 => "IQuartet",
                    5 => "IQuintet",
                    6 => "ISextet",
                    7 => "ISeptet",
                    8 => "IOctet",
                    _ => "",
            };

            var tName = TypeName(m,n);

            return text.concat(iName, Chars.Lt, tName, Chars.Gt);
        }

        protected string KindName(byte m)
        {
            var kName = m switch{
                    1 => "Singleton",
                    2 => "Duet",
                    3 => "Triad",
                    4 => "Quartet",
                    5 => "Quintet",
                    6 => "Sextet",
                    7 => "Septet",
                    8 => "Octet",
                    _ => "",
            };
            return kName;
        }

        protected string KindValue(byte m, byte n)
            => text.concat(KindName(m), Chars.Dot, AsciLetterLo.b, TypeDigits(m,n));

        protected string DeclareKindProperty(byte m, byte n)
            => Strings.concat($"public {KindName(m)} => {KindValue(m,n)};");

        protected string DeclareToString
            => "public override string ToString() => ValueName;";

        protected string DeclareFormat
            => "[MethodImpl(Inline)] public string Format() => ValueName;";

        protected string DefineType(byte l, byte m, byte n)
            => level(l, $"public readonly struct {TypeName(m,n)} : {Interface(m,n)}");

        protected string OpenDeclaration(byte l)
            => level(l, Chars.LBrace);

        protected string CloseDeclaration(byte l)
            => level(l, Chars.RBrace);

        protected string DeclareType(byte l, byte m, byte n)
        {
            var dst = text.build();
            dst.AppendLine(DefineType(l,m,n));
            dst.AppendLine(OpenDeclaration(l));
            dst.AppendLine();
            dst.AppendLine(level(l + 1, DeclareKindProperty(m,n)));
            dst.AppendLine();
            dst.AppendLine(level(l + 1, DeclareToString));
            dst.AppendLine();
            dst.AppendLine(level(l + 1, DeclareFormat));
            dst.AppendLine();
            dst.AppendLine(CloseDeclaration(l));
            dst.AppendLine();
            return dst.ToString();
        }

        public abstract byte Digits {get;}

        public abstract byte MaxValue {get;}

        public IEnumerable<string> TypeDeclarations
        {
            get
            {
                for(byte n=0; n<=MaxValue; n++)
                    yield return DeclareType(2, Digits, (byte)n);
            }
        }
    }
}