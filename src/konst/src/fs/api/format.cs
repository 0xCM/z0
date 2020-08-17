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
    using api = Table;

    using F = ListedFileField;

    partial struct FS
    {
        [Op]
        public static string format(in ListedFiles src)
        {
            var dst = text.build();
            format(src,dst);
            return dst.ToString();
        }
        
        [MethodImpl(Inline), Op]
        public static string format(in ListedFile src)
            => text.format("{0,-10} | {1}", src.Index, src.Path);

        [Op]
        public static void format(in ListedFiles src, StringBuilder dst)
        {
            var records = span(src.Data);
            var count = records.Length;
            var header = api.header<F>();
            dst.AppendLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref src[i];
                dst.AppendLine(format(record));
            }    
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