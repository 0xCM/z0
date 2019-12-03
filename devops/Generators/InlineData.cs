//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public class InlineData : CodeGenerator
    {
        public static string GenRandomData(ByteSize size)
        {
            var random = new Random();
            var buffer = new byte[size];
            random.NextBytes(buffer);
            var codegen = new InlineData(buffer,$"Bytes{size}");
            return codegen.GenAccessor();
        }

        public static InlineData Generator(byte[] data, string propName)
            => new InlineData(data,propName);

        public static string GenAccessor(byte[] data, string propName, int offset = 4, int seglen = 8)
            => new InlineData(data,propName).GenAccessor(offset,seglen);

        public InlineData(byte[] data, string propName)
        {
            this.Data = data;
            this.PropName = propName;
        }

        public string PropName {get;}

        public byte[] Data {get;}

        public string GenLookups(Type valueType, string rootName)
        {
            //public static ulong Seed00 => Lookup(0)
            var sb = text();
            for(var i=0; i<Data.Length; i++)
                sb.AppendLine($"public static {valueType.Name} {rootName}{i} => Lookup({i})");
            return sb.ToString();
        }

        public static string FormatBytes(byte[] src, int seglen, int lpad = 0, char? sep = null)
        {
            var dst = text();
            var delimiter = sep ?? AsciSym.Comma;
            var margin = AsciSym.Space.Replicate(lpad);
            for(var i=0; i<src.Length; i++)
            {   
                dst.Append($"{src[i].FormatHex()}{delimiter}");
                if((i + 1) % seglen == 0)
                {
                    dst.AppendLine();
                    dst.Append(margin);
                }
                else
                    dst.Append(AsciSym.Space);
            }
            return dst.ToString();

        }
        public string GenAccessor(int offset = 0, int seglen = 8)
        {
            var src = Data;
            var dst = text();
            var linepad = AsciSym.Space.Replicate(offset + 4);
            var margin = new string(' ',offset);
            dst.AppendLine(($"{margin}static ReadOnlySpan<byte> {PropName} => new byte[]"));
            dst.AppendLine(margin + "{");            
            dst.Append(linepad);
            for(var i=0; i<src.Length; i++)
            {
                var h = $"{src[i].FormatHex()}{AsciSym.Comma}";
                dst.Append($" {h}");
                if((i + 1) % seglen == 0)
                {
                    dst.AppendLine();
                    dst.Append(linepad);
                }
            }
            dst.AppendLine();
            dst.AppendLine(margin + "};");
            return dst.ToString();
        }
    }
}