//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using static Konst;

    public class HexCodeGenerator : CodeGenerator
    {
        public static CodeGenerator Service => new HexCodeGenerator();
        
        static string Name(byte value)
            => text.concat(AsciLetterUp.X, value.FormatHex(true,false,uppercase:true));

        static string Kind(byte value)
            => text.concat(AsciLetterLo.x, value.FormatHex(true,false));

        public static IEnumerable<string> Gen()
        {
            var template = new HexCodeGenerator();
            for(var i=0; i<= 0xFF;i++)
            {
                yield return template.Populate(Name((byte)i), Kind((byte)i));
                yield return text.blank;
            }
        }

        public static IEnumerable<string> Instances()
        {
            var template = new HexCodeGenerator();
            for(var i=0; i<= 0xFF;i++)
            {
                yield return template.Instance(Name((byte)i), Kind((byte)i));
                yield return text.blank;
            }
        }

        public string Instance(string Name, string Kind)
        {
            return text.concat(Level2, $"public static {Name} {Kind} => default;");
        }

        public string Populate(string Name, string Kind) 
        {
            return
                text.concat(
                Level2, $"public readonly struct {Name} : IHexCode<{Name}>, ITextual", Eol,                
                Level2, LBrace, Eol,
                Level3, InlineTag, Eol,
                Level3, ImplicitOp, $"HexKind({Name} src) => HexKind.{Kind};", Eol,
                Eol,
                Level3, InlineTag, Eol,
                Level3, ImplicitOp, $"byte({Name} src) => 0{Kind};", Eol,
                Eol,
                Level3, $"public HexKind Kind => HexKind.{Kind};", Eol,
                Eol,
                Level3, $"public string Format() => Kind.Format();", Eol,
                Eol,
                Level3, $"public override string ToString() => Format();", Eol,
                Level2, RBrace
            );
        }
    }
}