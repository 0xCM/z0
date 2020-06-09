//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct AsciResGenerator
    {
        static string BuildAsciData(bool span = true)
        {
            var sb = text.build();
            const char BS = '\\';
            const char SQ = '\'';
            const char QU = '\"';

            var count = 128;
            var name = span ? "AsciData" : "AsciDataString";
            var access = "public";
            var spanPropDecl = $"{access} static ReadOnlySpan<char> {name} => new " + $"char[{count}]" +"{";
            var constPropDecl = $"{access} const string {name} = \"";
            var propDecl = span ? spanPropDecl : constPropDecl;
            var charFence = span ? "'" : "";
            var spanPropClose = "};";
            var constPropCose = "\";";
            var propClose = span ? spanPropClose : constPropCose;

            sb.Append(propDecl);
            if(span)
                sb.AppendLine();
            
            for(var i=0; i<count; i++)
            {
                var c = (char)i;
                sb.Append(charFence);
                
                if(c == 0)
                    sb.Append('0');
                else if(c == 10 || c == 13)
                    sb.Append('0');
                else if(c == QU)
                    sb.Append($"\\{c}");
                else if(Char.IsControl(c) || c == BS || c == SQ)
                    sb.Append($"0");
                else
                    sb.Append(c);
                sb.Append(charFence);                
                
                if(span)
                {
                    sb.Append(", ");
                    if(i % 8 == 0 && i != 0)
                        sb.AppendLine();
                }
            }
            sb.AppendLine(propClose);
            
            var data = sb.ToString();
            return data;
        }

        static string BuildAsciByteSpan()
        {
            var sb = text.build();
            const char BS = '\\';
            const char SQ = '\'';
            const char QU = '\"';

            var count = 256;
            var span = true;
            var name = "AsciBytes";
            var access = "public";
            var propDecl = $"{access} static ReadOnlySpan<byte> {name} => new " + $"byte[{count}]" +"{";
            var propClose = "};";

            sb.Append(propDecl);
            if(span)
                sb.AppendLine();
            
            var j =0;
            for(int i=0; i<count; i++)
            {
                if(i % 2 == 0)
                    sb.Append($"{j++},");
                else
                    sb.Append("0,".PadRight(6));

                if((i + 1) % 16 == 0 && i != 0)
                    sb.AppendLine();

            }
            sb.AppendLine(propClose);
            
            var data = sb.ToString();
            return data;
        }

        public static void GenAsciTables()
        {
            var path = AppEnv.Default.AppPaths.AppSrcPath + FileName.Define("asci", FileExtensions.Txt);
            using var writer = path.Writer();
            writer.Write(BuildAsciData(false));
            writer.Write(BuildAsciData(true));
            writer.Write(BuildAsciByteSpan());
        }    
    }
}