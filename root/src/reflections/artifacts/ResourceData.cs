//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class ResourceData
    {                
        public static string GenRandomData(ByteSize size)
        {
            var random = new Random();
            var buffer = new byte[size];
            random.NextBytes(buffer);
            var codegen = new ResourceData(buffer,$"Bytes{size}");
            return codegen.GenAccessor();
        }

        public static ResourceData Generator(byte[] data, string propName)
            => new ResourceData(data,propName);

        public static string GenAccessor(byte[] data, string propName, int offset = 4, int seglen = 8)
            => new ResourceData(data,propName).GenAccessor(offset,seglen);

        public static string GenAccessor(Span<byte> data, string propName, int offset = 4, int seglen = 8)
            => new ResourceData(data,propName).GenAccessor(offset,seglen);

        public static string GenAccessor(ReadOnlySpan<byte> data, string propName, int offset = 4, int seglen = 8)
            => new ResourceData(data,propName).GenAccessor(offset,seglen);

        public ResourceData(Span<byte> data, string propName)
        {
            this.Data = data.ToArray();
            this.PropName = propName;
        }

        public ResourceData(ReadOnlySpan<byte> data, string propName)
        {
            this.Data = data.ToArray();
            this.PropName = propName;
        }

        public ResourceData(byte[] data, string propName)
        {
            this.Data = data;
            this.PropName = propName;
        }

        public string PropName {get;}

        public byte[] Data {get;}

        public string GenLookups(Type valueType, string rootName)
        {
            var sb = text.factory.Builder();
            for(var i=0; i<Data.Length; i++)
                sb.AppendLine($"public static {valueType.Name} {rootName}{i} => Lookup({i})");
            return sb.ToString();
        }
        
        public string GenAccessor(int offset = 0, int seglen = 8)
        {
            var src = Data;
            var dst = text.factory.Builder();
            var linepad = AsciSym.Space.Replicate(offset + 4);
            var margin = new string(' ',offset);
            dst.AppendLine(($"{margin}static ReadOnlySpan<byte> {PropName} => new byte[]"));
            dst.AppendLine(margin + "{");            
            dst.Append(linepad);
            for(var i=0; i<src.Length; i++)
            {
                var h = $"{src[i].FormatHex()}{AsciSym.Comma}";
                dst.Append($" {h}");
                if((i + 1) % seglen == 0 && i != src.Length - 1)
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