//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    public readonly struct ByteKindGen
    {
        public static ByteKindGen Define(bool hex)
            => new ByteKindGen(hex);
        
        static LogPaths Paths => LogPaths.The;

        public bool HexEnum {get;}
        
        ByteKindGen(bool HexEnum)
        {
            this.HexEnum = HexEnum;
        }
        
        public CSharpSource Gen()
        {
            const string TypeIndent = "    ";
            const string MemberIndent = "        ";            
            const string HexFormat = "X2";

            var targetName = HexEnum ? "HexByteKind" : "ByteKind";

            var sb = new StringBuilder();   
            sb.AppendLine(CSharpSource.FileHeader);
            sb.AppendLine("namespace Z0");
            sb.AppendLine("{");
            sb.AppendLine($"{TypeIndent}/// <summary>");
            sb.AppendLine($"{TypeIndent}/// Classifies each byte value");
            sb.AppendLine($"{TypeIndent}/// </summary>");
            sb.AppendLine($"{TypeIndent}public enum {targetName} : byte");
            sb.AppendLine(TypeIndent + "{");
            for(var i=0; i<= byte.MaxValue; i++)
            {
                sb.AppendLine($"{MemberIndent}/// <summary> ");
                if(HexEnum)
                    sb.AppendLine($"{MemberIndent}/// Identifies the hex value 0x{i.ToString(HexFormat)} := {i}");
                else
                    sb.AppendLine($"{MemberIndent}/// Identifies the decimal value {i} := 0x{i.ToString(HexFormat)} ");
                sb.AppendLine($"{MemberIndent}/// </summary> ");
                if(HexEnum)
                {
                    sb.AppendLine($"{MemberIndent}X{i.ToString(HexFormat)} = 0x{i.ToString(HexFormat)},");
                }
                else
                {
                    sb.AppendLine($"{MemberIndent}b{i.ToString().PadLeft(3,'0')} = {i},");
                }
                sb.AppendLine();
            }
            sb.AppendLine(TypeIndent + "}");
            sb.AppendLine("}");
            
            return new CSharpSource(sb.ToString());
        }

        public Option<FilePath> Save(CSharpSource src)
        {
            var filename = HexEnum ? FileName.Define("HexByteKind.cs") :  FileName.Define("ByteKind.cs");
            var dstpath = Paths.TargetPath(LogArea.App,filename);
            using var dst = dstpath.Writer();
            dst.WriteLine(src);
            return dstpath;
        }

        public Option<FilePath> GenToFile()
            => Save(Gen());
   }    
}