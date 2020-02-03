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
 
        public static string Format(this NumericKind k)
            => $"{k.Width()}{k.Indicator().Format()}";

        public static string FormatParam(this Pair<ParameterInfo,int> src)
        {
            var t = src.A.ParameterType;
            if(t.IsSegmented())
            {
                var typewidth = (int)t.Width();
                var segkind = t.SegType().Require().NumericKind();
                var segwidth = segkind.Width();
                var indicator = segkind.Indicator().Format();
                return $"{typewidth}x{segwidth}{indicator}".PadLeft(7);
            }
            else
                return $"{src.B}{t.NumericKind().Indicator().Format()}";
        }

        public static string FormatParams(this IEnumerable<Pair<ParameterInfo,int>> src)
        {
            var pairs = src.ToArray();
            if(pairs.Length == 1)
                return pairs[0].FormatParam();

            var dst = text();
            for(var i=0; i<pairs.Length; i++)
            {
                var pair = pairs[i];
                dst.Append(pairs[i].FormatParam());
                if(i != pairs.Length - 1)
                {
                    dst.Append(AsciSym.Comma);
                    dst.Append(AsciSym.Space);
                }
            }
            return parenthetical(dst.ToString());            
        }

        static string MethodSep => new string('_',80);

        public static string Format(this DataResource src, bool data = true)
        {
            if(src.IsEmpty)
                return string.Empty;
                
            var origin = src.Location.FormatHex(false,true,true,false);
            var datafmt = string.Empty;
            if(data)
            {
                var loaded = src.GetBytes();
                var current = parenthetical(location(loaded).FormatHex(false,true,true,false));
                datafmt = concat(AsciSym.Colon, AsciSym.Space, embrace(loaded.FormatHexBytes()), AsciSym.Space, current);
            }
            
            return concat($"{src.Id}, {origin}, {src.Length}", datafmt);            
        }

        /// <summary>
        /// Constructs a display name for a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static string DisplayName(this Type src)
        {
            if(src == null)
                throw new ArgumentNullException(nameof(src));
                
            if(Attribute.IsDefined(src, typeof(DisplayNameAttribute)))
                return src.GetCustomAttribute<DisplayNameAttribute>().DisplayName;

            if(src.IsEnum)
                return src.Name + AsciSym.Colon + src.GetEnumUnderlyingType().DisplayName();

            if(src.IsPointer)
                return $"{src.GetElementType().DisplayName()}*";
            
            if(src.IsPrimal())
                return src.PrimalKeyword().IfBlank(src.Name);

            if(src.IsGenericType && !src.IsRef())
                return src.FormatGeneric();

            if(src.IsRef())
                return src.GetElementType().DisplayName();

            return src.Name;
        }

        /// <summary>
        /// Constructs a display name for a method
        /// </summary>
        /// <param name="src">The source method</param>
        public static string DisplayName(this MethodInfo src)
        {
            var attrib = src.GetCustomAttribute<DisplayNameAttribute>();
            if(attrib != null)
                return attrib.DisplayName;
            var slots = src.GenericParameters(false);
            return slots.Length == 0 ? src.Name : GenericMemberDisplayName(src.Name, slots);            
        }

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

        static string GenericMemberDisplayName(string memberName, IReadOnlyList<Type> args)
        {                
            var argFmt = args.Count != 0 ? args.Select(t => t.DisplayName()).Concat(", ") : string.Empty;            
            var typeName = memberName.Replace($"`{args.Count}", string.Empty);
            return typeName + (args.Count != 0 ? angled(argFmt) : string.Empty);
        }

        static string FormatGeneric(this Type src)
        {
            var name = src.Name;                
            var args = src.GetGenericArguments();
            if(args.Length != 0)
            {
                name = name.Replace($"`{args.Length}", string.Empty);
                name += "<";
                for(var i= 0; i< args.Length; i++)
                {
                    name += args[i].DisplayName();
                    if(i != args.Length - 1)
                        name += ",";
                }                                
                name += ">";
            }
            return name;
        } 
   }
   
}