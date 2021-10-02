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

    partial struct RuleModels
    {
        public static Index<Operand> operands<T>(T src)
            where T : struct
        {
            var props = @readonly(typeof(T).DeclaredInstanceProperties());
            var _ref = __makeref(src);
            var count = props.Length;
            var buffer = alloc<Operand>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var prop = ref skip(props,i);
                seek(dst,i) = new Operand(prop.Name, prop.GetValue(src));
            }
            return buffer;
        }
    }
}