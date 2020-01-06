//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class MemberFormatX
    {
        static string MethodSep => new string('_',80);

        public static string Format<T>(this T data, int linebytes = 8, bool linelabels = true)
            where T : INativeMemberData
        {
            if(data.IsEmpty)
                return "<no_data>";

            var format = text();
            var range = bracket(concat(data.StartAddress.FormatHex(false,true), AsciSym.Comma, data.EndAddress.FormatHex(false,true)));
            format.AppendLine($"; function: {data.Method.MethodSig().Format()}");
            format.AppendLine($"; location: {range}, code length: {data.Length} bytes");

            for(ushort i=0; i< data.Length; i++)
            {
                if(i % linebytes == 0)
                {
                    if(i != 0)
                        format.AppendLine();

                    if(linelabels)
                    {
                        format.Append(i.FormatHex(true,false));
                        format.Append(AsciLower.h);
                        format.Append(AsciSym.Space);
                    }
                }
                format.Append(data.Body[i].FormatHex(true, true));
                format.Append(AsciSym.Space);
            }
            format.AppendLine();   
            format.AppendLine(MethodSep);
            return format.ToString();
        }

    }

}