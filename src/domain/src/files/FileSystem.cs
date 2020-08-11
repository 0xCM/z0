//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct FileSystem
    {   
        readonly FileKinds[] _Kinds;
        
        public static FileSystem create()
            => new FileSystem(0);

        FileSystem(int i)
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
            var reps = typeof(FileSystem).GetNestedTypes().Tagged<FileKindAttribute>();
            return new FileKinds(reps);
        }        

        [MethodImpl(Inline), Op]
        public static string format(in FileKinds src)
        {
            var dst = text.build();
            format(src,dst);
            return dst.ToString();
        }

        [Op]
        public static void format(in FileKinds src, StringBuilder dst)
        {
            dst.Append(Chars.LBracket);
            var reps = src.Reps;
            for(var i=0u; i<reps.Length; i++)
            {
                if(i != 0)
                {
                    dst.Append(Chars.Comma);
                    dst.Append(Chars.Space);
                }
                dst.Append(skip(reps,i).Name);
            }
            dst.Append(Chars.RBracket);
        }
    }
}