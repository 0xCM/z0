//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct PromptSyntax
    {
        [MethodImpl(Inline), Op]
        public static InputParameter parameter(string identifier, byte position)
            => new InputParameter(identifier, position);

        /// <summary>
        /// Creates a sequence of input parameters from a sequence of parameter identifiers
        /// </summary>
        /// <param name="src">The source identifiers</param>
        [MethodImpl(Inline), Op]
        public static InputParameter[] parameters(string[] src)
        {
            var dst = sys.alloc<InputParameter>(src.Length);
            parameters(src, dst);
            return dst;
        }

        /// <summary>
        /// Creates a sequence of input parameters from a sequence of parameter identifiers
        /// </summary>
        /// <param name="src">The source identifiers</param>
        /// <param name="src">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void parameters(string[] src, InputParameter[] dst)
        {
            var count = src.Length;
            var input = span(src);
            var output = span(dst);
            
            for(byte i=0; i<count; i++)
                seek(output, i) = parameter(skip(input,i), i);            
        }

        [MethodImpl(Inline), Op]
        public static InputParameter reposition(in InputParameter src, byte position)
            => new InputParameter(src.Identifier, src.Markers, named: src.Named, position: position);

        [MethodImpl(Inline), Op]
        public static PromptInputSyntax input(in StringRef prototype, in StringRef command)
            => new PromptInputSyntax(prototype, command, EmptyFlags, EmptyParams);
    
        [MethodImpl(Inline), Op]
        public static StringRef prototype(Type src)
        {
            var attrib = src.GetCustomAttribute<CmdPrototypeAttribute>();
            if(attrib != null)
                return attrib.Prototype;
            else
                return EmptyString;
        }

        [MethodImpl(Inline), Op]
        public static PromptInputSyntax input(Type src)
            => input(prototype(src), src.Name);

        [MethodImpl(Inline), Op]
        public static string format(in InputParameter src)
            => $"{src.Markers.ParamMarker}{src.Identifier}{src.Markers.ArgMarker}{src.Markers.ArgQualifier}arg_value{src.Markers.ArgQualifier}";     

        [MethodImpl(Inline), Op]
        public static string format(in PromptInputSyntax src)
            => $"{src.CommandName} {src.Parameters}";

        [MethodImpl(Inline), Op]
        public static string format(in InputFlag src)
        {
            ref readonly var marker = ref src.FlagMarker;
            ref readonly var id = ref src.FlagIdentifier;
            return text.format(marker.Data, id.Data);
        }

        [MethodImpl(Inline)]
        public static PromptInputSyntax input<c>()
            where c : ProcessCommand
        {
            var type = z.type<c>();
            return input(type);
        }

        static InputFlag[] EmptyFlags => sys.empty<InputFlag>();

        static InputParameter[] EmptyParams => sys.empty<InputParameter>();
    }
}