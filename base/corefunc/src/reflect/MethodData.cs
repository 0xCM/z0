//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zfunc;


    public interface IMethodData
    {
        /// <summary>
        /// The deconstructed method
        /// </summary>
        MethodInfo Method {get;}

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        ulong StartAddress {get;}

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        ulong EndAddress {get;}

        /// <summary>
        /// The memory content
        /// </summary>
        byte[] Body {get;}

        ulong Length 
            => EndAddress -StartAddress;        
    }

    public static class MethodDataX
    {
        public static string Format<T>(this T data)
            where T : IMethodData
        {
            var format = text();
            var title = data.Method.MethodSig().Format();
            format.Append(data.StartAddress.FormatHex(false,true));
            format.Append(AsciSym.Colon);
            format.Append(AsciSym.Space);
            format.AppendLine($"{title}[{data.Length}]");
            for(ushort i=0; i< data.Length; i++)
            {
                if(i % 2 == 0)
                {
                    if(i != 0)
                        format.AppendLine();

                    format.Append(i.FormatHex(true,false));
                    format.Append(AsciLower.h);
                    format.Append(AsciSym.Space);
                }
                format.Append(data.Body[i].FormatHex(true, true));
                format.Append(AsciSym.Space);
            }
            format.AppendLine();   
            format.Append(data.EndAddress.FormatHex(false,true));
            format.Append(AsciSym.Colon);
            format.Append(AsciSym.Space);
            format.Append($"{title} End");
            return format.ToString();
        }

    }

    /// <summary>
    /// Represents a contiguous block of memory that represents the machine code for a method
    /// </summary>
    public readonly struct DelegateData : IMethodData
    {        

        [MethodImpl(Inline)]
        public DelegateData(Delegate Delegate, ulong StartAddress, ulong EndAddress, byte[] body)
        {
            this.Delegate = Delegate;
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Body = body.ToArray();
        }

        /// <summary>
        /// The deconstructed delegate
        /// </summary>
        public readonly Delegate Delegate;

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        public readonly ulong StartAddress {get;}

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        public readonly ulong EndAddress {get;}

        /// <summary>
        /// The memory content
        /// </summary>
        public readonly byte[] Body {get;}
        
        public ref readonly byte this[int ix]
        {
            [MethodImpl(Inline)]
            get => ref Body[ix];
        }

        public ulong Length 
            => EndAddress -StartAddress;

        /// <summary>
        /// The method for the deconstructed delegate
        /// </summary>
        public MethodInfo Method    
            => Delegate.Method;

    }

    /// <summary>
    /// Represents a contiguous block of memory that represents the machine code for a method
    /// </summary>
    public readonly struct MethodData : IMethodData
    {        

        [MethodImpl(Inline)]
        public MethodData(MethodInfo method, ulong StartAddress, ulong EndAddress, byte[] body)
        {
            this.Method = method;
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Body = body.ToArray();
        }

        /// <summary>
        /// The deconstructed method
        /// </summary>
        public readonly MethodInfo Method {get;}

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        public readonly ulong StartAddress {get;}

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        public readonly ulong EndAddress {get;}

        /// <summary>
        /// The memory content
        /// </summary>
        public readonly byte[] Body {get;}
        
        public ulong Length 
            => EndAddress -StartAddress;

        public string Format()
        {
            var format = text();
            var title = Method.MethodSig().Format();
            format.Append(StartAddress.FormatHex(false,true));
            format.Append(AsciSym.Colon);
            format.Append(AsciSym.Space);
            format.AppendLine($"{title}[{Length}]");
            for(ushort i=0; i< Length; i++)
            {
                if(i % 2 == 0)
                {
                    if(i != 0)
                        format.AppendLine();

                    format.Append(i.FormatHex(true,false));
                    format.Append(AsciLower.h);
                    format.Append(AsciSym.Space);
                }
                format.Append(Body[i].FormatHex(true, true));
                format.Append(AsciSym.Space);
            }
            format.AppendLine();   
            format.Append(EndAddress.FormatHex(false,true));
            format.Append(AsciSym.Colon);
            format.Append(AsciSym.Space);
            format.Append($"{title} End");
            return format.ToString();
        }
    }
}