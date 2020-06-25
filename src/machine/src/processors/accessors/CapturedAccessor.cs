//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CapturedAccessor
    {
        [MethodImpl(Inline)]
        public CapturedAccessor(in ResourceAccessor accessor, in AsmFunctionCode code)
        {
            this.Accessor = accessor;
            this.Code = code;
        }
        
        public readonly ResourceAccessor Accessor;

        public readonly AsmFunctionCode Code;
    }

    public readonly struct CapturedAccessors
    {
        public readonly Type DeclaringType;

        public readonly CapturedAccessor[] Accessors;

        public CapturedAccessors(Type declaring, CapturedAccessor[] accessors)
        {
            this.DeclaringType = declaring;
            Accessors = accessors;
        }
    }
}