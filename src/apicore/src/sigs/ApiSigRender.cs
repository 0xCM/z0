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

    public readonly struct ApiSigRender
    {
        public const string ReturnIndicator = "@return";

        internal const string Arrow = " -> ";

        internal const string OperandLead = "::";

        internal const string TypeParamOpen = "{";

        internal const string TypeParamClose = "}";

        internal const string TypeParamSep = ", ";

        public static void render(ApiOperationSig src, ITextBuffer dst)
        {
            dst.Append(src.Name);
            dst.Append(OperandLead);
            var opcount = src.OperandCount;
            var operands = src.Operands.View;
            for(var i=0; i<opcount; i++)
            {
                ref readonly var operand = ref skip(operands,i);
                render(operand, dst);
                dst.Append(Arrow);
            }
            render(src.Return, dst);
        }

        public static void render(ApiOperandSig src, ITextBuffer dst)
        {
            if(src.IsReturn)
                dst.Append(ReturnIndicator);
            else
                dst.Append(src.Name);
            dst.Append(Chars.Colon);
            render(src.Type, dst);
        }

        public static void render(ISigTypeParam src, ITextBuffer dst)
        {
            if(src.IsOpen)
                dst.Append(src.Name);
            else
                render(src.Closure, dst);
        }

        public static string format(ApiTypeSig src)
        {
            var dst = TextTools.buffer();
            render(src, dst);
            return dst.Emit();
        }

        public static string format(ApiOperationSig src)
        {
            var dst = TextTools.buffer();
            render(src, dst);
            return dst.Emit();
        }

        public static void render(ApiTypeSig src, ITextBuffer dst)
        {
            dst.Append(src.TypeName);
            if(src.IsParametric)
            {
                var count = src.ParameterCount;
                var parameters = src.Parameters.View;
                dst.Append(TypeParamOpen);
                for(var i=0; i<count; i++)
                {
                    render(skip(parameters,i), dst);
                    if(i != count - 1)
                        dst.Append(TypeParamSep);
                }

                dst.Append(TypeParamClose);
            }
        }

        public static void render(in ApiSig src, ITextBuffer dst)
        {
            var parts = src.Components.View;
            var count = parts.Length;
            for(var i=0; i<count; i++)
            {
                dst.Append(core.skip(parts,i).Name);
                if(i != count - 1)
                    dst.Append(" -> ");
            }
        }
    }
}