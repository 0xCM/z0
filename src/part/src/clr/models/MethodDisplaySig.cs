//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct MethodDisplaySig
    {
        /// <summary>
        /// For a system-defined type, returns the C#-specific keyword for the type if it has one;
        /// otherwise, returns an empty string
        /// </summary>
        /// <param name="src">The type to test</param>
        [Op]
        public static string keyword(Type src)
        {
            if(src.IsSByte())
                return "sbyte";
            else if(src.IsByte())
                return "byte";
            else if(src.IsUInt16())
                return "ushort";
            else if(src.IsInt16())
                return "short";
            else if(src.IsInt32())
                return "int";
            else if(src.IsUInt32())
                return "uint";
            else if(src.IsInt64())
                return "long";
            else if(src.IsUInt64())
                return "ulong";
            else if(src.IsSingle())
                return "float";
            else if(src.IsDouble())
                return "double";
            else if(src.IsDecimal())
                return "decimal";
            else if(src.IsBool())
                return "bool";
            else if(src.IsChar())
                return "char";
            else if(src.IsString())
                return "string";
            else if(src.IsVoid())
                return "void";
            else if(src.IsDynamic())
                return "dynamic";
            else if(src.IsObject())
                return "object";
            else
                return EmptyString;
        }

        [Op]
        public static MethodDisplaySig from(in ClrMethodArtifact src)
            => new MethodDisplaySig(format(src));

        [Op]
        public static string format(in ClrTypeSigInfo src)
            => src.IsArray ? src.DisplayName + "[]" : $"{src.Modifier}{src.DisplayName}";

        [Op]
        public static string format(in ClrParamInfo src)
            => string.Format("{0} {1}", format(src.Type), src.Name);

        [Op]
        public static string format(in ClrMethodArtifact src)
        {
            var dst = text.buffer();
            dst.Append(format(src.ReturnType));
            dst.Append(Chars.Space);
            dst.Append(src.MethodName);
            dst.Append(Chars.LParen);
            var parameters = src.Args.View;
            var count = parameters.Length;
            for(var i=0; i<count; i++)
            {
                dst.Append(format(skip(parameters,i)));
                if(i != count - 1)
                {
                    dst.Append(Chars.Comma);
                    dst.Append(Chars.Space);
                }
            }
            dst.Append(Chars.RParen);
            return dst.Emit();
        }

        readonly TextBlock Content;

        [MethodImpl(Inline)]
        MethodDisplaySig(TextBlock src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        public static MethodDisplaySig Empty
        {
            [MethodImpl(Inline)]
            get => new MethodDisplaySig(TextBlock.Empty);
        }
    }
}