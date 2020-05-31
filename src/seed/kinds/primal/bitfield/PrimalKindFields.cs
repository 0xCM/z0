//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public struct PrimalKindFields
    {
        static PrimalKindFieldOps api => PrimalKindFieldOps.Service;

        PrimalKindField field;

        [MethodImpl(Inline)]
        internal PrimalKindFields(PrimalKindField field)
        {
            this.field = field;
        }
        
        public PrimalWidthL2 Width
        {
            [MethodImpl(Inline)]
            get => api.Width(field);
        }

        public PrimalKindId KindId
        {
            [MethodImpl(Inline)]
            get => api.KindId(field);
        }
        
        public Sign8 Sign
        {
            [MethodImpl(Inline)]
            get => api.Sign(field);
        }      
    }
}