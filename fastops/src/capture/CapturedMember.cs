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

    /// <summary>
    ///  Encapsulates all aspects of a member capture operation
    /// </summary>
    public sealed class CapturedMember
    {        
        public static CapturedMember Empty => default;

        public static CapturedMember Define(OpIdentity id, MethodInfo src, MemoryRange origin, byte[] content, CaptureCompletion result)
            => new CapturedMember(id, src.Signature().Format(), null, src, origin, content, result);

        public static CapturedMember Define(OpIdentity id, Delegate src, MemoryRange origin, byte[] content, CaptureCompletion result)
            => new CapturedMember(id, id, src, src.Method, origin, content, result);

        [MethodImpl(Inline)]
        CapturedMember(OpIdentity id, string label, Delegate src, MethodInfo method, MemoryRange origin, byte[] content, CaptureCompletion result)
        {
            require((int)origin.Length == content.Length);
            this.Delegate = src;
            this.Method = method;
            this.Origin = origin;
            this.Code = AsmCode.Define(id, origin, label, content);
            this.CaptureInfo = result;
        }

        public Option<Delegate> Delegate;

        public MethodInfo Method {get;}

        public MemoryRange Origin {get;}

        public AsmCode Code {get;}

        public CaptureCompletion CaptureInfo {get;}

        public OpIdentity Id => Code.Id;

        public string Label => Code.Label;
         
        public ulong Length 
            => Origin.Length;

        public bool IsEmpty 
            => Length == 0;

        public CapturedMember Replicate()
            => new CapturedMember(Id, Label, Delegate.ValueOrDefault(), Method, Origin, Code.Encoded.Replicate(), CaptureInfo);

	    public string FormatHexLines(HexLineFormat? fmt = null)
        {
            var data = this;
            if(data.IsEmpty)
                return "<no_data>";
            
            var src = data.Code;
            var dst = text();
			dst.AppendLine($"; label   : {data.Method.Signature().Format()}");
			dst.AppendLine($"; location: {src.Origin.Format()}, length: {src.Origin.Length} bytes");
            var lines = src.Encoded.FormatHexLines(fmt);
            dst.Append(lines.Concat(AsciEscape.Eol));
            dst.AppendLine(MethodSep);
            return dst.ToString();
        }         
 
        static string MethodSep => new string('_',80);
    }
}