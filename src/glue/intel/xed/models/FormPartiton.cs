//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct XedModels
    {
        public struct FormPartiton
        {
            public ushort Index;

            public IForm Form;

            public DelimitedIndex<string> Aspects;

            public IClass Class;

            public bool Complete;

            public ushort AspectCount
            {
                [MethodImpl(Inline)]
                get => (ushort)Aspects.Count;
            }
        }
    }
}