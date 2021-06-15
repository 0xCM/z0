//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct ApiSigBuilder
    {
        [MethodImpl(Inline), Op]
        public static ApiOperandSig @return(ApiTypeSig type, params ApiSigModKind[] modifiers)
            => new ApiOperandSig(ApiSigRender.ReturnIndicator, type, modifiers);

        [MethodImpl(Inline), Op]
        public static ApiSigTypeParam parameter(ushort position, Name name)
            => new ApiSigTypeParam(position, name);

        [MethodImpl(Inline), Op]
        public static ApiSigTypeParam parameter(ushort position, Name name, ApiTypeSig closure)
            => new ApiSigTypeParam(position, name, closure);

        [MethodImpl(Inline), Op]
        public static ApiOperandSig operand(Name name, ApiTypeSig type, params ApiSigModKind[] modifiers)
            => new ApiOperandSig(name, type, modifiers);

        [MethodImpl(Inline), Op]
        public static ApiOperationSig operation(Name name, ApiOperandSig @return, params ApiOperandSig[] operands)
            => new ApiOperationSig(name, @return, operands);

        [MethodImpl(Inline), Op]
        public static ApiTypeSig type(Name name, params ISigTypeParam[] parameters)
            => new ApiTypeSig(name, parameters);

        [MethodImpl(Inline), Op]
        public static ApiOpenSigParam open(ushort position, Name name)
            => new ApiOpenSigParam(position, name);

        [MethodImpl(Inline), Op]
        public static ApiClosedSigParam close(ApiOpenSigParam src, ApiTypeSig closure)
            => new ApiClosedSigParam(src.Position, src.Name, closure);

        [Op]
        public static ApiSig sig(MethodInfo src)
        {
            var @class = ApiClass.from(src);
            var @return = src.ReturnType;
            var @params = src.ParameterTypes();
            var count = @params.Length + 1;
            var components = alloc<Type>(count);
            for(var i=0; i<count; i++)
            {
                if(i < count - 1)
                    components[i] = @params[i];
                else
                    components[i] = @return;
            }
            return sig(@class, components);
        }

        [MethodImpl(Inline), Op]
        public static ApiSig sig(Index<Type> args)
            => new ApiSig(args);

        [MethodImpl(Inline)]
        public static ApiSig sig(ApiClassKind @class, Type[] args)
            => new ApiSig(@class, args);
    }
}
