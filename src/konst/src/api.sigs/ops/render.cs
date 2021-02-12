//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ApiSigs
    {
         [Op]
        public static void render(OperationSig src, ITextBuffer dst)
        {
            dst.Append(src.Name);
            dst.Append(Chars.Colon);
            dst.Append(Chars.Colon);
            var opcount = src.OperandCount;
            var operands = src.Operands.View;
            for(var i=0; i<opcount; i++)
            {
                ref readonly var operand = ref skip(operands,i);
                render(operand, dst);
                dst.Append(Chars.Space);
                dst.Append(Chars.Dash);
                dst.Append(Chars.Gt);
                dst.Append(Chars.Space);
            }
            render(src.Return, dst);
        }

        [Op]
        public static void render(OperandSig src, ITextBuffer dst)
        {
            if(src.IsReturn)
                dst.Append("@return");
            else
                dst.Append(src.Name);
            dst.Append(Chars.Colon);
            render(src.Type, dst);
        }

        [Op]
        public static void render(ITypeParameter src, ITextBuffer dst)
        {
            if(src.IsOpen)
                dst.Append(src.Name);
            else
                render(src.Closure, dst);
        }

        [Op]
        public static void render(TypeSig src, ITextBuffer dst)
        {
            dst.Append(src.TypeName);
            if(src.IsParametric)
            {
                var count = src.ParameterCount;
                var parameters = src.Parameters.View;
                dst.Append(Chars.LBrace);
                for(var i=0; i<count; i++)
                {
                    render(skip(parameters,i), dst);
                    if(i != count - 1)
                    {
                        dst.Append(Chars.Comma);
                        dst.Append(Chars.Space);
                    }
                }

                dst.Append(Chars.RBrace);
            }
        }
    }
}