//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    
    public class HexCodeGenerator : CodeGenerator
    {
        static string Name(byte value)
            => text.concat(Letters.X, value.FormatHex(true,false,uppercase:true));

        static string Kind(byte value)
            => text.concat(Letters.x, value.FormatHex(true,false));

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
            return text.concat(level2, $"public static {Name} {Kind} => default;");
        }

        public string Populate(string Name, string Kind) 
        {
            return
                text.concat(
                level2, $"public readonly struct {Name} : IHexCode<{Name}>, ITextual", endl,                
                level2, lbrace, endl,
                level3, inline, endl,
                level3, implicit_op, $"HexKind({Name} src) => HexKind.{Kind};", endl,
                endl,
                level3, inline, endl,
                level3, implicit_op, $"byte({Name} src) => 0{Kind};", endl,
                endl,
                level3, $"public HexKind Kind => HexKind.{Kind};", endl,
                endl,
                level3, $"public string Format() => Kind.Format();", endl,
                endl,
                level3, $"public override string ToString() => Format();", endl,
                level2, rbrace
            );
        }
    }
}