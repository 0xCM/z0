//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICodeGenerator
    {
        string Generate();
    }

    public class CodeGenerator : ICodeGenerator
    {
        protected const string HeaderLine1 = "//-----------------------------------------------------------------------------";
        
        protected const string HeaderLine2 = "// Copyright   :  (c) Chris Moore, 2020";
        
        protected const string HeaderLine3 = "// License     :  MIT";

        protected const string HeaderLine4 = "//-----------------------------------------------------------------------------";


        protected const string level0 = "";
        
        protected const string level1 = "    ";
        
        protected const string level2 = level1 + level1;
        
        protected const string level3 = level2 + level1;
                
        protected string endl = text.eol();

        protected const char rbrace = Chars.RBrace;

        protected const char lbrace = Chars.LBrace;

        protected const char lparen = Chars.LParen;

        protected const char rparen = Chars.RParen;

        protected const char space = Chars.Space;

        protected const char comma = Chars.Comma;

        protected const char semi = Chars.Semicolon;

        protected const string blank = text.blank;

        protected const string inline = "[MethodImpl(Inline)]";
        
        protected const string implicit_op ="public static implicit operator ";

        protected string bracket(object content)
            => text.bracket(content);

        protected string Using(string ns)
            => text.concat("using", space, ns, semi);

        protected string Args(params object[] src)
            => string.Join(comma,src);

        protected string attrib(string name, params object[] args)
            => args.Length == 0 
            ? bracket(concat(name)) 
            : bracket(concat(name,lparen, Args(args), rparen));

        protected CodeGenerator()
        {
            var dst = text.build();
            dst.AppendLine(HeaderLine1);
            dst.AppendLine(HeaderLine2);
            dst.AppendLine(HeaderLine3);
            dst.AppendLine(HeaderLine4);
            FileHeader = dst.ToString();

        }

        protected string FileHeader;

        protected string level(int i, params object[] src)
            => i switch {
                1 => l1(src),
                2 => l2(src),
                3 => l3(src),
                _ => l0(src),
            };

        protected string spaced(params object[] src)
            => string.Join(space, src);

        protected string l0(params object[] src)
            => concat(src);

        protected string l1(params object[] src)
            => level1 + concat(src);

        protected string l2(params object[] src)
            => level2 + concat(src);

        protected string l3(params object[] src)
            => level3 + concat(src);

        protected string concat(params object[] src)
            => text.concat(src);

        protected void line(string src, StringBuilder dst)
            => dst.AppendLine(src);

        protected void lines(IEnumerable<string> src, StringBuilder dst)
            => Control.iter(src,l => line(l,dst));

        protected string assign(object dst, object src)
            => concat(dst, space, Chars.Eq, space, src);

        protected virtual string Apply() => string.Empty;
        
        public string Generate()
            => Apply();

    }
}