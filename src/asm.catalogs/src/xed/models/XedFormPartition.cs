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

    partial struct XedModels
    {
        public struct FormParition
        {
            public ushort Index;

            public IForm Source;

            public Index<string> Parts;

            public IClass Class;

            public bool Complete;

            public ushort PartCount
            {
                [MethodImpl(Inline)]
                get => (ushort)Parts.Count;
            }
        }
    }
}