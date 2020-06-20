//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using Z0.Asm.Dsl;

    using static Konst;
    using static Root;
    
    [ApiHost("dsl.cases")]
    public readonly partial struct DslCases
    {
        [MethodImpl(Inline), Op]
        public static DslCases Service(int capacity = Pow2.T08) 
            => new DslCases(capacity);
        
        [MethodImpl(Inline)]
        DslCases(int capacity)
        {
            CommandBuffer = alloc<EncodedCommand>(capacity);
            IndexBuffer = new int[1]{0};
            NameBuffer = new asci32[1]{asci32.Null};
        }
        
        readonly EncodedCommand[] CommandBuffer;

        readonly int[] IndexBuffer;

        readonly asci32[] NameBuffer;

        [MethodImpl(Inline), Op]
        function func()
            => asm.func(NameBuffer, CommandBuffer, IndexBuffer);
    }
}