//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class ByteSpanFiller
    {                
        public static ByteSpanFiller Generator(byte[] data, string propName)
            => new ByteSpanFiller(data,propName);

        public static string GenAccessor(byte[] data, string propName, int offset = 4, int seglen = 8)
            => new ByteSpanFiller(data,propName).GenAccessor(offset,seglen);

        public static string GenAccessor(Span<byte> data, string propName, int offset = 4, int seglen = 8)
            => new ByteSpanFiller(data,propName).GenAccessor(offset,seglen);

        public static string GenAccessor(ReadOnlySpan<byte> data, string propName, int offset = 4, int seglen = 8)
            => new ByteSpanFiller(data,propName).GenAccessor(offset,seglen);

        public ByteSpanFiller(Span<byte> data, string propName)
        {
            this.Data = data.ToArray();
            this.PropName = propName;
        }

        public ByteSpanFiller(ReadOnlySpan<byte> data, string propName)
        {
            this.Data = data.ToArray();
            this.PropName = propName;
        }

        public ByteSpanFiller(byte[] data, string propName)
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
        
        /// <summary>
        /// Creates a span of replicated characters 
        /// </summary>
        /// <param name="src">The character to replicate</param>
        /// <param name="count">The replication count</param>
        public static ReadOnlySpan<char> replicate(char src, int count)
            => new string(src,count);

        public string GenAccessor(int offset = 0, int seglen = 8)
        {
            var src = Data;
            var dst = text.factory.Builder();

            var linepad = replicate(AsciSym.Space,offset + 4);
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