//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

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

        protected const int FileLevel = 0;
        
        protected const int TypeLevel = 1;

        protected const int MemberLevel = 2;

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

        }

        protected virtual string GenerateHeader()
        {
            var dst = text.build();
            dst.AppendLine(HeaderLine1);
            dst.AppendLine(HeaderLine2);
            dst.AppendLine(HeaderLine3);
            dst.AppendLine(HeaderLine4);
            return dst.ToString();
        }

        protected string FileHeader => GenerateHeader();

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

        protected string UsingNamespac(int level, string ns)
            => this.level(level, text.concat("using", space, ns, semi));
        
        protected string UsingStatic(int level, string type)
            => this.level(level, text.concat("using static", space, type, semi));

        protected string concat(params object[] src)
            => text.concat(src);

        protected void line(string src, StringBuilder dst)
            => dst.AppendLine(src);

        protected void lines(IEnumerable<string> src, StringBuilder dst)
            => Control.iter(src,l => line(l,dst));

        protected string assign(object dst, object src)
            => concat(dst, space, Chars.Eq, space, src);

        
        public virtual string Generate() => string.Empty;

        public string Comment(int i, object src)
            => level(i,$"// {src}");

        protected virtual string[] DefaultNamspaces {get;}
            = new string[]{
                "System",
                "System.Runtime.CompilerServices",
            };

        protected virtual string[] StaticUsings {get;}
            = new string[]{
                "Seed",
                "Memories",
            };

        protected virtual string FileNamespace => nameof(Z0);

        protected void EmitFileHeader(TextWriter dst)
        {
            dst.WriteLine(FileHeader);
        }

        protected void OpenFileNamespace(TextWriter dst)
        {
            dst.WriteLine(string.Concat("namespace ",FileNamespace));
            dst.WriteLine(lbrace);            
        }

        protected void CloseFileNamespace(TextWriter dst)
        {
            dst.WriteLine(rbrace);            

        }

        protected void CloseTypeDeclaration(int level, TextWriter dst)
        {
            dst.WriteLine(this.level(level, rbrace));
        }

        protected void EmitUsingStatments(int level, TextWriter dst)
        {
            for(var j=0; j<DefaultNamspaces.Length; j++)
                dst.WriteLine(UsingNamespac(level, DefaultNamspaces[j]));                

            dst.WriteLine();

            for(var j=0; j<StaticUsings.Length; j++)
                dst.WriteLine(UsingStatic(level, StaticUsings[j]));                

            dst.WriteLine();

        }

    }
}