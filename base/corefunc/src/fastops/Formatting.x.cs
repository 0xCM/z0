//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class YetAnotherFormattingExtensionClass
    {
        /// <summary>
        /// Formats the function body encoding as a comma-separated list of hex values
        /// </summary>
        /// <param name="src">The source function</param>
        public static string FormatNativeHex(this AsmCode src)
            => src.Encoded.FormatHex(AsciSym.Comma, true, true, true);

		public static string FormatHexLines(this AsmCode src, NativeFormatConfig? fmt = null)
		{
			var dst = text();
			dst.AppendLine($"; label   : {src.Label}");
			dst.AppendLine($"; location: {src.Origin.Format()}, length: {src.Origin.Length} bytes");
            dst.Append(src.Encoded.FormatHexLines(fmt));
			return dst.ToString();;
		}

        public static string FormatHexLines(this byte[] data, NativeFormatConfig? fmt = null)
        {
            var dst = text();
            var configured = fmt ?? NativeFormatConfig.Default;            
            for(ushort i=0; i< data.Length; i++)
            {
                if(i % configured.BytesPerLine == 0)
                {
                    if(i != 0)
                        dst.AppendLine();

                    if(configured.LineLabels)
                    {
                        dst.Append(i.FormatHex(true,false));
                        dst.Append(AsciLower.h);
                        dst.Append(AsciSym.Space);
                    }
                }
                dst.Append(data[i].FormatHex(true, true));
                dst.Append(AsciSym.Space);
            }
            dst.AppendLine();
            return dst.ToString();
        }

        public static string Format(this CapturedMember data, NativeFormatConfig? fmt = null)
        {
            if(data.IsEmpty)
                return "<no_data>";
            
            var dst = text();
            var range = bracket(concat(data.StartAddress.FormatHex(false,true), AsciSym.Comma, data.EndAddress.FormatHex(false,true)));
            var bytes = data.Code.Encoded;
            dst.AppendLine($"; label   : {data.Method.Signature().Format()}");
            dst.AppendLine($"; location: {range}, length: {data.Length} bytes");
            dst.Append(bytes.FormatHexLines(fmt));
            dst.AppendLine(MethodSep);
            return dst.ToString();
        }         
 

        static string MethodSep => new string('_',80);


        /// <summary>
        /// Constructs a display name for a generic method specialized for a specified type
        /// </summary>
        /// <typeparam name="T">The relative type</typeparam>
        /// <param name="src">The source method</param> 
        [MethodImpl(Inline)]
        public static string SpecializeName<T>(this MethodBase src)
            => src.DeclaringType.DisplayName() + "/" + src.Name + "<" + typeof(T).DisplayName() + ">";
                
        /// <summary>
        /// Constructs a display name for a method
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static string FullDisplayName(this MethodInfo src)
            => $"{src.DeclaringType.DisplayName()}/{src.DisplayName()}";


   }
   
}