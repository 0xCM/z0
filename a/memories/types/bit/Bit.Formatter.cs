//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;
    
    /// <summary>
    /// Configurable bit data type formatter
    /// </summary>
    public readonly struct BitFormatter<T> : IFormatter<T,BitFormatConfig>
        where T : struct
    {            
        public string Format(T src, in BitFormatConfig config)
        {
            var bytes = Bytes.from(ref src);
            Span<char> dst = new char[bytes.Length*8];
            dst.Fill(bit.Zero);
            var k=0;
            for(var i=0; i<bytes.Length; i++)
            {
                for(var j=0; j<8; j++,k++)
                {                
                    if(k>=config.MaxBitCount)
                        break;

                    seek(dst,k) = bit.test(skip(bytes, i),j).ToChar();            
                }
                if(k >= config.MaxBitCount)
                    break;
            }
            
            dst.Reverse();
            var bs =new string(dst);                
            if(config.TrimLeadingZeros)
                bs = bs.TrimStart(bit.Zero);
            if(config.BlockWidth != 0)
                bs = string.Join(config.BlockSep, bs.Partition(config.BlockWidth));
            
            return config.SpecifierPrefix ? "0b" + bs : bs;                
        }

        public string Format(T src)
            => Format(src,BitFormatConfig.Default);
    }

    partial class XTend
    {
        [MethodImpl(Inline)]
        static BitFormatter<T> BitFormatter<T>()
            where T : struct
                => default;

        /// <summary>
        /// Formats source bits using default configuration
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <typeparam name="T">The bit source type</typeparam>
        public static string FormatDataBits<T>(this T src)
            where T : struct
                => BitFormatter<T>().Format(src);

        /// <summary>
        /// Formats source bits using a specified configuration
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="config">The formatting configuration</param>
        /// <typeparam name="T">The bit source type</typeparam>
        public static string FormatDataBits<T>(this T src, in BitFormatConfig config)
            where T : struct
                => BitFormatter<T>().Format(src,config);
    }
}