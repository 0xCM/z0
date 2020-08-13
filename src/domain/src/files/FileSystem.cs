//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct FS
    {   
        readonly FileKinds[] _Kinds;
        
        [Op]
        public static FS create()
            => new FS(0);

        [MethodImpl(Inline)]
        FS(int i)
        {
            _Kinds= new FileKinds[1]{kinds()};
        }
        
         public ref readonly FileKinds Kinds
         {
             [MethodImpl(Inline), Op]
             get => ref _Kinds[0];
         }

        [Op]
        static FileKinds kinds()
        {            
            var reps = typeof(FS).GetNestedTypes().Tagged<FileKindAttribute>();
            return new FileKinds(reps);
        }        
    }
}