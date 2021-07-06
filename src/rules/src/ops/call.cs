//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Root;


    partial struct Rules
    {
        [MethodImpl(Inline), Op]
        public static Call call(IOperation target,  params OperandValue[] args)
            => new Call(target, args);
    }
}