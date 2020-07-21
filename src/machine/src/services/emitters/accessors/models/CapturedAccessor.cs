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
        public readonly ApiHostUri Host;
        
        public readonly ResourceAccessor Accessor;

        public readonly AsmFunctionCode Code;        
        
        [MethodImpl(Inline)]
        public CapturedAccessor(ApiHostUri host, in ResourceAccessor accessor, in AsmFunctionCode code)
        {
            Host = host;
            Accessor = accessor;
            Code = code;
        }    
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Accessor.IsEmpty && Code.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Accessor.IsNonEmpty && Code.IsNonEmpty;
        }

        public static CapturedAccessor Empty
            => new CapturedAccessor(ApiHostUri.Empty, ResourceAccessor.Empty, AsmFunctionCode.Empty);        
    }
}