//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    
    public abstract class BitCodeGenerator : CodeGenerator
    {
        protected string TypeDigits(int m, int n)
            => BitFormatter.format(n,BitFormatConfig.Limited(m,m));
        protected string TypeName(int m, byte n)
            => text.concat(Letters.B, TypeDigits(m,n));

        protected string ValueName(int m, byte n)
            => text.concat(Letters.b, TypeDigits(m,n));


        public string DeclareLiteral(string name, string value)
            => $"public const string {name} = {text.enquote(value)};";

        // public const string TypeName = "B00";
        protected string TypeNameLiteral(int m, byte n)
            => DeclareLiteral("TypeName", TypeName(m,n));

        // public const string ValueName = "b00";
        protected string ValueNameLiteral(int m, byte n)
            => DeclareLiteral("ValueName", TypeName(m,n));

        protected string Interface(int m, byte n)
        {
            var iName = m switch{
                    1 => nameof(IBit),
                    2 => nameof(IDuet),
                    3 => nameof(ITriad),
                    4 => nameof(IQuartet),
                    5 => nameof(IQuintet),
                    8 => nameof(IOctet),
                    _ => "",
            };

            var tName = TypeName(m,n);

            return text.concat(iName, Chars.Lt, tName, Chars.Gt);
        }

        //public Duet Kind => Duet.b00;

        protected string KindName(int m)
        {
            var kName = m switch{
                    1 => nameof(BitKind),
                    2 => nameof(Duet),
                    3 => nameof(Triad),
                    4 => nameof(Quartet),
                    5 => nameof(Quintet),
                    8 => nameof(Octet),
                    _ => "",
            };
            return kName;
        }

        protected string KindValue(int m, byte n)
            => text.concat(KindName(m), Chars.Dot, Letters.b, TypeDigits(m,n));

        protected string DeclareKindProperty(int m, byte n)
            => text.concat($"public {KindName(m)} => {KindValue(m,n)};");
        
        protected string DeclareToString => "public override string ToString() => ValueName;";

        protected string DeclareFormat => "[MethodImpl(Inline)] public string Format() => ValueName;";

        protected string DefineType(int level, int m, byte n)
            => base.level(level,$"public readonly struct {TypeName(m,n)} : {Interface(m,n)}");

        protected string OpenDeclaration(int level)
            => base.level(level, Chars.LBrace);

        protected string CloseDeclaration(int level)
            => base.level(level, Chars.RBrace);
        
        protected string DeclareType(int level, int m, byte n)
        {
            var dst = text.build();
            dst.AppendLine(DefineType(level,m,n));
            dst.AppendLine(OpenDeclaration(level));
            dst.AppendLine();
            dst.AppendLine(base.level(level + 1, DeclareKindProperty(m,n)));            
            dst.AppendLine();
            dst.AppendLine(base.level(level + 1, DeclareToString));
            dst.AppendLine();
            dst.AppendLine(base.level(level + 1, DeclareFormat));
            dst.AppendLine();            
            dst.AppendLine(CloseDeclaration(level));
            dst.AppendLine();
            return dst.ToString();

        }

        public abstract int Digits {get;}

        public abstract byte MaxValue {get;}

        public IEnumerable<string> TypeDeclarations
        {
            get
            {
                for(var n=0; n<=MaxValue; n++)
                    yield return DeclareType(2, Digits, (byte)n);
            }
        }

    }

    public class DuetGenerator : BitCodeGenerator
    {
        public static BitCodeGenerator Service => new DuetGenerator();

        public override int Digits => 2;

        public override byte MaxValue => 3;

    }

    public class TriadGenerator : BitCodeGenerator
    {
        public static BitCodeGenerator Service => new TriadGenerator();

        public override int Digits => 3;

        public override byte MaxValue => 7;

    }

    public class QuartetGenerator : BitCodeGenerator
    {
        public static BitCodeGenerator Service => new QuartetGenerator();

        public override int Digits => 4;

        public override byte MaxValue => 15;

    }    

    public class QuintetGenerator : BitCodeGenerator
    {
        public static BitCodeGenerator Service => new QuintetGenerator();

        public override int Digits => 5;

        public override byte MaxValue => 31;

    }        

    public class OctetGenerator : BitCodeGenerator
    {
        public static BitCodeGenerator Service => new OctetGenerator();

        public override int Digits => 8;

        public override byte MaxValue => 255;

    }            
}
